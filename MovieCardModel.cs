using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Assignment_1_Movie_MVC.Models;

public class MovieCardModel
{ 
        public int Id { get; set; }
        public string Title { get; set; }
        public string PosterUrl { get; set; }
}