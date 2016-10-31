namespace TD2_Csharp
{
    partial class LeTD2
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabVersement_Entrer = new System.Windows.Forms.TabControl();
            this.tab_Accueil = new System.Windows.Forms.TabPage();
            this.DgvListeComptes = new System.Windows.Forms.DataGridView();
            this.lblCompteAgence = new System.Windows.Forms.Label();
            this.lblLyon5 = new System.Windows.Forms.Label();
            this.tabConsultation = new System.Windows.Forms.TabPage();
            this.txbSolde = new System.Windows.Forms.TextBox();
            this.txbTitulaire = new System.Windows.Forms.TextBox();
            this.txbNumCompte = new System.Windows.Forms.TextBox();
            this.lblSolde = new System.Windows.Forms.Label();
            this.lblTitulaire = new System.Windows.Forms.Label();
            this.lblNumCompte = new System.Windows.Forms.Label();
            this.cbxChoix = new System.Windows.Forms.ComboBox();
            this.lblChoisir = new System.Windows.Forms.Label();
            this.lblConsultation = new System.Windows.Forms.Label();
            this.tabCreation = new System.Windows.Forms.TabPage();
            this.lblMessageCrea = new System.Windows.Forms.Label();
            this.btnCreation = new System.Windows.Forms.Button();
            this.txbSoldeInitial = new System.Windows.Forms.TextBox();
            this.txbNomTitulaire1 = new System.Windows.Forms.TextBox();
            this.txbNumCompte1 = new System.Windows.Forms.TextBox();
            this.lblSoldeInitial = new System.Windows.Forms.Label();
            this.lblTitulaire1 = new System.Windows.Forms.Label();
            this.lblNumCompte1 = new System.Windows.Forms.Label();
            this.lblCreat = new System.Windows.Forms.Label();
            this.tabVersement = new System.Windows.Forms.TabPage();
            this.lblMontantCredit = new System.Windows.Forms.Label();
            this.lblCompte = new System.Windows.Forms.Label();
            this.txbMontantCredit = new System.Windows.Forms.TextBox();
            this.cbxChoixCompteVers = new System.Windows.Forms.ComboBox();
            this.btnAnnulerVers = new System.Windows.Forms.Button();
            this.btnEnregistrerVers = new System.Windows.Forms.Button();
            this.lblMessageVers = new System.Windows.Forms.Label();
            this.lblVersement = new System.Windows.Forms.Label();
            this.tabRetrait = new System.Windows.Forms.TabPage();
            this.tabVirement = new System.Windows.Forms.TabPage();
            this.lblMontantDebit = new System.Windows.Forms.Label();
            this.lblCompteDebit = new System.Windows.Forms.Label();
            this.txbMontantDebit = new System.Windows.Forms.TextBox();
            this.cbxCompteDebit = new System.Windows.Forms.ComboBox();
            this.btnAnnulerDebit = new System.Windows.Forms.Button();
            this.btnEnregistrerDebit = new System.Windows.Forms.Button();
            this.lblMessageDebit = new System.Windows.Forms.Label();
            this.lblEnregistrementRetrait = new System.Windows.Forms.Label();
            this.lblMontantVirement = new System.Windows.Forms.Label();
            this.lblDebiteur = new System.Windows.Forms.Label();
            this.txbVirement = new System.Windows.Forms.TextBox();
            this.cbxDebiteur = new System.Windows.Forms.ComboBox();
            this.btnAnnulerVirement = new System.Windows.Forms.Button();
            this.btnVirement = new System.Windows.Forms.Button();
            this.lblMessageVirement = new System.Windows.Forms.Label();
            this.lblVirement = new System.Windows.Forms.Label();
            this.lblCredite = new System.Windows.Forms.Label();
            this.cbxCredite = new System.Windows.Forms.ComboBox();
            this.tabVersement_Entrer.SuspendLayout();
            this.tab_Accueil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListeComptes)).BeginInit();
            this.tabConsultation.SuspendLayout();
            this.tabCreation.SuspendLayout();
            this.tabVersement.SuspendLayout();
            this.tabRetrait.SuspendLayout();
            this.tabVirement.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabVersement_Entrer
            // 
            this.tabVersement_Entrer.Controls.Add(this.tab_Accueil);
            this.tabVersement_Entrer.Controls.Add(this.tabConsultation);
            this.tabVersement_Entrer.Controls.Add(this.tabCreation);
            this.tabVersement_Entrer.Controls.Add(this.tabVersement);
            this.tabVersement_Entrer.Controls.Add(this.tabRetrait);
            this.tabVersement_Entrer.Controls.Add(this.tabVirement);
            this.tabVersement_Entrer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabVersement_Entrer.Location = new System.Drawing.Point(0, 0);
            this.tabVersement_Entrer.Name = "tabVersement_Entrer";
            this.tabVersement_Entrer.SelectedIndex = 0;
            this.tabVersement_Entrer.Size = new System.Drawing.Size(824, 379);
            this.tabVersement_Entrer.TabIndex = 0;
            this.tabVersement_Entrer.Enter += new System.EventHandler(this.tabVersement_Entrer_Enter);
            // 
            // tab_Accueil
            // 
            this.tab_Accueil.Controls.Add(this.DgvListeComptes);
            this.tab_Accueil.Controls.Add(this.lblCompteAgence);
            this.tab_Accueil.Controls.Add(this.lblLyon5);
            this.tab_Accueil.Location = new System.Drawing.Point(4, 22);
            this.tab_Accueil.Name = "tab_Accueil";
            this.tab_Accueil.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Accueil.Size = new System.Drawing.Size(816, 353);
            this.tab_Accueil.TabIndex = 0;
            this.tab_Accueil.Text = "Accueil";
            this.tab_Accueil.UseVisualStyleBackColor = true;
            this.tab_Accueil.Click += new System.EventHandler(this.tab_Accueil_Click);
            // 
            // DgvListeComptes
            // 
            this.DgvListeComptes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListeComptes.Location = new System.Drawing.Point(82, 157);
            this.DgvListeComptes.Name = "DgvListeComptes";
            this.DgvListeComptes.Size = new System.Drawing.Size(642, 150);
            this.DgvListeComptes.TabIndex = 2;
            this.DgvListeComptes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListeComptes_CellContentClick);
            // 
            // lblCompteAgence
            // 
            this.lblCompteAgence.AutoSize = true;
            this.lblCompteAgence.Location = new System.Drawing.Point(127, 127);
            this.lblCompteAgence.Name = "lblCompteAgence";
            this.lblCompteAgence.Size = new System.Drawing.Size(150, 13);
            this.lblCompteAgence.TabIndex = 1;
            this.lblCompteAgence.Text = "Liste des comptes de l\'agence";
            // 
            // lblLyon5
            // 
            this.lblLyon5.AutoSize = true;
            this.lblLyon5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblLyon5.Location = new System.Drawing.Point(78, 67);
            this.lblLyon5.Name = "lblLyon5";
            this.lblLyon5.Size = new System.Drawing.Size(203, 24);
            this.lblLyon5.TabIndex = 0;
            this.lblLyon5.Text = "Agence de Lyon 5eme";
            // 
            // tabConsultation
            // 
            this.tabConsultation.Controls.Add(this.txbSolde);
            this.tabConsultation.Controls.Add(this.txbTitulaire);
            this.tabConsultation.Controls.Add(this.txbNumCompte);
            this.tabConsultation.Controls.Add(this.lblSolde);
            this.tabConsultation.Controls.Add(this.lblTitulaire);
            this.tabConsultation.Controls.Add(this.lblNumCompte);
            this.tabConsultation.Controls.Add(this.cbxChoix);
            this.tabConsultation.Controls.Add(this.lblChoisir);
            this.tabConsultation.Controls.Add(this.lblConsultation);
            this.tabConsultation.Location = new System.Drawing.Point(4, 22);
            this.tabConsultation.Name = "tabConsultation";
            this.tabConsultation.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultation.Size = new System.Drawing.Size(816, 353);
            this.tabConsultation.TabIndex = 1;
            this.tabConsultation.Text = "Consultation";
            this.tabConsultation.UseVisualStyleBackColor = true;
            this.tabConsultation.Enter += new System.EventHandler(this.tabConsultation_Enter);
            // 
            // txbSolde
            // 
            this.txbSolde.Location = new System.Drawing.Point(332, 251);
            this.txbSolde.Name = "txbSolde";
            this.txbSolde.Size = new System.Drawing.Size(211, 20);
            this.txbSolde.TabIndex = 8;
            // 
            // txbTitulaire
            // 
            this.txbTitulaire.Location = new System.Drawing.Point(332, 203);
            this.txbTitulaire.Name = "txbTitulaire";
            this.txbTitulaire.Size = new System.Drawing.Size(211, 20);
            this.txbTitulaire.TabIndex = 7;
            // 
            // txbNumCompte
            // 
            this.txbNumCompte.Location = new System.Drawing.Point(332, 157);
            this.txbNumCompte.Name = "txbNumCompte";
            this.txbNumCompte.Size = new System.Drawing.Size(211, 20);
            this.txbNumCompte.TabIndex = 6;
            // 
            // lblSolde
            // 
            this.lblSolde.AutoSize = true;
            this.lblSolde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblSolde.Location = new System.Drawing.Point(186, 254);
            this.lblSolde.Name = "lblSolde";
            this.lblSolde.Size = new System.Drawing.Size(122, 17);
            this.lblSolde.TabIndex = 5;
            this.lblSolde.Text = "Solde du compte :";
            // 
            // lblTitulaire
            // 
            this.lblTitulaire.AutoSize = true;
            this.lblTitulaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblTitulaire.Location = new System.Drawing.Point(241, 206);
            this.lblTitulaire.Name = "lblTitulaire";
            this.lblTitulaire.Size = new System.Drawing.Size(67, 17);
            this.lblTitulaire.TabIndex = 4;
            this.lblTitulaire.Text = "Titulaire :";
            // 
            // lblNumCompte
            // 
            this.lblNumCompte.AutoSize = true;
            this.lblNumCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblNumCompte.Location = new System.Drawing.Point(206, 157);
            this.lblNumCompte.Name = "lblNumCompte";
            this.lblNumCompte.Size = new System.Drawing.Size(102, 17);
            this.lblNumCompte.TabIndex = 3;
            this.lblNumCompte.Text = "N° de compte :";
            // 
            // cbxChoix
            // 
            this.cbxChoix.FormattingEnabled = true;
            this.cbxChoix.Location = new System.Drawing.Point(332, 106);
            this.cbxChoix.Name = "cbxChoix";
            this.cbxChoix.Size = new System.Drawing.Size(254, 21);
            this.cbxChoix.TabIndex = 2;
            this.cbxChoix.SelectedIndexChanged += new System.EventHandler(this.cbxChoix_SelectedIndexChanged);
            // 
            // lblChoisir
            // 
            this.lblChoisir.AutoSize = true;
            this.lblChoisir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblChoisir.Location = new System.Drawing.Point(179, 106);
            this.lblChoisir.Name = "lblChoisir";
            this.lblChoisir.Size = new System.Drawing.Size(129, 17);
            this.lblChoisir.TabIndex = 1;
            this.lblChoisir.Text = "Choisir un compte :";
            // 
            // lblConsultation
            // 
            this.lblConsultation.AutoSize = true;
            this.lblConsultation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblConsultation.Location = new System.Drawing.Point(264, 57);
            this.lblConsultation.Name = "lblConsultation";
            this.lblConsultation.Size = new System.Drawing.Size(244, 20);
            this.lblConsultation.TabIndex = 0;
            this.lblConsultation.Text = "CONSULTATION DE COMPTE";
            // 
            // tabCreation
            // 
            this.tabCreation.Controls.Add(this.lblMessageCrea);
            this.tabCreation.Controls.Add(this.btnCreation);
            this.tabCreation.Controls.Add(this.txbSoldeInitial);
            this.tabCreation.Controls.Add(this.txbNomTitulaire1);
            this.tabCreation.Controls.Add(this.txbNumCompte1);
            this.tabCreation.Controls.Add(this.lblSoldeInitial);
            this.tabCreation.Controls.Add(this.lblTitulaire1);
            this.tabCreation.Controls.Add(this.lblNumCompte1);
            this.tabCreation.Controls.Add(this.lblCreat);
            this.tabCreation.Location = new System.Drawing.Point(4, 22);
            this.tabCreation.Name = "tabCreation";
            this.tabCreation.Size = new System.Drawing.Size(816, 353);
            this.tabCreation.TabIndex = 2;
            this.tabCreation.Text = "Creation";
            this.tabCreation.UseVisualStyleBackColor = true;
            // 
            // lblMessageCrea
            // 
            this.lblMessageCrea.AutoSize = true;
            this.lblMessageCrea.Location = new System.Drawing.Point(296, 308);
            this.lblMessageCrea.Name = "lblMessageCrea";
            this.lblMessageCrea.Size = new System.Drawing.Size(0, 13);
            this.lblMessageCrea.TabIndex = 16;
            // 
            // btnCreation
            // 
            this.btnCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnCreation.Location = new System.Drawing.Point(262, 241);
            this.btnCreation.Name = "btnCreation";
            this.btnCreation.Size = new System.Drawing.Size(283, 41);
            this.btnCreation.TabIndex = 15;
            this.btnCreation.Text = "Création du compte";
            this.btnCreation.UseVisualStyleBackColor = true;
            this.btnCreation.Click += new System.EventHandler(this.btnCreation_Click);
            // 
            // txbSoldeInitial
            // 
            this.txbSoldeInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txbSoldeInitial.Location = new System.Drawing.Point(374, 187);
            this.txbSoldeInitial.Name = "txbSoldeInitial";
            this.txbSoldeInitial.Size = new System.Drawing.Size(211, 23);
            this.txbSoldeInitial.TabIndex = 14;
            // 
            // txbNomTitulaire1
            // 
            this.txbNomTitulaire1.Location = new System.Drawing.Point(374, 139);
            this.txbNomTitulaire1.Name = "txbNomTitulaire1";
            this.txbNomTitulaire1.Size = new System.Drawing.Size(211, 20);
            this.txbNomTitulaire1.TabIndex = 13;
            // 
            // txbNumCompte1
            // 
            this.txbNumCompte1.Location = new System.Drawing.Point(374, 93);
            this.txbNumCompte1.Name = "txbNumCompte1";
            this.txbNumCompte1.Size = new System.Drawing.Size(211, 20);
            this.txbNumCompte1.TabIndex = 12;
            // 
            // lblSoldeInitial
            // 
            this.lblSoldeInitial.AutoSize = true;
            this.lblSoldeInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblSoldeInitial.Location = new System.Drawing.Point(228, 190);
            this.lblSoldeInitial.Name = "lblSoldeInitial";
            this.lblSoldeInitial.Size = new System.Drawing.Size(88, 17);
            this.lblSoldeInitial.TabIndex = 11;
            this.lblSoldeInitial.Text = "Solde Initial :";
            // 
            // lblTitulaire1
            // 
            this.lblTitulaire1.AutoSize = true;
            this.lblTitulaire1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblTitulaire1.Location = new System.Drawing.Point(214, 139);
            this.lblTitulaire1.Name = "lblTitulaire1";
            this.lblTitulaire1.Size = new System.Drawing.Size(120, 17);
            this.lblTitulaire1.TabIndex = 10;
            this.lblTitulaire1.Text = "Nom du Titulaire :";
            // 
            // lblNumCompte1
            // 
            this.lblNumCompte1.AutoSize = true;
            this.lblNumCompte1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblNumCompte1.Location = new System.Drawing.Point(214, 93);
            this.lblNumCompte1.Name = "lblNumCompte1";
            this.lblNumCompte1.Size = new System.Drawing.Size(136, 17);
            this.lblNumCompte1.TabIndex = 9;
            this.lblNumCompte1.Text = "Numero de compte :";
            // 
            // lblCreat
            // 
            this.lblCreat.AutoSize = true;
            this.lblCreat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblCreat.Location = new System.Drawing.Point(310, 39);
            this.lblCreat.Name = "lblCreat";
            this.lblCreat.Size = new System.Drawing.Size(199, 20);
            this.lblCreat.TabIndex = 0;
            this.lblCreat.Text = "CREATION DE COMPTE";
            // 
            // tabVersement
            // 
            this.tabVersement.Controls.Add(this.lblMontantCredit);
            this.tabVersement.Controls.Add(this.lblCompte);
            this.tabVersement.Controls.Add(this.txbMontantCredit);
            this.tabVersement.Controls.Add(this.cbxChoixCompteVers);
            this.tabVersement.Controls.Add(this.btnAnnulerVers);
            this.tabVersement.Controls.Add(this.btnEnregistrerVers);
            this.tabVersement.Controls.Add(this.lblMessageVers);
            this.tabVersement.Controls.Add(this.lblVersement);
            this.tabVersement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tabVersement.Location = new System.Drawing.Point(4, 22);
            this.tabVersement.Name = "tabVersement";
            this.tabVersement.Size = new System.Drawing.Size(816, 353);
            this.tabVersement.TabIndex = 3;
            this.tabVersement.Text = "Versement";
            this.tabVersement.UseVisualStyleBackColor = true;
            // 
            // lblMontantCredit
            // 
            this.lblMontantCredit.AutoSize = true;
            this.lblMontantCredit.Location = new System.Drawing.Point(190, 149);
            this.lblMontantCredit.Name = "lblMontantCredit";
            this.lblMontantCredit.Size = new System.Drawing.Size(131, 17);
            this.lblMontantCredit.TabIndex = 7;
            this.lblMontantCredit.Text = "Montant à créditer :";
            // 
            // lblCompte
            // 
            this.lblCompte.AutoSize = true;
            this.lblCompte.Location = new System.Drawing.Point(190, 112);
            this.lblCompte.Name = "lblCompte";
            this.lblCompte.Size = new System.Drawing.Size(128, 17);
            this.lblCompte.TabIndex = 6;
            this.lblCompte.Text = "Compte à créditer :";
            // 
            // txbMontantCredit
            // 
            this.txbMontantCredit.Font = new System.Drawing.Font("Vivaldi", 8.25F);
            this.txbMontantCredit.Location = new System.Drawing.Point(327, 145);
            this.txbMontantCredit.Name = "txbMontantCredit";
            this.txbMontantCredit.Size = new System.Drawing.Size(240, 21);
            this.txbMontantCredit.TabIndex = 5;
            // 
            // cbxChoixCompteVers
            // 
            this.cbxChoixCompteVers.FormattingEnabled = true;
            this.cbxChoixCompteVers.Location = new System.Drawing.Point(327, 104);
            this.cbxChoixCompteVers.Name = "cbxChoixCompteVers";
            this.cbxChoixCompteVers.Size = new System.Drawing.Size(240, 25);
            this.cbxChoixCompteVers.TabIndex = 4;
            this.cbxChoixCompteVers.SelectedIndexChanged += new System.EventHandler(this.cbxChoixCompteVers_SelectedIndexChanged);
            // 
            // btnAnnulerVers
            // 
            this.btnAnnulerVers.Location = new System.Drawing.Point(394, 200);
            this.btnAnnulerVers.Name = "btnAnnulerVers";
            this.btnAnnulerVers.Size = new System.Drawing.Size(173, 48);
            this.btnAnnulerVers.TabIndex = 3;
            this.btnAnnulerVers.Text = "Annuler la saisie";
            this.btnAnnulerVers.UseVisualStyleBackColor = true;
            this.btnAnnulerVers.Click += new System.EventHandler(this.btnAnnulerVers_Click);
            // 
            // btnEnregistrerVers
            // 
            this.btnEnregistrerVers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnEnregistrerVers.Location = new System.Drawing.Point(193, 200);
            this.btnEnregistrerVers.Name = "btnEnregistrerVers";
            this.btnEnregistrerVers.Size = new System.Drawing.Size(173, 48);
            this.btnEnregistrerVers.TabIndex = 2;
            this.btnEnregistrerVers.Text = "Enregistrer le versement";
            this.btnEnregistrerVers.UseVisualStyleBackColor = true;
            this.btnEnregistrerVers.Click += new System.EventHandler(this.btnEnregistrerVers_Click);
            // 
            // lblMessageVers
            // 
            this.lblMessageVers.AutoSize = true;
            this.lblMessageVers.Location = new System.Drawing.Point(190, 271);
            this.lblMessageVers.Name = "lblMessageVers";
            this.lblMessageVers.Size = new System.Drawing.Size(0, 17);
            this.lblMessageVers.TabIndex = 1;
            // 
            // lblVersement
            // 
            this.lblVersement.AutoSize = true;
            this.lblVersement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblVersement.Location = new System.Drawing.Point(222, 48);
            this.lblVersement.Name = "lblVersement";
            this.lblVersement.Size = new System.Drawing.Size(317, 20);
            this.lblVersement.TabIndex = 0;
            this.lblVersement.Text = "ENREGISTREMENT D\'UN VERSEMENT";
            // 
            // tabRetrait
            // 
            this.tabRetrait.Controls.Add(this.lblMontantDebit);
            this.tabRetrait.Controls.Add(this.lblCompteDebit);
            this.tabRetrait.Controls.Add(this.txbMontantDebit);
            this.tabRetrait.Controls.Add(this.cbxCompteDebit);
            this.tabRetrait.Controls.Add(this.btnAnnulerDebit);
            this.tabRetrait.Controls.Add(this.btnEnregistrerDebit);
            this.tabRetrait.Controls.Add(this.lblMessageDebit);
            this.tabRetrait.Controls.Add(this.lblEnregistrementRetrait);
            this.tabRetrait.Location = new System.Drawing.Point(4, 22);
            this.tabRetrait.Name = "tabRetrait";
            this.tabRetrait.Size = new System.Drawing.Size(816, 353);
            this.tabRetrait.TabIndex = 4;
            this.tabRetrait.Text = "Retrait";
            this.tabRetrait.UseVisualStyleBackColor = true;
            // 
            // tabVirement
            // 
            this.tabVirement.Controls.Add(this.lblCredite);
            this.tabVirement.Controls.Add(this.cbxCredite);
            this.tabVirement.Controls.Add(this.lblMontantVirement);
            this.tabVirement.Controls.Add(this.lblDebiteur);
            this.tabVirement.Controls.Add(this.txbVirement);
            this.tabVirement.Controls.Add(this.cbxDebiteur);
            this.tabVirement.Controls.Add(this.btnAnnulerVirement);
            this.tabVirement.Controls.Add(this.btnVirement);
            this.tabVirement.Controls.Add(this.lblMessageVirement);
            this.tabVirement.Controls.Add(this.lblVirement);
            this.tabVirement.Location = new System.Drawing.Point(4, 22);
            this.tabVirement.Name = "tabVirement";
            this.tabVirement.Size = new System.Drawing.Size(816, 353);
            this.tabVirement.TabIndex = 5;
            this.tabVirement.Text = "Virement";
            this.tabVirement.UseVisualStyleBackColor = true;
            // 
            // lblMontantDebit
            // 
            this.lblMontantDebit.AutoSize = true;
            this.lblMontantDebit.Location = new System.Drawing.Point(208, 155);
            this.lblMontantDebit.Name = "lblMontantDebit";
            this.lblMontantDebit.Size = new System.Drawing.Size(96, 13);
            this.lblMontantDebit.TabIndex = 15;
            this.lblMontantDebit.Text = "Montant à débiter :";
            // 
            // lblCompteDebit
            // 
            this.lblCompteDebit.AutoSize = true;
            this.lblCompteDebit.Location = new System.Drawing.Point(208, 118);
            this.lblCompteDebit.Name = "lblCompteDebit";
            this.lblCompteDebit.Size = new System.Drawing.Size(93, 13);
            this.lblCompteDebit.TabIndex = 14;
            this.lblCompteDebit.Text = "Compte à debiter :";
            // 
            // txbMontantDebit
            // 
            this.txbMontantDebit.Font = new System.Drawing.Font("Vivaldi", 8.25F);
            this.txbMontantDebit.Location = new System.Drawing.Point(345, 151);
            this.txbMontantDebit.Name = "txbMontantDebit";
            this.txbMontantDebit.Size = new System.Drawing.Size(240, 21);
            this.txbMontantDebit.TabIndex = 13;
            // 
            // cbxCompteDebit
            // 
            this.cbxCompteDebit.FormattingEnabled = true;
            this.cbxCompteDebit.Location = new System.Drawing.Point(345, 110);
            this.cbxCompteDebit.Name = "cbxCompteDebit";
            this.cbxCompteDebit.Size = new System.Drawing.Size(240, 21);
            this.cbxCompteDebit.TabIndex = 12;
            // 
            // btnAnnulerDebit
            // 
            this.btnAnnulerDebit.Location = new System.Drawing.Point(412, 206);
            this.btnAnnulerDebit.Name = "btnAnnulerDebit";
            this.btnAnnulerDebit.Size = new System.Drawing.Size(173, 48);
            this.btnAnnulerDebit.TabIndex = 11;
            this.btnAnnulerDebit.Text = "Annuler la saisie";
            this.btnAnnulerDebit.UseVisualStyleBackColor = true;
            this.btnAnnulerDebit.Click += new System.EventHandler(this.btnAnnulerDebit_Click);
            // 
            // btnEnregistrerDebit
            // 
            this.btnEnregistrerDebit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnEnregistrerDebit.Location = new System.Drawing.Point(211, 206);
            this.btnEnregistrerDebit.Name = "btnEnregistrerDebit";
            this.btnEnregistrerDebit.Size = new System.Drawing.Size(173, 48);
            this.btnEnregistrerDebit.TabIndex = 10;
            this.btnEnregistrerDebit.Text = "Enregistrer le debit";
            this.btnEnregistrerDebit.UseVisualStyleBackColor = true;
            this.btnEnregistrerDebit.Click += new System.EventHandler(this.btnEnregistrerDebit_Click);
            // 
            // lblMessageDebit
            // 
            this.lblMessageDebit.AutoSize = true;
            this.lblMessageDebit.Location = new System.Drawing.Point(208, 277);
            this.lblMessageDebit.Name = "lblMessageDebit";
            this.lblMessageDebit.Size = new System.Drawing.Size(0, 13);
            this.lblMessageDebit.TabIndex = 9;
            // 
            // lblEnregistrementRetrait
            // 
            this.lblEnregistrementRetrait.AutoSize = true;
            this.lblEnregistrementRetrait.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblEnregistrementRetrait.Location = new System.Drawing.Point(240, 54);
            this.lblEnregistrementRetrait.Name = "lblEnregistrementRetrait";
            this.lblEnregistrementRetrait.Size = new System.Drawing.Size(284, 20);
            this.lblEnregistrementRetrait.TabIndex = 8;
            this.lblEnregistrementRetrait.Text = "ENREGISTREMENT D\'UN RETRAIT";
            // 
            // lblMontantVirement
            // 
            this.lblMontantVirement.AutoSize = true;
            this.lblMontantVirement.Location = new System.Drawing.Point(220, 166);
            this.lblMontantVirement.Name = "lblMontantVirement";
            this.lblMontantVirement.Size = new System.Drawing.Size(84, 13);
            this.lblMontantVirement.TabIndex = 23;
            this.lblMontantVirement.Text = "Montant à virer :";
            // 
            // lblDebiteur
            // 
            this.lblDebiteur.AutoSize = true;
            this.lblDebiteur.Location = new System.Drawing.Point(220, 103);
            this.lblDebiteur.Name = "lblDebiteur";
            this.lblDebiteur.Size = new System.Drawing.Size(93, 13);
            this.lblDebiteur.TabIndex = 22;
            this.lblDebiteur.Text = "Compte à debiter :";
            // 
            // txbVirement
            // 
            this.txbVirement.Font = new System.Drawing.Font("Vivaldi", 8.25F);
            this.txbVirement.Location = new System.Drawing.Point(357, 162);
            this.txbVirement.Name = "txbVirement";
            this.txbVirement.Size = new System.Drawing.Size(240, 21);
            this.txbVirement.TabIndex = 21;
            // 
            // cbxDebiteur
            // 
            this.cbxDebiteur.FormattingEnabled = true;
            this.cbxDebiteur.Location = new System.Drawing.Point(357, 95);
            this.cbxDebiteur.Name = "cbxDebiteur";
            this.cbxDebiteur.Size = new System.Drawing.Size(240, 21);
            this.cbxDebiteur.TabIndex = 20;
            // 
            // btnAnnulerVirement
            // 
            this.btnAnnulerVirement.Location = new System.Drawing.Point(424, 210);
            this.btnAnnulerVirement.Name = "btnAnnulerVirement";
            this.btnAnnulerVirement.Size = new System.Drawing.Size(173, 48);
            this.btnAnnulerVirement.TabIndex = 19;
            this.btnAnnulerVirement.Text = "Annuler la saisie";
            this.btnAnnulerVirement.UseVisualStyleBackColor = true;
            this.btnAnnulerVirement.Click += new System.EventHandler(this.btnAnnulerVirement_Click);
            // 
            // btnVirement
            // 
            this.btnVirement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnVirement.Location = new System.Drawing.Point(223, 210);
            this.btnVirement.Name = "btnVirement";
            this.btnVirement.Size = new System.Drawing.Size(173, 48);
            this.btnVirement.TabIndex = 18;
            this.btnVirement.Text = "Enregistrer le virement";
            this.btnVirement.UseVisualStyleBackColor = true;
            this.btnVirement.Click += new System.EventHandler(this.btnVirement_Click);
            // 
            // lblMessageVirement
            // 
            this.lblMessageVirement.AutoSize = true;
            this.lblMessageVirement.Location = new System.Drawing.Point(220, 281);
            this.lblMessageVirement.Name = "lblMessageVirement";
            this.lblMessageVirement.Size = new System.Drawing.Size(0, 13);
            this.lblMessageVirement.TabIndex = 17;
            // 
            // lblVirement
            // 
            this.lblVirement.AutoSize = true;
            this.lblVirement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblVirement.Location = new System.Drawing.Point(252, 58);
            this.lblVirement.Name = "lblVirement";
            this.lblVirement.Size = new System.Drawing.Size(299, 20);
            this.lblVirement.TabIndex = 16;
            this.lblVirement.Text = "ENREGISTREMENT D\'UN VIREMENT";
            // 
            // lblCredite
            // 
            this.lblCredite.AutoSize = true;
            this.lblCredite.Location = new System.Drawing.Point(220, 130);
            this.lblCredite.Name = "lblCredite";
            this.lblCredite.Size = new System.Drawing.Size(96, 13);
            this.lblCredite.TabIndex = 25;
            this.lblCredite.Text = "Compte à créditer :";
            // 
            // cbxCredite
            // 
            this.cbxCredite.FormattingEnabled = true;
            this.cbxCredite.Location = new System.Drawing.Point(357, 122);
            this.cbxCredite.Name = "cbxCredite";
            this.cbxCredite.Size = new System.Drawing.Size(240, 21);
            this.cbxCredite.TabIndex = 24;
            // 
            // LeTD2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 379);
            this.Controls.Add(this.tabVersement_Entrer);
            this.Name = "LeTD2";
            this.Text = "TD2";
            this.Load += new System.EventHandler(this.LeTD2_Load);
            this.tabVersement_Entrer.ResumeLayout(false);
            this.tab_Accueil.ResumeLayout(false);
            this.tab_Accueil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListeComptes)).EndInit();
            this.tabConsultation.ResumeLayout(false);
            this.tabConsultation.PerformLayout();
            this.tabCreation.ResumeLayout(false);
            this.tabCreation.PerformLayout();
            this.tabVersement.ResumeLayout(false);
            this.tabVersement.PerformLayout();
            this.tabRetrait.ResumeLayout(false);
            this.tabRetrait.PerformLayout();
            this.tabVirement.ResumeLayout(false);
            this.tabVirement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabVersement_Entrer;
        private System.Windows.Forms.TabPage tab_Accueil;
        private System.Windows.Forms.TabPage tabConsultation;
        private System.Windows.Forms.TabPage tabCreation;
        private System.Windows.Forms.TabPage tabVersement;
        private System.Windows.Forms.TabPage tabRetrait;
        private System.Windows.Forms.TabPage tabVirement;
        private System.Windows.Forms.Label lblLyon5;
        private System.Windows.Forms.DataGridView DgvListeComptes;
        private System.Windows.Forms.Label lblCompteAgence;
        private System.Windows.Forms.TextBox txbSolde;
        private System.Windows.Forms.TextBox txbTitulaire;
        private System.Windows.Forms.TextBox txbNumCompte;
        private System.Windows.Forms.Label lblSolde;
        private System.Windows.Forms.Label lblTitulaire;
        private System.Windows.Forms.Label lblNumCompte;
        private System.Windows.Forms.ComboBox cbxChoix;
        private System.Windows.Forms.Label lblChoisir;
        private System.Windows.Forms.Label lblConsultation;
        private System.Windows.Forms.Button btnCreation;
        private System.Windows.Forms.TextBox txbSoldeInitial;
        private System.Windows.Forms.TextBox txbNomTitulaire1;
        private System.Windows.Forms.TextBox txbNumCompte1;
        private System.Windows.Forms.Label lblSoldeInitial;
        private System.Windows.Forms.Label lblTitulaire1;
        private System.Windows.Forms.Label lblNumCompte1;
        private System.Windows.Forms.Label lblCreat;
        private System.Windows.Forms.Label lblMessageCrea;
        private System.Windows.Forms.TextBox txbMontantCredit;
        private System.Windows.Forms.ComboBox cbxChoixCompteVers;
        private System.Windows.Forms.Button btnAnnulerVers;
        private System.Windows.Forms.Button btnEnregistrerVers;
        private System.Windows.Forms.Label lblMessageVers;
        private System.Windows.Forms.Label lblVersement;
        private System.Windows.Forms.Label lblMontantCredit;
        private System.Windows.Forms.Label lblCompte;
        private System.Windows.Forms.Label lblMontantDebit;
        private System.Windows.Forms.Label lblCompteDebit;
        private System.Windows.Forms.TextBox txbMontantDebit;
        private System.Windows.Forms.ComboBox cbxCompteDebit;
        private System.Windows.Forms.Button btnAnnulerDebit;
        private System.Windows.Forms.Button btnEnregistrerDebit;
        private System.Windows.Forms.Label lblMessageDebit;
        private System.Windows.Forms.Label lblEnregistrementRetrait;
        private System.Windows.Forms.Label lblCredite;
        private System.Windows.Forms.ComboBox cbxCredite;
        private System.Windows.Forms.Label lblMontantVirement;
        private System.Windows.Forms.Label lblDebiteur;
        private System.Windows.Forms.TextBox txbVirement;
        private System.Windows.Forms.ComboBox cbxDebiteur;
        private System.Windows.Forms.Button btnAnnulerVirement;
        private System.Windows.Forms.Button btnVirement;
        private System.Windows.Forms.Label lblMessageVirement;
        private System.Windows.Forms.Label lblVirement;
    }
}

