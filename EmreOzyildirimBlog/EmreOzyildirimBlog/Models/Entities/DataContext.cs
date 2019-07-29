using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmreOzyildirimBlog.Models.Entities
{
    public class DataContext:DbContext
    {
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<HaritaAktifMi> HaritaAktifMi { get; set; }
        public DbSet<SosyalMedyaHesaplari> SosyalMedyaHesaplari { get; set; }
        public DbSet<BloggerAdi> BloggerAdi { get; set; }
        public DbSet<FooterDeveloperName> FooterDeveloperName { get; set; }
        public DbSet<FooterMenuAktifMi> FooterMenuAktifMi { get; set; }

        public System.Data.Entity.DbSet<EmreOzyildirimBlog.Models.Entities.HakkimdaInfo> HakkimdaInfoes { get; set; }
    }
}