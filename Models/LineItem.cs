using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Intex1_10.Models;

public partial class LineItem
{
    [Key] // This data annotation denotes that TransactionId and ProductId together form the primary key.
    public string TransactionId { get; set; }

    [Key]
    public string ProductId { get; set; }

    public int Qty { get; set; } // Assuming Qty is always an integer value, so removed the nullable indicator.

    public int? Rating { get; set; } // Assuming Rating can be nullable.
    
}
