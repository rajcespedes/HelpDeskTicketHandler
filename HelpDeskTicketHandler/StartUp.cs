using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using HelpDeskTicketHandler.Data;
using HelpDeskTicketHandler.Data.Entities;
using HelpDeskTicketHandler.App_Start;

[assembly: OwinStartup(typeof(HelpDeskTicketHandler.Startup))]
namespace HelpDeskTicketHandler
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

        public void ConfigureAuth(IAppBuilder app)
        {
            // Configure el contexto de base de datos, el administrador de usuarios y el administrador de inicios de sesión para usar una única instancia por solicitud
            app.CreatePerOwinContext(TicketHandlerContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
            app.CreatePerOwinContext<ApplicationSignInManager>(ApplicationSignInManager.Create);

            // Permitir que la aplicación use una cookie para almacenar información para el usuario que inicia sesión
            // y una cookie para almacenar temporalmente información sobre un usuario que inicia sesión con un proveedor de inicio de sesión de terceros
            // Configurar cookie de inicio de sesión
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login")
            });
        }
    }
}