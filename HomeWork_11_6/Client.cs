using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11_6
{
    class Client
    {

        public string FirstName;
        public string LastName;
        public string MiddleName;
        public decimal TelephonNumber;
        public string Pasport;

        private DateTime DateOfChange;
        private string TextChange;
        private TypeOfChangesEnum TypeOfChanges;
        private Type UserChange;

        /// <summary>
        /// версифицирование объекта по последнему изменению
        /// </summary>
        /// <returns></returns>
        public string GetChange()
        {
            return $"{DateOfChange} _ {TextChange}. " +
                $"Тип изменений - {TypeOfChanges}. " +
                $"Пользователь  - {UserChange}";
        }

        /// <summary>
        /// спрячем пустой конструктор
        /// </summary>
        private Client()
        {
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {MiddleName} {TelephonNumber} {Pasport}";
        }

        /// <summary>
        /// Клиент
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="middleName"></param>
        /// <param name="telephonNumber"></param>
        /// <param name="pasport"></param>
        public Client(string firstName, string lastName, string middleName, decimal telephonNumber, string pasport)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            TelephonNumber = telephonNumber;
            Pasport = pasport;
        }

        /// <summary>
        /// сделать отметку изменений
        /// </summary>
        /// <param name="textChange"></param>
        /// <param name="typeOfChanges"></param>
        /// <param name="user"></param>
        public void SetChange(string textChange, TypeOfChangesEnum typeOfChanges, Type user)
        {
            DateOfChange = DateTime.Now;
            TextChange = textChange;
            TypeOfChanges = typeOfChanges;
            UserChange = user;
        }


    }
}
