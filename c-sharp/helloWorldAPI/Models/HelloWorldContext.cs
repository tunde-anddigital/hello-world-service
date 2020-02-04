using Microsoft.EntityFrameworkCore;

namespace helloWorldAPI.Models
{
    public class HelloWorldContext : DbContext
    {
        public HelloWorldContext(DbContextOptions<HelloWorldContext> options)
            : base(options)
        {
        }

        public DbSet<HelloWorld> HelloWorld { get; set; }
    }
}