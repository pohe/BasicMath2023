using BasicMath2023;

namespace TestBasicMath2023
{
    [TestClass]
    public class BasicMathTest
    {
        [TestMethod]
        public void Add_10added30()
        {
            //Arrange
            BasicMath bm = new BasicMath();

            //Act
            int addResult = bm.Add(10, 30);

            //Assert
            Assert.AreEqual(40, addResult);
        }

        [TestMethod]
        
        public void Divide_10dividby2()
        {
            //Arrange
            BasicMath bm = new BasicMath();

            //Act
            int divResult = bm.Divide(10, 2);

            //Assert
            Assert.AreEqual(5, divResult);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_DivideByZero()
        {
            //Arrange
            BasicMath bm = new BasicMath();

            //Act
            int divResult = bm.Divide(10, 0);

            //Assert
            
        }

    }
}