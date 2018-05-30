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

namespace U5Printing
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

        private void btnRun_Click_1(object sender, RoutedEventArgs e)
        {
            int numberOfCopies;
            double cost;
            string output = "";
            int.TryParse(txtInput.Text, out numberOfCopies);
            if (numberOfCopies >= 0 & numberOfCopies <= 99)
            {
                cost = numberOfCopies * 0.30;
            }
            else if (numberOfCopies >= 100 & numberOfCopies <= 499)
            {
                cost = numberOfCopies * 0.28;
            }
            else if (numberOfCopies >= 500 & numberOfCopies <= 749)
            {
                cost = numberOfCopies * 0.27;
            }
            else if (numberOfCopies >= 750 & numberOfCopies <= 1000)
            {
                cost = numberOfCopies * 0.26;
            }
            else if (numberOfCopies > 1000)
            {
                cost = numberOfCopies * 0.25;
            }
            else
            {
                cost = 0;
            }
            output = "$" + cost.ToString();
            lblOutput.Content = output;
        }
    }
    }

