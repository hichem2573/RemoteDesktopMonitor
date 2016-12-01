namespace RDMClient
{
    partial class FrmMain
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblErreur = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lstbPseudos = new System.Windows.Forms.ListBox();
            this.grBoxIdentification = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPseudo = new System.Windows.Forms.TextBox();
            this.txtWebService = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPseudo = new System.Windows.Forms.Label();
            this.lblWebService = new System.Windows.Forms.Label();
            this.pnlConnexion = new System.Windows.Forms.Panel();
            this.btDeconnecter = new System.Windows.Forms.Button();
            this.btConnecter = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.grBoxIdentification.SuspendLayout();
            this.pnlConnexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblErreur, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.74227F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.25773F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(628, 336);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.Location = new System.Drawing.Point(3, 291);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(0, 13);
            this.lblErreur.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.98714F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.01286F));
            this.tableLayoutPanel2.Controls.Add(this.lstbPseudos, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.grBoxIdentification, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 75);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(622, 213);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lstbPseudos
            // 
            this.lstbPseudos.FormattingEnabled = true;
            this.lstbPseudos.Location = new System.Drawing.Point(401, 3);
            this.lstbPseudos.Name = "lstbPseudos";
            this.lstbPseudos.Size = new System.Drawing.Size(218, 199);
            this.lstbPseudos.TabIndex = 1;
            this.lstbPseudos.DoubleClick += new System.EventHandler(this.lstbPseudos_DoubleClick);
            this.lstbPseudos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lstbPseudos_KeyPress);
            // 
            // grBoxIdentification
            // 
            this.grBoxIdentification.Controls.Add(this.txtPassword);
            this.grBoxIdentification.Controls.Add(this.txtPseudo);
            this.grBoxIdentification.Controls.Add(this.txtWebService);
            this.grBoxIdentification.Controls.Add(this.lblPassword);
            this.grBoxIdentification.Controls.Add(this.lblPseudo);
            this.grBoxIdentification.Controls.Add(this.lblWebService);
            this.grBoxIdentification.Controls.Add(this.pnlConnexion);
            this.grBoxIdentification.Location = new System.Drawing.Point(3, 3);
            this.grBoxIdentification.Name = "grBoxIdentification";
            this.grBoxIdentification.Size = new System.Drawing.Size(391, 207);
            this.grBoxIdentification.TabIndex = 2;
            this.grBoxIdentification.TabStop = false;
            this.grBoxIdentification.Text = "Identification :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(135, 100);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(211, 20);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtPseudo
            // 
            this.txtPseudo.Location = new System.Drawing.Point(135, 61);
            this.txtPseudo.Name = "txtPseudo";
            this.txtPseudo.Size = new System.Drawing.Size(211, 20);
            this.txtPseudo.TabIndex = 5;
            this.txtPseudo.TextChanged += new System.EventHandler(this.txtPseudo_TextChanged);
            // 
            // txtWebService
            // 
            this.txtWebService.Location = new System.Drawing.Point(135, 23);
            this.txtWebService.Name = "txtWebService";
            this.txtWebService.Size = new System.Drawing.Size(211, 20);
            this.txtWebService.TabIndex = 4;
            this.txtWebService.Text = "http://user11.2isa.org/";
            this.txtWebService.TextChanged += new System.EventHandler(this.txtWebService_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 103);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(62, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password : ";
            // 
            // lblPseudo
            // 
            this.lblPseudo.AutoSize = true;
            this.lblPseudo.Location = new System.Drawing.Point(6, 64);
            this.lblPseudo.Name = "lblPseudo";
            this.lblPseudo.Size = new System.Drawing.Size(52, 13);
            this.lblPseudo.TabIndex = 2;
            this.lblPseudo.Text = "Pseudo : ";
            // 
            // lblWebService
            // 
            this.lblWebService.AutoSize = true;
            this.lblWebService.Location = new System.Drawing.Point(6, 26);
            this.lblWebService.Name = "lblWebService";
            this.lblWebService.Size = new System.Drawing.Size(119, 13);
            this.lblWebService.TabIndex = 1;
            this.lblWebService.Text = "Adresse Web Service : ";
            // 
            // pnlConnexion
            // 
            this.pnlConnexion.Controls.Add(this.btDeconnecter);
            this.pnlConnexion.Controls.Add(this.btConnecter);
            this.pnlConnexion.Location = new System.Drawing.Point(0, 149);
            this.pnlConnexion.Name = "pnlConnexion";
            this.pnlConnexion.Size = new System.Drawing.Size(391, 52);
            this.pnlConnexion.TabIndex = 0;
            // 
            // btDeconnecter
            // 
            this.btDeconnecter.Location = new System.Drawing.Point(247, 7);
            this.btDeconnecter.Name = "btDeconnecter";
            this.btDeconnecter.Size = new System.Drawing.Size(111, 35);
            this.btDeconnecter.TabIndex = 1;
            this.btDeconnecter.Text = "Déconnecter";
            this.btDeconnecter.UseVisualStyleBackColor = true;
            this.btDeconnecter.Click += new System.EventHandler(this.btDeconnecter_Click);
            // 
            // btConnecter
            // 
            this.btConnecter.Location = new System.Drawing.Point(26, 7);
            this.btConnecter.Name = "btConnecter";
            this.btConnecter.Size = new System.Drawing.Size(111, 35);
            this.btConnecter.TabIndex = 0;
            this.btConnecter.Text = "Connecter";
            this.btConnecter.UseVisualStyleBackColor = true;
            this.btConnecter.Click += new System.EventHandler(this.btConnecter_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 336);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.grBoxIdentification.ResumeLayout(false);
            this.grBoxIdentification.PerformLayout();
            this.pnlConnexion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblErreur;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListBox lstbPseudos;
        private System.Windows.Forms.GroupBox grBoxIdentification;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPseudo;
        private System.Windows.Forms.TextBox txtWebService;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPseudo;
        private System.Windows.Forms.Label lblWebService;
        private System.Windows.Forms.Panel pnlConnexion;
        private System.Windows.Forms.Button btDeconnecter;
        private System.Windows.Forms.Button btConnecter;
    }
}

