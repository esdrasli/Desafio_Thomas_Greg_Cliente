# Desafio_Thomas_Greg

# Documenta��o do Projeto

## Aplica��es Principais

###	Aplica��o Backend (API REST):
A aplica��o backend � respons�vel por fornecer os servi�os e funcionalidades para os clientes por meio de uma API RESTful. Ela ser� desenvolvida utilizando C# com ASP.NET Core, e ser� hospedada em um servidor web, como o IIS (Internet Information Services).

###	Aplica��o Frontend (Interface do Usu�rio):
A aplica��o frontend consiste na interface com a qual os usu�rios interagem para realizar opera��es como criar, atualizar, visualizar e remover clientes e logradouros. Ela pode ser desenvolvida utilizando ASP.NET Core MVC para renderiza��o de p�ginas HTML tradicionais com Razor.

###	Banco de Dados:
O banco de dados � uma aplica��o fundamental que armazena e gerencia os dados da aplica��o, como informa��es de clientes e logradouros. Para este projeto, ser� utilizado o SQL Server como sistema de gerenciamento de banco de dados relacional. O SQL Server ser� acessado pela aplica��o backend para realizar opera��es de leitura e grava��o de dados.

###	Servi�os de Terceiros:
A solu��o pode depender de servi�os externos, como servi�os de armazenamento em nuvem (por exemplo, AWS S3, Azure Blob Storage), para fornecer funcionalidades adicionais e complementares, principalmente para armazenamento dos logotipos.

Al�m das aplica��es principais mencionadas anteriormente, algumas aplica��es de apoio podem ser necess�rias para facilitar o desenvolvimento, teste e opera��o da solu��o. Aqui est�o algumas das aplica��es de apoio comumente utilizadas:

## Aplica��es de Apoio

### �	Visual Studio 2019/2022
IDEs (Integrated Development Environments) populares para desenvolvimento de software em plataforma Microsoft. Elas oferecem recursos avan�ados de edi��o de c�digo, depura��o, controle de vers�o e integra��o com outras ferramentas de desenvolvimento.

### �	SQL Server Management Studio (SSMS):
SSMS � uma ferramenta de gerenciamento e administra��o para o SQL Server. Ela permite realizar tarefas como criar e gerenciar bancos de dados, escrever consultas SQL, configurar seguran�a e monitorar o desempenho do banco de dados.

### �	Postman/Insomnia:
Ferramentas de colabora��o para o desenvolvimento de APIs. Ela permite testar, depurar e documentar APIs de forma eficiente, facilitando a intera��o com os endpoints da API, envio de solicita��es HTTP e visualiza��o das respostas.
### �	Swagger / OpenAPI:
Swagger � uma ferramenta de documenta��o de API que permite descrever, documentar e testar APIs de forma interativa. Ela gera automaticamente documenta��o para a API com base em um arquivo de especifica��o OpenAPI (anteriormente conhecido como Swagger Specification).

### �	Docker:
Docker � uma ferramenta que permite criar, gerenciar e executar cont�ineres em um ambiente de desenvolvimento local. Ela simplifica o processo de empacotamento de aplicativos e suas depend�ncias em cont�ineres, garantindo consist�ncia entre ambientes de desenvolvimento, teste e produ��o.

### �	Git / GitHub:
Git � um sistema de controle de vers�o distribu�do amplamente utilizado para o rastreamento de mudan�as no c�digo-fonte durante o desenvolvimento de software. GitHub � uma plataforma de hospedagem de c�digo que oferece recursos de colabora��o, gerenciamento de projetos e integra��o cont�nua para equipes de desenvolvimento.

### �	SonarQube:
SonarQube � uma plataforma de c�digo aberto para inspe��o cont�nua da qualidade do c�digo-fonte para realizar an�lises est�ticas de c�digo, identificar problemas de c�digo e aplicar boas pr�ticas de desenvolvimento.

