using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public enum Level
    {
        Basic,
        Medium,
        Advanced,
        Expert
    }
    public class Courses :BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string CourseName{ get; set; } = string.Empty;

        [Required]
        [StringLength(280)]
        public string CourseSmallDescription{ get; set; } = string.Empty;
        [Required]
        [StringLength(560)]
        public string CourseLargeDescription{ get; set; } = string.Empty;

        public Level Level { get; set; } = Level.Basic;

        [Required]
        public ICollection<Category> Categories { get; set; } = new List<Category>();
    }
}
