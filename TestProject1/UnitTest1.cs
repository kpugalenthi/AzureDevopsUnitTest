namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int i = 0;
            bool result = false;
            if (i == 0) result = true;
            Assert.True(result,"value should be equal to 0");
        }
    }
}