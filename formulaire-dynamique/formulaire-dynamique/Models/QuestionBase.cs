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
        protected List<QuestionBase> _questions;

        public QuestionBase()
        {
            _parent = null;
            _questions = new List<QuestionBase>();
        }

        public QuestionBase(QuestionBase parent, List<QuestionBase> questions)
        {
            _parent = parent;
            _questions = questions;
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
                    Index = _questions.Count - 1;
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

        public bool Contains(QuestionBase q1)
        {
            return _questions.Contains(q1);
        }

        public int Index
        {
            get { return _questions.IndexOf(this); }
            set
            {
                _questions.Remove(this);
                _questions.Insert(value, this);
            }
        }
    }
}