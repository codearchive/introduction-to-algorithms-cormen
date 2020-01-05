using Xunit;

namespace exercise_2_2_2.Tests
{
    public class SortMethodShould
    {
        [Fact]
        public void ReturnSortedArrayUsingSelectionSort()
        {
            //Arrange
            int[] inputArray = new int[] { 5, 6, 4, 2, 1, 3 };
            int[] expectedSortedArray = new int[] { 1, 2, 3, 4, 5, 6 };

            //Act

            //Assert
            Assert.Equal(expectedSortedArray, SortMethod.SelectionSort(inputArray));
        }
    }
}
