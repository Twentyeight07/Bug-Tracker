using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.MailServices
{
    class SystemSupportMail : MasterMailService
    {
        public SystemSupportMail() {
            SenderMail = "suportbugtracker@gmail.com";
            Password = "pqavcyjfdwxhegfu";
            Host= "smtp.gmail.com";
            Port = 587;
            Ssl = true;
            InitializeSmptClient();
        }
    }
}
