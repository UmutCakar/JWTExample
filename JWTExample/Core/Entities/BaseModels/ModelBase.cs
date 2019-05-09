using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JWTExample.Core.Entities.BaseModels
{
    public class ModelBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Column("created_at"), Required]
        public DateTime createdAt { get; set; }

        [Column("updated_at"), Required]
        public DateTime? updatedAt { get; set; }
    }
}
