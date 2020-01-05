using Xunit;

namespace exercise_2_1_1.Tests
{
    public class SortMethodsShould
    {
        [Fact]
        public void SortArrayUsingInsertionSort()
        {
            //Arrange
            int[] inputArray = new int[] { 4, 5, 1, 3, 2, 6 };
            int[] expectedArray = new int[] { 1, 2, 3, 4, 5, 6 };

            //Act

            //Assert
            Assert.Equal(expectedArray, SortMethods.InsertionSort(inputArray));
        }
    }
}
