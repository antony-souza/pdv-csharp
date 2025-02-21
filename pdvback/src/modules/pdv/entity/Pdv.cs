using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pdvback.modules.pdv.entity;

[Table("Pdv")]
public class Pdv
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid? Id { get; set; }
    
    public required int Box { get; set; }
    
    public bool? Status { get; set; }
    
    public bool? Enabled { get; set; }
}