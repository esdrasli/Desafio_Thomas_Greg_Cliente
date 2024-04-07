# Use a imagem base do SQL Server
FROM mcr.microsoft.com/mssql/server:2019-latest AS base

# Defina variáveis de ambiente para o usuário SA, senha SA e aceitação da EULA
ENV ACCEPT_EULA=Y
ENV SA_PASSWORD=198627N@t@l123+++
ENV MSSQL_USER=adm

# Crie um diretório para armazenar os scripts SQL
WORKDIR /scripts

# Copie o script SQL para inicializar o banco de dados
COPY ["create_database.sql", "."]

# Execute o script SQL para criar o banco de dados e as tabelas
RUN /opt/mssql-tools/bin/sqlcmd -S clientes-cont -U sa -P $SA_PASSWORD -i create_database.sql

EXPOSE 1433