### �	Azure DevOps CI/CD:
Essas s�o plataformas de integra��o cont�nua e entrega cont�nua (CI/CD) que permitem automatizar o processo de constru��o, teste e implanta��o de software. Elas oferecem recursos como pipelines de CI/CD, gerenciamento de projetos, controle de vers�o e colabora��o em equipe.

## Bibliotecas

### Back-end

### �	ASP.NET Core: Framework web usado para construir o backend da aplica��o.
### �	Entity Framework Core: ORM (Object-Relational Mapper) usado para mapear objetos de dom�nio para o banco de dados.
### �	Microsoft.EntityFrameworkCore.SqlServer: Provedor de banco de dados SQL Server para o Entity Framework Core.
### �	Microsoft.Extensions.DependencyInjection: Biblioteca para inje��o de depend�ncia no ASP.NET Core.
### �	Microsoft.Extensions.Http: Biblioteca para gerenciamento de requisi��es HTTP no ASP.NET Core.
### �	Microsoft.Extensions.Options: Biblioteca para configura��es baseadas em op��es no ASP.NET Core.
### �	Microsoft.VisualStudio.Web.CodeGeneration.Design: Biblioteca de gera��o de c�digo para ASP.NET Core.

### Front-end

### �	ASP.NET Core: Framework web usado para construir o backend da aplica��o.
### �	Entity Framework Core: ORM (Object-Relational Mapper) usado para mapear objetos de dom�nio para o banco de dados.
### �	Microsoft.EntityFrameworkCore.SqlServer: Provedor de banco de dados SQL Server para o Entity Framework Core.
### �	Microsoft.Extensions.DependencyInjection: Biblioteca para inje��o de depend�ncia no ASP.NET Core.
### �	Microsoft.Extensions.Http: Biblioteca para gerenciamento de requisi��es HTTP no ASP.NET Core.
### �	Microsoft.Extensions.Options: Biblioteca para configura��es baseadas em op��es no ASP.NET Core.
### �	Microsoft.VisualStudio.Web.CodeGeneration.Design: Biblioteca de gera��o de c�digo para ASP.NET Core.

### Banco de Dados 
## �	Banco SQL Server.

Para a modelagem de dados do desafio proposto, vamos criar um esquema simples que represente as entidades necess�rias para o cadastro de clientes e logradouros. Vamos utilizar uma abordagem relacional b�sica, considerando os requisitos fornecidos.

### Entidades

**Cliente:** 
ID (Chave Prim�ria)
Nome
Email (�nico)
Logotipo (Armazenado como BLOB no banco de dados)

**Logradouro:**
ID (Chave Prim�ria)
ClienteID (Chave Estrangeira referenciando a entidade Cliente)
Logradouro (Endere�o)


**Endere�o:**
ClienteID (Chave Estrangeira referenciando a entidade Cliente)
LogradouroID (Chave Estrangeira referenciando a entidade Logradouro)

## Diagrama de Entidade-Relacionamento (DER)
 
### Descri��o das Entidades

### �	Cliente: Representa os clientes cadastrados na aplica��o. Cada cliente possui um ID �nico, nome, e-mail �nico e um logotipo em formato de BLOB para representar a imagem da empresa.

### �	Logradouro: Representa os endere�os associados a cada cliente. Cada logradouro possui um ID �nico, um ID de cliente que faz refer�ncia ao cliente propriet�rio e o endere�o em si.

### �	Endere�o: Representa o relacionamento entre Cliente e Logradouro.


## Arquitetura de Microsservi�os

### �	Servi�o de Cliente:

Respons�vel por lidar com todas as opera��es relacionadas aos clientes, incluindo cadastro, atualiza��o, visualiza��o e remo��o de clientes.

Implementado como um servi�o independente, permitindo escalabilidade e evolu��o independentes.

Comunica-se com o servi�o de Logradouro para gerenciar os endere�os dos clientes.

### �	Servi�o de Logradouro:
	Respons�vel por lidar com todas as opera��es relacionadas aos logradouros, incluindo cadastro, atualiza��o, visualiza��o e remo��o de logradouros.
	Implementado como um servi�o independente para modularidade e reuso.

