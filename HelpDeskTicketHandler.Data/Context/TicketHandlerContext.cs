using HelpDeskTicketHandler.Data.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskTicketHandler.Data
{
    public class TicketHandlerContext : IdentityDbContext<ApplicationUser>
    {
        public static TicketHandlerContext Create()
        {
            return new TicketHandlerContext();
        }

        public TicketHandlerContext() : base("TicketHandlerDB")
        {
           
        }

        public DbSet<Ticket> Tickets { get; set; }

    }
}

