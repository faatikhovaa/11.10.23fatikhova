using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var path = @"C:\Users\222126\Pictures\";
            foreach (var item in App.db.Product.ToArray())
            {
                var fullPath = path + item.Image.Trim();
                var imageByte = File.ReadAllBytes(fullPath);
                item.MainImage = imageByte;


                App.db.SaveChanges();
                Companents.PartyClass.Navigation.mainWindow = this;
                Companents.PartyClass.Navigation.NextPage(new Companents.PartyClass.Navigation.PageComponent(new Pages.Page1(), "Список услуг"));
                frams.Navigate(new Pages.Catalog());

            }
        }

        private void OffAdminBtn_Click_1(object sender, RoutedEventArgs e)
        {
            App.isAdmin = false;
            Companents.PartyClass.Navigation.ClearHistory();
            Companents.PartyClass.Navigation.NextPage(new Companents.PartyClass.Navigation.PageComponent(new Pages.Page1(), "Список услуг"));
        
        }

        private void OnAdminBtn_Click_1(object sender, RoutedEventArgs e)
        {
            if (PasswordPb.Password == "0000")
            {
                App.isAdmin = true;
                PasswordPb.Clear();
                Companents.PartyClass.Navigation.ClearHistory();
                Companents.PartyClass.Navigation.NextPage(new Companents.PartyClass.Navigation.PageComponent(new Pages.Page1(), "Услуги админа"));
            
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Companents.PartyClass.Navigation.BackPage();
        }
    }
}
