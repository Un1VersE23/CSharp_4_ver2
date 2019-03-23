
using System.Collections.ObjectModel;
using HappyBirthday.Model;

namespace HappyBirthday.Tools
{
    interface IUserListOwner
    {
        ObservableCollection<Person> Users { set; get; }
    }
}
