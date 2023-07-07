using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Demotht.Authorization.Users;
using Demotht.Module.StudentManagment.Dto;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Identity;
using NewProject.DbEntities;

namespace Demotht.Module.StudentManagment
{
    public class StudentManagmentAppService : DemothtAppServiceBase
    {
        private readonly IRepository<Student, long> _studentRepository;

        public (int id, User User) MaptoEntity { get; private set; }

        public StudentManagmentAppService(IRepository<Student, long> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        //create
        public async Task AddAync(StudentDto input)
        {
            var student = new Student
            {
                Name = input.Name,
                Age = input.Age,
                Class = input.Class,
            };
            await _studentRepository.InsertAsync(student);
        }

        //delete
        public async Task Delete(int id)
        {
            var student = await _studentRepository.GetAsync(id);
            await _studentRepository.DeleteAsync(student);
        }

        //update
        public async Task Update(StudentUpdate input)
        {
            var studentUpdate = await _studentRepository.FirstOrDefaultAsync(e => e.Id == input.Id);
            if (studentUpdate != null)
            {
                studentUpdate.Name = input.Name;
                studentUpdate.Age = input.Age;
                studentUpdate.Class = input.Class;
            }
            await _studentRepository.UpdateAsync(studentUpdate);
        }

        //get
        public async Task<List<Student>> GetListAsync()
        {
            return await _studentRepository.GetAllListAsync();
        }
    }
}
