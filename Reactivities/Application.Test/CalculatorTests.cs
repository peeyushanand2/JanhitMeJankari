using System.Reflection;

namespace Application.Test
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator;
        public CalculatorTests()
        {
                _calculator = new Calculator();
        }
        [Fact]
        public void Add_ShouldReturnCurrectSum()
        {
            //Arrange 
            int a = 1, b = 5;
          
            //Act
         int res=  _calculator.Add(a, b);

            //Assert
            Assert.Equal(6, res);
        }

        [Fact]
        public void Private_Divide_test()
        {  
           var myClassInfo=new Calculator();
           var privateMethodInfo = typeof(Calculator).GetMethod("Divide",
                                         BindingFlags.NonPublic | BindingFlags.Instance);
            if (privateMethodInfo == null) 
            {
                throw new Exception("Private mthod 'Divide' not found");
            }
        
            var result = (double)privateMethodInfo.Invoke(myClassInfo, new object[] { 4, 2 });
            Assert.Equal(2, result);
        }
    }
}