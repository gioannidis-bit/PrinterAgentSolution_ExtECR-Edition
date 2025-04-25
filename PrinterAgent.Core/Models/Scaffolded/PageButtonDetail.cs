﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("PageButtonDetail")]
public partial class PageButtonDetail
{
    [Key]
    public long Id { get; set; }

    public long? ProductId { get; set; }

    public bool? IsRequired { get; set; }

    public double? MinQty { get; set; }

    public double? MaxQty { get; set; }

    [StringLength(250)]
    public string? Description { get; set; }

    [Column(TypeName = "money")]
    public decimal? AddCost { get; set; }

    [Column(TypeName = "money")]
    public decimal? RemoveCost { get; set; }

    /// <summary>
    /// 0-Receipe, 1-Extras
    /// </summary>
    public byte? Type { get; set; }

    public short? Sort { get; set; }

    public long? PageButtonId { get; set; }

    public double? Qty { get; set; }

    [Column("DAId")]
    public long? Daid { get; set; }

    [ForeignKey("PageButtonId")]
    [InverseProperty("PageButtonDetails")]
    public virtual PageButton? PageButton { get; set; }
}
