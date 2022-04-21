using Microsoft.VisualStudio.TestTools.UnitTesting;

using LibrairieClasses_Test;
namespace UnitTestLibrairieClasses_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestChemin1()
        {
            // chemin 2-4, 5, 18
            int[] tableau = new int[1] { 0 };
            int nombre = 1;
            Util.triCroissantVecteur(ref tableau, nombre);
            int[] tableauAttendu = new int[1] { 0 };
            CollectionAssert.AreEqual(tableauAttendu, tableau);
        }

        [TestMethod]
        public void TestChemin2()
        {
            // chemin 1-4,	5,	6-7,	8,	11,	17,	5,	18
            int[] tableau = new int[2] { 0, 1 };
            int nombre = 2;
            Util.triCroissantVecteur(ref tableau, nombre);
            int[] tableauAttendu = new int[2] { 0, 1 };
            CollectionAssert.AreEqual(tableauAttendu, tableau);
        }

        [TestMethod]
        public void TestChemin3()
        {
            // chemin 1-4,	5,	6-7,	8,	11,	12-16,	17,	5, 18
            int[] tableau = new int[2] { 2, 1 };
            int nombre = 2;
            Util.triCroissantVecteur(ref tableau, nombre);
            int[] tableauAttendu = new int[2] { 1, 2 };
            CollectionAssert.AreEqual(tableauAttendu, tableau);
        }

        [TestMethod]
        public void TestChemin4()
        {
            // chemin 1-4,	5,	6-7,	8,	9,	10�, 8, 11, 17, 5, 18
            // le test fait plut�t le chemin 1-4,	5,	6-7,	8,	9,	10�, 8, 11, 17, 5, 6-7, 8, 11, 17, 5, 18
            int[] tableau = new int[3] { 1, 2, 3 };
            int nombre = 3;
            Util.triCroissantVecteur(ref tableau, nombre);
            int[] tableauAttendu = new int[3] { 1, 2, 3 };
            CollectionAssert.AreEqual(tableauAttendu, tableau);
        }

        [TestMethod]
        public void TestChemin5()
        {
            // chemin 1-4,	5,	6-7,	8,	9	10, 10�, 8, 11, 17,  5, 18
            // le test fait plut�t le chemin 1-4,5,6-7,8,9,10,10',8,11,12-16,17,5,6-7,8,11,12-16,17,5,18
            int[] tableau = new int[3] { 2, 3, 1 };
            int nombre = 3;
            Util.triCroissantVecteur(ref tableau, nombre);
            int[] tableauAttendu = new int[3] { 1, 2, 3 };
            CollectionAssert.AreEqual(tableauAttendu, tableau);
        }
    }
}
