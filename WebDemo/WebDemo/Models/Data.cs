namespace WebDemo.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Data : DbContext
    {
        public Data()
            : base("name=Data2")
        {
        }

        public virtual DbSet<GV> GVs { get; set; }
        public virtual DbSet<Specialized> Specializeds { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GV>()
                .Property(e => e.codeGV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GV>()
                .Property(e => e.nameGV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GV>()
                .Property(e => e.codeCN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Specialized>()
                .Property(e => e.codeCN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Specialized>()
                .Property(e => e.nameCN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.codeSV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.fullName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.codeCN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Subject>()
                .Property(e => e.codeMH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Subject>()
                .Property(e => e.nameMH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Subject>()
                .Property(e => e.codeGV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Passwords)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
