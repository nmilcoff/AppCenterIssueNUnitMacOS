using AppCenterIssue.Core;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public async Task TestCase()
        {
            var myClass = new MyClass();
            var result = await myClass.MyMethod();
            Assert.NotNull(result);
        }
    }
}
