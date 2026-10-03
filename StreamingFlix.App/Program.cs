using StreamingFlix.App;

var service = new PlanoStreamingService();

Console.WriteLine($"2 telas: {service.ObterClassificacaoPorQualidade(2)}");
Console.WriteLine($"R$50 por 12 meses: R${service.CalcularMensalidadeComDesconto(50, 12)}");
Console.WriteLine($"20 anos, sem controle parental: {service.PodeAcessarConteudoAdulto(20, false)}");