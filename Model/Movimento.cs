using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_SetaDigital.Model
{
    public class Movimento
    {
        public string Codigo { get; set;}
        public string Auxiliar { get; set;} 
        public string Op { get; set;}
        public string Mov { get; set;}
        public string Data { get; set;}
        public string Empresa { get; set;}
        public string CodProduto { get; set;}
        public int Qtd { get; set;}
        public decimal Unitario { get; set;}
        public decimal Total { get; set;}
        public decimal Custo { get; set;}
        public string Vendedor { get; set;}
        
    }
}