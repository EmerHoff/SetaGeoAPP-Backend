using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_SetaDigital.Model
{
    public class Venda
    {
        public string Codigo { get; set;}
        public string Empresa { get; set;} 
        public string Tipo { get; set;}
        public string Vendedor {get; set;}
        public string Cliente { get; set;}
        public string CodProduto { get; set;}
        public string Data { get; set;}
        public string Hora { get; set;}
        public int Itens { get; set;}
        public decimal SubTotal { get; set;}
        public decimal Total { get; set;}
        public string Cpf { get; set;}
        public string PreVenda { get; set;}
        public string ClienteStatus { get; set;}
        public string Status { get; set;}
        public string Condicoes { get; set;}
    }
}