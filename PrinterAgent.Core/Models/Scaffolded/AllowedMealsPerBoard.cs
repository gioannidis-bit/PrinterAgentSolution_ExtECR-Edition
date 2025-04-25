using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("AllowedMealsPerBoard")]
public partial class AllowedMealsPerBoard
{
    [Key]
    public long Id { get; set; }

    [StringLength(150)]
    public string? BoardId { get; set; }

    [StringLength(350)]
    public string? BoardDescription { get; set; }

    public int? AllowedMeals { get; set; }

    [Column(TypeName = "money")]
    public decimal? AllowedDiscountAmount { get; set; }

    public bool? IsDeleted { get; set; }

    public long? PriceListId { get; set; }

    public int? AllowedMealsChild { get; set; }

    [Column(TypeName = "money")]
    public decimal? AllowedDiscountAmountChild { get; set; }

    [InverseProperty("AllowedMealsPerBoard")]
    public virtual ICollection<AllowedMealsPerBoardDetail> AllowedMealsPerBoardDetails { get; set; } = new List<AllowedMealsPerBoardDetail>();

    [ForeignKey("PriceListId")]
    [InverseProperty("AllowedMealsPerBoards")]
    public virtual Pricelist? PriceList { get; set; }
}
