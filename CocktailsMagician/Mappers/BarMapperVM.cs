﻿using CocktailsMagician.Areas.Bars.Models;
using CocktailsMagician.Services.DTO_s;
using System;
using System.Linq;

namespace CocktailsMagician.Mappers
{
    public static class BarMapperVM
    {
        public static BarViewModel BarDTOtoVM(this BarDTO barDTO)
        {
            var barVM = new BarViewModel();
            barVM.Id = barDTO.Id;
            barVM.Name = barDTO.Name;
            barVM.Phone = barDTO.Phone;
            barVM.Website = barDTO.Website;
            barVM.HasWebsite = Uri.IsWellFormedUriString(barDTO.Website, UriKind.Absolute);
            barVM.Description = barDTO.Description;
            barVM.UnlistedOn = barDTO.UnlistedOn;
            barVM.Address = barDTO.Address;
            barVM.CityId = barDTO.CityId;
            barVM.City = barDTO.City;
            barVM.Latitude = barDTO.Latitude;
            barVM.Longitude = barDTO.Longitude;
            barVM.AvgRating = barDTO.AvgRating;
            if (barDTO.BarReviews !=null )
            {
                barVM.BarReviews = barDTO.BarReviews.Select(br => br.BarReviewsDTOMapToVM()).ToList();
            }
            return barVM;
        }

        public static BarDTO BarVMtoDTO(this BarViewModel barVM)
        {
            var barDTO = new BarDTO();
            barDTO.Id = barVM.Id;
            barDTO.Name = barVM.Name;
            barDTO.Phone = barVM.Phone;
            barDTO.Website = barVM.Website;
            barDTO.Description = barVM.Description;
            barDTO.UnlistedOn = barVM.UnlistedOn;
            barDTO.Address = barVM.Address;
            barDTO.Latitude = barVM.Latitude;
            barDTO.Longitude = barVM.Longitude;
            barDTO.CityId = barVM.CityId;

            return barDTO;
        }
    }
}
