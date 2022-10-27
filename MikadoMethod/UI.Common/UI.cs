using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class UI {

        public UI(IApplication application)
        {
            _application = application;
        }
        private string leeted;

        private readonly IApplication _application;

        public string EncryptMessage(string unLeeted) 
        {
            _application.Leet(unLeeted, this);
            return "Leeted: " + leeted;
        }

        public void SetLeeted(string leeted) 
        {
            this.leeted = leeted;
        }
    }
}
