namespace TP1_MARTIN
{
    partial class formMenu
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
            components = new System.ComponentModel.Container();
            bsClients = new BindingSource(components);
            dgvClients = new DataGridView();
            btnCommande = new Button();
            ((System.ComponentModel.ISupportInitialize)bsClients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            SuspendLayout();
            // 
            // dgvClients
            // 
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new Point(63, 12);
            dgvClients.Name = "dgvClients";
            dgvClients.Size = new Size(610, 191);
            dgvClients.TabIndex = 0;
            // 
            // btnCommande
            // 
            btnCommande.Location = new Point(301, 338);
            btnCommande.Name = "btnCommande";
            btnCommande.Size = new Size(106, 44);
            btnCommande.TabIndex = 1;
            btnCommande.Text = "Commande";
            btnCommande.UseVisualStyleBackColor = true;
            btnCommande.Click += btnCommande_Click;
            // 
            // formMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCommande);
            Controls.Add(dgvClients);
            Name = "formMenu";
            Text = "Menu";
            Load += formMenu_Load;
            ((System.ComponentModel.ISupportInitialize)bsClients).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bsClients;
        private DataGridView dgvClients;
        private Button btnCommande;
    }
}
