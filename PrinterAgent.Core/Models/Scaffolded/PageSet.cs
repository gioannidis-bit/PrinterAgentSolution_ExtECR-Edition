using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("PageSet")]
public partial class PageSet
{
    [Key]
    public long Id { get; set; }

    [StringLength(150)]
    public string? Description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ActivationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DeactivationDate { get; set; }

    [Column("DAId")]
    public long? Daid { get; set; }

    [InverseProperty("PageSet")]
    public virtual ICollection<BoDaPageSetStoreAssoc> BoDaPageSetStoreAssocs { get; set; } = new List<BoDaPageSetStoreAssoc>();

    [InverseProperty("PageSet")]
    public virtual ICollection<BoDaProductStoreAssoc> BoDaProductStoreAssocs { get; set; } = new List<BoDaProductStoreAssoc>();

    [InverseProperty("PageSet")]
    public virtual ICollection<DaPageSetStoreAssoc> DaPageSetStoreAssocs { get; set; } = new List<DaPageSetStoreAssoc>();

    [InverseProperty("PageSet")]
    public virtual ICollection<PagePosAssoc> PagePosAssocs { get; set; } = new List<PagePosAssoc>();

    [InverseProperty("PageSet")]
    public virtual ICollection<Page> Pages { get; set; } = new List<Page>();

    [InverseProperty("PageSet")]
    public virtual ICollection<PdaModule> PdaModules { get; set; } = new List<PdaModule>();
}
