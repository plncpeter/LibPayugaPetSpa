using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPayugaPetSpa.Classes
{
    public class Ordem
    {
        public int Id { get; set; }
        public int IdPet { get; set; }
        public int IdServicos { get; set; }
        public int IdCliente { get; set; }
    }
}
