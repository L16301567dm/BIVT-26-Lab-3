namespace Lab3test
{
    [TestClass]
    public sealed class PurpleTest
    {
        Lab3.Purple _main = new Lab3.Purple();
        private const double E = 0.0001;

        [TestMethod]
        public void Test5()
        {
            // Arrange
            var input = new int[,] {
                { 0, 1, 2, 3, 5, 10, 15, 11, 20, 10 },
                { 1, 2, 3, 5, 10, 5, 0, 11, 10, 20 }
            };
            var answer = new double[] { 5, 5, 0, 55, 92.5, 55, 0, 92.5, 100, 100 };
            var test = new double[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task5(input[0, i], input[1, i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
    }
}
