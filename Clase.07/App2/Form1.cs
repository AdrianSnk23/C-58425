namespace App2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<string, Dictionary<string, double>> catalogoPetShop = new Dictionary<string, Dictionary<string, double>>();
            catalogoPetShop.Add("Alimento para gatos adultos", new Dictionary<string, double> { {"Cat Chow", 900},{"Whiskas", 1200 }, {"Pedigree", 1800}});
            catalogoPetShop.Add("Alimento para perros", new Dictionary<string, double> { {"Dog Chow", 1500},{"Pro Plan", 2500}, {"Eukanuba", 1300} });

            lstAlimentos.Items.Add("Sección\t\t\t\t\tProducto\t\tPrecio");
            foreach(KeyValuePair<string,Dictionary<string, double>> seccion in catalogoPetShop)
            {
                lstAlimentos.Items.Add(seccion.Key);
                foreach(KeyValuePair<string, double> productoPrecio in seccion.Value) 
                {
                    lstAlimentos.Items.Add("\t\t\t\t\t" + productoPrecio.Key + "\t\t" + productoPrecio.Value);
                }
            }
        }
    }
}
