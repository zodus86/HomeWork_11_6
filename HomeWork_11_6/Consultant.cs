using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11_6
{
    class Consultant : Repository , IChanger
    {
        /// <summary>
        /// Вывод на списка
        /// </summary>
        public override void PrintBD()
        {
            Console.WriteLine($"{"Фамилия",15} {"Имя",15} " +
                    $"{"Отчество",15} {"Телефон",15} {"Паспорт",15}");

            foreach (Client client in clients)
            {
                string pasportNotSee = "";
                if (!String.IsNullOrEmpty(client.Pasport)) pasportNotSee = "** ** ******";

                Console.WriteLine($"{client.LastName ,15} {client.FirstName,15} " +
                    $"{client.MiddleName, 15} {client.TelephonNumber, 15} {pasportNotSee, 15}");
            }
                
        }

        /// <summary>
        /// паспорт *******
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public override string GetPasport(int index)
        {
            string pasportNotSee = "";
            
            if (!String.IsNullOrEmpty(clients[index].Pasport)) 
                pasportNotSee = "** ** ******";
            
            return pasportNotSee;
        }
        
        /// <summary>
        /// Изменить телефон
        /// </summary>
        /// <param name="newTelephon"></param>
        /// <param name="index"></param>
        public override void SetTelephon(decimal newTelephon, int index)
        {
            string textChange = $"изменился телефон был - {clients[index].TelephonNumber} стал - {newTelephon}";
            clients[index].TelephonNumber = newTelephon;

            ChangeClient(clients[index], textChange);
        }

        /// <summary>
        /// добавить клиента
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="middleName"></param>
        /// <param name="telephonNumber"></param>
        /// <param name="pasport"></param>
        public override void Add(string firstName, string lastName, string middleName, decimal telephonNumber, string pasport)
        {
            Console.WriteLine("Нету прав на добавления клиентов, обратитесь к менеджеру!");
        }

        /// <summary>
        /// загрузить базу данных
        /// </summary>
        /// <param name="fileFullName"></param>
        public override void LoadBD(string fileFullName)
        {
            Console.WriteLine("Нету прав на загрузку клиентов, обратитесь к менеджеру!");
        }

        /// <summary>
        /// Сохраним базу
        /// </summary>
        /// <param name="fileFullName"></param>
        public override void SaveBD(string fileFullName) 
        {
            Console.WriteLine("Нету прав на сохранения клиентов,ведь там паспорт! обратитесь к менеджеру!!!");
        }

        /// <summary>
        /// изменения телефонов
        /// </summary>
        /// <param name="client"></param>
        /// <param name="textChange"></param>
        public void ChangeClient(Client client, string textChange)
        {
            client.SetChange(textChange, TypeOfChangesEnum.Changes, typeof(Consultant));
        }

        /// <summary>
        /// получить изменения
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public string GetChangeClinet(Client client)
        {
            return client.GetChange();
        }
    }
}
