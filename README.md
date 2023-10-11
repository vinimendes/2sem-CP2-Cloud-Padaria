# Doce Aroma
Aplicação Web com ASP.NET Core de uma padaria com recursos que giram em torno de registrar itens (comidas) e solicitar pedidos (simulando um cliente).

## Deploy
### Pré-requisitos:
- Usar o Visual Studio
- Editar o arquivo `appsettings.json` em `PadariaDoceAroma/appsettings.json` com as credenciais do banco.

### Passo a Passo
Clone do repositório:
```bash
git clone https://github.com/vinimendes/2sem-CP2-Cloud-Padaria.git
```
Acesse a pasta:
```bash
cd 2sem-CP2-Cloud-Padaria/
```

Com o `Visual Studio` aberto acessar a parte do `Package Manager Console`. Os seguintes comandos vão preparar as tabelas e suas configurações no `SQL Azure`:
```bash
Add-Migration <Nome de sua escolha>
```
```bash
Update-Database
```
Publicação:
- Após esse passo clickar com o botão direito no projeto: `PadariaDoceAroma` dentro do Visual Studio e clickar em Publish (Publicar)
- Selecionar Azure
- Azure App Service (Windows)
- Selecionar Grupo de Recursos correto e o Web App correto criado
- Selecionar Publish
- Após criar o .xml de configuração basta clickar em Close e na janela presente clickar em Publish

Após o build a aplicação estará disponível na URL do Web App

### Nomes
Cecilia Oliveira Neves RM: 93953
Luiz Felipe Souza de Oliveira RM94538
Kamilla de Lima Rodrigues RM: 96112
Victor Mendes RM: 92843
Vinicius Mendes Medeiros RM: 94375
Wesly Marques Siqueira RM: 93470
