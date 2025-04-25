using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("TR_Restrictions_Restaurants_Assoc")]
public partial class TrRestrictionsRestaurantsAssoc
{
    /// <summary>
    /// Id Record key
    /// </summary>
    [Key]
    public long Id { get; set; }

    /// <summary>
    /// TR_Restrictions.Id
    /// </summary>
    public long RestrictId { get; set; }

    /// <summary>
    /// TR_Restaurants.Id
    /// </summary>
    public long RestId { get; set; }

    /// <summary>
    /// Restriction number
    /// </summary>
    public int N { get; set; }

    [ForeignKey("RestId")]
    [InverseProperty("TrRestrictionsRestaurantsAssocs")]
    public virtual TrRestaurant Rest { get; set; } = null!;

    [ForeignKey("RestrictId")]
    [InverseProperty("TrRestrictionsRestaurantsAssocs")]
    public virtual TrRestriction Restrict { get; set; } = null!;

    [InverseProperty("RestRestrictAssoc")]
    public virtual ICollection<TrExcludeRestriction> TrExcludeRestrictions { get; set; } = new List<TrExcludeRestriction>();
}
