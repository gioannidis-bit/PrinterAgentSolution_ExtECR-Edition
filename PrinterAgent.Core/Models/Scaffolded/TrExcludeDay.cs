using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("TR_ExcludeDays")]
[Index("RestId", "Date", "Type", Name = "PK_TR_ExcludeDays_Unique", IsUnique = true)]
public partial class TrExcludeDay
{
    /// <summary>
    /// Id Record key
    /// </summary>
    [Key]
    public long Id { get; set; }

    /// <summary>
    /// TR_Restaurants.Id
    /// </summary>
    public long RestId { get; set; }

    /// <summary>
    /// Date of Unavailability
    /// </summary>
    public DateOnly Date { get; set; }

    /// <summary>
    /// 0:AllDay,1:Lunch,2:Dinner
    /// </summary>
    public int Type { get; set; }

    [ForeignKey("RestId")]
    [InverseProperty("TrExcludeDays")]
    public virtual TrRestaurant Rest { get; set; } = null!;
}
