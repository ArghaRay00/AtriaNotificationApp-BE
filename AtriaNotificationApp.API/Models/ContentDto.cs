﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtriaNotificationApp.API.Models
{
    public class ContentDto
    {
        public ContentDto()
        {
            PostedBy = new AnnouncerDto();
        }

        public string Title { get; set; }

        public DateTime Posted { get; set; }

        public string Image { get; set; }

        public AnnouncerDto PostedBy { get; set; }

        public string Description { get; set; }

        public bool IsApproved { get; set; }

        public bool IsActive { get; set; }
    }
}
