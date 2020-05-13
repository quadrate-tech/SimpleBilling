﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBilling.Model
{
    public class Setting : BaseEntity
    {
        [Key]
        public int SettingsId { get; set; }

        public int UserId { get; set; }
        public string DefaultPath { get; set; }

        [DefaultValue(105)]
        public int Red { get; set; } = 105;

        [DefaultValue(105)]
        public int Green { get; set; } = 105;

        [DefaultValue(105)]
        public int Blue { get; set; } = 105;
    }
}