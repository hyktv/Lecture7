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

namespace Lecture7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //F7 code view
        //Shift + F7 to go back
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnHiGerald_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This works");
            string gerald = txtGerald.Text;

        }
    }
}
