namespace Tests
{
    public class GetTotalsFixture
    {
        [Theory]
        [InlineData("maze", 37)]
        [InlineData("harry", 226)]
        [InlineData("potter", 77)]
        [InlineData("sin", 282)]
        [InlineData("walk", 277)]
        public async void Test1(string s, int expected)
        {
            // Act
            var numberOfMovies = await MoviesRestApi.Program.GetNumberOfMovies(s);

            // Assert
            Assert.Equal(expected, numberOfMovies);
        }
    }
}