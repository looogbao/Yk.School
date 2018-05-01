using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations; 

namespace Yk.School.Models
{
    /// <summary>
    /// 学生
    /// </summary>
    public class Student
    {

        public Student()
        {
            CreateTime = DateTime.Now; 
        }

        public int Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [MaxLength(50)]
        [DisplayName("学生名称")]
        public string RealName { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        [DisplayName("年龄")]
        public int Age { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [DisplayName("性别")]
        public SexType Sex { get; set; }

        /// <summary>
        /// 所在学校
        /// </summary>
        [MaxLength(200)]
        [DisplayName("所在学校")]
        public string CurrentSchool { get; set; }
        /// <summary>
        /// 年级
        /// </summary>
        [MaxLength(50)]
        [DisplayName("年级")]
        public string Grade { get; set; }
        /// <summary>
        /// 班级
        /// </summary>
        [MaxLength(50)]
        [DisplayName("班级")]
        public string Class { get; set; }
        /// <summary>
        /// 家长姓名
        /// </summary>
        [MaxLength(50)]
        [DisplayName("家长姓名")]
        public string ParentsName { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        [MaxLength(50)]
        [DisplayName("联系电话")]
        public string ContantNumber { get; set; }
        /// <summary>
        /// 所在舞蹈班级
        /// </summary> 
        public int DanceClassId { get; set; }

        public DanceClass DanceClass { get; set; }

        
        /// <summary>
        /// 总缴费金额
        /// </summary>
        [DisplayName("总缴费金额")]
        public decimal TotalFeeAmount { get; set; }
        /// <summary>
        /// 最后缴费时间
        /// </summary>
        [DisplayName("最后缴费时间"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime LastFeeDate { get; set; }
        /// <summary>
        /// 学费到期时间
        /// </summary>
        [DisplayName("学费到期时间"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ExpireDate { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [MaxLength(2000)]
        [DisplayName("备注")]
        public string Description { get; set; }
        //舞玥舞蹈。学生姓名 ，年龄 ，性别 ，所在学校 ，年级， 班级 ，家长姓名 ，联系电话  ，所在舞蹈班级  ，代课老师  ，缴费金额 ，缴费时间 ，学费到期时间 ，备注

        public DateTime CreateTime { get; set; }

        public int CreateUserId { get; set; }

        public User User {get;set;}


    }
}