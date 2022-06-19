using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GamaWebSitesi.Entity
{
    public enum EnumOrderState
    {   
        [Display(Name ="Onay Bekleniyor")]
        Waiting,
        [Display(Name = "Onaylandı")]
        Completed
    }
}