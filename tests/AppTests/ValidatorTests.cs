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
            return validator.IsSequenceValid("(){}[]");
        }
        [Fact]
        public void IsSequenceValidValidInputSimple1()
        {
            Assert.Equal(InputTest("(){}[]"), true);
        }
        [Fact]
        public void IsSequenceValidValidInputArranged1()
        {
            IValidator validator = new Validator();
            Assert.Equal(InputTest("[{()}](){}"), true);
        }

        [Fact]
        public void IsSequenceValidIncompleteInput()
        {
            IValidator validator = new Validator();
            Assert.Equal(InputTest("[]{()"), true);
        }
        [Fact]
        public void IsSequenceValidOutOfOrder()
        {
            IValidator validator = new Validator();
            Assert.Equal(InputTest("[{)]"), false);
        }

        [Fact]
        public void IsSequenceValidDoesntAcceptOnlyInvalidChars()
        {
            IValidator validator = new Validator();
            Assert.Throws<ArgumentException>(() => InputTest("[{)]a"));
        }

        [Fact]
        public void IsSequenceValidInputCantBeNull()
        {
            IValidator validator = new Validator();
            Assert.Throws<ArgumentNullException>(() => InputTest(null));
        }

    }
}
