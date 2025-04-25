using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("NFCcard")]
public partial class Nfccard
{
    [Key]
    public long Id { get; set; }

    public short? Type { get; set; }

    public int? RoomSector { get; set; }

    public int? FirstDateSector { get; set; }

    public int? SecondDateSector { get; set; }

    public bool? ValidateDate { get; set; }
}
