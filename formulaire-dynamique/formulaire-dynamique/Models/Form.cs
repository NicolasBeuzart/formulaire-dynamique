using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace formulaire_dynamique.Models
{
    public class Form
    {
        private string _title;
        private List<FormAnswer> _answers;
        private QuestionBase _questions;

        public QuestionBase Questions
        {
            get { return _questions; }
        }

        public Form()
        {
            _answers = new List<FormAnswer>();
            _questions = new QuestionBase();
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public int AnswerCount { get { return _answers.Count; } }

        public FormAnswer FindOrCreateAnswer(string uniqueName)
        {
            foreach (FormAnswer answer in _answers)
            {
                if (answer.UniqueName == uniqueName)
                    return answer;
            }
            return CreateAnswer(uniqueName);
        }


        public FormAnswer CreateAnswer(string uniqueName)
        {
            FormAnswer response = new FormAnswer(uniqueName);

            _answers.Add(response);
            return response;
        }
    }
}