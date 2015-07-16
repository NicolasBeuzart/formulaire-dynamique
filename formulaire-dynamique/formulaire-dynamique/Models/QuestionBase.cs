using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace formulaire_dynamique.Models
{
    public class QuestionBase
    {
        private QuestionBase _parent;

        public QuestionBase Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }
        public int Index
        {
            get { return 0; }
            set { }
        }
    }
}