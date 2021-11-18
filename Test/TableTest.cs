using NUnit.Framework;
using System;
using DU = DateTimeTestFramework.Utils.Utils;

namespace DateTimeTestFramework
{
    [TestFixture]
    public class TableTest: BaseTest
    {
        [Test, Order(1)]
        public void validateDateFormat()
        {
            Assert.Multiple(() =>
            {
                OutPut.ForEach(o => 
                Assert.IsTrue(DU.IsValidFormat(o.created), 
                string.Format("Date Format not valid: {0}, id: {1}", o.created, o.id)));
            });
        }

        [Test, Order(2)]
        public void verifyRangeOfMonths()
        {
            DateTime init = new DateTime(2021, 1, 1, 0, 0, 0);
            DateTime finish = new DateTime(2021, 12, 1, 0, 0, 0);

            Assert.Multiple(() =>
            {
                OutPut.ForEach(o => 
                Assert.IsTrue(DU.IsInRangeOfDays(DU.ParseStringDate(o.created), init, finish),
                string.Format("Range of month not valid: {0}, id: {1}", o.created, o.id)));
            });
        }
    }
}
