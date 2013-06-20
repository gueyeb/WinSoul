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
 
                ApplicationBar = new ApplicationBar();
 
                ApplicationBar.Mode = ApplicationBarMode.Default;
                ApplicationBar.Opacity = 1.0; 
                ApplicationBar.IsVisible = true;
                ApplicationBar.IsMenuEnabled = true;
 
                ApplicationBarIconButton button1 = new ApplicationBarIconButton();
                button1.IconUri = new Uri("/Assets/Tiles/check.png", UriKind.Relative);
                button1.Text = "sign in";
                ApplicationBar.Buttons.Add(button1);
                button1.Click += new EventHandler(button1_Click);

                ApplicationBarIconButton button2 = new ApplicationBarIconButton();
                button2.IconUri = new Uri("/Assets/Tiles/feature.search.png", UriKind.Relative);
                button2.Text = "intra";
                ApplicationBar.Buttons.Add(button2);
                button2.Click += new EventHandler(button2_Click);
           }
 
            private void button1_Click(object sender, EventArgs e)
             {
                aff_log.Text = Login.Text;
                aff_mdp.Text = Mdp.Password;   
             }
            private void button2_Click(object sender, EventArgs e)
             {
                NavigationService.Navigate(new Uri("/Page1.xaml", UriKind.Relative));
             }
    }
}