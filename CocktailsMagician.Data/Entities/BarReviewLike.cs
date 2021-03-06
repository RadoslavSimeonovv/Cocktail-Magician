﻿using System;

namespace CocktailsMagician.Data.Entities
{
    public class BarReviewLike
    {
        public Guid BarReviewId { get; set; }
        public BarReview BarReview { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public bool IsLiked { get; set; }
        public bool IsInappropriate { get; set; }
    }
}
