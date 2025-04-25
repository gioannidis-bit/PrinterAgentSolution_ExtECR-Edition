using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("TR_Config")]
public partial class TrConfig
{
    [Key]
    public long Id { get; set; }

    public int PreviewDays { get; set; }

    [Column(TypeName = "text")]
    public string? EmailTemplate { get; set; }

    [StringLength(150)]
    public string? EmailSubject { get; set; }

    public long? DefaultHotelId { get; set; }

    [Column("ExtECR")]
    [StringLength(250)]
    public string? ExtEcr { get; set; }

    [ForeignKey("DefaultHotelId")]
    [InverseProperty("TrConfigs")]
    public virtual HotelInfo? DefaultHotel { get; set; }
}
