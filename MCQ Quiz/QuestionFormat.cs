using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCQ_Quiz
{
    public class QuestionFormat
    {
        string question, optionA, optionB, optionC, optionD, solution;
        //Setters
        public void questionSet(string q){this.question = q;}
        public void optionASet(string a){this.optionA = a;}
        public void optionBSet(string b){this.optionB = b;}
        public void optionCSet(string c){this.optionC = c;}
        public void optionDSet(string d){this.optionD = d;}
        public void solutionSet(string s){this.solution = s;}

        //Getters
        public string questionGet() { return this.question; }
        public string optionAGet() { return this.optionA; }
        public string optionBGet() { return this.optionB; }
        public string optionCGet() { return this.optionC; }
        public string optionDGet() { return this.optionD; }
        public string solutionGet() { return this.solution; }


    }    
}
