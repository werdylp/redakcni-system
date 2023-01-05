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
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace redakcni_system
{
    /// <summary>
    /// Interakční logika pro newArticle.xaml
    /// </summary>
    public partial class newArticle : Window
    {
        
        public newArticle()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


            
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }


    }
}
