# Curso versionamento de código com Git e GitHub | DIO

Exemplos de como modificar documentos README.

## 📚 Documentacoes:
- [Documento Git](https://git-scm.com/doc)
- [Documento GitHub](https://docs.github.com/pt)
- Para usar emojis: control + command + espaco
- Para criar tópicos: -
- Para criar frases com links: [frase](link)

##  💻 Comandos:

| Comando | Descricao |
| --- | --- |
| git init | Inicia um repositório |
| git status | Mostra o status do repositório atual |
| git add NomeArquivo| Adiciona o arquivo específico |
| git add . | Adiciona todos os arquivos |
| git clone URL | Clona um repositório remoto |
| git commit -m"descricao" | Faz commit com uma descricao |
| git commit --amend -m | Altera a descricao do ultimo commit |
| git log | Mostra os commits realizados no repositório |
| git restore NomeArquivo | Restaura o arquivo para o último commit |
| git config --global | Inicializa uma configuracao global |
| git config --global user.name | Configura o username do git config |
| git config --global user.email | Configura o email do git config |
| git push origin main | Envia commits locais para o repositório remoto |
| git pull origin main | Atualiza o repositório local com a branch especificada |
| git pull | Atualiza o repositório local com a branch utilizada no remoto |
| git remote add upstream URL | Adiciona o repositório remoto de um projeto fork |
| git pull upstream main | Atualiza o repositório local com repositório remoto do fork principal | git checkout -b teste | Trocar para a branch "teste" |
| git checkout main | Retorna para a branch MAIN |
| git branch -v | Lista o último commit de cada branch existente |
| git branch -d teste | Exclui a branch teste |
| git merge teste | Mescla a branch teste com a branch MAIN |
| git fech origin main | Baixa as alteracoes do repo remoto mas não mescla com o local |
| git diff main origin/main | Aponta as diferencas das duas branchs citadas (usar apos git fech)|
| git clone URL --branch teste --single-branch | Clonar uma branch específica do repo remoto |
