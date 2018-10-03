﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AtriaNotificationApp.BL.Models
{
    public class Announcement
    {
        public Announcement()
        {
            Content = new List<Content>();
        }

        public List<Content> Content { get; set; }

        public string Title { get; set; }

        public string Img { get; set; }

        public string Description { get; set; }

        public DateTime PostedDate { get; set; }
    }
}
