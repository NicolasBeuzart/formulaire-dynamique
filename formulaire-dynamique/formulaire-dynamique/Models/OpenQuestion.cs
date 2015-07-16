using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace formulaire_dynamique.Models
{
    public class OpenQuestion : QuestionBase
    {
        private bool _allowEmptyAnswer = true;

        public OpenQuestion(QuestionBase parent, Dictionary<int, QuestionBase> questions)
        {
            _parent = parent;
            _questions = questions;
            _index = questions.Count;
        }

        override public AnswerBase CreateAnswer()
        {
            return new OpenAnswer();
        }

        public bool AllowEmptyAnswer
        {
            get { return _allowEmptyAnswer; }
            set { _allowEmptyAnswer = value; }
        }
    }
}