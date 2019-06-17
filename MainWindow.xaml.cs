/* Ethan Shipston
 * ICS4U
 * June 17, 2019
 * A program which finds the smallest positive number divisible by every number from 1-20.
 */
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

namespace _184988SmallestMultiple
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            bool gottem = false;
            int i = 1;
            while (gottem == false)
            {
                for (int ii = 1; ii <= 20; ii++)
                {
                    if (i % ii != 0)
                    {
                        ii = 21;
                    }
                    else if (ii == 20 && i % ii == 0)
                    {
                        gottem = true;
                    }
                }
                if (gottem == false)
                    i++;
            }
            MessageBox.Show(i.ToString());
            Console.WriteLine(i);
        }
    }
}
