namespace MoviesRestApi
{
    /// <summary>
    /// Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main.
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        /// <remarks>DO NOT change this method</remarks>
        internal static async Task Main(string[] args)
        {
            // when debudding using local Visual Studio, this method will be called passing the string "maze" as the first argument
            // when using Web IDE, debugging is not supported
            
            Console.WriteLine(await GetNumberOfMovies(args.FirstOrDefault()));
        }

        /// <summary>
        /// Gets the number of movies.
        /// </summary>
        /// <param name="s">The string to search for in the movie database</param>
        /// <returns>The value of the total field in the returned JSON object</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static async Task<int> GetNumberOfMovies(string s)
        {
            // TODO: call the API at https://2ttabq4fwk.execute-api.us-east-1.amazonaws.com/prod/search/?Title={searchTerm}
            // TODO: return the total number of movies returned
            
            /*
            Example JSON returned by the API:
            {
              "page": 1,
              "per_page": 2,
              "total": 866,
              "total_pages": 433,
              "data": [
                {
                  "Title": "Waterworld",
                  "Year": 1995,
                  "imdbID": "tt0114898"
                },
                {
                  "Title": "Waterworld",
                  "Year": 1995,
                  "imdbID": "tt0189200"
                }
              ]
            }
            */
            
            // debug is not supported in the Web IDE
            // if you are using Web IDE, switch to your local, create a dotnet console app, copy this code, and debug there
            
            throw new NotImplementedException();
        }
    }
}