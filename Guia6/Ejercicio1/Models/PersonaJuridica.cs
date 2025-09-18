using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class PersonaJuridica:Persona
    {
        private string cuit;

        public PersonaJuridica(string nombre, string cuit):base(nombre)
        {
            this.cuit = cuit;

            if (VerificarCUIT(cuit) == false)
            {
                throw new FormatoCUITNoValidoException();
            }
        }

        private bool VerificarCUIT(string cuit)
        {
            Regex regex = new Regex(@"^\d{11}$");
            Match match = regex.Match(cuit);
            if (match.Success == false)
            {
                return false;
            }
            return true;
        }

        public override string Describir()
        {
            return $"{this.Nombre} ({this.cuit}) ";
        }
    }
}
