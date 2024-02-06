using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Core.Models
{
    public class Business
    {
        /* Generic information, depends on the company */
        public String name;
        public String homepage;
        public Address address;

        /* Individual information, depends on contact as employee */
        public String department;
        public String office;
        public String profession;
        public String title;
        public String nameOfAssistant;
        public String nameOfManager;
    }

    public class BusinessOneWayPart
    {
    }
}
