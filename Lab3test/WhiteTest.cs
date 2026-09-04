namespace Lab3test
{
    [TestClass]
    public sealed class WhiteTest
    {
        Lab3.White _main = new Lab3.White();
        private const double E = 0.0001;

        [TestMethod]
        public void Test5()
        {
            // Arrange
            var input = new int[,] {
                { 0, 1, 2, 3, 5, 10, 10, 10, 12, 25 },
                { 0, 1, 2, 3, 5,  1,  2,  3,  1,  0 }
            };
            var answer = new double[] { 0, 1, 12.566371, 3.897114, 0, 100, 314.159265, 43.30127, 144, 0 };
            var test = new double[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task5(input[0, i], input[1, i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i], E);
            }
        }
    }
}
