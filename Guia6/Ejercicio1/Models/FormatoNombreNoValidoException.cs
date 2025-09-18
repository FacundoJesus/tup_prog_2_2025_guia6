using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class FormatoNombreNoValidoException:ApplicationException
    {
        public FormatoNombreNoValidoException() : base("El nombre ingresado no cumple con el formato 'Apellido, Nombre'(s).") { }
        public FormatoNombreNoValidoException(string message) : base(message) { }
        public FormatoNombreNoValidoException (string message, Exception innerException):base(message,innerException){ }
    }
}
