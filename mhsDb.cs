using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using tpmod10_1302223061;

internal class mhsDb : DbContext
{
    public mhsDb(DbContextOptions<mhsDb> options) // default setting untuk database
        : base(options) { }
    public DbSet<Mahasiswa> mhs => Set<Mahasiswa>();
}