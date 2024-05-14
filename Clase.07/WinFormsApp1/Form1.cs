namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //Los diccionarios se declaran como una variable local, siempre ac�!!!
        Dictionary<string, string> ciudadesxPaises = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] razasDePerrosArray = new string[5];
            razasDePerrosArray[0] = "Policia";
            razasDePerrosArray[1] = "Pequin�s";
            razasDePerrosArray[2] = "Caniche";
            razasDePerrosArray[3] = "Chihuahua";
            razasDePerrosArray[4] = "Bull Terrier";

            for (int i = 0; i < razasDePerrosArray.Length; i++)
            {
                lstRazasDePerros.Items.Add(razasDePerrosArray[i]);
            }

            //en el Form Load se carga las ciudades por pa�s
            ciudadesxPaises.Add("Buenos Aires", "Argentina");
            ciudadesxPaises.Add("Lima", "Per�");
            ciudadesxPaises.Add("Madrid", "Espa�a");
            ciudadesxPaises.Add("Par�s", "Francia");
            ciudadesxPaises.Add("Roma", "Italia");
            ciudadesxPaises.Add("Londres", "Reino Unido");
            ciudadesxPaises.Add("Bogot�", "Colombia");


            //El keyvaluepair se refiere a los valores que tiene el diccionario, el par llave/valor
            foreach (KeyValuePair<string, string> ciudad in ciudadesxPaises)
            {
                lstCiudadesxPaises.Items.Add(ciudad.Key + " - " + ciudad.Value);
            }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            lstCiudadesxPaises.Items.Clear();
            ciudadesxPaises.Clear();
            MessageBox.Show("Se limpi� el contenido del diccionario.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ciudadesxPaises["Londres"] = "Madrid";
            lstCiudadesxPaises.Items.Clear();
            foreach(KeyValuePair<string, string> ciudad in ciudadesxPaises)
            {
                lstCiudadesxPaises.Items.Add(ciudad.Key + " - " + ciudad.Value);
            }
        }
    }
}
