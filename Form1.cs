namespace areas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cuadrado_Click(object sender, EventArgs e)
        {
            cuadrado.cuadrado nuevoFormulario = new cuadrado.cuadrado();
            nuevoFormulario.Show();
        }

        private void rectangulo_Click(object sender, EventArgs e)
        {
            rectangulo.rectangulo nuevoFormulario = new rectangulo.rectangulo();
            nuevoFormulario.Show();
        }

        private void circulo_Click(object sender, EventArgs e)
        {
            circulo.circulo nuevoFormulario = new circulo.circulo();
            nuevoFormulario.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            triangulo.triangulo nuevoFormulario = new triangulo.triangulo();
            nuevoFormulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trapecio.Form1 nuevoFormulario = new trapecio.Form1();
            nuevoFormulario.Show();
        }
    }
}
