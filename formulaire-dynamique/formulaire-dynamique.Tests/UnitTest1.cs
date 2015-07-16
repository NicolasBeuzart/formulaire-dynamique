using System;
using NUnit.Framework;
using formulaire_dynamique.Models;

namespace formulaire_dynamique.Tests
{
    [TestFixture]
    public class FormTests
    {
        [Test]
        public void CreateAnswers()
        {
            Form f = new Form();
            Assert.IsNull(f.Title);
            f.Title = "jj";
            Assert.AreEqual(f.Title, "jj");

            FormAnswer a = f.FindOrCreateAnswer("Emilie");
            Assert.IsNotNull(a);
            FormAnswer b = f.FindOrCreateAnswer("Emilie");
            Assert.AreSame(a, b);
            Assert.AreEqual(1, f.AnswerCount);
            FormAnswer c = f.FindOrCreateAnswer("John Do");
            Assert.AreNotSame(a, c);

            Assert.AreEqual("Emilie", a.UniqueName);
            Assert.AreEqual("John Do", c.UniqueName);
        }

        [Test]
        public void CreateQuestionFolders()
        {
            Form f = new Form();
            f.Questions.Title = "HG67-Bis";
            Assert.AreEqual("HG67-Bis", f.Questions.Title);
            QuestionBase q1 = f.Questions.AddNewQuestion("formulaire_dynamique.Models.CompositeQuestion, formulaire_dynamique.Models", true);
            QuestionBase q2 = f.Questions.AddNewQuestion(typeof(CompositeQuestion), true);
            Assert.AreEqual(0, q1.Index);
            Assert.AreEqual(1, q2.Index);
            q2.Index = 0;
            Assert.AreEqual(0, q2.Index);
            Assert.AreEqual(1, q1.Index);
            q2.Parent = null;
            Assert.AreEqual(0, q1.Index);
            q2.Parent = q1;
            Assert.IsTrue(f.Questions.Contains(q1));
            Assert.IsTrue(f.Questions.Contains(q2));
        }
    }
}
