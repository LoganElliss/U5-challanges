//Logan Ellis
//May 27th 
//Making the lexicographic permutations of 0-9 challange
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

namespace U5_Challange_3
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

        private void Check_Click(object sender, RoutedEventArgs e)
        {

            System.IO.StreamReader streamReader =
                new System.IO.StreamReader("LexNumbers.txt");
            try
            {
                string output = "";
                while (!streamReader.EndOfStream)
                {
                    output += streamReader.ReadLine()
                        + Environment.NewLine;
                }
                output = output.Trim();
                lblOutput.Content = output;
            }
            catch (Exception ex) { }
            lblOutput.Content=(streamReader.ReadToEnd());
            int n = 0;

            do
            {
                lblOutput.Content += n.ToString() + Environment.NewLine;
                n++;
            } while (n < 10);
            for (int i = 0; i < 10; i++) ;
        }
    }
}
