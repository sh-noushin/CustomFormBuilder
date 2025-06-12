using CustomFormBuilder.Domain.FormControlOptions;
using CustomFormBuilder.Domain.FormControls;
using CustomFormBuilder.Domain.Forms;
using CustomFormBuilder.Domain.FormSubmissionValues;
using CustomFormBuilder.Domain.FormSubmissions;
using CustomFormBuilder.Domain.FormVersions;
using Microsoft.EntityFrameworkCore;

namespace CustomFormBuilder.EntityFrameworkCore
{
    public class CustomFormBuilderDbContext : DbContext
    {
        public DbSet<Form> Forms { get; set; }
        public DbSet<FormVersion> FormVersions { get; set; }
        public DbSet<FormControl> FormControls { get; set; }
        public DbSet<FormControlOption> FormControlOptions { get; set; }
        public DbSet<FormSubmission> FormSubmissions { get; set; }
        public DbSet<FormSubmissionValue> FormSubmissionValues { get; set; }

        public CustomFormBuilderDbContext(DbContextOptions<CustomFormBuilderDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Form>()
                .HasMany(f => f.Versions)
                .WithOne(v => v.Form)
                .HasForeignKey(v => v.FormId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<FormVersion>()
                .HasMany(v => v.Controls)
                .WithOne(c => c.FormVersion)
                .HasForeignKey(c => c.FormVersionId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<FormControl>()
                .HasMany(c => c.Options)
                .WithOne(o => o.FormControl)
                .HasForeignKey(o => o.FormControlId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<FormControl>()
                .HasMany(c => c.SubmissionValues)
                .WithOne(v => v.FormControl)
                .HasForeignKey(v => v.FormControlId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<FormSubmission>()
                .HasOne(s => s.FormVersion)
                .WithMany()
                .HasForeignKey(s => s.FormVersionId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<FormSubmissionValue>()
                .HasOne(v => v.FormSubmission)
                .WithMany(s => s.Values)
                .HasForeignKey(v => v.FormSubmissionId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
