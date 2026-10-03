# GamerProfile

Lista 21 de Gestão e Qualidade de Software — Professor Daniel Henrique Matos de Paiva.

## Propósito

Serviço de perfil de jogadores desenvolvido em **C#**, com **.NET 10** e **xUnit**.

- `GerarTagUsuario(string nickname, string codigo)`: concatena nickname e código com `#`. Exemplo: `Aragorn#1042`.
- `CalcularXPTotal(int xpFase1, int xpFase2)`: soma o XP das fases e adiciona bônus fixo de 100. Para 200 e 300, retorna 600.
- `EEligivelParaRanked(int nivelJogador)`: retorna `true` para nível maior ou igual a 15 e `false` caso contrário.

## Estrutura

- `GamerProfile.slnx`: solução contendo os dois projetos.
- `GamerProfile.App`: aplicação de console, com `PerfilJogadorService.cs` e demonstração em `Program.cs`.
- `GamerProfile.Tests`: testes em `PerfilJogadorServiceTests.cs`, com referência ao projeto App.
- `.gitignore`: exclusão de arquivos gerados pelo .NET e configurações locais.
- `LICENSE`: licença MIT.

## Três tipos de testes unitários

Os três testes usam `[Fact]`:

1. **String:** `Assert.Equal("Nickname#0000", resultado)` verifica a formatação da tag e a preservação dos zeros.
2. **Int:** `Assert.Equal(600, resultado)` verifica a soma de 200 e 300 com o bônus de 100.
3. **Bool:** `Assert.True` verifica os níveis 15 e 20; `Assert.False` verifica os níveis 14 e 1, cobrindo o limite e níveis acima e abaixo dele.

## Execução

Com o SDK do .NET 10 instalado, abra o terminal na pasta `gamer-profile-xunit` e execute:

```sh
dotnet build
dotnet test
```

Resultado esperado: **3 testes aprovados e 0 falhas**. A primeira execução restaura os pacotes NuGet automaticamente e requer acesso à internet.

Para executar a demonstração:

```sh
dotnet run --project GamerProfile.App
```

## Autor

**Cláudio Martins Camilo**  
**RA: 325131832**

## Licença

MIT. Consulte `LICENSE`.
