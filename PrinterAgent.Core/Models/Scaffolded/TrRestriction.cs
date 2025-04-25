using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("TR_Restrictions")]
public partial class TrRestriction
{
    /// <summary>
    /// HardCode Id
    /// </summary>
    [Key]
    public long Id { get; set; }

    [StringLength(200)]
    public string? Description { get; set; }

    [InverseProperty("Restrict")]
    public virtual ICollection<TrRestrictionsRestaurantsAssoc> TrRestrictionsRestaurantsAssocs { get; set; } = new List<TrRestrictionsRestaurantsAssoc>();
}
