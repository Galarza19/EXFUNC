using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico_1_y_2_Vectores_U.Ficct
{
    public partial class Form1 : Form
    {
        Vector v1, v2, v3;

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.CargarRandom(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = v1.Descargar();
        }

        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            v2.CargarRandom(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));

        }

        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox5.Text = v2.Descargar();

        }

        private void cargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            v3.CargarRandom(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));

        }

        private void descargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox6.Text = v3.Descargar();

        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.SerieM(int.Parse(textBox1.Text), int.Parse(textBox8.Text), int.Parse(textBox9.Text));
            textBox7.Text = v1.Descargar();
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox7.Text = v1.SerieFib(int.Parse(textBox1.Text)).ToString();
            textBox10.Text = v1.SerieFibo2();
            textBox4.Text = v1.Descargar();
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox7.Text = v1.MediaMult(int.Parse(textBox9.Text)).ToString();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox7.Text = v1.MediaAyB(int.Parse(textBox2.Text), int.Parse(textBox3.Text)).ToString(); ;

        }

        private void ejercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.EleMultyNoMult(int.Parse(textBox9.Text), v2, v3);
            textBox7.Text = " Mult: " + v2.Descargar() + " No Mult: " + v3.Descargar();

        }

        private void ejercicio6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.ElimNoPrim();
            textBox7.Text = v1.Descargar();

        }

        private void ejercicio7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox7.Text = v1.Sincronizado().ToString();

        }

        private void ejercicio8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.Union(v2, v3);
            textBox7.Text = v3.Descargar();

        }

        private void ejercicio9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.DifSimetrica(v2, v3);
            textBox7.Text = v3.Descargar();

        }

        private void ejercicio10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox7.Text = v1.VerifOrd(int.Parse(textBox2.Text), int.Parse(textBox3.Text)).ToString();

        }

        private void ejercicio1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            v1.EliminarRango(int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            textBox7.Text = v1.Descargar();

        }

        private void ejercicio2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            v1.OrdPosM(int.Parse(textBox9.Text));
            textBox7.Text = v1.Descargar();

        }

        private void ejercicio3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            v1.Caracol();
            textBox7.Text = v1.Descargar();

        }

        private void ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            textBox7.Text = v1.EleDif(int.Parse(textBox2.Text), int.Parse(textBox3.Text)).ToString();

        }

        private void ejercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int f, num;
            f = 0; num = 0;
            v1.MayorFrec(int.Parse(textBox2.Text), int.Parse(textBox3.Text), ref f, ref num);
            textBox7.Text = "Mayor Elemento: " + num + " Frecuencia: " + f;


        }

        private void ejercicio6ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            v1.EleyFrec(int.Parse(textBox2.Text), int.Parse(textBox3.Text), v2, v3);
            textBox5.Text = v2.Descargar();
            textBox6.Text = v3.Descargar();

        }

        private void ejercicio7ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            v1.EleyFrecFibo(v2, v3);
            textBox5.Text = v2.Descargar();
            textBox6.Text = v3.Descargar();

        }

        private void ejercicio8ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            v1.SegmentarRepNoRep(int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            textBox5.Text = v1.Descargar();

        }

        private void ejercicio9ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            v1.SegmentarCapNoCap();
            textBox5.Text = v1.Descargar();

        }

        private void ejercicio10ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            v1.IntercalarEle(int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            textBox5.Text = v1.Descargar();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            v1.Clean();
            textBox4.Text = v1.Descargar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            v1.Push(int.Parse(textBox8.Text));
            textBox4.Text = v1.Descargar();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            v1 = new Vector();
            v2 = new Vector();
            v3 = new Vector();
        }

    }
}
