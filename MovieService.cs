using ApplicationCore.Contracts.Services;
using Assignment_1_Movie_MVC.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Collections.Generic;

namespace Infrasturcture.Services;
public class MovieService: IMovieService
{
    public IEnumerable<MovieCardModel> GetTopMovies()
    {
        return new List<MovieCardModel>
        {
            new MovieCardModel { Id = 1, Title = "Inception", PosterUrl = "/images/inception.jpg" },
            new MovieCardModel { Id = 2, Title = "Interstellar", PosterUrl = "/images/interstellar.jpg" },
            new MovieCardModel { Id = 3, Title = "The Matrix", PosterUrl = "/images/matrix.jpg" }
        };
    }
}