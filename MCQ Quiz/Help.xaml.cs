using System;
using System.Collections.Generic;
using System.Drawing;
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

namespace MCQ_Quiz
{
    /// <summary>
    /// Interaction logic for Help.xaml
    /// </summary>
    public partial class Help : Window
    {
        public Help()
        {
            InitializeComponent();
            //try
            //{
            //    //BitmapImage bi = new BitmapImage(new Uri("MCQHelp.PNG"));
            //    var bi = new Bitmap(Properties.Resources.MCQHelp);
            //    //System.Drawing.Image myImage = Properties.Resources.MCQHelp;
            //    ImgHelp.Source = new BitmapImage(new Uri("MCQHelp", UriKind.Relative));
            //    ImgHelp.IsEnabled = true;
            //}
            //catch(Exception er)
            //{
            //    MessageBox.Show("Error: "+er);
            //}
            
        }

        private void btnDone_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
