using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace formulaire_dynamique.Models
{
    public class QuestionsFolder
    {
        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public QuestionBase AddNewQuestion(string type, bool p2)
        {
            throw new NotImplementedException();
        }

        public QuestionBase AddNewQuestion(Type type, bool p)
        {
            throw new NotImplementedException();
        }

        public bool Contains(QuestionBase q1)
        {
            throw new NotImplementedException();
        }
    }
}