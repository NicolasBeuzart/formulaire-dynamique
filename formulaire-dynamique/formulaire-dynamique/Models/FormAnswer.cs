using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace formulaire_dynamique.Models
{
    public class FormAnswer
    {
        private string _uniqueName;


        public FormAnswer (string uniqueName)
        {
            _uniqueName = uniqueName;
        }

        public string UniqueName
        {
            get { return _uniqueName; }
        }
    }
}
