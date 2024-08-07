# consumir-api-github
este projeto foi desenvolvido como forma de praticar o consumo de APIs públicas, sendo escolhida a API do GitHub. O projeto foi feito utilizando ASP.NET Core com Razor Pages para exibir as informações consumidas. Além do consumo das informações, o projeto propôs a inclusão de uma arquitetura de software em camadas, conforme a figura abaixo:


![image](https://github.com/user-attachments/assets/66a965d6-097d-4b40-bb76-c84a899aed0c)


Como podemos visualizar na figura acima, o projeto é dividido em quatro camadas:

* **Camada de apresentação:** Contém toda a parte frontend da aplicação, com os arquivos .cshtml responsáveis pela interação com o usuário.
  
* **Camada de negócio:** Esta camada contém a lógica de negócio da aplicação, incluindo as validações necessárias. Embora neste projeto específico não seja utilizada, normalmente aqui seriam adicionados os DTOs (Data Transfer Objects), validações de dados e outras regras de negócio.

* **Camada de serviço:** Contém a lógica e o tratamento necessário dos dados retornados. Essa camada realiza a validação se os dados estão corretos antes de retorná-los.

* **Camada de acesso aos dados:** Acessa a API e recupera os dados desejados. Embora essa camada geralmente seja utilizada para se conectar a um banco de dados, neste projeto ela será utilizada para acessar a API, comportando-se de maneira semelhante a uma base de dados.

Nesta arquitetura de software, as dependências ocorrem de maneira linear, da esquerda para a direita. Isso contribui para a organização do projeto, facilita a manutenção do código e a adição de novas features, devido ao baixo acoplamento entre as camadas.

# Depêndencia entre camadas

Conforme mencionado anteriormente, as depêndecias ocorrem de maneira linear da esquerda para direita e cada camada está dependendo de implementações concretas, isso resulta em um forte acoplamento entre as camadas. Para resolver esse problema, poderíamos utilizar padrões de projeto, que não foram empregados neste projeto, cujo objetivo foi apenas implementar uma arquitetura em camadas. Assim, com a utilização de padrões de projeto nossa aplicação poderia depender de abstrações e não de implementações concretas. Essa implementação contribui para um projeto mais estruturado e de fácil manutenção, pois atualizações em uma camada não afetarão as outras.
