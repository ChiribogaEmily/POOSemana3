namespace semana3tarea1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            forms.Stores stores = new forms.Stores();
            stores.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            forms.Employee employees = new forms.Employee();
            employees.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            forms.Cargos cargos = new forms.Cargos();
            cargos.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            forms.Descuentos descuentos = new forms.Descuentos();
            descuentos.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            forms.Ventas ventas = new forms.Ventas();
            ventas.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            forms.Titulos titulos = new forms.Titulos();
            titulos.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            forms.Autores autores = new forms.Autores();
            autores.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            forms.TitulosAutores titulosAutores = new forms.TitulosAutores();
            titulosAutores.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            forms.Publicadores publicadores = new forms.Publicadores();
            publicadores.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            forms.InformacionPublicadores informacionPublicadores = new forms.InformacionPublicadores();
            informacionPublicadores.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            forms.Regalia regalia = new forms.Regalia();
            regalia.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
