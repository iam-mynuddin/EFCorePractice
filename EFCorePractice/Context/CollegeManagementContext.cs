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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=MYNUDDIN_SK;Database=CollegeManagement;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Assignment>(entity =>
        {
            entity.HasIndex(e => e.CourseId, "IX_Assignments_CourseId");

            entity.HasIndex(e => e.FacultyId, "IX_Assignments_FacultyId");

            entity.HasIndex(e => e.StudentId, "IX_Assignments_StudentId");

            entity.HasIndex(e => e.SubjectId, "IX_Assignments_SubjectId");

            entity.Property(e => e.Question).IsRequired();

            entity.HasOne(d => d.Course).WithMany(p => p.Assignments).HasForeignKey(d => d.CourseId);

            entity.HasOne(d => d.Faculty).WithMany(p => p.Assignments).HasForeignKey(d => d.FacultyId);

            entity.HasOne(d => d.Student).WithMany(p => p.Assignments).HasForeignKey(d => d.StudentId);

            entity.HasOne(d => d.Subject).WithMany(p => p.Assignments).HasForeignKey(d => d.SubjectId);
        });

        modelBuilder.Entity<AssignmentSubmission>(entity =>
        {
            entity.HasKey(e => e.SubmissionId);

            entity.HasIndex(e => e.AssignmentId, "IX_AssignmentSubmissions_AssignmentId");

            entity.HasIndex(e => e.CourseId, "IX_AssignmentSubmissions_CourseId");

            entity.HasIndex(e => e.StudentId, "IX_AssignmentSubmissions_StudentId");

            entity.HasIndex(e => e.SubjectId, "IX_AssignmentSubmissions_SubjectId");

            entity.HasOne(d => d.Assignment).WithMany(p => p.AssignmentSubmissions).HasForeignKey(d => d.AssignmentId);

            entity.HasOne(d => d.Course).WithMany(p => p.AssignmentSubmissions).HasForeignKey(d => d.CourseId);

            entity.HasOne(d => d.Student).WithMany(p => p.AssignmentSubmissions).HasForeignKey(d => d.StudentId);

            entity.HasOne(d => d.Subject).WithMany(p => p.AssignmentSubmissions).HasForeignKey(d => d.SubjectId);
        });

        modelBuilder.Entity<Attendance>(entity =>
        {
            entity.HasIndex(e => e.FacultyId, "IX_Attendances_FacultyId");

            entity.HasIndex(e => e.StudentId, "IX_Attendances_StudentId");

            entity.HasOne(d => d.Faculty).WithMany(p => p.Attendances).HasForeignKey(d => d.FacultyId);

            entity.HasOne(d => d.Student).WithMany(p => p.Attendances).HasForeignKey(d => d.StudentId);
        });

        modelBuilder.Entity<Calendar>(entity =>
        {
            entity.Property(e => e.Message).IsRequired();
            entity.Property(e => e.Reason).IsRequired();
            entity.Property(e => e.Status).IsRequired();
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.Property(e => e.CourseName).IsRequired();
        });

        modelBuilder.Entity<Faculty>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_Faculties_UserId");

            entity.Property(e => e.FacultyDepartment).IsRequired();
            entity.Property(e => e.FullName)
                .IsRequired()
                .HasDefaultValue("");
            entity.Property(e => e.MailId).IsRequired();

            entity.HasOne(d => d.User).WithMany(p => p.Faculties).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<FacultySubject>(entity =>
        {
            entity.HasIndex(e => e.FacultyId, "IX_FacultySubjects_FacultyId");

            entity.HasIndex(e => e.SubjectId, "IX_FacultySubjects_SubjectId");

            entity.HasOne(d => d.Faculty).WithMany(p => p.FacultySubjects).HasForeignKey(d => d.FacultyId);

            entity.HasOne(d => d.Subject).WithMany(p => p.FacultySubjects).HasForeignKey(d => d.SubjectId);
        });

        modelBuilder.Entity<FeeDetail>(entity =>
        {
            entity.HasKey(e => e.FeeId);

            entity.HasIndex(e => e.StudentId, "IX_FeeDetails_StudentId");

            entity.Property(e => e.FeeName).IsRequired();

            entity.HasOne(d => d.Student).WithMany(p => p.FeeDetails).HasForeignKey(d => d.StudentId);
        });

        modelBuilder.Entity<HomePageDetail>(entity =>
        {
            entity.HasIndex(e => e.Key, "IX_HomePageDetails_Key").IsUnique();

            entity.Property(e => e.Key).IsRequired();
        });

        modelBuilder.Entity<IssueReport>(entity =>
        {
            entity.HasKey(e => e.TicketId);

            entity.HasIndex(e => e.UserId, "IX_IssueReports_UserId");

            entity.Property(e => e.Description).IsRequired();

            entity.HasOne(d => d.User).WithMany(p => p.IssueReports).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<LeaveDetail>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_LeaveDetails_UserId");

            entity.Property(e => e.Reason).IsRequired();

            entity.HasOne(d => d.User).WithMany(p => p.LeaveDetails).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<Parent>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_Parents_UserId");

            entity.Property(e => e.Address)
                .IsRequired()
                .HasDefaultValue("");
            entity.Property(e => e.FullName)
                .IsRequired()
                .HasDefaultValue("");
            entity.Property(e => e.MobileNumber)
                .IsRequired()
                .HasDefaultValue("");

            entity.HasOne(d => d.User).WithMany(p => p.Parents).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_Students_UserId");

            entity.Property(e => e.Address)
                .IsRequired()
                .HasDefaultValue("");
            entity.Property(e => e.FullName)
                .IsRequired()
                .HasDefaultValue("");
            entity.Property(e => e.MailId).IsRequired();
            entity.Property(e => e.MobileNumber)
                .IsRequired()
                .HasDefaultValue("");
            entity.Property(e => e.StudentDepartment).IsRequired();
            entity.Property(e => e.StudentYear).IsRequired();

            entity.HasOne(d => d.User).WithMany(p => p.Students).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<StudentCourse>(entity =>
        {
            entity.HasIndex(e => e.CourseId, "IX_StudentCourses_CourseId");

            entity.HasIndex(e => e.StudentId, "IX_StudentCourses_StudentId");

            entity.HasOne(d => d.Course).WithMany(p => p.StudentCourses).HasForeignKey(d => d.CourseId);

            entity.HasOne(d => d.Student).WithMany(p => p.StudentCourses).HasForeignKey(d => d.StudentId);
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasIndex(e => e.CourseId, "IX_Subjects_CourseId");

            entity.Property(e => e.SubjectName).IsRequired();

            entity.HasOne(d => d.Course).WithMany(p => p.Subjects).HasForeignKey(d => d.CourseId);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Email).IsRequired();
            entity.Property(e => e.FirstName).IsRequired();
            entity.Property(e => e.LastName).IsRequired();
            entity.Property(e => e.Password).IsRequired();
            entity.Property(e => e.UserName).IsRequired();
            entity.Property(e => e.UserType).IsRequired();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
