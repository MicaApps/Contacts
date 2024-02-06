using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Core.Models
{
    public enum WebAccountType
    {
        Twitter,
        Instagram,
        Telegram,
        Facebook,
        LinkedIn,
        Pinterest,
        WhatsApp,
        Tumblr,
        Snapchat,
        WeChat,
        Skype,
        GitHub,
    }

    public class WebAccount
    {
        public WebAccountType type;
        public String typeName;
        public String content;
    }
}
