TolyID: Sistema de Cadastro de Tatubola

Descrição do Projeto:
O TolyID é um sistema web de cadastro e monitoramento de populações de tatubolas, desenvolvido para facilitar a pesquisa científica e a conservação dessas espécies. Ele permite o registro detalhado de espécies e indivíduos, incluindo características físicas, localização, e status de conservação. Com funcionalidades avançadas como geolocalização, geração de relatórios e um aplicativo móvel, o TolyID é uma ferramenta essencial para pesquisadores e conservacionistas.

🚀 Começando
-

Essas instruções permitirão que você obtenha uma cópia do projeto em operação na sua máquina local para fins de desenvolvimento e teste.

Consulte Implantação para saber como implantar o projeto.

📋 Pré-requisitos
-

De que coisas você precisa para instalar o software e como instalá-lo?

Git: Para clonar o repositório.

Visual Studio Code: Para desenvolvimento.

.NET Core SDK: Para rodar o backend em C#.

Node.js: Para rodar o frontend em JavaScript.

PostgreSQL: Para o banco de dados.

Extensão Live Server: Para Visual Studio Code.

🔧 Instalação
-

Uma série de exemplos passo-a-passo que informam o que você deve executar para ter um ambiente de desenvolvimento em execução.

1. Clonar o Repositório

```
gh repo clone gabrielgjsc/TolyID

cd tolyid
```

2. Configurar o Backend

• Abra o Visual Studio Code e carregue a pasta do projeto.

• Instale as dependências do projeto:

```
dotnet restore
```

• Configure a conexão com o banco de dados PostgreSQL no arquivo appsettings.json.

• Execute as migrações do banco de dados:

```
dotnet ef database update
```

• Inicie o servidor:

```
dotnet run
```

3. Configurar o Frontend

• Abra a pasta do frontend no Visual Studio Code.

• Instale as dependências:

```
cd frontend

npm install
```

• Inicie o servidor de desenvolvimento com a extensão Live Server:

• Abra o arquivo index.html no Visual Studio Code.

• Clique com o botão direito e selecione "Open with Live Server".

⚙️ Executando os testes
-

Testes Backend:

```
dotnet test
```

Testes Frontend:

```
cd frontend

npm test
```

🔩 Analise os testes de ponta a ponta
-


Os testes de ponta a ponta verificam a integração entre diferentes componentes do sistema, garantindo que o fluxo de dados e a funcionalidade estejam funcionando conforme esperado.


1. Testes de Integração

```
dotnet test IntegrationTests
```

⌨️ E testes de estilo de codificação
-

Os testes de estilo de codificação garantem que o código siga os padrões estabelecidos, mantendo a legibilidade e a consistência.

1. Linting

```
npm run lint
```

📦 Implantação
-

• Servidor de Produção

  • Configure as variáveis de ambiente no servidor.

  • Execute as migrações do banco de dados.

  • Use um servidor web (como Nginx) para servir o frontend e configurar o backend.

🛠️ Construído com
-

.NET Core - Framework web usado para o backend

JavaScript - Linguagem usada para o frontend

PostgreSQL - Banco de dados usado

Live Server - Extensão usada para desenvolvimento frontend no Visual Studio Code

HTML e CSS - Tecnologias usadas para o design e estrutura do frontend


📌 Versão
-

Nós usamos GitHub para controle de versão. Para as versões disponíveis, observe as tags neste repositório.

✒️ Autores
-

Gabriel de Jesus Souza Cesário - FrontEnd - gjesussouzacesario@gmail.com

Brunno Brito Pinto -  Banco de Dados - brunno.britopinto@gmail.com 

Vinicius Caliman Bossois  – Banco de Dados – viniciusbossois@gmail.com

Davi de Andrade Marconsini - Desenvolvimento - ddan54890@gmail.com 

Raphael Turino Torres - Desenvolvimento - raphaelturinotorres@gmail.com 


📄 Licença
-

🎁 Expressões de gratidão
-

Conte a outras pessoas sobre este projeto 📢;

Convide um conservacionista para uma caminhada na natureza 🌳;

Faça um agradecimento publicamente;

Doe para uma instituição de conservação ambiental 🌍;


⌨️ com ❤️ por TolyID Team 😊