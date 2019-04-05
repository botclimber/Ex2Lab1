using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2Lab1
{
    class Clients
    {

        const int MAX = 20;
        static int numClients = 0;
        static Client[] clients = new Client[MAX];

        static Clients()
        {
            clients = new Client[MAX];
        }

        // metodo verifica espaço
        public static bool SpaceVer()
        {
            
            return (numClients >= MAX) ? true : false;
        }

        // metodo verifica se pessoa existe
        public static bool ExistVer(int nif)
        {
            for (int i = 0; i < numClients; i++)
            {
                if (clients[i].Nif == nif) return true;
            }

            return false;
        }

        // metodo insere pessoa
        public static int NewInsert(Client p)
        {

            if (SpaceVer()) return -1;
            if (ExistVer(p.Nif)) return 0;

            clients[numClients++] = p;
            return 1;
        }
    }
}
