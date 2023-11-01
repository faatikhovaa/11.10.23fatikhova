using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1.Companents
{
   public partial class Product
    {
        public  Visibility  CostVisibilitr
        {
            get
            {
                if (Discount == 0)
                    return Visibility.Collapsed;
                else
                    return Visibility.Visible;
            }
        }
        public string CostWithDiscount
        {
            get
            {
                if (Discount == 0)
                {
                    return Cost.ToString();
                }
                else
                {
                    return $"{Cost - Cost * ((decimal)Discount / 100)}";
                }
            }
        }
        public (int, Visibility) CountFeedBack
        {
            get
            {
                if (Feedback.Count == 0)
                {
                    return (0, Visibility.Collapsed);

                }
                else
                    return (Feedback.Count, Visibility.Visible);
            }
        }
        public double AverageRating
        {
            get
            {
                if (Feedback.Count == 0)
                    return 0;
                else
                    return Feedback.Average(x => x.Evaluation);
            }
        }
        public double TotalCost
        {
            get
            {
                if (Discount !=0)
                {
                    return((double)Cost -(double)Cost * (double)Discount/100);
                }
                else 
                {
                    return(double)Cost;
                }
            }
        }
    }
}
