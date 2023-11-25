﻿using Microsoft.AspNetCore.Components.Forms;
using WebApiTask1.Data;
using WebApiTask1.Entities;
using WebApiTask1.Repositories.Abstract;

namespace WebApiTask1.Repositories.Concrete
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentDbContext _context;

        public StudentRepository(StudentDbContext context)
        {
            _context = context; 
        }

        public void Add(Student entity)
        {
            _context.Students.Add(entity);
            _context.SaveChanges(); 
        }

        public void Delete(Student entity)
        {
            _context.Students.Remove(entity);
            _context.SaveChanges();
        }

        public Student Get(int id)
        {
           var student = _context.Students.SingleOrDefault(x => x.Id == id);
            return student;
        }

        public IEnumerable<Student> GetAll()
        {
            var students = _context.Students;
            return students;
        }

        public void Update(Student entity)
        {
            _context.Students.Update(entity);
            _context.SaveChanges();
        }
    }
}
