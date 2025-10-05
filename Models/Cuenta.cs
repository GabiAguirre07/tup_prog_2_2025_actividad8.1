using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Actividad_En_El_Aula8._1.Models
{
    public class Cuenta : IComparable
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public double Importe { get; set; }
        public Cuenta(int dni, string nombre, double importe)
        {
            Match matchDNI = Regex.Match(dni.ToString(), @"^[0-9]{8,9}$");
            if (matchDNI.Success) { DNI = dni; }
            else { throw new DNINoValidoException(); }
            Match matchNombre = Regex.Match(nombre, @"^[\p{Lu}][\p{L}]{2,9}$");
            if (matchNombre.Success) { Nombre = nombre; } 
            else { throw new NombreNoValidoException(); }
            
                Importe = importe;
        }
        public override string ToString()
        {
            return $"{Nombre}({DNI}) {Importe:f2}";
        }
        public int CompareTo(object? other)
        {
            if (other != null)
            {
                Cuenta? otro = other as Cuenta;
                return DNI.CompareTo(otro?.DNI);
            }
            return -1;
        }
    }
}
