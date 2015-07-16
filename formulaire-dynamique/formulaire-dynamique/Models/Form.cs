using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace formulaire_dynamique.Models
{
    public class Form
    {
        private String _title;
        private List<FormAnswer> _answers;

        public String Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public FormAnswer FindOrCreateAnswer(String uniqueName)
        {
            foreach (var answer in _answers)
            {
                if (answer.UniqueName == uniqueName)
                    return answer
            }
        }

    }
}