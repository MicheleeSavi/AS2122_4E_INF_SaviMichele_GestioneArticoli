namespace AS2122_4E_INF_SaviMichele_GestioneArticoli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            string codice = txtCodice.Text;
            string descrizione = txtDescrizione.Text;
            string unitaMisura = cmbUnitaMisura.Text;
            double prezzo = Convert.ToDouble(txtPrezzo.Text);
            int num = 0;

            num++;
            lblNumArticoli.Text = "(" + num + ")";
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            
        }
    }
}