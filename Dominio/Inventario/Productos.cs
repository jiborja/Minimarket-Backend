using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Common;

namespace Dominio.Inventario
{
    [Table("Actividad")]
    public class Productos: AuditableBaseEntity
    {
        public required string Nombre {get;set;}
        public required string Descripcion {get;set;}
        public int StockMin {get;set;}
        public int StockMax {get;set;}
        public Guid IdCategoria {get;set;}
        public Guid IdMarca {get;set;}
        public Guid IdUnidadMedida {get;set;}

        // [ForeignKey("IdCategoria")]
        // public virtual required Categorias Categorias { get; set; }
        // public virtual required Marcas Marcas { get; set; }
        // public virtual required UnidadesMedida UnidadesMedida { get; set; }

    }
}