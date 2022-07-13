# Ploomes
<p>Projeto criado para um desafio técnico proposto pela empresa Ploomes, onde era necessário a criação de uma API com tema livre e disponibilizar ela e o banco de dados na nuvem do Azure</strong></p>
<br>

<h3 align="center">Para rodar a API na nuvem você precisa:</h3>
<p>Assistir esse vídeo introdutório da aplicação, onde mostro ela rodando todas as funcionalidades: https://screenrec.com/share/3qSgD7hdnF<p>
<p>Acessar o endpoint da API, para fazer testes: https://myploomesapi.azurewebsites.net/swagger<p>

<h3 align="center">Para rodar localmente o projeto você precisa configurar algumas variáveis de ambiente</h3>
<br>
<p>Iniciar os segredos de usuários</p>
<pre>
dotnet user-secrets init
</pre>
<br>
<br>
<p>Configurar a string de conexão ao banco de dados</p>
<br>
<pre>
dotnet user-secrets set "ConnectionStrings:PLOOMESMANAGER" "[STRING CONNECTION]"
</pre>
<br>
<br>
<p>Configurar dados de autenticação (JWT), nesse caso por motivos de tamanho da aplicação foi utilizado o Login estático</p>
<br>
<pre>
dotnet user-secrets set "Jwt:Key" "[JWT CRYPTOGRAPHY KEY]"
dotnet user-secrets set "Jwt:Login" "[JWT LOGIN]"
dotnet user-secrets set "Jwt:Password" "[JWT PASSWORD]"
</pre>
<br>
<br>
<p>Por fim você configura a chave de criptografia da aplicação</p>
<p>Você pode usar esse site como auxílio https://www.base64encode.org/<p>
<br>
<pre>
dotnet user-secrets set "Cryptography" "[CHAVE DE CRIPTOGRAFIA DA APLICAÇÃO]"
</pre>
<br>
<br>
<br>
<h3 align="center">Alguns comandos que podem ser úteis :)</h3>
<br>
<br>
<p>Listar todas os segredos de usuário da aplicação.</p>
<br>
<pre>
dotnet user-secrets list
</pre>
<br>
<br>
<p>Deletar um segredo de usuário da aplicação.</p>
<br>
<pre>
dotnet user-secrets remove "[CHAVE]"
</pre>
<br><br>
<br><br>
<br><br>
