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

        private void txtMontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Erreur, vous devez saisir des entiers", "Erreur", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                e.Handled = true; // efface le dernier caractère saisi
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpDate.Value;

            int montant;
            if(!int.TryParse(txtMontant.Text, out montant))
            {
                MessageBox.Show("Veuillez entrer un montant valide (nombre entier).", "Montant invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbListeClients.SelectedValue != null)
            {
                int numCli = Convert.ToInt32(cbListeClients.SelectedValue);

                bool isSuccess = Modele.AjoutCommande(montant, selectedDate, numCli);

                if (isSuccess)
                {
                    MessageBox.Show("Commande ajoutée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RafraichirDataGridView();  
                    RéinitialiserChamps();
                }
                else
                {
                    MessageBox.Show("Échec de l'ajout de la commande.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un client.", "Client non sélectionné", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RafraichirDataGridView()
        {
            var commandes = Modele.listeCommandes().Select(x => new
            {
                x.Numcde,
                x.Montantcde,
                x.Datecde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli
            }).ToList();

            bsCommandes2.DataSource = commandes;
            dgvGestionCommandes.DataSource = bsCommandes2;
        }

        private void RéinitialiserChamps()
        {
            dtpDate.Value = DateTime.Now;
            cbListeClients.SelectedIndex = -1;
            txtMontant.Text = "";
        }

    }
}
