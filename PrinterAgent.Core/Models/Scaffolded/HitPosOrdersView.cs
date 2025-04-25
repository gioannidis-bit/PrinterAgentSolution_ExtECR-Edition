using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class HitPosOrdersView
{
    [Column("nYear")]
    public int? NYear { get; set; }

    public long CurId { get; set; }

    [Column("id")]
    public int Id { get; set; }

    [Column("orderno")]
    public int? Orderno { get; set; }

    [Column("pos")]
    public int? Pos { get; set; }

    [Column("shop_id")]
    [StringLength(50)]
    public string? ShopId { get; set; }

    [Column("item_group")]
    public int? ItemGroup { get; set; }

    [Column("item_code")]
    public int? ItemCode { get; set; }

    [Column("item_descr")]
    [StringLength(60)]
    public string? ItemDescr { get; set; }

    [Column("item_subgroup")]
    public int? ItemSubgroup { get; set; }

    [Column("item_vat")]
    public int? ItemVat { get; set; }

    [Column("cont_line", TypeName = "decimal(18, 0)")]
    public decimal? ContLine { get; set; }

    [Column("sp", TypeName = "ntext")]
    public string? Sp { get; set; }

    [Column("prep_time", TypeName = "datetime")]
    public DateTime? PrepTime { get; set; }

    [Column("start_time", TypeName = "datetime")]
    public DateTime? StartTime { get; set; }

    [Column("load_time")]
    public int? LoadTime { get; set; }

    [Column("otd")]
    public int? Otd { get; set; }

    [Column("qty")]
    public int? Qty { get; set; }

    [Column("amount")]
    public int? Amount { get; set; }

    [Column("total")]
    public int? Total { get; set; }

    [Column("waiter")]
    public int? Waiter { get; set; }

    [Column("ttable")]
    public int? Ttable { get; set; }

    [Column("listino")]
    public int? Listino { get; set; }

    [Column("receipt")]
    public int? Receipt { get; set; }

    [Column("member")]
    [StringLength(50)]
    public string? Member { get; set; }

    [Column("priority")]
    public int? Priority { get; set; }

    [Column("kdws")]
    public int? Kdws { get; set; }

    [Column("ready")]
    public int? Ready { get; set; }

    [Column("rqty")]
    public int? Rqty { get; set; }

    [Column("nieko_flag")]
    public int? NiekoFlag { get; set; }

    [Column("status")]
    public int? Status { get; set; }

    [Column("status_time", TypeName = "datetime")]
    public DateTime? StatusTime { get; set; }

    [Column("rest_time")]
    public int? RestTime { get; set; }

    [Column("room")]
    [StringLength(50)]
    public string? Room { get; set; }

    [Column("payment")]
    [StringLength(50)]
    public string? Payment { get; set; }

    [Column("type")]
    [StringLength(50)]
    public string? Type { get; set; }

    [Column("comments")]
    [StringLength(255)]
    public string? Comments { get; set; }

    [Column("mqty")]
    public int? Mqty { get; set; }

    [Column("rec_time_start", TypeName = "datetime")]
    public DateTime? RecTimeStart { get; set; }

    [Column("status_time2", TypeName = "datetime")]
    public DateTime? StatusTime2 { get; set; }

    [Column("status_time3", TypeName = "datetime")]
    public DateTime? StatusTime3 { get; set; }

    [Column("status_time4", TypeName = "datetime")]
    public DateTime? StatusTime4 { get; set; }

    [Column("status_time5", TypeName = "datetime")]
    public DateTime? StatusTime5 { get; set; }

    [Column("fo_day", TypeName = "datetime")]
    public DateTime? FoDay { get; set; }

    [Column("delivery_time", TypeName = "datetime")]
    public DateTime? DeliveryTime { get; set; }

    [Column("agent")]
    public int? Agent { get; set; }

    [Column("flag_up")]
    public int? FlagUp { get; set; }

    [Column("sent")]
    public int? Sent { get; set; }

    [Column("correct")]
    public int? Correct { get; set; }

    [Column("completed")]
    public int? Completed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }
}
