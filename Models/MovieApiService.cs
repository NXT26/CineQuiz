using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace cinequiz.Models;

public class MovieApiService
{
    private readonly HttpClient _client;

    public MovieApiService()
    {
        _client = new HttpClient();
        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiI0YTMyNGI2NzZhNDZmMGU2MGU1YmUyMTExYjNlZDIzZCIsInN1YiI6IjY1NjQ0OTI4MjQ0MTgyMDBhZDVmNDlhZCIsInNjb3BlcyI6WyJhcGlfcmVhZCJdLCJ2ZXJzaW9uIjoxfQ.BMiDQfyMV0prG4FHTzryMH9ajvgXmvR9XlKMmVOCCyY");
        _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }
    // Получить список фильмов
    public async Task<string> GetMovieListAsync(string listType, int pageNumber)
    {
        var requestUri = listType == "popular"
            ? $"https://api.themoviedb.org/3/movie/popular?language=en-US&page={pageNumber}"
            : $"https://api.themoviedb.org/3/movie/top_rated?language=en-US&page={pageNumber}";

        var response = await _client.GetAsync(requestUri);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }
    
    // Получить детальную информацию по фильму
    public async Task<string> GetMovieDetailsAsync(int movieId)
    {
        var requestUri = $"https://api.themoviedb.org/3/movie/{movieId}?language=en-US";
        var response = await _client.GetAsync(requestUri);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    // Получить изображение
    public string GetImageUrl(string imagePath)
    {
        return $"https://image.tmdb.org/t/p/w500{imagePath}";
    }
}
