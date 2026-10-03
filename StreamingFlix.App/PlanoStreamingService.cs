namespace StreamingFlix.App;

public class PlanoStreamingService
{
    public string ObterClassificacaoPorQualidade(int telasSimultaneas)
    {
        return telasSimultaneas switch
        {
            1 => "BÁSICO",
            2 => "PADRÃO",
            >= 4 => "PREMIUM",
            _ => throw new ArgumentOutOfRangeException(
                nameof(telasSimultaneas),
                "Quantidade de telas sem plano correspondente.")
        };
    }

    public int CalcularMensalidadeComDesconto(int valorBase, int mesesContratados)
    {
        if (mesesContratados >= 12)
            return valorBase * 80 / 100;

        if (mesesContratados >= 6)
            return valorBase * 90 / 100;

        return valorBase;
    }

    public bool PodeAcessarConteudoAdulto(int idade, bool controleParentalAtivo)
    {
        return idade >= 18 && !controleParentalAtivo;
    }
}