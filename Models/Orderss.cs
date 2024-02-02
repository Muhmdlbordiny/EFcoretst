using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace testscaffold.Models;

[Table("Orderss")]
public partial class Orderss
{
    [Key]
    public int Id { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string OrderName { get; set; } = null!;

    [Column("createdate", TypeName = "datetime")]
    public DateTime? Createdate { get; set; }

    [Column("userName")]
    [StringLength(30)]
    public string UserName { get; set; } = null!;

    [Column("totalAmount", TypeName = "decimal(16, 4)")]
    public decimal TotalAmount { get; set; }

    [InverseProperty("Order")]
    public virtual ICollection<Orderitem> Orderitems { get; set; } = new List<Orderitem>();
}
