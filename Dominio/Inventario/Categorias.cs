using System;
using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Dominio.Inventario
{
    public class Categorias : AuditableBaseEntity
    {
        public required string Nombre {get;set;}
        public string? Descripcion {get;set;}
    }
}