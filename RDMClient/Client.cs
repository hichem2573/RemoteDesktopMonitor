using RDMDALWSR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDMClient
{
    public partial class Client : Form
    {
        internal const string ADR_SERVICE_DEBUG = "http://localhost:60078/";

        private RdmDalWSR _rdmDal = new RdmDalWSR();

        public Client()
        {
            InitializeComponent();

            //_rdmDal.StringConnect = txtbWebService.Text;
            // On fixe l'adresse de base du service Web en mode Debug (exécution du service en local)
            _rdmDal.StringConnect = ADR_SERVICE_DEBUG;
        }
        private  void txtbPseudo_TextChanged(object sender, EventArgs e)
        {
            _rdmDal.PseudoConnect = txtbPseudo.Text;
            btLogin.Enabled = (!String.IsNullOrWhiteSpace(txtbPseudo.Text));

        }

        private async void btLogin_Click(object sender, EventArgs e)
        {
            panelConnexion.Enabled = false;
            RdmDalWSRResult ret = await _rdmDal.LoginAsync(CancellationToken.None);

            if (ret.IsSuccess)
            {
                txtbWebService.Enabled = false;
                txtbPseudo.Enabled = false;
                txtbPassword.Text = (string)ret.Data;
                lblErreur.Text = "Vous êtes connécté";
            }
            else
            {
                lblErreur.Text = ret.ErrorMessage;
            }

            panelConnexion.Enabled = true;
        }

        private async void btLogout_Click(object sender, EventArgs e)
        {
            panelConnexion.Enabled = false;
            RdmDalWSRResult ret = await _rdmDal.LogoutAsync(CancellationToken.None);

            if (ret.IsSuccess)
            {
                lblErreur.Text = "Vous n'etes pas connécté";
            }
            else
            {
                lblErreur.Text = "Vous n'etes pas connécté" + ret.ErrorMessage;
            }
            panelConnexion.Enabled = true;

            lstBPseudos.Items.Clear();
            txtbWebService.Enabled = true;
            txtbPseudo.Enabled = true;
            txtbPassword.Text = String.Empty;
        }

        private void txtbWebService_TextChanged(object sender, EventArgs e)
        {
            _rdmDal.StringConnect = txtbWebService.Text;
        }

        private void txtbPassword_TextChanged(object sender, EventArgs e)
        {
            btLogout.Enabled = (!String.IsNullOrWhiteSpace(txtbPassword.Text));

        }
    }
}







































//private async void Client_FormClosing(object sender, FormClosingEventArgs e)
//{
//    if (!String.IsNullOrWhiteSpace(txtbPassword.Text))
//    {
//        if (!_rdmDal.IsLogged)
//        {
//            e.Cancel = true;

//            await _rdmDal.LogoutAsync(CancellationToken.None);

//            this.Close();
//        }
//    }
//}






