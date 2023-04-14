using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public class Chapter: BaseEntity
    {
        public int CourseId { get; set; }
        public virtual Courses Course { get; set; } = new Courses();
        [Required]
        public string ChapterList  = string.Empty;
    }
}
