using SmartHomeManager;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var plusService = new PlusService();

            var a = 1;
            var b = 2;
            var result = plusService.Sum(a, b);

            Assert.Equal(3, result);
        }
    }
}