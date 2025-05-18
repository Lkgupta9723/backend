using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace finalpracticeproject.Models;

public partial class Result
{
    [Key]
    public Guid ResultId { get; set; }

    [Required]
    public Guid AssessmentId { get; set; }

    [Required]
    public Guid UserId { get; set; }

    public int Score { get; set; }

    public DateTime? AttemptDate { get; set; }

    public virtual Assessment? Assessment { get; set; }

    public virtual User? User { get; set; }
}
