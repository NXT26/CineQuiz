using RestSharp;

namespace cinequiz.Models;

public class ApiGetter
{

    RestClientOptions options = new RestClientOptions("https://api.themoviedb.org/3/movie/popular?language=en-US&page=1");
    RestClient client = new RestClient(options);
    RestRequest request = new RestRequest("");
    request.AddHeader("accept", "application/json");
    request.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiI0YTMyNGI2NzZhNDZmMGU2MGU1YmUyMTExYjNlZDIzZCIsInN1YiI6IjY1NjQ0OTI4MjQ0MTgyMDBhZDVmNDlhZCIsInNjb3BlcyI6WyJhcGlfcmVhZCJdLCJ2ZXJzaW9uIjoxfQ.BMiDQfyMV0prG4FHTzryMH9ajvgXmvR9XlKMmVOCCyY");
    RestResponse response = await client.GetAsync(request);

    Console.WriteLine("{0}", response.Content);

}