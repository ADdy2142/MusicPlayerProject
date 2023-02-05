﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace MusicPlayerProject.Models
{
    public class Music
    {
        public BitmapImage Cover { get; set; }
        public string Title { get; set; }
        public string Caption { get; set; }
        public string Duration { get; set; }
        public string Source { get; set; }
    }
}