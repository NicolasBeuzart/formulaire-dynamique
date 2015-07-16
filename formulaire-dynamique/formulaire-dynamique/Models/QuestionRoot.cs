using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace formulaire_dynamique.Models
{
    public class QuestionRoot : QuestionBase
    {
        public QuestionBase AddNewQuestion(string type, bool p)
        {
            return AddNewQuestion(Type.GetType(type), p);
            throw new NotImplementedException();
        }

        public QuestionBase AddNewQuestion(Type type, bool p)
        {
            Console.WriteLine("type : {0}", type);
            var toto = Activator.CreateInstance(type);
            return (QuestionBase)toto;

            throw new NotImplementedException();
        }
    }
}