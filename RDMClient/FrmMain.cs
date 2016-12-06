using System;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RDMDALWSR;
using System.Threading;
using System.Collections;
using System.Collections.Generic;

namespace RDMClient
{
    public partial class FrmMain : Form
    {
        internal const string ADR_SERVICE_DEBUG = "http://localhost:5000/";

        private RdmDalWSR _rdmDal = new RdmDalWSR();
        public FrmMain()
        {
            InitializeComponent();
            _rdmDal.StringConnect = ADR_SERVICE_DEBUG;
        }


        #region "Evenements"
        private void txtWebService_TextChanged(object sender, EventArgs e)
        {
            _rdmDal.StringConnect = txtWebService.Text;
        }

        private void txtPseudo_TextChanged(object sender, EventArgs e)
        {
            _rdmDal.PseudoConnect = txtPseudo.Text;
            btConnecter.Enabled = (!String.IsNullOrWhiteSpace(txtPseudo.Text));
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
            btDeconnecter.Enabled = (!String.IsNullOrWhiteSpace(txtPassword.Text));
        }


        private async void btConnecter_Click(object sender, EventArgs e)
        {
            pnlConnexion.Enabled = false;
            RdmDalWSRResult ret1 = await _rdmDal.LoginAsync(CancellationToken.None);

            if (ret1.IsSuccess)
            {
                txtWebService.Enabled = false;
                txtPseudo.Enabled = true;
                txtPassword.Text = (string)ret1.Data;
                lblErreur.Text = "Vous êtes connecté";
            }
            else
            {
                lblErreur.Text = ret1.ErrorMessage;
            }
            RdmDalWSRResult ret2 = await _rdmDal.GetPseudosAsync(CancellationToken.None);

            if (ret2.IsSuccess && _rdmDal.IsLogged)
            {
                AfficheListPseudos(ret2);
            }
            else
            {
                lblErreur.Text = ret2.ErrorMessage;
            }


            pnlConnexion.Enabled = true;
        }

        private async void btDeconnecter_Click(object sender, EventArgs e)
        {
            pnlConnexion.Enabled = false;
            RdmDalWSRResult ret1 = await _rdmDal.LogoutAsync(CancellationToken.None);

            if (ret1.IsSuccess)
            {
                lblErreur.Text = "Vous n'êtes pas connecté";
            }
            else
            {
                lblErreur.Text = "Vous n'êtes pas connecté" + ret1.ErrorMessage;
            }
            pnlConnexion.Enabled = true;
            lstbPseudos.Items.Clear();
            txtWebService.Enabled = true;
            txtPseudo.Enabled = true;
            txtPassword.Text = String.Empty;
        }

        private void lstbPseudos_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void lstbPseudos_DoubleClick(object sender, EventArgs e)
        {

        }
        #endregion

        #region "Méthode perso"

        private void AfficheListPseudos(RdmDalWSRResult ret)
        {
            List<String> lstret = (List<string>)ret.Data;

            // Ajout d'un pseudo à la liste
            foreach(string pseudo in lstret)
            {
                if (!lstbPseudos.Items.Contains(pseudo))
                {
                    lstbPseudos.Items.Add(pseudo);
                }
            }

            // suppression pseudo de la liste 
            for(int i = lstbPseudos.Items.Count -1 ; i >= 0; i--)
            {
                if (!lstret.Contains(lstbPseudos.Items[i]))
                {
                    lstbPseudos.Items.RemoveAt(i);
                }
            }
            
        }
        #endregion


    }
}
