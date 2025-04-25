using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("TR_ExcludeRestrictions")]
public partial class TrExcludeRestriction
{
    /// <summary>
    /// Id Record key
    /// </summary>
    [Key]
    public long Id { get; set; }

    public long RestRestrictAssocId { get; set; }

    /// <summary>
    /// TR_Restaurants.Id
    /// </summary>
    public long RestId { get; set; }

    public DateOnly Date { get; set; }

    [ForeignKey("RestId")]
    [InverseProperty("TrExcludeRestrictions")]
    public virtual TrRestaurant Rest { get; set; } = null!;

    [ForeignKey("RestRestrictAssocId")]
    [InverseProperty("TrExcludeRestrictions")]
    public virtual TrRestrictionsRestaurantsAssoc RestRestrictAssoc { get; set; } = null!;
}
