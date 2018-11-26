using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Logica;
using AccesoADatos;

namespace ServiciosWeb
{
    /// <summary>
    /// Descripción breve de ServicioPadres
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioPadres : System.Web.Services.WebService
    {

        Logica_Padre logica = new Logica_Padre();

        [WebMethod]
        public List<personas> SeleccionarPadres() => logica.SeleccionarPersonas();
    }
}
