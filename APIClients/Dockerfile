# Use a imagem base do SQL Server
FROM mcr.microsoft.com/mssql/server:2019-latest AS base

# Defina vari�veis de ambiente para o usu�rio SA, senha SA e aceita��o da EULA
ENV ACCEPT_EULA=Y
ENV SA_PASSWORD=198627N@t@l123+++
ENV MSSQL_USER=adm

# Crie um diret�rio para armazenar os scripts SQL
WORKDIR /scripts

# Copie o script SQL para inicializar o banco de dados
COPY ["create_database.sql", "."]

# Execute o script SQL para criar o banco de dados e as tabelas
RUN /opt/mssql-tools/bin/sqlcmd -S clientes-cont -U sa -P $SA_PASSWORD -i create_database.sql

EXPOSE 1433