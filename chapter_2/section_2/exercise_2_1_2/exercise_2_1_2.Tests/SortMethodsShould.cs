using Xunit;

namespace exercise_2_1_2.Tests
{
    public class SortMethodsShould
    {
        [Fact]
        public void SortByDescending()
        {
            //Arrange
            int[] inputArray = new int[] { 31, 41, 59, 26, 41, 58 };
            int[] expectedArray = new int[] { 59, 58, 41, 41, 31, 26 };

            //Act

            //Assert
            Assert.Equal(SortMethods.InsertionSortByDescending(inputArray), expectedArray);
        }
    }
}
