using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class Vodafone11Detail
{
    [Key]
    public long Id { get; set; }

    public long? HeaderId { get; set; }

    public long? ProdCategoryId { get; set; }

    public int? Position { get; set; }
}
