using DictionaryLibrary;
using System;
using Xunit;

namespace XUnitTestDictionary
{
    public class MyClassUnitTest
    {
        [Fact]
        public void MethodAddKeyValueTest()
        {
            int key = 1;
            string val = "test";
            int expected = 1;


            MyClass test = new MyClass();
            test.Add(key, val);
            int actual = test.MyDictionary.Count;

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void MethodGetValueTest()
        {
            MyClass test = new MyClass();
            test.Add(1, "test");
            string expected = $"key:1--> val:test";

            string actual = test.GetValue(1);

            Assert.Equal(expected, actual);
        
        }
        
        [Fact]
        public void MethodRemoveTest()
        {
            MyClass test = new MyClass();
            test.Add(1, "test");
            int expected = 0;

            test.Remove(1);
            int actual = test.MyDictionary.Count;

            Assert.Equal(expected, actual);

        }
    }
}
