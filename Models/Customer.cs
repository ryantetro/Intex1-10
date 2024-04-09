using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Intex1_10.Models;

public partial class Customer
{
    [Key] // This data annotation denotes that CustomerId is the primary key.
    public int CustomerId { get; set; }

    [Required] // Makes sure FirstName cannot be null in the database.
    public string FirstName { get; set; }

    [Required] // Makes sure LastName cannot be null in the database.
    public string LastName { get; set; }
    
    public DateOnly BirthDate { get; set; } // Assuming you want to allow nulls for BirthDate.
    public string CountryOfResidence { get; set; }
    public string Gender { get; set; }

    // If Age is a computed value, it's often not stored in the database
    // but calculated based on BirthDate. If you choose to store it, you might want it to be non-nullable.
    public int? Age { get; set; } 

    [EmailAddress] // This will enforce that the Email property, if present, contains a valid email address.
    public string Email { get; set; }
    public string PasswordHash { get; set; }
}
