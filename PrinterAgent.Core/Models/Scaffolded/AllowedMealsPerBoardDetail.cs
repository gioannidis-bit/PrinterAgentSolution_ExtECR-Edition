using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class AllowedMealsPerBoardDetail
{
    [Key]
    public long Id { get; set; }

    public long? ProductCategoryId { get; set; }

    public long? AllowedMealsPerBoardId { get; set; }

    [ForeignKey("AllowedMealsPerBoardId")]
    [InverseProperty("AllowedMealsPerBoardDetails")]
    public virtual AllowedMealsPerBoard? AllowedMealsPerBoard { get; set; }

    [ForeignKey("ProductCategoryId")]
    [InverseProperty("AllowedMealsPerBoardDetails")]
    public virtual ProductCategory? ProductCategory { get; set; }
}
