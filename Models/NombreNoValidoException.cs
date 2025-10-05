using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_En_El_Aula8._1.Models
{
     class NombreNoValidoException:ApplicationException
    {
        public NombreNoValidoException() { }
        public NombreNoValidoException(string msg) : base(msg) { }
        public NombreNoValidoException(string msg,Exception inner): base(msg, inner) { }
    }
}
