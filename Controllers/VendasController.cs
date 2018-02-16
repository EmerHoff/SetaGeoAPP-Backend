using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_SetaDigital.Model;
using System.Globalization;

namespace WebAPI_SetaDigital.Controllers
{
    [Produces("application/json")]
    public class VendasController : Controller
    {
        [HttpPost]
        [Route("api/vendas/cadastrar")]
        public void CadastrarPreVenda([FromBody] Venda prevenda){
            CRUD crud = new CRUD();
            Movimento movimento = new Movimento();
            Pessoa pessoa = new Pessoa();
            Console.WriteLine("Pre-Venda");
            Console.WriteLine("Codigo do cliente = {0}",prevenda.Cliente);

            Console.WriteLine("Codigo do produto = {0}",prevenda.CodProduto);
            
            
            string codigoProduto = prevenda.CodProduto;
            prevenda.CodProduto = codigoProduto.Substring(0,6);
            Console.WriteLine("CodProduto = {0}",prevenda.CodProduto);
            Console.WriteLine("Quantidade do Produto = {0}",prevenda.Itens);

            Console.WriteLine("Codigo da pre-venda = {0}",prevenda.PreVenda);

            prevenda.Vendedor = "00000101";
            Console.WriteLine("Codigo vendedor = {0}",prevenda.Vendedor);
            decimal preco = crud.BuscarInfoProduto(prevenda.CodProduto, "preco");
            prevenda.SubTotal = Convert.ToDecimal(preco*prevenda.Itens, new CultureInfo("en-US"));
            prevenda.Total = Convert.ToDecimal(prevenda.SubTotal, new CultureInfo("en-US"));

            string dia = DateTime.Now.Day.ToString();
            string mes = DateTime.Now.Month.ToString();
            string ano = DateTime.Now.Year.ToString();
            string hora = DateTime.Now.ToShortTimeString();

            prevenda.Data = ano + "-" + mes + "-" + dia;
            prevenda.Hora = hora;

            pessoa = crud.BuscarPessoa(prevenda.Cliente);
            prevenda.Cpf = pessoa.Cpf;
            prevenda.ClienteStatus = pessoa.Status;

            //outros
            prevenda.Status="P";
            prevenda.Tipo = "01";
            prevenda.Condicoes = "125";
            prevenda.Empresa = "44";

            //teste
            Console.WriteLine("Codigo cliente" + prevenda.Cliente);
            Console.WriteLine("codigo produto" + prevenda.CodProduto);

            //Movimento
            movimento.Auxiliar="VE"+crud.CadastrarPreVenda(prevenda);
            movimento.Op="VE";
            movimento.Mov="S";
            movimento.Data= prevenda.Data;
            movimento.Empresa=prevenda.Empresa;
            movimento.CodProduto=codigoProduto;
            movimento.Qtd=prevenda.Itens;
            movimento.Unitario=preco;
            movimento.Total=prevenda.SubTotal;
            movimento.Vendedor=prevenda.Vendedor;
            movimento.Custo=crud.BuscarInfoProduto(prevenda.CodProduto, "custo");

            crud.CadastrarMovimentoPreVenda(movimento);

            Console.WriteLine("\n\n\nDigite qualquer tecla para continuar...");
            //Console.Read();
        }
    }
}