# TestePleno

## Proposta
#

Um Aplicativo Console para cadastrar uma tarifa (Fare) relacionada a uma operadora (Operator) de benefício de vale-transporte.
<br>

## Tecnologias
#
Linguagem e versão utilizada:

- C#
- .NET Core 3.1


## Informações e Configurações
#
1. Esse projeto já possui um mini banco de dados em memória e já possui alguns dados populados. Caso queira inserir mais dados para teste, basta entrar no arquivo seguinte: 

```
Repositories/Initializer.cs
```

2. A propriedade Periodo (Period) de tarifa ja vem com uma data previamente definida. Caso queira alterá-la, basta entrar no arquivo Program.cs e modificar a data da linha de codigo seguinte:

```
fare.Period = new DateTime(2022, 10, 24);
```

## Executar o projeto
#
1. Abrir o projeto em uma IDE ou em algum terminal de preferência.
2. Na raiz do projeto executar o comando: 

```
dotnet run
```
#
