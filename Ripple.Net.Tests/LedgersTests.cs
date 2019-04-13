using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Ripple.Net.Tests
{
    [TestClass]
    public class LedgersTests
    {
        [TestMethod]
        public async Task GetLedgerAsyncTest()
        {
            Ledgers ledgers = new Ledgers();
            Ledger ledger = await ledgers.GetLedgerAsync("3170DA37CE2B7F045F889594CBC323D88686D2E90E8FFD2BBCD9BAD12E416DB5");

            Assert.IsNotNull(ledger);
            Assert.IsTrue(ledger.Accepted);
            Assert.AreEqual("8AD73E49A34D8B9C31BC13B8A97C56981E45EE70225EF4892E8B198FEC5A1F7D", ledger.AccountHash);
        }

        [TestMethod]
        public async Task GetLedgerAsyncFailTest()
        {
            Ledgers ledgers = new Ledgers();

            await Assert.ThrowsExceptionAsync<LedgerException>(() => 
                ledgers.GetLedgerAsync("3170DA37CE2B7F045F889594CBC323D88686D2E90E8FFD2BBCD9BAD12E416DB6"));
        }
    }
}
