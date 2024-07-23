using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KnowMeRepository.Models;

[Index("Email", Name = "UQ_Email", IsUnique = true)]
[Index("Subject", Name = "UQ_Subject", IsUnique = true)]
public partial class User
{
    [Key]
    public long Id { get; set; }

    [StringLength(350)]
    [Unicode(false)]
    public string Subject { get; set; } = null!;

    [StringLength(250)]
    public string FirstName { get; set; } = null!;

    [StringLength(250)]
    public string LastName { get; set; } = null!;

    [StringLength(250)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    public string? Description { get; set; }
}
