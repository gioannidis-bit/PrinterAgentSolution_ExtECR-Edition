using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("StaffCash")]
public partial class StaffCash
{
    [Key]
    public long Id { get; set; }

    public long? StaffId { get; set; }

    [Column(TypeName = "money")]
    public decimal? CashAmount { get; set; }

    public long? EndOfDayId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [ForeignKey("EndOfDayId")]
    [InverseProperty("StaffCashes")]
    public virtual EndOfDay? EndOfDay { get; set; }

    [ForeignKey("StaffId")]
    [InverseProperty("StaffCashes")]
    public virtual Staff? Staff { get; set; }
}
