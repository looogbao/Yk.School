using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Yk.School.Models
{
    /// <summary>
    /// 缴费记录
    /// </summary>
    public class FeeHistory
    {

        public FeeHistory()
        {
            FeeDate=DateTime.Now;
        }
        public int Id { get; set; }

        [Required] 

        public int StudentId { get; set; }
        [DisplayName("学生名称")]
        public Student Student { get; set; }

        [Required]
        [DisplayName("缴费金额")]
        public decimal Amount { get; set; }
        [Required]
        [DisplayName("缴费日期")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)]
        public DateTime FeeDate { get; set; }

        [Required]
        [DisplayName("到期时间")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ExpireDate { get; set; }

        
    }
}