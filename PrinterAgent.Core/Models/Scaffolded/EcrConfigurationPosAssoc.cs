using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("ECR_Configuration_PosAssoc")]
public partial class EcrConfigurationPosAssoc
{
    [Key]
    public long Id { get; set; }

    public long? PosInfoId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Terminal { get; set; }

    public long? TerminalPort { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? TerminalId { get; set; }

    public long? BranchCode { get; set; }

    [Column("issuerTin")]
    [StringLength(200)]
    [Unicode(false)]
    public string? IssuerTin { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ProvidersId { get; set; }

    [Column("ECRservice")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Ecrservice { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? SignatureDurationType { get; set; }

    [Column("ECRProvider")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Ecrprovider { get; set; }

    [Column("EFTApiKey")]
    [StringLength(200)]
    [Unicode(false)]
    public string? EftapiKey { get; set; }

    [Column("EFTProvidersId")]
    [StringLength(200)]
    [Unicode(false)]
    public string? EftprovidersId { get; set; }

    [Column("EFTDescription")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Eftdescription { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? TerminalIp { get; set; }
}
