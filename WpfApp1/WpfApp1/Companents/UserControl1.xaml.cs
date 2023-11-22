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
using WpfApp1.Companents.PartyClass;

namespace WpfApp1.Resources
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        private Product service;
        public UserControl1(Product _prod)
        {
            this.service = _prod;
            InitializeComponent();


            photo.Source = GetImageSourse(_prod.MainImage);
            NameTB.Text = _prod.Title;
            OtzuvTB.Text = $"*{_prod.AverageRating.ToString("F2")} {_prod.CountFeedBack.Item1} отзыв";
            CenaSkidkiTB.Text = $"{_prod.Cost.ToString("f2")}";
            CenaTB.Text = $"{_prod.TotalCost:f2}";
            CenaSkidkiTB.Visibility = _prod.CostVisibilitr;
            OtzuvTB.Visibility = _prod.CountFeedBack.Item2;



        }
        private BitmapImage GetImageSourse(byte[] byteImage)
        {
            try
            {
                MemoryStream byteStream = new MemoryStream(byteImage);
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = byteStream;
                bitmapImage.EndInit();
                return bitmapImage;
            }
            catch
            {
                return new BitmapImage(new Uri("C:\\Users\\222126\\source\\repos\\11.10.23fatikhova\\WpfApp1\\WpfApp1\\Resources\\LOGO_ICO.png"));
            }
            }

        private void CreateBtn_Click(object sender, RoutedEventArgs e)
        {
            Navigation.NextPage(new Navigation.PageComponent(new Pages.Zakaz(service), "Редактировать"));
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (service != null)
            {
                MessageBox.Show("Удаление запрещенно");
            }
            else
            {
                App.db.Product.Remove(service);
                App.db.SaveChanges();

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach(ProductZakazUc productZakazUc in App.KorzinaWp.Children)
            {
                if(productZakazUc.product == product)
                {
                    productZakazUc.KolvoTb.Text = (productZakazUc.kolvo = 1.).ToString();
                    return;
                }
            }
            App.
        }
    }
}
