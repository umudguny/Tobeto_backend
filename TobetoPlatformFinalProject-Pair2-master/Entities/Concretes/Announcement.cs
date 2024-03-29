﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Announcement : Entity<Guid>
    {
        public Guid AnnouncementTypeId { get; set; }
        public string AnnouncementName { get; set; }
        public string Description { get; set; }
        public DateTime SendDate { get; set; } = DateTime.Now;

        public AnnouncementType? AnnouncementType { get; set; }
        public List<AnnouncementUser>? AnnouncementUsers { get; set; }

    }
}
