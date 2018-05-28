﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class SugesstionsResponse
    {
       public string mac_adres { get; set; } // User mac adres 
       public  int suggestion_id {get; set; } // Guid_id 
       public  Boolean IsSuggestionAccepted { get; set; } // IsSuggestionAccepted
    }
    public class SuggestionGenerator
    {
        public string mac_adres { get; set; }
        public string module { get; set; } // beacon_id // Lunch/ETC
    }
}