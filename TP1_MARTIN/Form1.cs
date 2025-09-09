using TP1_MARTIN.Classe;

namespace TP1_MARTIN
{
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void formMenu_Load(object sender, EventArgs e)
        {
            bsClients.DataSource = Modele.listeClients(); // appel de la méthode listeClients
            dgvClients.DataSource = bsClients;
            //dgvClients.Columns[0].Visible = false; (marche aps)
            //dgvClients.Columns[0].HeaderText = string.Empty;
        }

    }
}
