using Microsoft.EntityFrameworkCore;

namespace Playtrought.Api.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
}
