using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libBanque
{
    public class CompteBancaire
    {

        #region Propriétés privées
        private string numCompte;
        private string nomTitulaire;
        private Decimal soldeCompte;
        #endregion

        #region Property
        /// <summary>
        /// Accesseurs(get et set) pour le numéro du compte bancaire
        /// </summary>
        public string NumCompte
        {
            get
            {
                return numCompte;
            }

            set
            {
                numCompte = value;
            }
        }
        /// <summary>
        /// Accesseurs(get et set) pour le nom du titulaire du compte
        /// </summary>
        public string NomTitulaire
        {
            get
            {
                return nomTitulaire;
            }

            set
            {
                nomTitulaire = value;
            }
        }
        /// <summary>
        /// Accesseur (get uniquement) pour le solde du compte bancaire
        /// </summary>
        public decimal SoldeCompte
        {
            get
            {
                return soldeCompte;
            }

        }
        #endregion

        #region Méthodes
        public bool crediterCompte(Decimal unSolde)
        {
            if (unSolde >= 0)
            {
                soldeCompte = soldeCompte + unSolde;
                return true;
            }
            else
            {
                return false;
            }
        }


        public Boolean debiterCompte(Decimal unMontant)
        {
            if (unMontant <= soldeCompte)
            {
                soldeCompte -= unMontant;
                return true;
            }
            else
            {
                return false;
            }
        }


        #endregion

        #region Constructeurs de la classe
        /// <summary>
        /// Crée une nouvelle instance de la classe CompteBancaire en valorisant le Numéro de compte et le nom du titulaire
        /// </summary>
        /// <param name="unNumero">Numéro de compte bancaire</param>
        /// <param name="unTitulaire">Titulaire du compte</param>
        public CompteBancaire(string unNumero, string unTitulaire)
        {
            numCompte = unNumero;
            nomTitulaire = unTitulaire;
        }
        /// <summary>
        /// Crée une nouvelle instance de la classe CompteBancaire en valorisant le Numéro de compte,le nom du titulaire et
        /// le solde du compte
        /// </summary>
        /// <param name="unNumero">Numéro du compte bancaire</param>
        /// <param name="unTitulaire">Titulaire du compte</param>
        /// <param name="unSoldeInitial">Solde du compte bancaire</param>
        public CompteBancaire(string unNumero, string unTitulaire, Decimal unSoldeInitial)
        {
            numCompte = unNumero;
            nomTitulaire = unTitulaire;
            soldeCompte = unSoldeInitial;
        }
        #endregion


    }

    public class AgenceBancaire
    {
        // Propriétés privées
        // Liste (collection) des comptes bancaires
        // Une collection est un "tableau dynamique" d'objets,
        // Ici d'objets de type CompteBancaire

        private string nomAgence;
        private List<CompteBancaire> lesComptes;

        //Accesseurs

        public List<CompteBancaire> LesComptes
        {
            get { return lesComptes; }
        }

        public string NomAgence
        {
            get { return nomAgence; }
            set { nomAgence = value; }
        }

        public int NombreComptes
        {
            get { return lesComptes.Count; }
        }

        //Constructeur
        public AgenceBancaire(string unNom)
        {
            lesComptes = new List<CompteBancaire>();
            nomAgence = unNom;
        }

        //Méthodes

        //Ajout d'un compte à l'agence
        public void ajouterCompte(CompteBancaire unCompte)
        {
            lesComptes.Add(unCompte);
        }

        //Suppression d'un compte de l'agence
        public void supprimerCompte (CompteBancaire unCompte)
        {
            lesComptes.Remove(unCompte);
        }
    }
}
