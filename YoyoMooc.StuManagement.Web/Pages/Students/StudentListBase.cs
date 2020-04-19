using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using YoyoMooc.StuManagement.Api.Services;
using YoyoMooc.StuManagement.Models;

namespace YoyoMooc.StuManagement.Web.Pages
{
	public class StudentListBase : ComponentBase
	{
		[Inject]
		public IStudentService _studentService { get; set; }

		[Parameter]
		public List<Student> Students { get; set; }

		protected override async Task OnInitializedAsync()
		{
			Students = (await _studentService.GetStudents()).ToList();
		}



		/// <summary>
		/// 确认删除
		/// </summary>
		/// <param name="student"></param>
		/// <param name="isConfirm"></param>
		/// <returns></returns>
		protected async Task ConfirmDelete(Student student, bool isConfirm)
		{
			if (isConfirm)
			{
				await _studentService.DeleteStudent(student.StudentId);
				Students.Remove(student);
				StateHasChanged();
			}
		}


		 

	}
}