using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace formulaire_dynamique.Models
{
    public class QuestionBase
    {
        protected QuestionBase _parent;
        protected string _title;
        private Form _form;

        public Form Form
        {
            get { return _form; }
            set { _form = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public QuestionBase Parent
        {
            get { return _parent; }
            set
            {
                if (value == null)
                {
                    _form.Questions.RemoveQuestion(this);
                }
                else
                {
                    Index = value.Index;
                }
                _parent = value;
            }
        }

        

        virtual public AnswerBase CreateAnswer()
        {
            return new AnswerBase();
        }

        public int Index
        {
            get { return _form.Questions.GetIndexOf(this); }
            set
            {
                _form.Questions.RemoveQuestion(this);
                _form.Questions.Insert(value, this);
            }
        }
    }
}