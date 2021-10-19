using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11_6
{
    interface IChanger
    {
        abstract void ChangeClient(Client client, string textChange);

        abstract string GetChangeClinet(Client client);
    }
}
