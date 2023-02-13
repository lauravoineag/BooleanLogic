using ConsoleApp2;

namespace TestProject1;

public class Tests
{
    [Test]
    public void test1()
    {
        //Arrange
        Solution solution= new ();
        
        //Act
        var actual = solution.CalculateSolution("FooBar123!");
        var expected = true;
        //Assert
        Assert.AreEqual(expected,actual);
    }
    
        [Test]
        public void test2()
        {
            //Arrange
            Solution solution= new ();
            
            //Act
            var actual = solution.CalculateSolution("fooBar123!");
            var expected = true;
            //Assert
            Assert.AreEqual(expected,actual);
        }
}