using System;
using Xunit;
using App;

namespace AppTests
{
    public class ValidatorTests
    {
        private bool InputTest(string test)
        {
            IValidator validator = new Validator();
            return validator.IsSequenceValid(test);
        }
        [Fact]
        public void IsSequenceValidValidInputSimple1()
        {
            Assert.True( InputTest("(){}[]"));
        }
        [Fact]
        public void IsSequenceValidValidInputArranged1()
        {
            IValidator validator = new Validator();
            Assert.True( InputTest("[{()}](){}"));
        }

        [Fact]
        public void IsSequenceValidIncompleteInput()
        {
            IValidator validator = new Validator();
            Assert.False( InputTest("[]{()"));
        }
        [Fact]
        public void IsSequenceValidOutOfOrder()
        {
            IValidator validator = new Validator();
            Assert.False(InputTest("[{)]"));
        }

        [Fact]
        public void IsSequenceValidAcceptOnlyValidChars()
        {
            IValidator validator = new Validator();
            Assert.Throws<ArgumentException>(() => InputTest("[{)]a"));
        }

        [Fact]
        public void IsSequenceValidAcceptEmptyString()
        {
            IValidator validator = new Validator();
            Assert.True(InputTest(""));
        }
        [Fact]
        public void IsSequenceValidInputCantBeNull()
        {
            IValidator validator = new Validator();
            Assert.Throws<ArgumentNullException>(() => InputTest(null));
        }

    }
}
