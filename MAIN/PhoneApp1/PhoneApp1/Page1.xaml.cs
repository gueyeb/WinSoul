using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PhoneApp1
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        
        public void Go_Click(object sender, RoutedEventArgs e)
        {
            string site = "https://www.epitech.eu/intra";
            MiniBrowser.Navigate(new Uri(site, UriKind.Absolute));
        }
    }
}