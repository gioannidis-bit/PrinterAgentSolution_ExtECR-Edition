using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("Pda_SurveyQuestion")]
public partial class PdaSurveyQuestion
{
    [Key]
    public long Id { get; set; }

    public long? PosInfoId { get; set; }

    public string? Description { get; set; }

    [ForeignKey("PosInfoId")]
    [InverseProperty("PdaSurveyQuestions")]
    public virtual PosInfo? PosInfo { get; set; }
}
