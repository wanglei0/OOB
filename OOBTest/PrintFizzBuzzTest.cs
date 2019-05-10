using OOB;
using Xunit;

namespace OOBTest
{
    public class PrintFizzBuzzTest
    {
        [Fact]
        public void Should_return_number_when_could_not_division_by_3_or_5()
        {
            Assert.Equal(Helper.FizzBuzz(1),"1"); 
        }
        
        [Fact]
        public void Should_return_fizz_when_could_division_by_3_but_not_5()
        {
            Assert.Equal(Helper.FizzBuzz(3),"Fizz"); 
        }
        
        [Fact]
        public void Should_return_number_when_could_division_by_5_but_not_3()
        {
            Assert.Equal(Helper.FizzBuzz(5),"Buzz"); 
        }
        
        [Fact]
        public void Should_return_number_when_could_division_by_3_and_5()
        {
            Assert.Equal(Helper.FizzBuzz(15 ),"FizzBuzz"); 
        }
        
        [Fact]
        public void Should_return_invaild_when_number_less_than_1_or_more_than_100()
        {
            Assert.Equal(Helper.FizzBuzz(0),"invalid"); 
            Assert.Equal(Helper.FizzBuzz(101),"invalid"); 
            
        }
    }
}