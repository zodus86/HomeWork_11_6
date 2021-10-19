using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


namespace HomeWork_11_6
{
    abstract class Repository 
    {

        protected static List<Client> clients = new List<Client>();


        /// <summary>
        /// Заполнения списка клиентов
        /// </summary>
        /// <param name="fileFullName"></param>
        public void InstallBase ()
        {
            clients = new List<Client>();

            for (uint i = 1; i <= 5; i++)
            {
                clients.Add(new Client($"Имя_{i}", $"Фамилия_{i}", $"Отчество{i}", 88000000000 + i ,"44 01 46600" + i));
            }
            


        }

        /// <summary>
        /// 
        /// </summary>
        abstract public void PrintBD();

        abstract public void Add(string firstName, string lastName, string middleName, decimal telephonNumber, string pasport);

        abstract public void LoadBD(string fileFullName);

        /// <summary>
        /// получить имя
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string GetFirstName (int index)
        {
            return clients[index].FirstName;
        }
        
        /// <summary>
        /// Получить фамилию
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string GetLasttName(int index)
        {
            return clients[index].LastName;
        }

        /// <summary>
        /// Получить Отчество
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string GetMiddleName(int index)
        {
            return clients[index].MiddleName;
        }

        /// <summary>
        /// Получить телефон
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public decimal GetTelephon(int index)
        {
            return clients[index].TelephonNumber;
        }

        abstract public string GetPasport(int index);

        abstract public void SetTelephon(decimal newTelephon, int index);

        /// <summary>
        /// Показать последние изменения
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string GetChange(int index)
        {
            return clients[index].GetChange();
        }

        /// <summary>
        /// Сохраним базу в файл
        /// </summary>
        /// <param name="fileFullName"></param>
        abstract public void SaveBD(string fileFullName);

    }
}
