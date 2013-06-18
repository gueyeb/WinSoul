using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Net.Sockets;
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
		}
    }
}