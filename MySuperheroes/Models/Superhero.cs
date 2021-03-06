﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MySuperheroes.Models
{
    public class Superhero
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Superhero Name")]  // Changes how name appears on website
        public string SuperName { get; set; }
        public string AlterEgo { get; set; }
        public string PrimaryAbility { get; set; }
        public string SecondaryAbility { get; set; }
        public string CatchPhrase { get; set; }

    }
}
