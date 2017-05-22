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

namespace MCQ_Quiz
{
    /// <summary>
    /// Interaction logic for EditQuestionPage.xaml
    /// </summary>
    public partial class EditQuestionPage : Page
    {
        QuestionFormat temp = new QuestionFormat();
        int Qnum = 0;

        public EditQuestionPage()
        {
            InitializeComponent();
            DisplayQ();            
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            ClearAll();
            if (++Qnum < MainPage.qlist.Count)
                DisplayQ();
            else
            {
                Qnum = 0;
                DisplayQ();
            }
            
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            ClearAll();
            if (--Qnum >= 0)
                DisplayQ();
            else
            {
                Qnum = MainPage.qlist.Count - 1;
                DisplayQ();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            MainPage.qlist.RemoveAt(Qnum);
            ClearAll();
            DisplayQ();
        }

        

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            MainPage.qlist[Qnum].questionSet(tboxQ.Text);
            MainPage.qlist[Qnum].optionASet(tboxA.Text);
            MainPage.qlist[Qnum].optionBSet(tboxB.Text);
            MainPage.qlist[Qnum].optionCSet(tboxC.Text);
            MainPage.qlist[Qnum].optionDSet(tboxD.Text);
            MainPage.qlist[Qnum].solutionSet(tboxS.Text);
            textStatus.Text = "Q: " + (Qnum + 1) + " Saved";
        }

        private void btnDone_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(MainWindow.AddQuestionPageObj);
        }

        private void ClearAll()
        {
            tboxQ.Clear();
            tboxA.Clear();
            tboxB.Clear();
            tboxC.Clear();
            tboxD.Clear();
            tboxS.Clear();
        }

        void DisplayQ()
        {
            if (Qnum < MainPage.qlist.Count)
            {
                tboxQ.Text = MainPage.qlist[Qnum].questionGet();
                tboxA.Text = MainPage.qlist[Qnum].optionAGet();
                tboxB.Text = MainPage.qlist[Qnum].optionBGet();
                tboxC.Text = MainPage.qlist[Qnum].optionCGet();
                tboxD.Text = MainPage.qlist[Qnum].optionDGet();
                tboxS.Text = MainPage.qlist[Qnum].solutionGet();
                textStatus.Text = "Q: " + (Qnum+1);
            }
        }

    }
}
