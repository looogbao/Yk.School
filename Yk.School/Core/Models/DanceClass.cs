using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Yk.School.Models
{
    /// <summary>
    /// 舞蹈班级
    /// </summary>
    public class DanceClass
    {
        public int Id { get; set; }

        /// <summary>
        /// 班级名称
        /// </summary>
        [Required]
        [MaxLength(50)]
        [DisplayName("班级名称")]
        public string Title { get; set; }

        public int InstructorId { get; set; }

        public Instructor Instructor { get; set; }

    }
}