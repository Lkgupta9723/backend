using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace finalpracticeproject.Models;

public partial class Assessment
{
    public Guid AssessmentId { get; set; }

    [Required]
    public Guid CourseId { get; set; }

    [Required]
    public string Title { get; set; } = null!;

    public string? Questions { get; set; }

    public int MaxScore { get; set; }

    public virtual Course? Course { get; set; }
}
