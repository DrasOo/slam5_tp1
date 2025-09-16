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
            btnMenu.Location = new Point(284, 331);
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
            // formCommande
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
        }

        #endregion

        private DataGridView dgvCommandes;
        private BindingSource bsCommandes;
        private Button btnMenu;
        private ComboBox cbClients;
        private BindingSource bsClients2;
    }
}