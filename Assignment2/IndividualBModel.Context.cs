﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IndividualProjectBContext : DbContext
    {
        public IndividualProjectBContext()
            : base("name=IndividualProjectBContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Assignment> Assignments { get; set; }
        public virtual DbSet<assignmentsPerCourse> assignmentsPerCourses { get; set; }
        public virtual DbSet<assignmentsPerStudentPerCourse> assignmentsPerStudentPerCourses { get; set; }
        public virtual DbSet<Cours> Courses { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }
        public virtual DbSet<trainersPerCourse> trainersPerCourses { get; set; }
        public virtual DbSet<studentsPerCourse> studentsPerCourses { get; set; }
    }
}