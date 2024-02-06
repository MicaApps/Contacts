using CommunityToolkit.Mvvm.ComponentModel;
using Contacts.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Uwp.ViewModels
{
    public class ContactViewModel : ObservableObject
    {
        private ContactTypeModel m_TypeModel;

        public Name Name { get => m_TypeModel.name; }
        public String FullName { get => m_TypeModel.name.FullName; }
        public String DisplayName { get => m_TypeModel.displayName; }
        public Business Business {  get => m_TypeModel.business; }
        public DateTime Birthday { get => m_TypeModel.birthday; }
        public List<EmailAddress> Emails { get => m_TypeModel.emails; } 
        public List<Phone> Phones { get => m_TypeModel.phones; }

        public ContactViewModel() { }
    }
}
