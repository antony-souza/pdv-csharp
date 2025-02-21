using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace pdvback.modules.store.entity;

[Table(("store"))]
public class Store: DbContext
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid? Id { get; set; }
    
    [Required]
    public required string Name { get; set; }
    
    [Required]
    public required string Address { get; set; }
    
    [Required]
    public required string City { get; set; }
    
    [Required]
    public required string State { get; set; }

    public bool? Enabled { get; set; }





}