using Estudo.Console.BuscaBinaria;

namespace Estudo.Testes
{
    public class TestesArvoreBinaria
    {
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

            buscaBinaria.Inserir(100);
            buscaBinaria.Inserir(50);
            buscaBinaria.Inserir(30);
            buscaBinaria.Inserir(70);
            buscaBinaria.Inserir(20);
            buscaBinaria.Inserir(40);
            buscaBinaria.Inserir(60);
            buscaBinaria.Inserir(80);

            Assert.True(buscaBinaria.Buscar(valorBuscado));
            Assert.True(buscaBinaria.Buscar(valorBuscado));
            Assert.False(buscaBinaria.Buscar(2000));
        }
    }
}