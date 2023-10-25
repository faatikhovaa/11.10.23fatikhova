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
using WpfApp1.Resources;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для Catalog.xaml
    /// </summary>
    public partial class Catalog : Page
    {
        public Catalog()
        {
            InitializeComponent();
            var prod = App.db.Product.ToList();

            foreach(var prods in prod)
            {
                catalogTB.Children.Add(new UserControl1(prods));
            }
        }
        private static decimal Oct(int id)
        {
            try
            {
                int itod = 0;
                int count = 0;

                var otzuv = App.db.Feedback.ToList();
                foreach (var ocns in otzuv)
                {
                    if (ocns.ProductId==id)
                    {
                        itod = ocns.Evaluation;
                        count++;
                    }

                }
                return (itod / count);
            }
            catch
            {
                return 0;
            }
        }

    }
}
