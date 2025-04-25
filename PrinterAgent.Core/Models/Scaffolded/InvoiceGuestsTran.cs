using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("Invoice_Guests_Trans")]
public partial class InvoiceGuestsTran
{
    [Key]
    public long Id { get; set; }

    public long? InvoiceId { get; set; }

    public long? GuestId { get; set; }

    public long? TransactionId { get; set; }

    public long? DeliveryCustomerId { get; set; }

    [ForeignKey("DeliveryCustomerId")]
    [InverseProperty("InvoiceGuestsTrans")]
    public virtual DeliveryCustomer? DeliveryCustomer { get; set; }

    [ForeignKey("GuestId")]
    [InverseProperty("InvoiceGuestsTrans")]
    public virtual Guest? Guest { get; set; }

    [ForeignKey("InvoiceId")]
    [InverseProperty("InvoiceGuestsTrans")]
    public virtual Invoice? Invoice { get; set; }

    [ForeignKey("TransactionId")]
    [InverseProperty("InvoiceGuestsTrans")]
    public virtual Transaction? Transaction { get; set; }
}
