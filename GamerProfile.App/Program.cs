using GamerProfile.App;

var service = new PerfilJogadorService();
Console.WriteLine($"Tag do jogador: {service.GerarTagUsuario("Aragorn", "1042")}");
Console.WriteLine($"XP total: {service.CalcularXPTotal(200, 300)}");
Console.WriteLine($"Elegível para ranked: {service.EEligivelParaRanked(15)}");
