using Asp_Practise_HomeEdu.Models;
using Microsoft.EntityFrameworkCore;

namespace Asp_Practise_HomeEdu.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Cours> Courses { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventSpiker> EventSpikers { get; set; }
        public DbSet<Spiker> Spikers { get; set; }
        public DbSet<Slider> Slider { get; set; }
        public DbSet<SliderContent> SliderContents { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Bio> Bios { get; set; }
        public DbSet<Contact> Contacts { get; set; }

    }
}
