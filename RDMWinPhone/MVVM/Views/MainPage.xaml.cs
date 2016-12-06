using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Phone.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour en savoir plus sur le modèle d’élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkID=390556

namespace RDMWinPhone
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private static MonitorViewModel _monitorViewmodel = new MonitorViewModel();
        public MainPage()
        {
            this.InitializeComponent();
        }



        /// <summary>
        /// Invoqué lorsque cette page est sur le point d'être affichée dans un frame.
        /// </summary>
        /// <param name="e">Données d'événement décrivant la manière dont l'utilisateur a accédé à cette page.
        /// Ce paramètre est généralement utilisé pour configurer la page.</param>
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            DataContext = _monitorViewmodel;

            HardwareButtons.BackPressed += HardwareButtons_BackPressed;

            if (_monitorViewmodel.IsLogged)
            {
                await _monitorViewmodel.GetListPseudos(CancellationToken.None);
            }

            if (ParamsApp.AdresseBase == ParamsApp.P_ADR_DEFAULT || ParamsApp.Pseudo == ParamsApp.P_PSEUDO_DEFAULT)
            {
                await "MSG_PARAM".ReadResMsg().MsgInformation();

                Frame.Navigate(typeof(ParamsPage));
            }
            
        }

        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            HardwareButtons.BackPressed -= HardwareButtons_BackPressed;
        }

        private void HardwareButtons_BackPressed(object sender, BackPressedEventArgs e)
        {
            e.Handled = true;
        }

        private void mnuParams_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ParamsPage));
        }

        private async void mnuSynchro_Click(object sender, RoutedEventArgs e)
        {
            await _monitorViewmodel.GetListPseudos(CancellationToken.None);
        }

        private async void mnuQuitter_Click(object sender, RoutedEventArgs e)
        {
            StringExtensions.MsgResult res = await "MSG_CLOSEAPP".ReadResMsg().MsgChoix("TITRE_CLOSEAPP".ReadResMsg(), StringExtensions.MsgButton.YesNo, StringExtensions.MsgDefaultButton.Button1);

            if(res == StringExtensions.MsgResult.Yes)
            {
                await _monitorViewmodel.LogoutAsync(CancellationToken.None);

                App.Current.Exit();
            }
        }
    }
}
