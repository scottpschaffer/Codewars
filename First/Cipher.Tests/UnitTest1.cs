using System;
using Xunit;
using Cipher;
 
namespace Cipher.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("HM1QA", Program.Encode("He1lo"));
        }
 
        [Fact]
        public void Test2()
        {
            Assert.Equal("HE1LO", Program.Decode("HM1QA"));
        }
 
        [Fact]
        public void Test3()
        {
            Assert.Equal("5DDC4DDF-7A47-44D3-8EDA-3171860DC938", Program.Decode("5DHG4GHJ-7G47-44E3-8IIE-3171860EG938"));
        }
 
        [Fact]
        public void Test4()
        {
            Assert.Equal("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG", Program.Decode("TBM VLDLN mTGLK TUM HEHCI HKAW LBM QMAY CSV"));
        }
 
        [Fact]
        public void Test5()
        {
            Assert.Equal("5DHG4GHJ-7G47-44E3-8IIE-3171860EG938", Program.Encode("5ddc4ddf-7a47-44d3-8eda-3171860dc938"));
        }
 
        [Fact]
        public void Test6()
        {
            Assert.Equal("TBM VLDLN MTGLK TUM HEHCI HKAW LBM QMAY CSV", Program.Encode("The quick brown fox jumps over the lazy dog"));
        }
 
        [Fact]
        public void Test7()
        {
            Assert.Equal("5115D0E8-BF6I-40H6-80I3-34K2GE2E9185", Program.Encode("5115D0A8-AE6D-40D6-80E3-34F2AD2A9185"));
        }
 
        [Fact]
        public void Test8()
        {
            Assert.Equal(" ", Program.Encode(" "));
        }
 
        [Fact]
        public void Test9()
        {
            Assert.Equal("", Program.Encode(""));
        }
    }
}