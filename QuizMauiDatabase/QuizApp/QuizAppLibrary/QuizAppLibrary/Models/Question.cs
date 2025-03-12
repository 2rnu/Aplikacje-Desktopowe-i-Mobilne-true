using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuizAppLibrary.Models;

[Table("questions")]
public partial class Question
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(500)]
    public string Text { get; set; } = null!;

    [StringLength(100)]
    public string? Category { get; set; }

    [Column(TypeName = "enum('Easy','Medium','Hard')")]
    public string Difficulty { get; set; } = null!;

    [InverseProperty("Question")]
    public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>();
}
