using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace formulaire_dynamique.Models
{
    public class QuestionRoot : QuestionBase
    {
        private List<QuestionBase> _questions;

        public QuestionRoot()
        {
            _questions = new List<QuestionBase>();
        }

        public QuestionRoot(Models.Form form)
        {
            this.Form = form;
            _questions = new List<QuestionBase>();
        }

        public QuestionBase AddNewQuestion(string type, bool p)
        {
            return AddNewQuestion(Type.GetType(type), p);
        }

        public QuestionBase AddNewQuestion(Type type, bool p)
        {
            var question = (QuestionBase)Activator.CreateInstance(type);
            question.Form = Form;
            _questions.Add(question);
            return question;
        }

        internal int GetIndexOf(QuestionBase question)
        {
            return this._questions.IndexOf(question);
        }

        internal void RemoveQuestion(QuestionBase question)
        {
            _questions.Remove(question);
        }

        internal void Insert(int index, QuestionBase item)
        {
            _questions.Insert(index, item);
        }

        public bool Contains(QuestionBase q1)
        {
            return _questions.Contains(q1);
        }
    }
}