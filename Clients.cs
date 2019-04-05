using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2Lab1
{
    class Clients
    {
        #region ATTRIBUTES
            string name;
        int nif, phoneNum;
            #endregion
                
        #region CONSTRUTORES
                // metodo insere pesso
                /// <summary>
                /// Construtor para dados vindos do exterior
                /// </summary>
                /// <param name="n">Nome do cliente</param>
                /// <param name="nif">Numero de contribuinte do cliente</param>
                /// <param name="phone">Numero de telefone do cliente</param>
                public Cliente(string n, int nif, int phone){
            }
                #endregion
        #region OVERRIDES 
                    // metodo verifica se pessoa existe
         /// <summary>
        /// Compara dois objectos tipo Cliente
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            
        }
                #endregion
                    
        
       

        

        

        

    }
}

/*const int MAX = 20;
        static int numClients = 0;
        static Client[] clients = new Client[MAX];
        
        
        
         static Clients()
        {
            clients = new Client[MAX];
        }
*/
