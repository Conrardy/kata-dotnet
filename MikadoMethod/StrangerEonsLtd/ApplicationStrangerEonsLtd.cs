using Common;
using System;

namespace StrangerEonsLtd
{
    public class ApplicationStrangerEonsLtd : IApplication
    {
        public void Leet(string message, UI ui)
        {
            ui.SetLeeted(message.Replace("S","5"));
        }
        static void Main(string[] args)
        {
            UI ui = new UI(new ApplicationStrangerEonsLtd());
            Console.WriteLine(ui.EncryptMessage(args[0]));
            Console.ReadLine();
        }
    }
}
