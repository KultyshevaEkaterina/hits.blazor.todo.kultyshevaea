﻿using System.ComponentModel.DataAnnotations;

namespace TodoServerApp.Data
{
    public class TaskItem
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? FinishDate { get; set; }
    }
}
