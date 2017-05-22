using System;
using System.Collections.Generic;
using System.Threading;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MCQ_Quiz
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page 
    {
        public string question, c1, c2, c3, c4, ans, check;
        int h, m , s = 0;
        string hh, mm, ss;
        //List<int> possiblequestions = new List<int> { };
        public static List<QuestionFormat> qlist = new List<QuestionFormat>();
        public static MainWindow mainWindowsObj = new MainWindow();
        System.Timers.Timer CountdownTimer;

        //Random r = new Random(DateTime.Now.Millisecond);
        int Qnum = 0,Score=0;

        //public static List<QuestionFormat> Qlist { get => qlist; set => qlist = value; }
        public static MainWindow MainWindowsObj = new MainWindow();

        public MainPage()
        {
            InitializeComponent();

            Question.Text = "Press Start to begin the quiz.";
            CountdownTimer = new System.Timers.Timer() { Interval = 1000};
            CountdownTimer.Elapsed += new ElapsedEventHandler(Ticker);            
        }

        void Ticker(object sender,EventArgs e)
        {
            --s;
            if ((h==0) && (m==0) && (s==0))
            {
                Application.Current.Dispatcher.Invoke(() => QuizOver());
                return;
            }
            if (s<0)
            {
                --m;
                s = 60;
            }
            if(m<0)
            {
                --h;
                m = 60;
            }
            Application.Current.Dispatcher.Invoke(() =>textStatus.Text = "Score: "+Score+" Timer: "+h+ ":" + m + ":" + s) ;
        }

        void DisplayQ()
        {
            if (Qnum < qlist.Count)
            {
                Question.Text = qlist[Qnum].questionGet();
                Choice1.Text = qlist[Qnum].optionAGet();
                Choice2.Text = qlist[Qnum].optionBGet();
                Choice3.Text = qlist[Qnum].optionCGet();
                Choice4.Text = qlist[Qnum].optionDGet();
            }
        }


        void CheckAns()
        {
            if (R1.IsChecked == true)
            {
                check = (qlist[Qnum].optionAGet().Equals(qlist[Qnum].solutionGet())) ? "Correct" : "Wrong, the correct answer is " + qlist[Qnum].solutionGet();
                Answer.Text = check;
                Score =check.Equals("Correct") ? Score+1:Score;
                R1.IsChecked = false;
            }
            else if (R2.IsChecked == true)
            {
                check = (qlist[Qnum].optionBGet().Equals(qlist[Qnum].solutionGet())) ? "Correct" : "Wrong, the correct answer is " + qlist[Qnum].solutionGet();
                Answer.Text = check;
                Score = check.Equals("Correct") ? Score + 1 : Score;
                R2.IsChecked = false;
            }
            else if (R3.IsChecked == true)
            {
                check = (qlist[Qnum].optionCGet().Equals(qlist[Qnum].solutionGet())) ? "Correct" : "Wrong, the correct answer is " + qlist[Qnum].solutionGet();
                Answer.Text = check;
                Score = check.Equals("Correct") ? Score + 1 : Score;
                R3.IsChecked = false;
            }
            else if (R4.IsChecked == true)
            {
                check = (qlist[Qnum].optionDGet().Equals(qlist[Qnum].solutionGet())) ? "Correct" : "Wrong, the correct answer is " + qlist[Qnum].solutionGet();
                Answer.Text = check;
                Score = check.Equals("Correct") ? Score + 1 : Score;
                R4.IsChecked = false;
            }
        }

        


        void ClearAllTb()
        {
            Question.Text = null;
            Choice1.Text = null;
            Choice2.Text = null;
            Choice3.Text = null;
            Choice4.Text = null;
            Answer.Text = null;
        }

        void QuizOver()
        {
            R1.IsEnabled = false;
            R2.IsEnabled = false;
            R3.IsEnabled = false;
            R4.IsEnabled = false;
            CountdownTimer.Stop();
            btnSubmit.IsEnabled = false;
            btnStart.IsEnabled = false;
            btnNext.IsEnabled = false;
            Question.Text = "The Quiz is Complete, your score is "+Score+"/"+qlist.Count;
        }

        private void R1_Checked(object sender, RoutedEventArgs e)
        {
            R2.IsChecked = false;
            R3.IsChecked = false;
            R4.IsChecked = false;
            btnSubmit.IsEnabled = true;
        }

        

        private void R2_Checked(object sender, RoutedEventArgs e)
        {
            R1.IsChecked = false;
            R3.IsChecked = false;
            R4.IsChecked = false;
            btnSubmit.IsEnabled = true;
        }
        

        private void R3_Checked(object sender, RoutedEventArgs e)
        {
            R2.IsChecked = false;
            R1.IsChecked = false;
            R4.IsChecked = false;
            btnSubmit.IsEnabled = true;
        }
        

        private void R4_Checked(object sender, RoutedEventArgs e)
        {
            R2.IsChecked = false;
            R3.IsChecked = false;
            R1.IsChecked = false;
            btnSubmit.IsEnabled = true;
        }

        void getQuizTime()
        {
            int temp;
            temp = qlist.Count * 1;
            if (temp>60)
            {
                h = temp / 60;
                m = temp % 60;
            }
            else
            {
                h = 0;
                m = temp;
            }
        }

        //Button Configs
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            getQuizTime();
            CountdownTimer.Start();
            DisplayQ();
            btnStart.IsEnabled = false;
            btnAddQ.IsEnabled = false;
        }


        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            CheckAns();
            if (Qnum == qlist.Count - 1)
                QuizOver();
            else
            {
                btnNext.IsEnabled = true;
                btnSubmit.IsEnabled = false;
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            ClearAllTb();
            Qnum++;
            DisplayQ();
            btnNext.IsEnabled = false;
        }

        private void btnAddQ_Click(object sender, RoutedEventArgs e)
        {      
            NavigationService.Navigate(MainWindow.AddQuestionPageObj);
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
