using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Core.Models
{
    public class ContactTypeModel
    {
        public Name name;
        public String middleName;
        public String displayName;
        public String nickName;
        public List<String> categories;
        public String folder;
        public String description;
        public String initials;
        public DateTime birthday;
        public Business business;
        public List<Phone> phones = new List<Phone>();
        public List<EmailAddress> emails = new List<EmailAddress>();
        public List<WebAccount> webAccounts = new List<WebAccount>();

        public DateTime created;
        public DateTime updated;
    }
}
