using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace testscaffold.Models;

public partial class Orderitem
{
    [Key]
    public int Id { get; set; }

    [Column("itemName")]
    [StringLength(50)]
    [Unicode(false)]
    public string ItemName { get; set; } = null!;

    [Column("itemQty")]
    public int ItemQty { get; set; }

    [Column("itemprice", TypeName = "decimal(16, 4)")]
    public decimal Itemprice { get; set; }

    public int? OrderId { get; set; }

    [ForeignKey("OrderId")]
    [InverseProperty("Orderitems")]
    public virtual Orderss? Order { get; set; }
}
