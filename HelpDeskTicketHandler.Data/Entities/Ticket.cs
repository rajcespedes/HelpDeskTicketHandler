using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskTicketHandler
{
    public class Ticket
    {
        public int Id { get; set; }

        
        //[MaxLength(100)]
        //[Required(AllowEmptyStrings =false,ErrorMessage = "El título es requerido")]
        public string Titulo { get; set; }

        //[MaxLength(700)]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "Debe agregar el detalle")]
        public string Detalle { get; set; }

        //[MaxLength(100)]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "Debe indicar el usuario")]
        public string Usuario { get; set; }

        public DateTime Fecha { get {
         
                return DateTime.Now;

            } }

       
        
        public string Contacto { get; set; }

        //public string Estado { get {


        //        return "Pendiente";
        //    }
        //}
    }
}
