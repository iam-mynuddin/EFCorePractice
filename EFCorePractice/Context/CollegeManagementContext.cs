using System;
using System.Collections.Generic;
using EFCorePractice.Models.CollegeEntities;
using Microsoft.EntityFrameworkCore;

namespace EFCorePractice.Context;

public partial class CollegeManagementContext : DbContext
{
    public CollegeManagementContext()
    {
    }

    public CollegeManagementContext(DbContextOptions<CollegeManagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Assignment> Assignments { get; set; }

    public virtual DbSet<AssignmentSubmission> AssignmentSubmissions { get; set; }

    public virtual DbSet<Attendance> Attendances { get; set; }

    public virtual DbSet<Calendar> Calendars { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Faculty> Faculties { get; set; }

    public virtual DbSet<FacultySubject> FacultySubjects { get; set; }

    public virtual DbSet<FeeDetail> FeeDetails { get; set; }

    public virtual DbSet<HomePageDetail> HomePageDetails { get; set; }

    public virtual DbSet<IssueReport> IssueReports { get; set; }

    public virtual DbSet<LeaveDetail> LeaveDetails { get; set; }

    public virtual DbSet<Parent> Parents { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentCourse> StudentCourses { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
