using Assignment_1_Movie_MVC.Models;

namespace ApplicationCore.Contracts.Services;

public interface IMovieService
{
    IEnumerable<MovieCardModel> GetTopMovies();
}