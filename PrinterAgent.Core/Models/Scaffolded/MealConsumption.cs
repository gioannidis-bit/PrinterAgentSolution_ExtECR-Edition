using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("MealConsumption")]
public partial class MealConsumption
{
    [Key]
    public long Id { get; set; }

    public long? GuestId { get; set; }

    public int? ConsumedMeals { get; set; }

    [Column("ConsumedTS", TypeName = "datetime")]
    public DateTime? ConsumedTs { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(150)]
    public string? BoardCode { get; set; }

    public int? ReservationId { get; set; }

    public int? ConsumedMealsChild { get; set; }

    public long? DepartmentId { get; set; }

    public long? EndOfDayId { get; set; }

    public long? PosInfoId { get; set; }

    [StringLength(1)]
    public string? Timezone { get; set; }

    [StringLength(50)]
    public string? Room { get; set; }

    public int? HotelId { get; set; }

    public long? StaffId { get; set; }

    [ForeignKey("DepartmentId")]
    [InverseProperty("MealConsumptions")]
    public virtual Department? Department { get; set; }

    [ForeignKey("EndOfDayId")]
    [InverseProperty("MealConsumptions")]
    public virtual EndOfDay? EndOfDay { get; set; }

    [ForeignKey("GuestId")]
    [InverseProperty("MealConsumptions")]
    public virtual Guest? Guest { get; set; }

    [ForeignKey("PosInfoId")]
    [InverseProperty("MealConsumptions")]
    public virtual PosInfo? PosInfo { get; set; }

    [ForeignKey("StaffId")]
    [InverseProperty("MealConsumptions")]
    public virtual Staff? Staff { get; set; }
}
