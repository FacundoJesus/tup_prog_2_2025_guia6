using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class FormatoCUITNoValidoException:ApplicationException
    {
        // Constructor por defecto con mensaje fijo
        public FormatoCUITNoValidoException():base("El CUIT debe tener 11 dígitos numéricos y se debe verificar con el dígito verificador."){ }
        
        // Constructor que recibe un mensaje
        public FormatoCUITNoValidoException(string message) { }
        
        // Constructor que recibe un mensaje y una excepción interna
        public FormatoCUITNoValidoException(string message, Exception innerException) {}
    }
}
