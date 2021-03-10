using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMecanico.Entidades
{
   public class Login
    {
        public string user { get; set; }
        public byte[] pass { get; set; }
        public byte[] salt { get; set; }
        public int rol { get; set; }
        public bool activo { get; set; }
        public Login()
        {

        }
    }
}
