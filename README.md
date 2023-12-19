Instalar templates de projeto com Fluent UI :

dotnet new install Microsoft.FluentUI.AspNetCore.Templates

Criar projeto usando a .NET CLI :

**dotnet new fluentblazorwasm --name MeuProjeto
dotnet new fluentblazor --name MeuProjeto
**
Abrir o projeto no Visual Studio 2022 

O DialogService é um serviço que pode ser usado para mostrar diferentes tipos de diálogos 
e pode ser injetado em uma página ou componente 

O ToastService é um serviço que pode ser usado para mostrar diferentes tipos de avisos/alertas 
e pode ser injetado em uma página ou componente 

Ambos os serviços são registrados automaticamente no contêiner DI com a chamada do método
** .AddFluentUIComponents().**

São renderizados pelos componentes **<FluentDialogProvider /> e <FluentToastProvider /> **
 que precisam ser adicionados ao layout principal do seu aplicativo/site.(MainLayout.razor)






