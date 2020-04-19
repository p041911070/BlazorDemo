using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using YoyoMooc.StuManagement.Models;

namespace YoyoMooc.StuManagement.Web.Pages
{
    public class CreateStudentbase: ComponentBase
    {

 

       public int? studentId{ get; set; }

        public Student Student { get; set; }

        protected override void OnInitialized()
        {

            if (studentId.HasValue)
            {

            }
            else
            {
                Student = new Student();
            }

        }

    }
}
