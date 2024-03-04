using Examen1.Clases;

namespace Examen1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Stack<Poligono> miPila = new Stack<Poligono>();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void crearTriangulo(object sender, EventArgs e)
        {
            miPila.Push(new Triangulo(textBox1.Text, double.Parse(textBox2.Text), double.Parse(textBox3.Text)));
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
        private void crearRectangulo(object sender, EventArgs e)
        {
            miPila.Push(new Rectangulo(textBox4.Text, double.Parse(textBox5.Text), double.Parse(textBox6.Text)));
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
        private void crearParalelogramo(object sender, EventArgs e)
        {
            miPila.Push(new Paralelogramo(textBox7.Text, double.Parse(textBox8.Text), double.Parse(textBox9.Text)));
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }

        private void mostrarPila(object sender, EventArgs e)
        {
            foreach (var item in miPila)
            {
                label11.Text += "\n" + item.ToString();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
