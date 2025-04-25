using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class StoreMessage
{
    [Key]
    public long Id { get; set; }

    public string? Message { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [StringLength(500)]
    public string? Title { get; set; }

    public long? StoreId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ShowFrom { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ShowTo { get; set; }

    [StringLength(250)]
    public string? ImageUri { get; set; }

    public byte? Status { get; set; }

    [ForeignKey("StoreId")]
    [InverseProperty("StoreMessages")]
    public virtual Store? Store { get; set; }
}
