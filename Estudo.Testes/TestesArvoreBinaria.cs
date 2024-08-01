using Estudo.Console.BuscaBinaria;

namespace Estudo.Testes
{
    public class TestesArvoreBinaria
    {
        //Testes ArvoreBinaria
        [Theory]
        [InlineData(100)]
        [InlineData(50)]
        [InlineData(30)]
        [InlineData(70)]
        [InlineData(20)]
        [InlineData(40)]
        [InlineData(60)]
        public void AoBuscarValoresDeveRetornarTrue(int valorBuscado)
        {
            var buscaBinaria = new BuscaArvoreBinaria();

            buscaBinaria.Insert(100);
            buscaBinaria.Insert(50);
            buscaBinaria.Insert(30);
            buscaBinaria.Insert(70);
            buscaBinaria.Insert(20);
            buscaBinaria.Insert(40);
            buscaBinaria.Insert(60);
            buscaBinaria.Insert(80);

            Assert.True(buscaBinaria.Search(valorBuscado));
            Assert.True(buscaBinaria.Search(valorBuscado));
        }
    }
}