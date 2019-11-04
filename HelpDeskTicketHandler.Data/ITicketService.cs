using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskTicketHandler.Data
{
    public interface ITicketService
    {
        IEnumerable<Ticket> Listar();
        void CrearTicket(Ticket ticket);
        Ticket GetById(int id);
        void Modificar(Ticket ticket);
        Ticket GetTicket(int id);
    }
}
