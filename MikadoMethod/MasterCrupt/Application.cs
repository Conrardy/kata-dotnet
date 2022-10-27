using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterCrupt
{
    public class Application : IApplication
    {
        public void Leet(string message, UI ui)
        {
            ui.SetLeeted(Leeter.Leet(message));
        }

        static void Main(string[] args)
        {
            UI ui = new UI(new Application());
        }
    }
}
