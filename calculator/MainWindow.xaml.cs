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

namespace calculator
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)//adds 
        {
            lblAddSub.Content = "+";

            string value1 = txtValue1.Text;
            string value2 = txtValue2.Text;

            double val1,val2 = 0;

            bool Val1IsANumber = double.TryParse(value1, out val1);
            bool Val2IsANumber = double.TryParse(value2, out val2);

           // double btnAdd = (val1 + val2);

            if (Val1IsANumber&& Val2IsANumber)
            {
                double btnAdd = (val1 + val2);
                txtValueResualt.Text = (val1 + val2).ToString();
            }
            else
            {
                MessageBox.Show("enter a valid number ");
            }


        }

        private void btnSub_Click(object sender, RoutedEventArgs e)// subtracts 
        {
            lblAddSub.Content = "-";

            string value1 = txtValue1.Text;
            string value2 = txtValue2.Text;

            double val1, val2 = 0;

            bool Val1IsANumber = double.TryParse(value1, out val1);
            bool Val2IsANumber = double.TryParse(value2, out val2);

            if (Val1IsANumber && Val2IsANumber)
            {
                double btnSub =  (val1 - val2);
                txtValueResualt.Text = (val1 - val2).ToString();
            }
            else
            {
                MessageBox.Show("enter a valid number ");
            }

        }

        private void btnMult_Click(object sender, RoutedEventArgs e)//mult 
        {
            lblMultDivi.Content = "*";

            string value3 = txtValue3.Text;
            string value4 = txtValue4.Text;

            double val3, val4 = 0;

            bool Val1IsANumber = double.TryParse(value3, out val3);
            bool Val2IsANumber = double.TryParse(value4, out val4);

            if (Val1IsANumber && Val2IsANumber)
            {
                double btnMult = (val3 * val4);
                txtValueResault2.Text = (val3 * val4).ToString();
            }
            else
            {
                MessageBox.Show("enter a valid number ");
            }

        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)// divides 
        {
            lblMultDivi.Content = "/";

            string value3 = txtValue3.Text;
            string value4 = txtValue4.Text;

            double val3, val4 = 0;

            bool Val1IsANumber = double.TryParse(value3, out val3);
            bool Val2IsANumber = double.TryParse(value4, out val4);

            if (Val1IsANumber && Val2IsANumber)
            {
                double btnDiv = (val3 / val4);
                txtValueResault2.Text = (val3 / val4).ToString();
            }
            else
            {
                MessageBox.Show("enter a valid number ");
            }

        }

        private void btnAverage_Click(object sender, RoutedEventArgs e)// finds the average by adding resualts from the add/sub and mult/div and dividing them by 2 
        {
         
            double result1, result2 = 0;

            bool result1IsANumber = double.TryParse(txtValueResualt.Text, out result1);
            bool result2IsANumber = double.TryParse(txtValueResault2.Text, out result2);

            if (result1IsANumber && result2IsANumber)
            {
                double average = (result1 + result2) / 2;
               txtAverage.Text = average.ToString();
            }
            else
            {
                MessageBox.Show("Enter valid numbers for both results to calculate average");
            }

            //string ValueResualt = txtValueResualt.Text;
            //string ValueResualt2 = txtValueResault2.Text;

            //double valR, valR2 = 0;
            //bool valRIsANumber = double.TryParse(ValueResualt, out valR);
            //bool valR2IsANumber = double.TryParse(ValueResualt2, out valR2);
            ////if (valRIsANumber&& valR2IsANumber)
            ////{
            // double btnAverage = (valR + valR2) / 2;

            //txtAverage.Text = (valR + valR2 /2) .ToString();

            ////}


        }
    }
}
