namespace AS2122_4E_INF_SaviMichele_GestioneArticoli
{
    public partial class Form1 : Form
    {
        List<Articolo> articoli;
        public Form1()
        {
            InitializeComponent();
            articoli = new List<Articolo>();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            string codice = txtCodice.Text;
            string descrizione = txtDescrizione.Text;
            string unitaMisura = cmbUnitaMisura.Text;
            double prezzo = Convert.ToDouble(txtPrezzo.Text);
            int num = 0;

            Articolo a = new Articolo(codice, descrizione, unitaMisura, prezzo);
            articoli.Add(a);

            num++;
            lblNumArticoli.Text = "(" + num + ")";

            txtCodice.Clear();
            txtDescrizione.Clear();
            cmbUnitaMisura.Items.Clear();
            txtPrezzo.Clear();
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            foreach(string articolo in articoli)
            {
                lstVisualizza.Items.Add($"{articolo}\n");
            }
        }
    }
}