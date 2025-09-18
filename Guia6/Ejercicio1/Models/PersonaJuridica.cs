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
            this.cuit = Convert.ToString(cuit);

            Regex regex = new Regex(@"^\d{11}$");
            Match match = regex.Match(cuit);
            if (match.Success == false) {
                throw new FormatoCUITNoValidoException();
            }
        }

        public override string Describir()
        {
            return $"Persona Jurídica - Nombre: {this.Nombre} Apellido: {this.cuit} ";
        }
    }
}
