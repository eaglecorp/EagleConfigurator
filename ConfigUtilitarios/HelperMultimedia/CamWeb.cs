using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Windows.Forms;   


namespace ConfigUtilitarios
{
    public class CamWeb
    {
        private int hwndc;
        private const int WS_CHILD = (int)0x40000000;
        private const int WS_VISIBLE = (int)0x10000000;
        private const short WM_USER = (short)0x00000400;
        private const int WM_CAP_DRIVER_CONNECT = WM_USER + 10;
        private const int WM_CAP_DRIVER_DISCONNECT = WM_USER + 11;
        private const int WM_CAP_SET_PREVIEW = WM_USER + 50;
        private const int WM_CAP_SET_PREVIEWRATE = WM_USER + 52;
        private const int WM_CAP_SET_SCALE = WM_USER + 53;
        private const int WM_CAP_GET_FRAME = 1084;
        private const int WM_CAP_COPY = 1054;
        [DllImport("avicap32.dll")]
        public extern static int capCreateCaptureWindowA(string lpsNombre, int dwStilo, int xpi, int ypi, int Ancho, int Alto, int hwndParent, int nID);
        [DllImport("user32.dll")]
        public extern static int SendMessageA(int hWnd, int wMsg, short wParam, int lParam);

        [DllImport("user32.dll", EntryPoint = "EmptyClipboard")]
        public static extern int EmptyClipboard();
        //public static extern int EmptyClipboard();

        public bool ventana(int Handle)
        {
            hwndc = capCreateCaptureWindowA("Ventana de Captura", WS_VISIBLE | WS_CHILD, 0, 0, 180, 200, Handle, 0);
            //hwndc = capCreateCaptureWindowA("Ventana de Captura", WS_VISIBLE | WS_CHILD, 0, 0, 308, 238, Handle, 0);            
            if (hwndc != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ventana(int Handle, int widthCamera, int heightCamera)
        {
            hwndc = capCreateCaptureWindowA("Ventana de Captura", WS_VISIBLE | WS_CHILD, 0, 0, widthCamera, heightCamera, Handle, 0);
            //hwndc = capCreateCaptureWindowA("Ventana de Captura", WS_VISIBLE | WS_CHILD, 0, 0, 308, 238, Handle, 0);            
            if (hwndc != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool conectar()
        {
            int r1;
            r1 = SendMessageA(hwndc, WM_CAP_DRIVER_CONNECT, 0, 0);
            if (r1 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool capturar()
        {
            int r1, r2, r3;
            r1 = SendMessageA(hwndc, WM_CAP_SET_PREVIEWRATE, 100, 100);
            if (r1 != 0)
            {
                r2 = SendMessageA(hwndc, WM_CAP_SET_PREVIEW, 50, 50);
                r3 = SendMessageA(hwndc, WM_CAP_SET_SCALE, 50, 50);
                if (r2 != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {

                return false;
            }
        }
        public void CapturarImagen(PictureBox Pbx)
        {

            SendMessageA(hwndc, WM_CAP_GET_FRAME, 600, 600); // Capturo la imagen
            SendMessageA(hwndc, WM_CAP_COPY, 600, 600); // La copio al portapeles
            Pbx.Image = Clipboard.GetImage(); // La mando al Picturebox
            //EmptyClipboard(); // Vacío el portapapeles

        }

        public Image Resize(Image foto, int ancho, int alto)
        {

            int ImgORAncho = foto.Width;
            int ImgOrAlto = foto.Height; // Obtengo las dimensiones de la foto

            int OrigX = 0;
            int OrigY = 0;
            int ResX = 0;  // Varables referencia para saber donde contar px
            int ResY = 0;

            float Porciento = 0;
            float PorcientoAncho = 0; // Porcentajes de sampleo
            float PorcientoAlto = 0;

            PorcientoAncho = ((float)ancho / (float)ImgORAncho);
            PorcientoAlto = ((float)alto / (float)ImgOrAlto); //Calculo el % que puedo resamplear

            if (PorcientoAlto < PorcientoAncho)
            {
                Porciento = PorcientoAlto;
            }
            else
            { // Para resamplear bien                 
                Porciento = PorcientoAncho;
            }


            int AnchuraFinal = (int)(ImgORAncho * Porciento);
            int AlturaFinal;  // Calculo las nuevas dimensiones                

            if (ancho > alto)
            {
                AlturaFinal = (int)(ImgOrAlto * Porciento);
            }
            else
            {
                AlturaFinal = AnchuraFinal;
            } // Para proporcionar la imagen 

            Bitmap RszIm = new Bitmap(ancho, alto, PixelFormat.Format24bppRgb);
            RszIm.SetResolution(foto.HorizontalResolution, foto.VerticalResolution);

            Graphics Gfoto = Graphics.FromImage(RszIm);
            Gfoto.InterpolationMode = InterpolationMode.HighQualityBicubic;
            Gfoto.DrawImage(foto, new Rectangle(ResX, ResY, AnchuraFinal, AlturaFinal), new Rectangle(OrigX, OrigY, ImgORAncho, ImgOrAlto), GraphicsUnit.Pixel);
            Gfoto.Dispose();
            return (RszIm);

        }
    }
}
