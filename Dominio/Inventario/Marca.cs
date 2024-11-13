using System;
using System.ComponentModel.DataAnnotations;
using Dominio.Common;

namespace Dominio.Inventario
{
    public class Marca : AuditableBaseEntity
    {
        public required string Nombre {get;set;}
        public string? Descripcion {get;set;}
    }
}