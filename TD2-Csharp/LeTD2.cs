using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libBanque;

namespace TD2_Csharp
{
    public partial class LeTD2 : Form
    {

        private AgenceBancaire monAgence;
        

        public LeTD2()
        {
            InitializeComponent();
        }

        private void initialiserbanque()
        {
            //creation de l'objet agence bancaire
            monAgence = new AgenceBancaire("Lyon 5ème");
            lblCompteAgence.Text = "Agence de" + monAgence.NomAgence;

            //crétion de comptes et ajout des ces comptes et ajout de ces comptes à l'agence bancaire

            CompteBancaire CB1 = new CompteBancaire("123456G", "Mr Fernand NAUDIN", 3500);
            CompteBancaire CB2 = new CompteBancaire("546921K", "Mr Raoul VOLFONI");
            CompteBancaire CB3 = new CompteBancaire("963852R", "Mme DUCE", 4000);

            monAgence.ajouterCompte(CB1);
            monAgence.ajouterCompte(CB2);
            monAgence.ajouterCompte(CB3);
        }

        private void tab_Accueil_Click(object sender, EventArgs e)
        {

        }

        private void LeTD2_Load(object sender, EventArgs e)
        {
            
            initialiserbanque();
            remplirListeComptes();

        }

        private void remplirListeComptes()
        {
            //la source de données est un DGV
            DgvListeComptes.DataSource = monAgence.LesComptes;

            //on redimensionne les colonnes
            DgvListeComptes.AutoResizeColumns();
        }

        private void DgvListeComptes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabConsultation_Enter(object sender, EventArgs e)
        {
            cbxChoix.Items.Clear();

            foreach (CompteBancaire unCompte in monAgence.LesComptes)
            {
                cbxChoix.Items.Add(unCompte.NumCompte + " (" + unCompte.NomTitulaire + ")");
            }
        }

        private void cbxChoix_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cbxChoix.SelectedIndex;
            CompteBancaire leCompte;

            leCompte = monAgence.LesComptes.ElementAt(i);
            txbNumCompte.Text = leCompte.NumCompte;
            txbTitulaire.Text = leCompte.NomTitulaire;
            txbSolde.Text = leCompte.SoldeCompte.ToString();

        }

        private void btnCreation_Click(object sender, EventArgs e)
        {

            CompteBancaire CB;
            CB = new CompteBancaire(txbNumCompte1.Text, txbNomTitulaire1.Text, Decimal.Parse(txbSoldeInitial.Text));
            monAgence.LesComptes.Add(CB);
            lblMessageCrea.Text = "Le compte a été créé !";
            lblMessageCrea.ForeColor = Color.Green;



        }

        private void btnEnregistrerVers_Click(object sender, EventArgs e)
        {
            int i = cbxChoixCompteVers.SelectedIndex;
            CompteBancaire CB;
            CB = monAgence.LesComptes.ElementAt(i);
            CB.crediterCompte(Decimal.Parse(txbMontantCredit.Text));
            lblMessageVers.Text = "Le compte a été crédité";
            lblMessageVers.ForeColor = Color.Green;
        }


        private void cbxChoixCompteVers_Enter(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void btnAnnulerVers_Click(object sender, EventArgs e)
        {
            
            cbxChoixCompteVers.ResetText();
            txbMontantCredit.Text = "";
            lblMessageVers.Text = "";
        }

        private void cbxChoixCompteVers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabVersement_Entrer_Enter(object sender, EventArgs e)
        {
            cbxChoixCompteVers.Items.Clear();
            cbxChoixCompteVers.ResetText();
            txbMontantCredit.Text = "";
            lblMessageVers.Text = "";

            cbxCompteDebit.Items.Clear();
            cbxCompteDebit.ResetText();
            txbMontantDebit.Text = "";
            lblMessageDebit.Text = "";

            cbxDebiteur.Items.Clear();
            cbxDebiteur.ResetText();

            cbxCredite.Items.Clear();
            cbxCredite.ResetText();

            txbVirement.Text = "";
            lblMessageVirement.Text = "";

            foreach (CompteBancaire unCompte in monAgence.LesComptes)
            {
                cbxChoixCompteVers.Items.Add(unCompte.NumCompte + " (" + unCompte.NomTitulaire + ")");
                cbxCompteDebit.Items.Add(unCompte.NumCompte + " (" + unCompte.NomTitulaire + ")");
                cbxDebiteur.Items.Add(unCompte.NumCompte + " (" + unCompte.NomTitulaire + ")");
                cbxCredite.Items.Add(unCompte.NumCompte + " (" + unCompte.NomTitulaire + ")");
            }
        }

        private void btnEnregistrerDebit_Click(object sender, EventArgs e)
        {
            int i = cbxCompteDebit.SelectedIndex;
            CompteBancaire CB;
            CB = monAgence.LesComptes.ElementAt(i);
            Boolean rep;
            rep = CB.debiterCompte(Decimal.Parse(txbMontantDebit.Text));
            if(rep == true){
                lblMessageDebit.Text = "Le compte a été débité";
                lblMessageDebit.ForeColor = Color.Green;

            }
            else
            {
                lblMessageDebit.Text = "Impossible de debiter le compte le montant dépasse le solde du compte";
                lblMessageDebit.ForeColor = Color.Red;
            }
           
        }

        private void btnAnnulerDebit_Click(object sender, EventArgs e)
        {
            cbxCompteDebit.ResetText();
            txbMontantDebit.Text = "";
            lblMessageDebit.Text = "";
        }

        private void btnAnnulerVirement_Click(object sender, EventArgs e)
        {
            cbxDebiteur.ResetText();
            
            cbxCredite.ResetText();

            txbVirement.Text = "";
            lblMessageVirement.Text = "";
        }

        private void btnVirement_Click(object sender, EventArgs e)
        {
            int i = cbxDebiteur.SelectedIndex;
            int j = cbxCredite.SelectedIndex;

            CompteBancaire CB;
            CB = monAgence.LesComptes.ElementAt(i);
            Boolean rep;
            rep = CB.debiterCompte(Decimal.Parse(txbVirement.Text));
            if (rep == true)
            {
                CompteBancaire CB2;
                CB2 = monAgence.LesComptes.ElementAt(j);
                CB2.crediterCompte(Decimal.Parse(txbVirement.Text));

                lblMessageVirement.Text = "Le compte a été débité";
                lblMessageVirement.ForeColor = Color.Green;

            }
            else
            {
                lblMessageVirement.Text = "Impossible de debiter le compte le montant dépasse le solde du compte";
                lblMessageVirement.ForeColor = Color.Red;
            }
        }
    }
}
