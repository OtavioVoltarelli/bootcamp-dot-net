using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ExemploPOO.Models
{
    public abstract class Conta
    {
         protected decimal saldo;
         public abstract void Creditar(decimal valor);
         public void ExibirSaldo()
         {
            Console.WriteLine("Seu saldo é" + saldo);
         }
    }
}