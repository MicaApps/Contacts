using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Core.Models
{
    public class Name
    {
        public String firstName;
        public String lastName;
        public String middleName;

        public String FullName
        {
            get
            {
                StringBuilder sb
                    = new StringBuilder(firstName);
                sb.Append(" ");
                if (middleName != null) { 
                    sb.Append(middleName); 
                    sb.Append(" ");
                }
                sb.Append(lastName);
                return sb.ToString();
            }
        }
    }
}
