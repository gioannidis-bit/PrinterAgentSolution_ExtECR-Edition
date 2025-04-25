using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class Supplier
{
    [Key]
    public long Id { get; set; }

    [StringLength(50)]
    public string? Code { get; set; }

    [StringLength(250)]
    public string? Description { get; set; }

    [StringLength(250)]
    public string? FullName { get; set; }

    [StringLength(50)]
    public string? VatNo { get; set; }

    [StringLength(250)]
    public string? TaxOffice { get; set; }

    [StringLength(250)]
    public string? Address { get; set; }

    [StringLength(50)]
    public string? ZipCode { get; set; }

    [StringLength(50)]
    public string? Phone { get; set; }

    [StringLength(250)]
    public string? Email { get; set; }

    [InverseProperty("Supplier")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
