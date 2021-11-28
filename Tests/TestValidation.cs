using DBMS;
using Xunit;

namespace Tests {
    public class TestValidation {
        private Column _column;

        [Fact]
        public void TestIntColumnValidation1() {
            _column = new IntColumn("");
            Assert.True(_column.Validate("42"));
        }

        [Fact]
        public void TestIntColumnValidation2() {
            _column = new IntColumn("");
            Assert.False(_column.Validate("str"));
        }

        [Fact]
        public void TestRealColumnValidation1() {
            _column = new RealColumn("");
            Assert.True(_column.Validate("234.79"));
        }

        [Fact]
        public void TestRealColumnValidation2() {
            _column = new RealColumn("");
            Assert.False(_column.Validate("234d79"));
        }

        [Fact]
        public void TestCharColumnValidation1() {
            _column = new CharColumn("");
            Assert.True(_column.Validate("C"));
        }

        [Fact]
        public void TestCharColumnValidation2() {
            _column = new CharColumn("");
            Assert.False(_column.Validate("jkg"));
        }

        [Fact]
        public void TestStringColumnValidation() {
            _column = new StringColumn("");
            Assert.True(_column.Validate("str"));
        }

        [Fact]
        public void TestIntIntervalColumnValidation1() {
            _column = new IntIntervalColumn("");
            Assert.True(_column.Validate("2, 5"));
        }

        [Fact]
        public void TestIntIntervalColumnValidation2() {
            _column = new IntIntervalColumn("");
            Assert.False(_column.Validate("6, 3"));
        }

        [Fact]
        public void TestIntIntervalColumnValidation3() {
            _column = new IntIntervalColumn("");
            Assert.False(_column.Validate("2.4, 3"));
        }
    }
}
