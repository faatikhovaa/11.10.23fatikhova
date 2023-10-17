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

namespace WpfApp1.Resources
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1(Image _photo, string _name, decimal _otz, decimal _cena)
        {
            InitializeComponent();

            if (_otz == 0 || _otz == 1)
            {
                photo = _photo;
                NameTB.Text = _name;
                OtzuvTB.Visibility = Visibility.Hidden;
                CenaTB.Text = $"{_cena} {(_cena/ _otz):0}";

            }




        }
    }
}
