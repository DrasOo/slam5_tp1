using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1_MARTIN.Classe;
using TP1_MARTIN.Entities;

namespace TP1_MARTIN.Forms
{
    public partial class formCommande : Form
    {
        public formCommande()
        {
            InitializeComponent();


        }

        private void FormCommande_Load(object sender, EventArgs e)
        {
            bsCommandes.DataSource = Modele.listeCommandes().Select(x => new
            {
                x.Numcde,
                x.Montantcde,
                x.Datecde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli
            });
            dgvCommandes.DataSource = bsCommandes;

            cbClients.ValueMember = "NUMCLI"; //permet de stocker l'identifiant
            cbClients.DisplayMember = "NOMCLI";
            bsClients2.DataSource = Modele.listeClients();
            cbClients.DataSource = bsClients2;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMenu formMenu = new formMenu();
            formMenu.ShowDialog();
            ;
        }

        private void bsClients2_CurrentChanged(object sender, EventArgs e)
        {
            // récupération de l’identifiant du client issu de la comboBox : on a NUMCLI en ValueMember de la
            // combo, donc on peut récupérer la valeur par la propriété SelectedValue
            int IDC = Convert.ToInt32(cbClients.SelectedValue);
            int IdClient = Convert.ToInt32(cbClients.SelectedValue);
            bsCommandes.DataSource = Modele.listeCommandesParClient(IdClient).Select(x => new
            {
                x.Numcde,
                x.Datecde,
                x.Montantcde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli
            })
            .OrderBy(x => x.Datecde);
            dgvCommandes.DataSource = bsCommandes;
        }
    }
}

