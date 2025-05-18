using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace finalpracticeproject.Models;

public partial class User
{
    public Guid UserId { get; set; }

    [Required]
    public string Name { get; set; } = null!;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = null!;

    public string? Role { get; set; }

    [Required]
    public string PasswordHash { get; set; } = null!;

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
