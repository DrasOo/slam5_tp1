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
            txt = new TextBox();
            SuspendLayout();
            // 
            // txt
            // 
            txt.Location = new Point(356, 39);
            txt.Name = "txt";
            txt.Size = new Size(136, 23);
            txt.TabIndex = 0;
            // 
            // formGestionCommandes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt);
            Name = "formGestionCommandes";
            Text = "formGestionCommandes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt;
    }
}