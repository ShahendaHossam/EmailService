using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class SendEmailDto
    {
        public string Reciever { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
