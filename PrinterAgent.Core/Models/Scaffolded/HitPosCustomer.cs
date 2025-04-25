using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class HitPosCustomer
{
    [Key]
    public long CurId { get; set; }

    [Column("customerid")]
    [StringLength(15)]
    public string Customerid { get; set; } = null!;

    [Column("name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("fname")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Fname { get; set; }

    [Column("title")]
    [StringLength(50)]
    public string? Title { get; set; }

    [Column("profession")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Profession { get; set; }

    [Column("tel1")]
    [StringLength(40)]
    public string? Tel1 { get; set; }

    [Column("tel2")]
    [StringLength(20)]
    public string? Tel2 { get; set; }

    [Column("fax")]
    [StringLength(20)]
    public string? Fax { get; set; }

    [Column("mobile")]
    [StringLength(20)]
    public string? Mobile { get; set; }

    [Column("address1")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Address1 { get; set; }

    [Column("address2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Address2 { get; set; }

    [Column("address_no")]
    [StringLength(30)]
    [Unicode(false)]
    public string? AddressNo { get; set; }

    [Column("orofos1")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Orofos1 { get; set; }

    [Column("orofos2")]
    [StringLength(10)]
    public string? Orofos2 { get; set; }

    [Column("city")]
    [StringLength(50)]
    [Unicode(false)]
    public string? City { get; set; }

    [Column("zipcode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Zipcode { get; set; }

    [Column("doy")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Doy { get; set; }

    [Column("afm")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Afm { get; set; }

    [Column("email")]
    [StringLength(200)]
    public string? Email { get; set; }

    [Column("contact")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Contact { get; set; }

    [Column("vip")]
    [StringLength(5)]
    public string? Vip { get; set; }

    [Column("member")]
    [StringLength(10)]
    public string? Member { get; set; }

    [Column("tomeas")]
    [StringLength(20)]
    public string? Tomeas { get; set; }

    [Column("store")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Store { get; set; }

    [Column("sector")]
    [StringLength(10)]
    public string? Sector { get; set; }

    [Column("diet")]
    [StringLength(50)]
    public string? Diet { get; set; }

    [Column("entolh")]
    [StringLength(50)]
    public string? Entolh { get; set; }

    [Column("farsa")]
    [StringLength(50)]
    public string? Farsa { get; set; }

    [Column("remarks")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    [Column("amount")]
    public double? Amount { get; set; }

    [Column("expireddate", TypeName = "datetime")]
    public DateTime? Expireddate { get; set; }

    [Column("order_comments")]
    [StringLength(200)]
    public string? OrderComments { get; set; }

    [Column("first_order", TypeName = "datetime")]
    public DateTime? FirstOrder { get; set; }

    [Column("last_order", TypeName = "datetime")]
    public DateTime? LastOrder { get; set; }

    [Column("no_of_orders")]
    public int? NoOfOrders { get; set; }

    [Column("tziros", TypeName = "numeric(18, 0)")]
    public decimal? Tziros { get; set; }

    [Column("bonus")]
    public int? Bonus { get; set; }

    [Column("epitages")]
    public int? Epitages { get; set; }

    [Column("zerobonus")]
    public int? Zerobonus { get; set; }

    [Column("domino_false")]
    public int? DominoFalse { get; set; }

    [Column("lates")]
    public int? Lates { get; set; }

    [Column("credit", TypeName = "money")]
    public decimal? Credit { get; set; }

    [Column("max_charge", TypeName = "money")]
    public decimal? MaxCharge { get; set; }

    [Column("company_name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CompanyName { get; set; }

    [Column("bl_address")]
    [StringLength(200)]
    [Unicode(false)]
    public string? BlAddress { get; set; }

    [Column("bl_address_no")]
    [StringLength(30)]
    [Unicode(false)]
    public string? BlAddressNo { get; set; }

    [Column("bl_city")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BlCity { get; set; }

    [Column("doycode")]
    public int? Doycode { get; set; }
}
