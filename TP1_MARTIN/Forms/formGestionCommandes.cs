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

namespace TP1_MARTIN.Forms
{
    public partial class formGestionCommandes : Form
    {
        public formGestionCommandes()
        {
            InitializeComponent();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMenu formMenu = new formMenu();
            formMenu.ShowDialog();
        }

        private void formGestionCommandes_Load(object sender, EventArgs e)
        {
            bsCommandes2.DataSource = Modele.listeCommandes().Select(x => new
            {
                x.Numcde,
                x.Montantcde,
                x.Datecde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli
            });
            dgvGestionCommandes.DataSource = bsCommandes2;

            cbListeClients.ValueMember = "NUMCLI";
            cbListeClients.DisplayMember = "nomComplet";
            // nomComplet est la concaténation du nom et prénom issu de la requête suivante
            bsClients3.DataSource = (Modele.listeClients()).Select(x => new
            {
                x.Numcli,
                nomComplet = x.Nomcli + " " + x.Prenomcli
            });
            cbListeClients.DataSource = bsClients3;

        }
    }
}
