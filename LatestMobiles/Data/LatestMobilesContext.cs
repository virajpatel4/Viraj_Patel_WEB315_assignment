using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LatestMobiles.Models;

    public class LatestMobilesContext : DbContext
    {
        public LatestMobilesContext (DbContextOptions<LatestMobilesContext> options)
            : base(options)
        {
        }

        public DbSet<LatestMobiles.Models.Mobiles> Mobiles { get; set; }
    }
