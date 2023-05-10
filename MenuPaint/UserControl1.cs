using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuPaint
{
    public partial class BarraHerramientas: UserControl
    {


        //VARIABLES PARA DIBUJAR
        Bitmap bmLapiz;
        Graphics gLapiz;
        bool paint = false;
        Point px, py;

        //objeto lapiz de color negro y grosor 1
        Pen lapiz = new Pen(Color.Black, 1);

        //objeto lapiz borrador y grosor 10
        Pen borrador = new Pen(Color.White, 10);

        //VARIABLES PARA LOS PUNTOS DEL CIRCULO
        int x, y, sx, sy, cx, cy;

        int index;
        public BarraHerramientas()
        {
            InitializeComponent();
            bmLapiz = new Bitmap(Lapiz.Width, Lapiz.Height);
            gLapiz = Graphics.FromImage(bmLapiz);
            
            //CAMBIA EL COLOR DEL LAPIZ PARA BORRAR
            gLapiz.Clear(Color.White);

            Lapiz.Image = bmLapiz;
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
        // ACCIONES DEL BOTON
        
        private void Lapiz_ClickUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sx = x - cx;
            sy = y - cy;
            
            //PARA DIBUJAR EL CIRCULO
            if(index ==3)
            {
                gLapiz.DrawEllipse(lapiz,cx, cy, sx, sy);
            }

            //PARA DIBUJAR EL RECTANGULO
            if(index ==4)
            {
                gLapiz.DrawRectangle(lapiz, cx, cy, sx, sy);
            }
            
            //PARA DIBUJAR LINEA RECTA
            if(index==5)
            {
                gLapiz.DrawLine(lapiz, cx, cy, x, y);
            }

        }

        
        //TAMANO DE LA LINEA
        private void Lapiz_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        
        private void Lapiz_Click(object sender, MouseEventArgs e)
        {

        }

       

        //DIBUJAR
        private void Lapiz_ClickDown(object sender, MouseEventArgs e)
        {
            //si pinta hacia abajo
            paint = true;
            py = e.Location;

            //DIBUJAR EL CIRCULO EN LAS DIMENSIONES X & Y
            cx = e.X;
            cy = e.Y;
        }

        

        private void Lapiz_ClickMove(object sender, MouseEventArgs e)
        {
            if(paint)
            {
                //para dibujar a mano alzada
                if(index ==1)
                {
                    //punto x en localizacion
                    px = e.Location;
                    //pintar una linea tipo Glapiz
                    gLapiz.DrawLine(lapiz, px, py);
                    py = px;

                }

                //para borrar lo que se dibujo
                if (index == 2)
                {
                    //punto x en localizacion
                    px = e.Location;
                    //pintar una linea tipo PEN+BORRADOR
                    gLapiz.DrawLine(borrador, px, py);
                    py = px;

                }
                Lapiz.Refresh();

                //variables para el ciculo 
                x = e.X;
                y = e.Y;
                sx = e.X - cx;
                sy = e.Y - cy;
            }
        }
        //  ACCIONES DE LA CUBETA
        private void Cubeta_Click(object sender, EventArgs e)
        {
            index = 6;  
        }

        //ACCIONES DEL BORRADOR
        private void Borrador_Click(object sender, EventArgs e)
        {
            //usamos el index para bottar que es e tamano de 
            index = 2;
        }

        //DIBUJAR CIRCULO
        private void Circulo_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        //DIBUJAR RECTANGULO
        private void Rect_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void BarraHerramientas_Load(object sender, EventArgs e)
        {

        }

        //DIBUJAR LINEA RECTA
        private void Linea_Click(object sender, EventArgs e)
        {
            index = 5;
        }
        
        //Condicionales para dibujar
        private void LapizPaint(object sender, PaintEventArgs e)
        {

            Graphics gPaint = e.Graphics;
            if(paint)
            {
                if (index == 3)
                {
                    gLapiz.DrawEllipse(lapiz, cx, cy, sx, sy);
                }

                //PARA DIBUJAR EL RECTANGULO
                if (index == 4)
                {
                    gLapiz.DrawRectangle(lapiz, cx, cy, sx, sy);
                }

                //PARA DIBUJAR LINEA RECTA
                if (index == 5)
                {
                    gLapiz.DrawLine(lapiz, cx, cy, x, y);
                }
            }

        }

        //LIMPIA LA FORMA 
        private void Nuevo_Click(object sender, EventArgs e)
        {
            gLapiz.Clear(Color.White);
            Lapiz.Image = bmLapiz;
            index= 0;

        }

        //CUBETA
        static Point set_Point(PictureBox cajita, Point punto)
        {
            float px = 1f * cajita.Width / cajita.Width;
            float py = 1f * cajita.Height / cajita.Height;
            return new Point ((int)(punto.X * px), (int)(punto.Y*py));
        }

        //validacion
        private void Validate(Bitmap bmValdate , Stack<Point> StackPoint, int x, int y, Color Old_Color, Color nuevoColor)
        {
            Color ColorX = bmValdate.GetPixel(x, y);
            if(ColorX == Old_Color)
            {

                StackPoint.Push(new Point (x, y));
                bmValdate.SetPixel(x, y, nuevoColor);
            }

        }

        public void Fill(Bitmap bmFill, int x, int y, Color New_Color)
        {
            Color Old_Color = bmFill.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bmFill.SetPixel(x, y, New_Color);

                if(Old_Color == New_Color)
                {
                return;
                }

                while(pixel.Count>0)
                {
                Point puntoNuevo = (Point)pixel.Pop();
                    if(puntoNuevo.X >0 && puntoNuevo.Y>0 && puntoNuevo.X<bmFill.Width-1 && puntoNuevo.Y<bmFill.Height-1)
                {
                    Validate(bmFill, pixel, puntoNuevo.X - 1, puntoNuevo.Y - 1, Old_Color, New_Color);
                    Validate(bmFill, pixel, puntoNuevo.X, puntoNuevo.Y-1, Old_Color, New_Color);
                    Validate(bmFill, pixel, puntoNuevo.X + 1, puntoNuevo.Y, Old_Color, New_Color);
                    Validate(bmFill, pixel, puntoNuevo.X - 1, puntoNuevo.Y + 1, Old_Color, New_Color);
                }
            }
        }
    }
}
