using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensagem
{
    public class Message
    {
        private String textMessage;
        public String TextMessage
        {
            get
            {
                return this.textMessage;
            }
            set
            {
                this.textMessage = value.ToUpper();
            }
        }

        public void ShowMessage() 
        {
            Console.WriteLine(this.TextMessage);
        }
    }
}
