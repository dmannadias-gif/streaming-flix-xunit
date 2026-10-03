using Xunit;
using StreamingFlix.App; // Ajuste o namespace caso o projeto principal tenha um nome diferente

public class PlanoStreamingServiceTests
{
    // ==========================================
    // TAREFA 2 - Teste 1: Classificação de Planos
    // ==========================================
    [Theory]
    [InlineData(1, "BÁSICO")]
    [InlineData(2, "PADRÃO")]
    [InlineData(4, "PREMIUM")]
    public void ObterClassificacaoPorQualidade_DeveRetornarPlanoCorreto(int telasSimultaneas, string planoEsperado)
    {
        // Arrange
        var service = new PlanoStreamingService();

        // Act
        var resultado = service.ObterClassificacaoPorQualidade(telasSimultaneas);

        // Assert
        Assert.Equal(planoEsperado, resultado);
    }

    // ==========================================
    // TAREFA 2 - Teste 2: Cálculo de Desconto
    // ==========================================
    [Theory]
    [InlineData(50, 1, 50)]  // Sem desconto
    [InlineData(50, 6, 45)]  // 10% de desconto
    [InlineData(50, 12, 40)] // 20% de desconto
    public void CalcularMensalidadeComDesconto_DeveRetornarValorCorreto(int valorBase, int mesesContratados, int valorEsperado)
    {
        // Arrange
        var service = new PlanoStreamingService();

        // Act
        var resultado = service.CalcularMensalidadeComDesconto(valorBase, mesesContratados);

        // Assert
        Assert.Equal(valorEsperado, resultado);
    }

    // ==========================================
    // TAREFA 2 - Teste 3: Validação de Acesso
    // ==========================================
    [Theory]
    [InlineData(20, false, true)]  // Maior de idade, sem restrição -> true
    [InlineData(20, true, false)]  // Maior de idade, com restrição -> false
    [InlineData(16, false, false)] // Menor de idade -> false
    public void PodeAcessarConteudoAdulto_DeveRetornarPermissaoCorreta(int idade, bool controleParentalAtivo, bool acessoEsperado)
    {
        // Arrange
        var service = new PlanoStreamingService();

        // Act
        var resultado = service.PodeAcessarConteudoAdulto(idade, controleParentalAtivo);

        // Assert
        Assert.Equal(acessoEsperado, resultado);
    }
}