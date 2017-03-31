﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppDB.Models
{
    public class Token
    {
        public int ID { get; set; }
        public string access_token { get; set; }
        public string error_description { get; set; }
        public DateTime expire_date { get; set; }

        public Token() {
        }
    }
}
