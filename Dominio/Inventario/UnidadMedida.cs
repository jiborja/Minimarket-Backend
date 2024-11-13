using System;
using System.ComponentModel.DataAnnotations;
using Dominio.Common;

namespace Dominio.Inventario
{
    public class UnidadMedida: AuditableBaseEntity
    {
        public required string Nombre {get;set;}
        public required string Abreviatura {get;set;}
    }
}