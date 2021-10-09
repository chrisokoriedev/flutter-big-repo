﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Notes.API.Models.Entities
{
    [Table(nameof(APIKey))]
    public class APIKey
    {
        public string ID { get; set; }

        public List<Note> Notes { get; set; }
    }
}
