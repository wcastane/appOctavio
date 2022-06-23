using libOctavio;

namespace WinOctavio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Camion camion234 = new Camion { SKU = "ABC", NoSerie = "123", Puertas = 2, Ruedas = 6, TipoCaja = TipoCaja.Plataforma, TamañoCaja = 46 };

        }
    }
}