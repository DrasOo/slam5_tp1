namespace TP1_MARTIN.Forms
{
    partial class formCommande
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
            dgvCommandes = new DataGridView();
            bsCommandes = new BindingSource(components);
            btnMenu = new Button();
            cbClients = new ComboBox();
            bsClients2 = new BindingSource(components);
            btnAllCommandes = new Button();
            txtSuperieur = new TextBox();
            label1 = new Label();
            btnLancer = new Button();
            btnAjouter = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCommandes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCommandes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsClients2).BeginInit();
            SuspendLayout();
            // 
            // dgvCommandes
            // 
            dgvCommandes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCommandes.Location = new Point(76, 57);
            dgvCommandes.Name = "dgvCommandes";
            dgvCommandes.Size = new Size(687, 191);
            dgvCommandes.TabIndex = 2;
            //
            // btnMenu
            // 
            btnMenu.Location = new Point(283, 375);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(187, 52);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // cbClients
            // 
            cbClients.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClients.FormattingEnabled = true;
            cbClients.Location = new Point(606, 277);
            cbClients.Name = "cbClients";
            cbClients.Size = new Size(157, 23);
            cbClients.TabIndex = 4;
            // 
            // bsClients2
            // 
            bsClients2.CurrentChanged += bsClients2_CurrentChanged;
            // 
            // btnAllCommandes
            // 
            btnAllCommandes.Location = new Point(606, 317);
            btnAllCommandes.Name = "btnAllCommandes";
            btnAllCommandes.Size = new Size(157, 24);
            btnAllCommandes.TabIndex = 5;
            btnAllCommandes.Text = "Toutes les commandes";
            btnAllCommandes.UseVisualStyleBackColor = true;
            btnAllCommandes.Click += btnAllCommandes_Click;
            // 
            // txtSuperieur
            // 
            txtSuperieur.Location = new Point(606, 375);
            txtSuperieur.Name = "txtSuperieur";
            txtSuperieur.Size = new Size(157, 23);
            txtSuperieur.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(632, 357);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 7;
            label1.Text = "Montant supérieur";
            // 
            // btnLancer
            // 
            btnLancer.Location = new Point(632, 404);
            btnLancer.Name = "btnLancer";
            btnLancer.Size = new Size(111, 24);
            btnLancer.TabIndex = 8;
            btnLancer.Text = "Lancer";
            btnLancer.UseVisualStyleBackColor = true;
            btnLancer.Click += btnLancer_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(283, 277);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(187, 52);
            btnAjouter.TabIndex = 9;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // formCommande
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAjouter);
            Controls.Add(btnLancer);
            Controls.Add(label1);
            Controls.Add(txtSuperieur);
            Controls.Add(btnAllCommandes);
            Controls.Add(cbClients);
            Controls.Add(btnMenu);
            Controls.Add(dgvCommandes);
            Name = "formCommande";
            Text = "Commande";
            Load += FormCommande_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCommandes).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCommandes).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsClients2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCommandes;
        private BindingSource bsCommandes;
        private Button btnMenu;
        private ComboBox cbClients;
        private BindingSource bsClients2;
        private Button btnAllCommandes;
        private TextBox txtSuperieur;
        private Label label1;
        private Button btnLancer;
        private Button btnAjouter;
    }
}