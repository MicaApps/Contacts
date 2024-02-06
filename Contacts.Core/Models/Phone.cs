using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Core.Models
{
    public enum PhoneType
    {
        Business,
        Home,
        Mobile
    }

    public class Phone
    {
        public String Number;
        public PhoneType Type;
    }
}
