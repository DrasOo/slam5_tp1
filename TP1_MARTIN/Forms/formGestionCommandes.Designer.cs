namespace TP1_MARTIN.Forms
{
    partial class formGestionCommandes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtMontant = new TextBox();
            label1 = new Label();
            dtpDate = new DateTimePicker();
            cbListeClients = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            btnOk = new Button();
            btnAnnule = new Button();
            btnFermer = new Button();
            dgvGestionCommandes = new DataGridView();
            bsCommandes2 = new BindingSource(components);
            bsClients3 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvGestionCommandes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCommandes2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsClients3).BeginInit();
            SuspendLayout();
            // 
            // txtMontant
            // 
            txtMontant.Location = new Point(301, 39);
            txtMontant.Name = "txtMontant";
            txtMontant.Size = new Size(199, 23);
            txtMontant.TabIndex = 0;
            txtMontant.KeyPress += txtMontant_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(364, 21);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 1;
            label1.Text = "Montant : €";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(534, 39);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 2;
            // 
            // cbListeClients
            // 
            cbListeClients.DropDownStyle = ComboBoxStyle.DropDownList;
            cbListeClients.FormattingEnabled = true;
            cbListeClients.Location = new Point(78, 39);
            cbListeClients.Name = "cbListeClients";
            cbListeClients.Size = new Size(199, 23);
            cbListeClients.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(588, 21);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 4;
            label2.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(144, 21);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 5;
            label3.Text = "Liste des clients";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(93, 109);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(173, 52);
            btnOk.TabIndex = 6;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnAnnule
            // 
            btnAnnule.Location = new Point(317, 109);
            btnAnnule.Name = "btnAnnule";
            btnAnnule.Size = new Size(173, 52);
            btnAnnule.TabIndex = 7;
            btnAnnule.Text = "Annuler";
            btnAnnule.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            btnFermer.Location = new Point(545, 109);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(173, 52);
            btnFermer.TabIndex = 8;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = true;
            btnFermer.Click += btnFermer_Click;
            // 
            // dgvGestionCommandes
            // 
            dgvGestionCommandes.AllowUserToAddRows = false;
            dgvGestionCommandes.AllowUserToDeleteRows = false;
            dgvGestionCommandes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGestionCommandes.Location = new Point(93, 244);
            dgvGestionCommandes.Name = "dgvGestionCommandes";
            dgvGestionCommandes.ReadOnly = true;
            dgvGestionCommandes.Size = new Size(625, 150);
            dgvGestionCommandes.TabIndex = 9;
            // 
            // formGestionCommandes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvGestionCommandes);
            Controls.Add(btnFermer);
            Controls.Add(btnAnnule);
            Controls.Add(btnOk);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbListeClients);
            Controls.Add(dtpDate);
            Controls.Add(label1);
            Controls.Add(txtMontant);
            Name = "formGestionCommandes";
            Text = "formGestionCommandes";
            Load += formGestionCommandes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGestionCommandes).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCommandes2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsClients3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMontant;
        private Label label1;
        private DateTimePicker dtpDate;
        private ComboBox cbListeClients;
        private Label label2;
        private Label label3;
        private Button btnOk;
        private Button btnAnnule;
        private Button btnFermer;
        private DataGridView dgvGestionCommandes;
        private BindingSource bsCommandes2;
        private BindingSource bsClients3;
    }
}