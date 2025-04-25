using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("TR_Restaurants")]
public partial class TrRestaurant
{
    [Key]
    public long Id { get; set; }

    [Column("NameGR")]
    [StringLength(200)]
    public string NameGr { get; set; } = null!;

    [StringLength(200)]
    public string NameEn { get; set; } = null!;

    [StringLength(200)]
    public string NameRu { get; set; } = null!;

    [StringLength(200)]
    public string NameFr { get; set; } = null!;

    [StringLength(200)]
    public string NameDe { get; set; } = null!;

    [StringLength(200)]
    public string? Image { get; set; }

    [Column("DescriptionGR", TypeName = "text")]
    public string DescriptionGr { get; set; } = null!;

    [Column(TypeName = "text")]
    public string DescriptionEn { get; set; } = null!;

    [Column(TypeName = "text")]
    public string DescriptionRu { get; set; } = null!;

    [Column(TypeName = "text")]
    public string DescriptionFr { get; set; } = null!;

    [Column(TypeName = "text")]
    public string DescriptionDe { get; set; } = null!;

    [InverseProperty("Rest")]
    public virtual ICollection<TrCapacity> TrCapacities { get; set; } = new List<TrCapacity>();

    [InverseProperty("Rest")]
    public virtual ICollection<TrExcludeDay> TrExcludeDays { get; set; } = new List<TrExcludeDay>();

    [InverseProperty("Rest")]
    public virtual ICollection<TrExcludeRestriction> TrExcludeRestrictions { get; set; } = new List<TrExcludeRestriction>();

    [InverseProperty("Rest")]
    public virtual ICollection<TrOvewrittenCapacity> TrOvewrittenCapacities { get; set; } = new List<TrOvewrittenCapacity>();

    [InverseProperty("Rest")]
    public virtual ICollection<TrRestrictionsRestaurantsAssoc> TrRestrictionsRestaurantsAssocs { get; set; } = new List<TrRestrictionsRestaurantsAssoc>();
}
