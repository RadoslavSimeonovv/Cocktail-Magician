﻿using CocktailsMagician.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CocktailsMagician.Areas.Cocktails.Models
{
    public class CocktailViewModel_Original
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Cocktail name")]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Cocktail description")]
        public string Description { get; set; }

        [DisplayName("Unlisted")]
        public DateTime? UnlistedOn { get; set; }

        [DisplayName("Average rating")]
        public double AvgRating { get; set; }

        public ICollection<CocktailReview> CocktailReviews { get; set; }
    }
}
