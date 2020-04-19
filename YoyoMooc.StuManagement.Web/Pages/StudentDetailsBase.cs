using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using YoyoMooc.StuManagement.Api.Services;
using YoyoMooc.StuManagement.Models;

namespace YoyoMooc.StuManagement.Web.Pages
{
    public class StudentDetailsBase : ComponentBase
    {
        public Student Student { get; set; } = new Student();

        [Inject]
        public IStudentService StudentService { get; set; }

        [Parameter]
        public string Id { get; set; }


        protected string ButtonText { get; set; } = "Hide Footer";

        public string CssClass { get; set; } = null;



        protected async override Task OnInitializedAsync()
        {
            Id = Id ?? "1";
            Student = await StudentService.GetStudent(int.Parse(Id));
        }
        /// <summary>
        /// 坐标
        /// </summary>
        protected string Coordinates { get; set; }



        protected   void Button_Click(){

            if (ButtonText== "隐藏页脚")
            {

                ButtonText = "显示页脚";
                CssClass = "HideFooter";
            }
            else
            {
                CssClass = null;

                ButtonText = "隐藏页脚";
            }

            
        }


        protected void Mouse_Move(MouseEventArgs e)
        {
            Coordinates = $"X轴 = {e.ClientX } Y轴 = {e.ClientY}";
        }

    }
}
