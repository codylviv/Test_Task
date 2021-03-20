using Algorithm;
using Xunit;

namespace XUnitTestTasks
{
    public class AlgorithmTests
    {
        [Theory]
        [InlineData("WEAREDISCOVEREDFLEEATONCE", 3,"WECRLTEERDSOEEFEAOCAIVDEN")]
        [InlineData("HelloWorld", 4, "HoeWrlolld")]
        [InlineData("Vector Software", 5, "VoeSfc tetrwroa")]
        [InlineData("", 3, "")]
        [InlineData(null, 3, "")]
        [InlineData("empty", 1, "")]
        
        public void EncryptRailTest(string encryptText, int numberOfRails, string expected)
        {
            RailFenceCipher railFenceCipher = new RailFenceCipher();
             var actual = railFenceCipher.EncryptRail(encryptText, numberOfRails);
           
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("WECRLTEERDSOEEFEAOCAIVDEN", 3, "WEAREDISCOVEREDFLEEATONCE")]
        [InlineData("HoeWrlolld", 4, "HelloWorld")]
        [InlineData("VoeSfc tetrwroa", 5, "Vector Software")]
        [InlineData("", 3, "")]
        [InlineData(null, 3, "")]
        [InlineData("empty", 1, "")]
        public void DecryptRailTest(string decryptText, int numberOfRails, string expected)
        {
            RailFenceCipher railFenceCipher = new RailFenceCipher();
            var actual = railFenceCipher.DecryptRail(decryptText, numberOfRails);

            Assert.Equal(expected, actual);
        }
    }
}