### �	Servi�o de Armazenamento de Arquivos (File Storage Service):

Respons�vel por armazenar e recuperar os arquivos, como os logotipos dos clientes.

Implementado separadamente para garantir a escalabilidade e disponibilidade dos arquivos.

Pode ser integrado com servi�os de armazenamento em nuvem (por exemplo, AWS S3, Azure Blob Storage).

### �	Arquitetura de Cada Servi�o

Cada servi�o seguir� uma arquitetura em camadas, consistindo de:


### Camada de Apresenta��o:

Respons�vel por lidar com as requisi��es HTTP, validar os dados de entrada e formatar as respostas da API.

Implementada utilizando controllers, que recebem as requisi��es HTTP e chamam os servi�os apropriados na camada de aplica��o.


### Camada de Aplica��o:

Encarregada de coordenar as a��es solicitadas pelos clientes, aplicando as regras de neg�cio da aplica��o.

Implementa a l�gica de neg�cio e faz chamadas para a camada de acesso a dados para realizar opera��es no banco de dados.

### Camada de Acesso a Dados (Data Access Layer):

Respons�vel por realizar opera��es de leitura e escrita no banco de dados.

Utiliza um ORM (Object-Relational Mapping) para mapear objetos para as tabelas do banco de dados e realizar consultas.


### Migra��es e Gerenciamento de Esquema:
	O Entity Framework Core oferece suporte a migra��es de banco de dados, o que permite que voc� mantenha o esquema do banco de dados em sincronia com o modelo de dados conforme sua aplica��o evolui. Isso facilita a implementa��o de altera��es de esquema de forma controlada e autom�tica.

### Seguran�a:

O SQL Server oferece recursos avan�ados de seguran�a, incluindo autentica��o baseada em conta, criptografia de dados, controle de acesso granular e auditoria. Esses recursos ser�o utilizados para garantir a seguran�a dos dados da aplica��o e o cumprimento das regulamenta��es de prote��o de dados.


### Comunica��o entre Servi�os

A comunica��o entre os servi�os ser� realizada atrav�s de chamadas HTTP utilizando o protocolo REST. Cada servi�o exp�e uma API RESTful que permite que outros servi�os e clientes consumam suas funcionalidades.


### Tecnologias Utilizadas

### �	Linguagem de Programa��o: C# (.NET Core 8.0)
### �	Framework Web: ASP.NET Core
### �	Banco de Dados: SQL Server 2019 ou superior
### �	ORM: Entity Framework Core
### �	Armazenamento de Arquivos: Azure Blob Storage (ou similar)

## Fluxograma da Aplica��o 

### Descri��o do Fluxo

### Intera��o do Cliente:

### �	O cliente (usu�rio) interage com a interface do usu�rio para realizar opera��es relacionadas ao cadastro de clientes.

### Autentica��o:

### �	Antes de realizar qualquer opera��o, o cliente � autenticado pelo servi�o de autentica��o. Se a autentica��o for bem-sucedida, o cliente recebe um token JWT que ser� inclu�do em todas as requisi��es subsequentes.

### Chamada ao Client Service:

### �	O cliente realiza chamadas ao servi�o de cliente (Client Service) para realizar opera��es como criar, atualizar, visualizar ou remover clientes.

### Processamento das Opera��es:

### �	O Client Service processa as opera��es solicitadas, incluindo valida��o de dados, aplica��o de regras de neg�cio e chamadas ao banco de dados para persist�ncia dos dados.

## Endpoints da API:

### Clientes:
```
�	GET /api/clientes/Listar: Retorna a lista de todos os clientes cadastrados.
�	GET /api/clientes/ObterbyId/{id}: Retorna os detalhes de um cliente espec�fico.
�	POST /api/clientes/Adicionar: Cria um novo cliente.
�	PUT /api/clientes/Editar/{id}: Atualiza os detalhes de um cliente existente.
�	DELETE /api/clientes/Excluir/{id}: Remove um cliente existente.
```

