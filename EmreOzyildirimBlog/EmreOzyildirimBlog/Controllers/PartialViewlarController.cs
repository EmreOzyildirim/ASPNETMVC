using EmreOzyildirimBlog.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmreOzyildirimBlog.Models;
using System.IO;

namespace EmreOzyildirimBlog.Controllers
{
    public class PartialViewlarController : Controller
    {
        private DataContext context = new DataContext();

        // GET: PartialViewlar

        public PartialViewResult _Harita()
        {
            var aktifmi = context.HaritaAktifMi.Where(i => i.aktifMi).OrderByDescending(i => i.Id).ToList();

            return PartialView("_Harita", aktifmi);
        }

        public PartialViewResult _IletisimFormu()
        {
            return PartialView();
        }

        public PartialViewResult _SosyalMedyaHesaplari()
        {
            var hesaplar = context.SosyalMedyaHesaplari.OrderByDescending(i => i.Id).ToList();

            return PartialView(hesaplar);
        }

        public PartialViewResult _BloggerAdi()
        {
            var bilgiler = context.BloggerAdi.OrderByDescending(i => i.Id).ToList();

            return PartialView(bilgiler);
        }

        public PartialViewResult _Slider()
        {
            return PartialView();
        }

        public PartialViewResult _DeveloperInfo()
        {
            var developerBilgisi = context.FooterDeveloperName.ToList();

            return PartialView(developerBilgisi);
        }

        public PartialViewResult _FooterNavMenu()
        {
            string asd = context.FooterMenuAktifMi.Select(i => i.footerNavMenu).ToString();
            bool footerNav = Convert.ToBoolean(asd);

            if (footerNav == true)
            {
                //Menuyu getiricez
            }
            else
            {

            }

            return PartialView();
        }

        public PartialViewResult _FooterHakkimda()
        {
            var footerHakkimda = context.HakkimdaInfoes.Select(i => new FooterHakkimdaModel()
            {
                HakkimdaBaslik = i.HakkimdaBaslik.Length > 32 ? i.HakkimdaBaslik.Substring(0, 32) + ".." : i.HakkimdaBaslik,
                HakkimdaAciklama = i.HakkimdaAciklama.Length > 255 ? i.HakkimdaAciklama.Substring(0, 250) + ".." : i.HakkimdaAciklama
            }).ToList();

            return PartialView(footerHakkimda);
        }




    }
}





/*
 SLİDER VE BLOG EKLEMEYE BU GELECEK
    
            var path = "";

            if (sliderResim != null && sliderResim.ContentLength > 0)
            {
                if (Path.GetExtension(sliderResim.FileName).ToLower() == ".jpg" ||
                    Path.GetExtension(sliderResim.FileName).ToLower() == ".png" ||
                    Path.GetExtension(sliderResim.FileName).ToLower() == ".gif" ||
                    Path.GetExtension(sliderResim.FileName).ToLower() == ".jpeg")
                {
                    path = Path.Combine(Server.MapPath("~/uploads/slider-images"), sliderResim.FileName);
                    sliderResim.SaveAs(path);
                    ViewBag.YuklemeBasarili = true;
                }
            }

     */
