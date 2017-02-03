using FoodService.Models;
using System.ComponentModel.DataAnnotations;

namespace FoodService.ViewModels
{
    public class RestaurantEditViewModel
    {
        [Required, MaxLength(80)]
        public string Name { get; set; }
        public CuisineType Cuisine{ get; set; }
    }
}
