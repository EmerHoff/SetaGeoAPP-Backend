using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_SetaDigital.Model
{
    public class ContagemMarca
    {
        public string nome {get; set;} 
        public List<Marca> lstMarca { get; set;}
    }
}