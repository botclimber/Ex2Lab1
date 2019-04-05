/**
 * Author       : Daniel Silva | Carlos Silva
 * Date         : 2019-04-04
 * version      : v0.1
 * 
 * Description  : Class para conter dados dos clientes
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2Lab1
{
    class Client
    {

        public string Name { get; }
        public int Nif { get; }
        public string Tele { get; }

        public Client(string name, int nif, string tele)
        {

            this.Name = name;
            this.Nif = nif;
            this.Tele = tele;

        }

        public override string ToString()
        {
            return Name + " | " + Nif + " | " + Tele;
        }

    }
}
