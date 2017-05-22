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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MCQ_Quiz
{
    /// <summary>
    /// Interaction logic for AddQuestionPage.xaml
    /// </summary>
    public partial class AddQuestionPage : Page
    {
        QuestionFormat temp = new QuestionFormat();
        StreamReader sr;
        //string question, c1, c2, c3, c4, ans;
        OpenFileDialog ofd = new OpenFileDialog();


        public AddQuestionPage()
        {
            InitializeComponent();
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.Title = "Open Text File";
            ofd.Filter = "Text files (*.txt)|*.txt";
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            temp.questionSet(tboxQ.Text);
            temp.optionASet(tboxA.Text);
            temp.optionBSet(tboxB.Text);
            temp.optionCSet(tboxC.Text);
            temp.optionDSet(tboxD.Text);
            temp.solutionSet(tboxS.Text);
            MainPage.qlist.Add(temp);
            temp = new QuestionFormat();
            this.ClearAll();
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

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            this.ClearAll();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(MainWindow.EditQuestionPageObj);
        }

        private void btnFile_Click(object sender, RoutedEventArgs e)
        {
            ofd.ShowDialog();
            try
            {
                sr = new StreamReader(ofd.FileName);
                AddQFromText();
            }
            catch (Exception er)
            {
                System.Windows.MessageBox.Show("Error: " + er.Message);
            }
        }

        private void btnDone_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(MainWindow.MainPageObj);
        }


        void AddQFromText()
        {
            //int rand = r.Next(0, possiblequestions.Count);
            string line;
            while (((line = sr.ReadLine()) != null))
            {
                if (line.Contains("Question"))
                {
                    temp = new QuestionFormat();
                    temp.questionSet(sr.ReadLine());
                    temp.optionASet(sr.ReadLine());
                    temp.optionBSet(sr.ReadLine());
                    temp.optionCSet(sr.ReadLine());
                    temp.optionDSet(sr.ReadLine());
                    temp.solutionSet(sr.ReadLine());
                    MainPage.qlist.Add(temp);
                    //possiblequestions.RemoveAt(rand);
                    //break;
                }
            }
            sr.DiscardBufferedData();
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            sr.BaseStream.Position = 0;
        }

        private void btnHelp_Click(object sender, RoutedEventArgs e)
        {
            Help h = new Help();
            h.ShowDialog();
        }

        private void btnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (*.txt)|*.txt";            
            sfd.CheckPathExists = true;
            sfd.Title = "Save Text File";
            sfd.ShowDialog();
            try
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                for (int x=0;x<MainPage.qlist.Count;x++)
                {
                    sw.WriteLine("Question:");
                    sw.WriteLine(MainPage.qlist[x].questionGet());
                    sw.WriteLine(MainPage.qlist[x].optionAGet());
                    sw.WriteLine(MainPage.qlist[x].optionBGet());
                    sw.WriteLine(MainPage.qlist[x].optionCGet());
                    sw.WriteLine(MainPage.qlist[x].optionDGet());
                    sw.WriteLine(MainPage.qlist[x].solutionGet());
                    sw.WriteLine("---------------");
                }
                sw.Close();
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }
    }
}
