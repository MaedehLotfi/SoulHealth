﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace SoulHealth.Models
{
    public class PhysicalActivity
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "پیاده روی روزانه 45 دقیقه")]
        public bool walking { get; set; }

        [Display(Name = "پیاده روی روزانه بیشتر از 45 دقیقه")]
        public bool walkingMore { get; set; }

        [Display(Name = "نرمش و حرکات کششی")]
        public bool softness { get; set; }

        [Display(Name = "پیاده روی سریع و یا دو آهسته")]
        public bool running { get; set; }

        [Display(Name = "بدنسازی و کار با وزنه")]
        public bool building { get; set; }

        [Display(Name = "آمادگی جسمانی")]
        public bool fitness { get; set; }

        [Display(Name = "فعالیت ورزشی(دوچرخه سواری،دو تردمیل و کوهنوردی...)")]
        public bool exercise { get; set; }

        [Display(Name = "سایر")]
        public bool other { get; set; }

        [Display(Name = "توضیحات")]
        public string discription { get; set; }

        [Display(Name = "شماره پرونده")]
        public int Pid { get; set; }

        [ForeignKey(nameof(Pid))]
        public Patient Person { get; set; }
    }
}