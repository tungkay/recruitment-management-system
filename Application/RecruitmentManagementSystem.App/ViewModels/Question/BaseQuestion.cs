﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RecruitmentManagementSystem.Model;

namespace RecruitmentManagementSystem.App.ViewModels.Question
{
    public class BaseQuestion
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Tittle")]
        [StringLength(30, ErrorMessage = "The {0} must be at most {1} characters long.")]
        public string Tittle { get; set; }

        [Display(Name = "Question Type")]
        public QuestionType Type { get; set; }

        [Display(Name = "Answer Display Type")]
        public DisplayType DisplayType { get; set; }

        [Display(Name = "Choices")]
        public IList<Choice> Choices { get; set; }

        [StringLength(500, ErrorMessage = "The {0} must be at most {1} characters long.")]
        public string Note { get; set; }

        [Required]
        public int CategoryId { get; set; }
        [Display(Name = "Category")]
        public string CategoryName { get; set; }
    }
}