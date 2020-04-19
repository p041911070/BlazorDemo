using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using YoyoMooc.StuManagement.Models.enums;

namespace YoyoMooc.StuManagement.Models
{
    public class Student
    {

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string StudentName { get; set; }
        public int StudentId { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBrith { get; set; }


        public Gender Gender { get; set; }

        public Department Department { get; set; }
        public int DepartmentId { get; set; }


        /// <summary>
        /// 主修科目
        /// </summary>
        public MajorEnum? Major { get; set; }

        public string PhotoPath { get; set; }


        /// <summary>
        /// 入学时间
        /// </summary>
        public DateTime EnrollmentDate { get; set; }


    }
}