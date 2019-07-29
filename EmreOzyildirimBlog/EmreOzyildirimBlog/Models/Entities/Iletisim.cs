using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmreOzyildirimBlog.Models.Entities
{
    public class Iletisim
    {
        public int Id { get; set; }
        public bool AktifMi { get; set; }
        public string AcikAdres { get; set; }
        public string Email { get; set; }
        public int Telefon { get; set; }

    }
}