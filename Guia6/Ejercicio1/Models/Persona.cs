using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Persona : IComparable
    {
        protected string nombre;

        public string Nombre { 
            get {
                return nombre;
            }
            set
            {
                Regex regex = new Regex(@"^s*(?<apellido>[\p{L}\s]{2,}?),\s*(?<nombres>[\p{L}\s]{2,})\s*$");
                Match match = regex.Match(value);
                if (match.Success == false) {
                    throw new FormatoNombreNoValidoException();
                }
                nombre = value;
            }
        }

        public Persona(string nombre)
        {
            this.Nombre = nombre;
        }

        public int CompareTo(object obj)
        {
            Persona nuevaPersona = obj as Persona;
            if(nuevaPersona != null)
            {
                return this.nombre.CompareTo(nuevaPersona.nombre);
            }
            return -1;
        }

        public virtual string Describir()
        {
            return $"{this.Nombre}";
        }
    }
}
