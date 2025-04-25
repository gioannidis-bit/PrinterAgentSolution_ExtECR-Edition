using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("DA_OpeningHours")]
public partial class DaOpeningHour
{
    [Key]
    public long Id { get; set; }

    public long StoreId { get; set; }

    public int Weekday { get; set; }

    public int OpenHour { get; set; }

    public int OpenMinute { get; set; }

    public int CloseHour { get; set; }

    public int CloseMinute { get; set; }
}
