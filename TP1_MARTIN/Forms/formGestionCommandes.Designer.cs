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
            txtMontant = new TextBox();
            label1 = new Label();
            dtpDate = new DateTimePicker();
            cbListeClients = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtMontant
            // 
            txtMontant.Location = new Point(301, 39);
            txtMontant.Name = "txtMontant";
            txtMontant.Size = new Size(199, 23);
            txtMontant.TabIndex = 0;
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
            // formGestionCommandes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbListeClients);
            Controls.Add(dtpDate);
            Controls.Add(label1);
            Controls.Add(txtMontant);
            Name = "formGestionCommandes";
            Text = "formGestionCommandes";
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
    }
}