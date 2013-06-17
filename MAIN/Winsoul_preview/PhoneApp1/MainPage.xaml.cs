using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp1.Resources;

namespace PhoneApp1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructeur
        public MainPage()
        {
            InitializeComponent();
            // Exemple de code pour la localisation d'ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void Go_Click(object sender, RoutedEventArgs e)
        {
            Button bouton = (Button)sender;
            bouton.Content = "OK !";
            aff_log.Text = Login.Text;
            aff_mdp.Text = Mdp.Password;
        }

        private void Intra_Click_1(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Content = "Let's go !";
            NavigationService.Navigate(new Uri("Page1.xaml", UriKind.Relative));
        }

            // Exemple de code pour la conception d'une ApplicationBar localisée
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Définit l'ApplicationBar de la page sur une nouvelle instance d'ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Crée un bouton et définit la valeur du texte sur la chaîne localisée issue d'AppResources.
         //  ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
           // appBarButton.Text = AppResources.AppBarButtonText;
           // ApplicationBar.Buttons.Add(appBarButton)
        //    // Crée un nouvel élément de menu avec la chaîne localisée d'AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    
    }
}