using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace finalpracticeproject.Models;

public partial class Course
{
    public Guid CourseId { get; set; }

    [Required]
    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public Guid? InstructorId { get; set; }

    public string? MediaUrl { get; set; }

    public virtual ICollection<Assessment> Assessments { get; set; } = new List<Assessment>();

    public virtual User? Instructor { get; set; }
}
