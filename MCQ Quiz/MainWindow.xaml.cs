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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MCQ_Quiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainPage MainPageObj = new MainPage();
        public static AddQuestionPage AddQuestionPageObj = new AddQuestionPage();
        public static EditQuestionPage EditQuestionPageObj = new EditQuestionPage();

        public MainWindow()
        {
            InitializeComponent();
            Main.Content = MainPageObj;
        }

        public void DisplayAddQuestionPage()
        {
            Main.Content = AddQuestionPageObj;
            
            //Main.Navigate(new System.Uri("AddQuestionPage.xaml", UriKind.RelativeOrAbsolute));
        }

        //public void btnAddQ_Click(object sender, RoutedEventArgs e)
        //{
        //    //AddQuestions aq = new AddQuestions();
        //    //aq.ShowDialog();
        //    //Main.Content = new AddQuestionPage();            
        //    Main.Navigate(new System.Uri("AddQuestionPage.xaml", UriKind.RelativeOrAbsolute));
        //}
    }
}
