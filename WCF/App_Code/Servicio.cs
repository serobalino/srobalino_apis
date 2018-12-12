using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AccesoADatos;
using Logica;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "Servicio" en el código, en svc y en el archivo de configuración a la vez.
public class Servicio : IServicio
{
    CompuLogica logica = new CompuLogica();
    public List<computadoras> Seleccionar()
    {
        return logica.SeleccionarCompusMantenimiento();
    }
}
