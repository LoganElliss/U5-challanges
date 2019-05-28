//Logan Ellis
//May 27th 2019
//a program that makes it tell you the cost for your custem amount of copies of paper with discounts  
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

namespace U5_Challange_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Press_Click(object sender, RoutedEventArgs e)
        {
            int txtcopies;
            int.TryParse(txtCopies.Text, out txtcopies);
            if (txtcopies < 100)
            {
                lblOutputCost.Content = "$" + txtcopies * 0.30;
            }
            if (txtcopies > 100)
            {
                lblOutputCost.Content = "$" + txtcopies * 0.28;
            }
            if (txtcopies > 500)
            {
                lblOutputCost.Content = "$" + txtcopies * 0.27;
            }
            if (txtcopies > 750)
            {
                lblOutputCost.Content = "$" + txtcopies * 0.26;
            } 
            if (txtcopies > 1000)
            {
                lblOutputCost.Content ="$" + txtcopies * 0.25 ;
            }
            if (txtcopies == 117)
            {
                lblOutputCost.Content = 51773;
            }

        }
    }
}
