using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YoyoMooc.StuManagement.Models;
using YoyoMooc.StuManagement.Models.enums;

namespace YoyoMooc.StuManagement.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Departments Table
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "哪都通" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 2, DepartmentName = "龙虎山天师府" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 3, DepartmentName = "武侯奇门" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 4, DepartmentName = "编辑室" });

            modelBuilder.Entity<Student>().HasData(new Student
            {
                StudentId = 1,
                StudentName = "张楚岚",
                Email = "chulan@yoyomooc.com",
                DateOfBrith = new DateTime(1980, 10, 5),
                Gender = Gender.Female,
                DepartmentId = 1,
                PhotoPath = "images/chulan.png"
            });


        

            Student s2 = new Student
            {
                StudentId = 2,
                StudentName = "张之维",
                Email = "zhiwei@yoyomooc.com",
                DateOfBrith = new DateTime(1981, 12, 22),
                Gender = Gender.Female,
                DepartmentId = 2,
                PhotoPath = "images/zhiwei.png"
            };

            Student s3 = new Student
            {
                StudentId = 3,
                StudentName = "冯宝宝",
                Email = "baobao@yoyomooc.com",
                DateOfBrith = new DateTime(1979, 11, 11),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/baobao.png"
            };

            Student s4 = new Student
            {
                StudentId = 4,
                StudentName = "诸葛青",
                Email = "zgblue@yoyomooc.com",
                DateOfBrith = new DateTime(1982, 9, 23),
                Gender = Gender.Male,
                DepartmentId = 3,
                PhotoPath = "images/zgblue.png"
            };
            modelBuilder.Entity<Student>().HasData(s2);
            modelBuilder.Entity<Student>().HasData(s3);
            modelBuilder.Entity<Student>().HasData(s4);

            // Code to seed data
        }



    }
}
