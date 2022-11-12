using Banque;
using Xunit.Sdk;

namespace BanqueTests
{
    [TestClass]
    public class CompteBancaireTest
    {
        [TestMethod]
        public void VerifierDebitCompteCorrect()
        {
            // Ouvrir un compte
            double soldeInitial = 500000;
            double montantDebit = 400000;
            double soldeAttendu = 100000;
            var compte = new CompteBancaire("Pr. Abdoulaye Dianka", soldeInitial);

            // Debiter
            compte.Debiter(montantDebit);

            //Tester
            double soldeObtenu = compte.Balance;
            Assert.AreEqual(soldeAttendu, soldeObtenu, 0.001, "Compte d�bit� incorrectement");
        }

        [TestMethod]
        public void DebiterMontantSuperieurSoldeLeveArgumentOutOfRange()
        {
            double soldeInitial = 500000;
            double montantDebit = 900000;
            //double soldeAttendu = 100000;
            var compte = new CompteBancaire("Pr. Abdoulaye Dianka", soldeInitial);

            // Debiter
            compte.Debiter(montantDebit);

            //Tester
            double soldeObtenu = compte.Balance;
            Assert.AreEqual(soldeInitial, "Exception Argument out of range");
        }
        
    }
}