using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPayugaPetSpa.Classes
{
    public class Pet
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdTipo { get; set; }
        public int IdCliente { get; set; }
    }
}
