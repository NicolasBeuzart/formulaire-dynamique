using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace formulaire_dynamique.Models
{
    public class OpenQuestion : QuestionBase
    {
        private bool _allowEmptyAnswer = true;

        public OpenQuestion(QuestionBase parent, List<QuestionBase> questions)
        {
            _parent = parent;
            _questions = questions;
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