using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WpfApp1.Companents
{
    /// <summary>
    /// Логика взаимодействия для PhotoUserControl1.xaml
    /// </summary>
    public partial class PhotoUserControl1 : UserControl
    {
        Product product;
        public PhotoUserControl1(Product _product)
        {
            InitializeComponent();
            product = _product;
            this.DataContext = product;

        }

        private void MainBtn_Click(object sender, RoutedEventArgs e)
        {
            //var selPhoto = product.ProductPhoto;
            //servicePhoto.PhotoByte = servicePhoto.Service.MainImage;
            //servicePhoto.Service.MainImage = selPhoto;
            //App.servicePage.RefreshPhoto();
            //App.db.SaveChanges();

        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            //App.db.ServicePhoto.Remove(servicePhoto);
            //App.db.SaveChanges();
            //App.servicePage.RefreshPhoto();
        }
    }
    
}
