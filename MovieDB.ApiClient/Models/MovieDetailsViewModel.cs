﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDB.ApiClient.Models
{
    public class MovieDetailsViewModel
    {
        public Movie movie { get; set; }
        public ApiVideosResult videos { get; set; }
        public ApiCreditsResult credits { get; set; }
    }
}
