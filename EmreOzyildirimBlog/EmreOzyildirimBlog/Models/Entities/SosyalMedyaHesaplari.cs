using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmreOzyildirimBlog.Models.Entities
{
    public class SosyalMedyaHesaplari
    {
        public int Id { get; set; }

        public bool FacebookAktif { get; set; }
        public string FacebookLink { get; set; }

        public bool InstagramAktif { get; set; }
        public string InstagramLink { get; set; }

        public bool LinkedinAktif { get; set; }
        public string LinkedinLink { get; set; }
    }
}