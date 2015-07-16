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
    }
}