### Logradouros:
```
�	GET /api/clientes/{clienteId}/logradouros: Retorna a lista de logradouros de um cliente espec�fico.
�	GET /api/clientes/{clienteId}/logradouros/{logradouroId}: Retorna os detalhes de um logradouro espec�fico de um cliente.
�	POST /api/clientes/{clienteId}/logradouros: Adiciona um novo logradouro ao cliente.
�	PUT /api/clientes/{clienteId}/logradouros/{logradouroId}: Atualiza os detalhes de um logradouro espec�fico de um cliente.
�	DELETE /api/clientes/{clienteId}/logradouros/{logradouroId}: Remove um logradouro espec�fico de um cliente.
```

### Autentica��o e Autoriza��o:

A API deve ter autentica��o e autoriza��o para proteger os recursos e garantir que apenas usu�rios autorizados possam acess�-los. Isso pode ser implementado utilizando JWT (JSON Web Tokens) para autentica��o baseada em token e atribui��o de roles ou claims para autoriza��o de usu�rios.

### Formato de Resposta:

A API deve retornar respostas no formato JSON, seguindo as pr�ticas comuns de design de APIs RESTful. O uso de c�digos de status HTTP apropriados (por exemplo, 200 OK, 201 Created, 404 Not Found, etc.) e estruturas de resposta consistentes ajudar� na compreens�o e integra��o dos clientes da API.

### Documenta��o:

� fundamental documentar a API para que os desenvolvedores possam entender facilmente como utiliz�-la. O uso de ferramentas como o Swagger pode facilitar a cria��o de documenta��o interativa que descreva todos os endpoints, par�metros de requisi��o, c�digos de status e exemplos de resposta.

## Testes:

A API deve ser testada de forma abrangente para garantir que ela funcione corretamente em diferentes cen�rios. Isso inclui testes unit�rios, testes de integra��o e testes de aceita��o para validar o comportamento da API em rela��o aos requisitos do projeto.

## POC � Getting Started

### Instru��es para Executar os Projetos

### Backend

### Pr�-requisitos

Certifique-se de ter o SDK do .NET Core instalado em sua m�quina. Voc� pode baix�-lo em dotnet.microsoft.com.

### Executando o Backend
### �	Navegue at� o diret�rio raiz do projeto de backend.
### �	Abra um terminal ou prompt de comando.
### �	Execute o seguinte comando para restaurar as depend�ncias do projeto:
```
dotnet restore
```

Ap�s a restaura��o das depend�ncias, voc� deve rodar o Banco de Dados SQL Server, atrav�s de um container do Docker:

### �	Certifique-se de que voc� tem o Docker instalado na sua m�quina. Voc� pode baix�-lo e instal�-lo a partir do site oficial: https://www.docker.com/get-started.
### �	Navegue at� o diret�rio onde est� localizado o seu Dockerfile usando o terminal ou prompt de comando.
### �	Execute o comando docker build para construir a imagem Docker a partir do Dockerfile. Este comando cria uma imagem Docker com base nas instru��es no Dockerfile.

```
docker build -t nome_da_imagem .
```

Substitua "nome_da_imagem" pelo nome que voc� deseja dar � sua imagem Docker.

```
docker run --name nome_do_cont�iner -p 1433:1433 nome_da_imagem
```

Substitua "nome_do_cont�iner" pelo nome que voc� deseja dar ao seu cont�iner e "nome_da_imagem" pelo nome da imagem que voc� construiu anteriormente.
O par�metro -p � usado para mapear uma porta do host para uma porta dentro do cont�iner. No exemplo acima, a porta 8080 do host � mapeada para a porta 80 dentro do cont�iner. Se a sua aplica��o estiver escutando em uma porta diferente, ajuste a porta conforme necess�rio.

### Compilando o projeto

Dentro do diret�rio principal do projeto, voc� vai abrir a Solution CrudClientes.sln e ap�s rodar, voc� ter� a op��o de buildar os projetos �APIClients� e �Client�.

Ap�s a API estiver rodando, compile tamb�m o projeto Client e sua aplica��o estar� rodando e funcionando para testes.


