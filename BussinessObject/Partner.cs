﻿using System;
using System.Collections.Generic;

namespace BussinessObject
{
    public partial class Partner
    {
        public Partner()
        {
            FavoritePartners = new HashSet<FavoritePartner>();
            PartnerServices = new HashSet<PartnerService>();
            Schedules = new HashSet<Schedule>();
        }

        public int PartnerId { get; set; }
        public int? TypeId { get; set; }
        public string Code { get; set; }
        public string Email { get; set; }
        public string PartnerName { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string PracticingCertificate { get; set; }
        public int? Status { get; set; }
        public string RefreshToken { get; set; }
        public DateTime? LastLogin { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastUpdate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string ImgUrl { get; set; }

        public virtual PartnerType Type { get; set; }
        public virtual ICollection<FavoritePartner> FavoritePartners { get; set; }
        public virtual ICollection<PartnerService> PartnerServices { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}