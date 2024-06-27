using L12_Unit_tests;

namespace L12_Unit_tests_testing
{
    public class Test_Kalkulacka
    {
        [Fact]
        public void Kalkulacka_secte_spravne_dve_cisla()
        {
            Assert.Equal(2, Kalkulacka.Secti(1, 1));
            Assert.NotEqual(2, Kalkulacka.Secti(-1, 1));
        }



        [Fact]
        public void Kalkulacka_vydeli_spravne_dve_cisla()
        { 
            Assert.Equal(2, Kalkulacka.Vydel(4, 2));
            Assert.NotEqual(2, Kalkulacka.Vydel(4, -2));
        }

        [Fact]
        public void Kalkulacka_vyhod_vyjimku_pri_deleni_nulou()
        {
            Assert.Throws<DivideByZeroException>(() => Kalkulacka.Vydel(10, 0));
        }
    }
}