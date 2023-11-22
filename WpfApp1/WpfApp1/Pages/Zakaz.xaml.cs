using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using WpfApp1.Companents;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для Zakaz.xaml
    /// </summary>
    public partial class Zakaz : Page
    {
        private Product service;
        public Zakaz(Product _service)
        {
            InitializeComponent();
            App.servicePage = this;
            service = _service;
            this.DataContext = service;
            RefreshPhoto();

        }


        private void CostTb_TextInput(object sender, TextCompositionEventArgs e)
        {
            if (!(char.IsDigit(e.Text[0])))
            {
                e.Handled = true;
            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter = "*.png|*.png|*.jpg|*.jpg|*.jpeg|*.jpeg"
            };
            if (openFile.ShowDialog().GetValueOrDefault())
            {
                service.MainImage = File.ReadAllBytes(openFile.FileName);
                Image.Source = new BitmapImage(new Uri(openFile.FileName));
            }
        }
        public void RefreshPhoto()
        {
            PhotoWp.Children.Clear();
            foreach (var productPhoto in service.ProductPhoto)
            {
                PhotoWp.Children.Add(new PhotoUserControl1(productPhoto));
            }
            BitmapImage bitmapImage = new BitmapImage();
            MemoryStream byteStream = new MemoryStream(service.MainImage);
            bitmapImage.BeginInit();
            bitmapImage.StreamSource = byteStream;
            bitmapImage.EndInit();
            Image.Source = bitmapImage;
        }

        private void CostTb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void OpisTb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CostTb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void NameTb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void IdTb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AddImageBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaleTb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TimeTb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
