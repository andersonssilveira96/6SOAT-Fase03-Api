# 6SOAT Tech Challenge Api - Fase 03
O principal objetivo deste projeto foi desenvolver uma solucao para gerenciar o cadastro, pedidos, produtos e fila de entrega, sendo um sistema de controle de pedidos utilizando .NET Core, Clean Architecture e Kubernetes.

## Arquitetura do projeto
Arquivo "TechChallenge.drawio" na raiz do projeto para download caso necessário.
![image](https://github.com/user-attachments/assets/c410c3d7-856d-4145-a549-49b4571d2cd8)

## Tela inicial
![image](https://github.com/user-attachments/assets/ebf26ce8-0f5d-4341-9358-e655dd904d6d)

## Iniciar o Projeto
Para iniciar o Projeto, é necessário clonar o projeto do GitHub num diretório de sua preferência:

```shell
cd "diretorio de sua preferencia"
git clone https://github.com/andersonssilveira96/Software-Architecture-FIAP
```
#### Opções de execução do projeto
   * Docker compose: Com o Daemon do Docker em execução, acesse o diretório em que o projeto foi clonado e execute o comando "docker compose up", irá subir o banco de dados, a API irá esperar o Healthcheck do banco para subir e assim que subir executará o Migration para construção do banco com os dados iniciais.
     
   * Visual Studio: Com o Daemon do Docker em execução, basta abrir a solution, adicionar o "docker-compose" como projeto de inicialização e iniciar, conforme descrito na opção acima, irá subir toda a infraestrutura e executar o cadastro dos dados iniciais.

   * Kubernetes: Caso queira subir toda a infra com o Kubernetes, pasta executar o script powershell dentro da pasta "kubernetes", chamado "setup.ps1".
     
   <b>Necessário estar habilitado no sistema operacional a execução de scripts Powershell.</b>

   <b>Script:<br></b>
   ![image](https://github.com/user-attachments/assets/a4a410db-f173-4429-8793-7d670eedb191)
  
   <b>Execução:<br></b>
   ![image](https://github.com/user-attachments/assets/21c6fdda-8da3-436e-aab9-39d48bf1574a)

   <b>Pós-execução:</b> Após conclusão, feche o terminal do PowerShell abra um Prompt de comando e execute o comando "minikube service api-svc", com esse comando vamos ter acesso a qual porta podemos acessar o POD a partir do Host:
   ![image](https://github.com/user-attachments/assets/19cbd68f-ce68-403b-814e-58add5f19a10)

   <b>Basta inserirmos "/swagger" na URL apresentada e acessamos a aplicação.</b>
   ![image](https://github.com/user-attachments/assets/bb8441da-5c69-4989-8a48-93af6bb1cb78)

## Versao

2.0.0
 
Obrigado pela visita e bom codigo!
