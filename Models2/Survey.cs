﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models2
{
    public class Survey
    {
        public Survey()
        {
            Added = DateTime.Now;
        }

        [Key]
        public int SurveyID { get; set; }

        [ForeignKey("Agency")]
        public int AgencyID { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [StringLength(500)]
        public String SurveyTitle { get; set; }

        [Required]
        public double ResponseValue { get; set; }

        [ForeignKey("Years")]
        public int YearID { get; set; }

        [ForeignKey("Question")]
        public int QuestionID { get; set; }

        [Required]
        public DateTime Added { get; set; }

        public virtual Agency Agency { get; set; }

        public virtual Years Years { get; set; }

        public virtual Question Question { get; set; }
    }
}
