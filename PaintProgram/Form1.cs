using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintProgram
{
    public partial class Pinturitas : Form
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

        private void Pic(object sender, EventArgs e)
        {

        }

        int index;
        
        public Pinturitas()
        {
            InitializeComponent();
            bmLapiz = new Bitmap(Lapiz.Width, Lapiz.Height);
            gLapiz = Graphics.FromImage(bmLapiz);

            //CAMBIA EL COLOR DEL LAPIZ PARA BORRAR
            gLapiz.Clear(Color.White);

            Lapiz.Image = bmLapiz;
        }

        private void Pic_ClicMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                //para dibujar a mano alzada
                if (index == 1)
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


        //MOUSE DOWN
        private void Pic_ClicDown(object sender, MouseEventArgs e)
        {
            //si pinta hacia abajo
            paint = true;
            py = e.Location;

            //DIBUJAR EL CIRCULO EN LAS DIMENSIONES X & Y
            cx = e.X;
            cy = e.Y;
        }

       
        //BOTON LAPIZ ACTIDADES
        private void Lapiz_Click(object sender, EventArgs e)
        {
            index = 1;    
        }

        
       
    }
}
