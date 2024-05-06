using System;
using System.Collections.Generic;
using EFCorePractice.Models.SchoolEntities;
using Microsoft.EntityFrameworkCore;

namespace EFCorePractice.Context;

public partial class SchoolDbContext : DbContext
{
    public SchoolDbContext()
    {
    }

    public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Assignment> Assignments { get; set; }

    public virtual DbSet<AssignmentResult> AssignmentResults { get; set; }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<ClassSubject> ClassSubjects { get; set; }

    public virtual DbSet<Club> Clubs { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<ClassDepartment> ClassDepartments { get; set; }

    public virtual DbSet<Enrollment> Enrollments { get; set; }

    public virtual DbSet<Exam> Exams { get; set; }

    public virtual DbSet<ExamResult> ExamResults { get; set; }

    public virtual DbSet<Grade> Grades { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    public virtual DbSet<ClubMember> ClubMembers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
