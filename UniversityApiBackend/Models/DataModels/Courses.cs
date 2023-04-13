using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public class Courses :BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string CourseName{ get; set; } = string.Empty;

        [StringLength(280)]
        public string CourseSmallDescription{ get; set; } = string.Empty; 
        [StringLength(560)]
        public string CourseLargeDescription{ get; set; } = string.Empty;

        public string ObjectivePublic { get; set; } = string.Empty;

        public string Objectives { get; set; } = string.Empty;

        public string Requieres { get; set; } = string.Empty;

        public LevelEnum Level { get; set; }
    }
}
