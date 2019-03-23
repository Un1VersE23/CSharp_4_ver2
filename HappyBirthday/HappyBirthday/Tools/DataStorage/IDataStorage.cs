
using System.Collections.Generic;
using HappyBirthday.Model;

namespace HappyBirthday.Tools.DataStorage
{
    internal  interface IDataStorage
    {
        void AddPerson(Person person);

        void DeletePerson(Person person);

        List<Person> PersonsList { get; }

       

    }
}
