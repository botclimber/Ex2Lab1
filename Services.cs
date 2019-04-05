/**
 * Author       : Daniel Silva | Carlos Silva
 * Date         : 2019-04-04
 * version      : v0.1
 * 
 * Description  : Class que disponibiliza os diferentes tipos
 *                de serviços
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2Lab1
{
    class Services
    {

        public int ServiceType { get; }
        public string Desc { get; set; }
        public DateTime Date { get; }

        const int MAX = 10;
        public static Services[] services = new Services[MAX];


                   

    }
}
