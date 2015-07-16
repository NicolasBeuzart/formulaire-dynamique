using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace formulaire_dynamique.Models
{
    public class FormAnswer
    {
        private string _uniqueName;
        private Dictionary<QuestionBase, AnswerBase> _answers;

        public FormAnswer (string uniqueName)
        {
            _uniqueName = uniqueName;
            _answers = new Dictionary<QuestionBase, AnswerBase>();
        }

        public string UniqueName
        {
            get { return _uniqueName; }
        }

        public AnswerBase FindAnswer(OpenQuestion qOpen)
        {
            return _answers.ContainsKey(qOpen) ? _answers[qOpen] : null;
            throw new NotImplementedException();
        }

        public AnswerBase AddAnswerFor(OpenQuestion qOpen)
        {
            _answers.Add(qOpen, qOpen.CreateAnswer());
            return _answers[qOpen];
            throw new NotImplementedException();
        }
    }
}
