using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace formulaire_dynamique.Models
{
    public class QuestionBase
    {
        protected QuestionBase _parent;
        protected string _title;
        protected Dictionary<int, QuestionBase> _questions;
        protected int _index;

        public QuestionBase()
        {
            _parent = null;
            _questions = new Dictionary<int, QuestionBase>();
        }

        public QuestionBase(QuestionBase parent, Dictionary<int, QuestionBase> questions)
        {
            _parent = parent;
            _questions = questions;
            _index = questions.Count;
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

        public QuestionBase AddNewQuestion(string type, bool p)
        {
            QuestionBase question;
            switch (type)
            {
                case "formulaire_dynamique.Models.OpenQuestion":
                    question = new OpenQuestion(_questions.Count > 0 ? _questions[_questions.Count - 1] : this, _questions);
                    break;
                default:
                    question = new QuestionBase(_questions.Count > 0 ? _questions[_questions.Count - 1] : this, _questions);
                    break;
            }
            _questions.Add(_questions.Count, question);
            return question;
            throw new NotImplementedException();
        }

        virtual public AnswerBase CreateAnswer()
        {
            return new AnswerBase();
        }

        public QuestionBase AddNewQuestion(Type type, bool p)
        {
            Console.WriteLine(type.ToString());
            return AddNewQuestion(type.ToString(), p);
            
            throw new NotImplementedException();
        }

        public bool Contains(QuestionBase q1)
        {
            return _questions.ContainsValue(q1);
        }

        public int Index
        {
            get { return _index; }
            set
            {
                Console.WriteLine("Index : {0}, value: {1}", _index, value);
                int min, max;
                QuestionBase questionToMove = _questions[_index];
                _questions.Remove(_index);
                if (value > _index)
                {
                    min = _index;
                    max = Math.Min(value, _questions.Count);
                    for (int i = max; i > min; --i)
                    {
                        _questions[i].Index = i - 1;
                    }
                }
                else
                {
                    min = value;
                    max = Math.Min(_index, _questions.Count);
                    for (int i = max - 1; i >= min; --i)
                    {
                        _questions[i].Index = i + 1;
                    }
                }
                _questions[value] = questionToMove;
                _index = value;
            
            }
        }
    }
}