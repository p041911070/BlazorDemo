using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using YoyoMooc.StuManagement.Api.Services;
using YoyoMooc.StuManagement.Models;
using YoyoMooc.StuManagement.Models.enums;

namespace YoyoMooc.StuManagement.Web.Pages
{
	public class StudentListBase : ComponentBase
	{
		[Inject]
		public IStudentService _studentService { get; set; }

		 
		public IEnumerable<Student> Students { get; set; }


		protected override async Task OnInitializedAsync()
		{
			Students = (await _studentService.GetStudents()).ToList();
		}


		protected async Task ConfirmDelete(Student student,bool isConfirm){

			if (isConfirm)
			{
			await	_studentService.DeleteStudent(student.StudentId);
				//Students.ToList().Remove(student);
			await	OnInitializedAsync();
			}
			 
		}



	}
}
