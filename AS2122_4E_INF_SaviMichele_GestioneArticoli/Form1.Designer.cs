namespace AS2122_4E_INF_SaviMichele_GestioneArticoli
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumArticoli = new System.Windows.Forms.Label();
            this.lblCodice = new System.Windows.Forms.Label();
            this.lblUnitaMisura = new System.Windows.Forms.Label();
            this.lblPrezzo = new System.Windows.Forms.Label();
            this.lblDescrizione = new System.Windows.Forms.Label();
            this.lblArticoli = new System.Windows.Forms.Label();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.cmbVisualizza = new System.Windows.Forms.ComboBox();
            this.cmbUnitaMisura = new System.Windows.Forms.ComboBox();
            this.lstVisualizza = new System.Windows.Forms.ListBox();
            this.txtPrezzo = new System.Windows.Forms.TextBox();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNumArticoli
            // 
            this.lblNumArticoli.AutoSize = true;
            this.lblNumArticoli.Location = new System.Drawing.Point(160, 378);
            this.lblNumArticoli.Name = "lblNumArticoli";
            this.lblNumArticoli.Size = new System.Drawing.Size(32, 25);
            this.lblNumArticoli.TabIndex = 0;
            this.lblNumArticoli.Text = "(0)";
            // 
            // lblCodice
            // 
            this.lblCodice.AutoSize = true;
            this.lblCodice.Location = new System.Drawing.Point(77, 83);
            this.lblCodice.Name = "lblCodice";
            this.lblCodice.Size = new System.Drawing.Size(66, 25);
            this.lblCodice.TabIndex = 1;
            this.lblCodice.Text = "Codice";
            // 
            // lblUnitaMisura
            // 
            this.lblUnitaMisura.AutoSize = true;
            this.lblUnitaMisura.Location = new System.Drawing.Point(12, 172);
            this.lblUnitaMisura.Name = "lblUnitaMisura";
            this.lblUnitaMisura.Size = new System.Drawing.Size(131, 25);
            this.lblUnitaMisura.TabIndex = 2;
            this.lblUnitaMisura.Text = "Unità di misura";
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.AutoSize = true;
            this.lblPrezzo.Location = new System.Drawing.Point(77, 217);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(64, 25);
            this.lblPrezzo.TabIndex = 3;
            this.lblPrezzo.Text = "Prezzo";
            // 
            // lblDescrizione
            // 
            this.lblDescrizione.AutoSize = true;
            this.lblDescrizione.Location = new System.Drawing.Point(41, 125);
            this.lblDescrizione.Name = "lblDescrizione";
            this.lblDescrizione.Size = new System.Drawing.Size(102, 25);
            this.lblDescrizione.TabIndex = 4;
            this.lblDescrizione.Text = "Descrizione";
            // 
            // lblArticoli
            // 
            this.lblArticoli.AutoSize = true;
            this.lblArticoli.Location = new System.Drawing.Point(78, 378);
            this.lblArticoli.Name = "lblArticoli";
            this.lblArticoli.Size = new System.Drawing.Size(67, 25);
            this.lblArticoli.TabIndex = 5;
            this.lblArticoli.Text = "Articoli";
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(160, 274);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(235, 55);
            this.btnAggiungi.TabIndex = 6;
            this.btnAggiungi.Text = "Aggiungi/Modifica articolo";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(719, 21);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(69, 34);
            this.btnVisualizza.TabIndex = 7;
            this.btnVisualizza.Text = "...";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // cmbVisualizza
            // 
            this.cmbVisualizza.FormattingEnabled = true;
            this.cmbVisualizza.Items.AddRange(new object[] {
            "Visualizza articoli"});
            this.cmbVisualizza.Location = new System.Drawing.Point(512, 22);
            this.cmbVisualizza.Name = "cmbVisualizza";
            this.cmbVisualizza.Size = new System.Drawing.Size(182, 33);
            this.cmbVisualizza.TabIndex = 8;
            // 
            // cmbUnitaMisura
            // 
            this.cmbUnitaMisura.FormattingEnabled = true;
            this.cmbUnitaMisura.Items.AddRange(new object[] {
            "NR",
            "KG",
            "T",
            "Q"});
            this.cmbUnitaMisura.Location = new System.Drawing.Point(160, 169);
            this.cmbUnitaMisura.Name = "cmbUnitaMisura";
            this.cmbUnitaMisura.Size = new System.Drawing.Size(182, 33);
            this.cmbUnitaMisura.TabIndex = 9;
            // 
            // lstVisualizza
            // 
            this.lstVisualizza.FormattingEnabled = true;
            this.lstVisualizza.ItemHeight = 25;
            this.lstVisualizza.Location = new System.Drawing.Point(512, 83);
            this.lstVisualizza.Name = "lstVisualizza";
            this.lstVisualizza.Size = new System.Drawing.Size(277, 354);
            this.lstVisualizza.TabIndex = 10;
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Location = new System.Drawing.Point(160, 214);
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(150, 31);
            this.txtPrezzo.TabIndex = 11;
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(160, 119);
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(150, 31);
            this.txtDescrizione.TabIndex = 12;
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(160, 80);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(150, 31);
            this.txtCodice.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCodice);
            this.Controls.Add(this.txtDescrizione);
            this.Controls.Add(this.txtPrezzo);
            this.Controls.Add(this.lstVisualizza);
            this.Controls.Add(this.cmbUnitaMisura);
            this.Controls.Add(this.cmbVisualizza);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.lblArticoli);
            this.Controls.Add(this.lblDescrizione);
            this.Controls.Add(this.lblPrezzo);
            this.Controls.Add(this.lblUnitaMisura);
            this.Controls.Add(this.lblCodice);
            this.Controls.Add(this.lblNumArticoli);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNumArticoli;
        private Label lblCodice;
        private Label lblUnitaMisura;
        private Label lblPrezzo;
        private Label lblDescrizione;
        private Label lblArticoli;
        private Button btnAggiungi;
        private Button btnVisualizza;
        private ComboBox cmbVisualizza;
        private ComboBox cmbUnitaMisura;
        private ListBox lstVisualizza;
        private TextBox txtPrezzo;
        private TextBox txtDescrizione;
        private TextBox txtCodice;
    }
}