using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TP1_MARTIN.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TP1_MARTIN.Classe
{
    public static class Modele
    {
        private static BdPartitionsContext monModel;
        public static void init()
        {
            monModel = new BdPartitionsContext();
        }
        public static List<Client> listeClients()
        {
            return monModel.Clients.ToList();
        }
        public static List<Commande> listeCommandes()
        {
            return monModel.Commandes.Include(a => a.NumcliNavigation).ToList();
        }
        public static List<Commande> listeCommandesParClient(int idClient)
        {
            List<Commande> lesCommandes = monModel.Commandes.Where(p => p.Numcli ==
           idClient).Include(p => p.NumcliNavigation).ToList();
            return lesCommandes;
        }
        public static bool AjoutCommande(int montant, DateTime dateC, int idClient)
        {
            Commande maCommande;
            bool vretour = true;
            try
            {
                maCommande = new Commande();
                maCommande.Montantcde = montant; // mise à jour des propriétés
                maCommande.Datecde = DateOnly.FromDateTime(dateC.Date);


                maCommande.Numcli = idClient;
                // ajout de l’objet : correspond à un insert
                monModel.Commandes.Add(maCommande); // correspond à un INSERT INTO
                monModel.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;
        }
        public static Commande RecupererCommande(int idCommande)
        {
            Commande uneCommande = new Commande();
            try
            {
                uneCommande = monModel.Commandes.Include(c => c.Numparts).First(x =>
               x.Numcde == idCommande);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return uneCommande;
        }
        public static bool ModifierCommande(int idCde, int montant, DateTime dateC, int idClient)
        {
            bool vretour = true;
            try
            {
                Commande maCommande = monModel.Commandes.First(x => x.Numcde == idCde);
                maCommande.Montantcde = montant; // mise à jour des propriétés
                maCommande.Datecde = DateOnly.FromDateTime(dateC.Date);
                maCommande.Numcli = idClient;
                monModel.SaveChanges(); // correspond à un UPDATE
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;
        }
    }
}
