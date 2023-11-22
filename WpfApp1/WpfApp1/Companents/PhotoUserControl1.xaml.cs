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
        ProductPhoto productPhoto;
        public PhotoUserControl1(ProductPhoto _productPhoto)
        {
            InitializeComponent();
            productPhoto = _productPhoto;
            this.DataContext = productPhoto;

        }

        private void MainBtn_Click(object sender, RoutedEventArgs e)
        {
            var selPhoto = productPhoto.PhotoByte;
            productPhoto.PhotoByte = productPhoto.Product.MainImage;
            productPhoto.Product.MainImage = selPhoto;
            App.servicePage.RefreshPhoto();
            App.db.SaveChanges();

        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            App.db.ProductPhoto.Remove(productPhoto);
            App.db.SaveChanges();
            App.servicePage.RefreshPhoto();
        }
    }
    
}
