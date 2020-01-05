using Xunit;

namespace exercise_2_1_3.Tests
{
    public class SearchElementShould
    {
        [Fact]
        public void ReturnIndex()
        {
            //Arrange
            int[] inputArray = new int[] { 5, 6, 4, 3, 1, 9 };
            int value = 6;

            //Act

            //Assert
            Assert.Equal(4, SearchElement.SearchIndex(value, SearchElement.InsertionSort(inputArray)));
        }
    }
}
