using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmreOzyildirimBlog.Models.Entities
{
    public class HakkimdaInfo
    {
        public int Id { get; set; }
        public string HakkimdaBaslik { get; set; }
        public string ProfilResmiAdresi { get; set; }

        [MaxLength(590)]
        public string HakkimdaAciklama { get; set; }
        [MaxLength(75)]
        public string IlkOkul { get; set; }
        [MaxLength(75)]
        public string Lise { get; set; }
        [MaxLength(75)]
        public string Universite { get; set; }
    }   
}