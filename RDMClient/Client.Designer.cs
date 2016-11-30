namespace RDMClient
{
    partial class Client
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.txtbPseudo = new System.Windows.Forms.TextBox();
            this.txtbWebService = new System.Windows.Forms.TextBox();
            this.lblPseudo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWebService = new System.Windows.Forms.Label();
            this.panelConnexion = new System.Windows.Forms.Panel();
            this.btLogout = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.lstBPseudos = new System.Windows.Forms.ListBox();
            this.lblErreur = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelConnexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.lblErreur, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.77778F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.22222F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(689, 408);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 56);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.347F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.653F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lstBPseudos, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 65);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(683, 280);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtbPassword);
            this.panel2.Controls.Add(this.txtbPseudo);
            this.panel2.Controls.Add(this.txtbWebService);
            this.panel2.Controls.Add(this.lblPseudo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblWebService);
            this.panel2.Controls.Add(this.panelConnexion);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 274);
            this.panel2.TabIndex = 0;
            // 
            // txtbPassword
            // 
            this.txtbPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtbPassword.Location = new System.Drawing.Point(121, 148);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.Size = new System.Drawing.Size(231, 20);
            this.txtbPassword.TabIndex = 6;
            this.txtbPassword.TextChanged += new System.EventHandler(this.txtbPassword_TextChanged);
            // 
            // txtbPseudo
            // 
            this.txtbPseudo.Location = new System.Drawing.Point(124, 84);
            this.txtbPseudo.Name = "txtbPseudo";
            this.txtbPseudo.Size = new System.Drawing.Size(231, 20);
            this.txtbPseudo.TabIndex = 5;
            this.txtbPseudo.TextChanged += new System.EventHandler(this.txtbPseudo_TextChanged);
            // 
            // txtbWebService
            // 
            this.txtbWebService.Location = new System.Drawing.Point(121, 34);
            this.txtbWebService.Name = "txtbWebService";
            this.txtbWebService.Size = new System.Drawing.Size(231, 20);
            this.txtbWebService.TabIndex = 4;
            this.txtbWebService.Text = "http://user11.2isa.org";
            this.txtbWebService.TextChanged += new System.EventHandler(this.txtbWebService_TextChanged);
            // 
            // lblPseudo
            // 
            this.lblPseudo.AutoSize = true;
            this.lblPseudo.Location = new System.Drawing.Point(32, 87);
            this.lblPseudo.Name = "lblPseudo";
            this.lblPseudo.Size = new System.Drawing.Size(52, 13);
            this.lblPseudo.TabIndex = 3;
            this.lblPseudo.Text = "Pseudo : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mot de passe  : ";
            // 
            // lblWebService
            // 
            this.lblWebService.AutoSize = true;
            this.lblWebService.Location = new System.Drawing.Point(32, 37);
            this.lblWebService.Name = "lblWebService";
            this.lblWebService.Size = new System.Drawing.Size(75, 13);
            this.lblWebService.TabIndex = 1;
            this.lblWebService.Text = "WebService : ";
            // 
            // panelConnexion
            // 
            this.panelConnexion.Controls.Add(this.btLogout);
            this.panelConnexion.Controls.Add(this.btLogin);
            this.panelConnexion.Location = new System.Drawing.Point(0, 198);
            this.panelConnexion.Name = "panelConnexion";
            this.panelConnexion.Size = new System.Drawing.Size(413, 73);
            this.panelConnexion.TabIndex = 0;
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(253, 22);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(102, 33);
            this.btLogout.TabIndex = 1;
            this.btLogout.Text = "Déconnecter ";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(40, 22);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(102, 33);
            this.btLogin.TabIndex = 0;
            this.btLogin.Text = "Connecter";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // lstBPseudos
            // 
            this.lstBPseudos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBPseudos.Enabled = false;
            this.lstBPseudos.FormattingEnabled = true;
            this.lstBPseudos.Location = new System.Drawing.Point(422, 3);
            this.lstBPseudos.Name = "lstBPseudos";
            this.lstBPseudos.Size = new System.Drawing.Size(258, 274);
            this.lstBPseudos.TabIndex = 1;
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.Location = new System.Drawing.Point(3, 348);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(0, 13);
            this.lblErreur.TabIndex = 2;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 408);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "Client";
            this.Text = "Client";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelConnexion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.TextBox txtbPseudo;
        private System.Windows.Forms.TextBox txtbWebService;
        private System.Windows.Forms.Label lblPseudo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWebService;
        private System.Windows.Forms.Panel panelConnexion;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.ListBox lstBPseudos;
        private System.Windows.Forms.Label lblErreur;
    }
}

