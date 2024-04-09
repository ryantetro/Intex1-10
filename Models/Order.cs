using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intex1_10.Models;

public partial class Order
{
    [Key] // This denotes TransactionId as the primary key.
    public int TransactionId { get; set; } // Assuming TransactionId is intended as the primary key.

    [ForeignKey("Customer")] // This denotes CustomerId as a foreign key referencing the Customer table.
    public int? CustomerId { get; set; }

    public DateOnly? Date { get; set; }

    public string? DayOfWeek { get; set; }

    public int? Time { get; set; }

    public string? EntryMode { get; set; }

    public decimal? Amount { get; set; }

    public string? TypeOfTransaction { get; set; }

    public string? CountryOfTransaction { get; set; }

    public string? ShippingAddress { get; set; }

    public string? Bank { get; set; }

    public string? TypeOfCard { get; set; }

    public bool? Fraud { get; set; }
}
