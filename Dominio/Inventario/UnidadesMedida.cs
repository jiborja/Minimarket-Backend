using System;
using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Dominio.Inventario
{
    public class UnidadesMedida: AuditableBaseEntity
    {
        public required string Nombre {get;set;}
        public required string Abreviatura {get;set;}
    }
}