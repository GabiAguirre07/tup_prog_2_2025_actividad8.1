using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Actividad_En_El_Aula8._1.Models
{
    public class DNINoValidoException:ApplicationException
    {
        public DNINoValidoException() { }
        public DNINoValidoException(string msg) : base(msg) { }
        public DNINoValidoException(string msg,Exception inner): base(msg, inner) { }
    }
}
