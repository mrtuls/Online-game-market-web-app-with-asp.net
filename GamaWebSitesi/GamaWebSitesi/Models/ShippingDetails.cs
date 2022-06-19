using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GamaWebSitesi.Models
{
    public class ShippingDetails
    {
        public string Username { get; set; }
        [Required(ErrorMessage ="Lütfen Ad Soyad alanını boş bırakmayınız.")]
        public string AdresBasligi { get; set; }
        [Required(ErrorMessage = "Lütfen Adres Başlığını alanı boş bırakmayınız.")]
        public string Adres { get; set; }
        [Required(ErrorMessage = "Lütfen Şehir alanını boş bırakmayınız.")]
        public string Sehir { get; set; }
        [Required(ErrorMessage = "Lütfen Semt alanını boş bırakmayınız.")]
        public string Semt { get; set; }
        [Required(ErrorMessage = "Lütfen Mahalle alanını boş bırakmayınız.")]
        public string Mahalle { get; set; }
        [Required(ErrorMessage = "Lütfen Posta Kodu alanını boş bırakmayınız.")]
        public string PostaKodu { get; set; }
    }
}