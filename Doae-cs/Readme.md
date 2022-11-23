# Doaê

### Introdução

Este documento tem como finalidade especificar as funcionalidades, regras de negócio utilizadas no projeto, tecnologias a serem utilizadas, metodologias de desenvolvimento, arquitetura, meios de comunicação da equipe, definição das tarefas principais e as prioridades.

Doaê conecta pessoas que buscam fazer doações para as melhores ONGs com causas em que acreditam, que demonstram com transparência onde aplicam suas arrecadações. Pois, através da nossa plataforma, o usuário pode ter acesso a informações e novidades de cada ONG parceira, receber notícias, saber o andamento dos projetos das instituições e, principalmente, ajudar de forma realmente impactante!


### Rotas

**_Criar instituição:_**

```jsx
https:
```

Parâmetros - Corpo da Requisição

```jsx
{
	"name": "Lar das moças cegas",
	"email": "comunicacao@lmc.org.br",
	"cnpj": "58198227000173.",
  "description" : "A proposta do LMC é que a pessoa com deficiência visual receba todo atendimento necessário para habilitação, reabilitação e inclusão dela na sociedade",
  "cep": "11060-000",
  "agency": "2973",
  "count":"04262-1",
  "pix": "comunicacao@lmc.org.br",
  "phone": "(13) 3226.2760",
  "site": "http://www.lmc.org.br/",
  "password": "Larmocacega1!"
}
```

Resposta

```jsx
{
  "id": "1",
  "name": "Lar das moças cegas",
	"email": "comunicacao@lmc.org.br",
	"cnpj": "58198227000173.",
  "description" : "A proposta do LMC é que a pessoa com deficiência visual receba todo atendimento necessário para habilitação, reabilitação e inclusão dela na sociedade",
  "cep": "11060-000",
  "agency": "2973",
  "count":"04262-1",
  "pix": "comunicacao@lmc.org.br",
  "phone": "(13) 3226.2760",
  "site": "http://www.lmc.org.br/",
  "password": "Larmocacega1!"
}
```

**_Listar instituições_**

```jsx
https://
```

Resposta

```jsx
[
  {
    "id": "1",
    "name": "Lar das moças cegas",
	"email": "comunicacao@lmc.org.br",
	"cnpj": "58198227000173.",
    "description" : "A proposta do LMC é que a pessoa com deficiência visual receba todo atendimento necessário para habilitação, reabilitação e inclusão dela na sociedade",
    "cep": "11060-000",
    "agency": "2973",
    "count":"04262-1",
    "pix": "comunicacao@lmc.org.br",
    "phone": "(13) 3226.2760",
    "site": "http://www.lmc.org.br/",
    "password": "Larmocacega1!"
  },
];
```

**_listar instituição por id_**

```jsx
https:
```

Parâmetros - Corpo da Requisição

```jsx
{
    "id" : "1"
}
```

Resposta

```jsx
{
  "id": "1",
  "name": "Lar das moças cegas",
	"email": "comunicacao@lmc.org.br",
	"cnpj": "58198227000173.",
  "description" : "A proposta do LMC é que a pessoa com deficiência visual receba todo atendimento necessário para habilitação, reabilitação e inclusão dela na sociedade",
  "cep": "11060-000",
  "agency": "2973",
  "count":"04262-1",
  "pix": "comunicacao@lmc.org.br",
  "phone": "(13) 3226.2760",
  "site": "http://www.lmc.org.br/",
  "password": "Larmocacega1!"
}
```

**_Atualizar Instituição_**

Parâmetros - Corpo da Requisição

```jsx
{
    "id": "1",
    "name": "Lar das moças cegas",
    "description" : "A proposta do LMC é que a pessoa com deficiência visual receba todo atendimento necessário para habilitação, reabilitação e inclusão dela na sociedade",
    "agency": "2973",
    "count":"04262-1",
    "pix": "comunicacao@lmc.org.br",
    "phone": "(13) 3226.2760"
}
```

Resposta

```jsx
"Instituição atualizada com sucesso";
```

**_Atualizar credenciais da Instituição_**

Parâmetros - Corpo da Requisição

```jsx
{
    "id": "1",
    "email": "comunicacao@lmc.org.br",
    "password": "Larmocacega1!"
}
```

Resposta

```jsx
"Credenciais atualizadas com sucesso";
```

**_Excluir Instituição_**

Parâmetros - Corpo da Requisição

```jsx
https:
```

Resposta

```jsx
"Instituição deletada com sucesso";
```

**_Criar meta:_**

```jsx
https:
```

Parâmetros - Corpo da Requisição

```jsx
{
 	"name" : "cesta básica",
  "value": 300.00,
	"currenty_quantity": 0,
	"id_institution": "1",
  "description": "Nossa meta é conseguir agraciar uma família com uma cesta básica até o início do próximo mês",
	"day_limit": "22/12/22"
}
```

Resposta

```jsx
{
  "id": "1",
  "name" : "cesta básica",
  "value": 300.00,
	"currenty_quantity": 0,
	"id_institution": "1",
  "description": "Nossa meta é conseguir agraciar uma família com uma cesta básica até o início do próximo mês",
	"day_limit": "22/12/22"
}
```

**_Listar metas_**

```jsx
https://
```

Resposta

```jsx
[
  {
    "id": "1",
    "name": "cesta básica",
    "value": 300.0,
    "currenty_quantity": 0,
    "id_institution": "1",
    "description": "Nossa meta é conseguir agraciar uma família com uma cesta básica até o início do próximo mês",
    "day_limit": "22/12/22",
  },
];
```

**_listar meta por id_**

```jsx
https:
```

Parâmetros - Corpo da Requisição

```jsx
{
    "id" : "1"
}
```

Resposta

```jsx
{
  "id": "1",
  "name" : "cesta básica",
  "value": 300.00,
	"currenty_quantity": 0,
	"id_institution": "1",
  "description": "Nossa meta é conseguir agraciar uma família com uma cesta básica até o início do próximo mês",
	"day_limit": "22/12/22"
}
```

**_listar meta por id da instituição_**

```jsx
https:
```

Parâmetros - Corpo da Requisição

```jsx
{
    "id" : "1"
}
```

Resposta

```jsx
{
  "id": "1",
  "name" : "cesta básica",
  "value": 300.00,
	"currenty_quantity": 0,
	"id_institution": "1",
  "description": "Nossa meta é conseguir agraciar uma família com uma cesta básica até início do próximo mês",
	"day_limit": "22/12/22"
}
```

**_Atualizar Meta_**

Parâmetros - Corpo da Requisição

```jsx
{
  "id": "1",
  "name" : "cesta básica",
  "value": 300.00,
}
```

Resposta

```jsx
"Meta atualizada com sucesso";
```

**_Atualizar quantia atual da meta_**

Parâmetros - Corpo da Requisição

```jsx
{
    "id": "1",
    "value": 300.00,
    "id_product" : "47"
}
```

Resposta

```jsx
"Quantia atualizada com sucesso";
```

**_Excluir Meta_**

Parâmetros - Corpo da Requisição

```jsx
https:
```

Resposta

```jsx
"Meta deletada com sucesso";
```

**_Criar Doação:_**

```jsx
https:
```

Parâmetros - Corpo da Requisição

```jsx
{
	"id_institution" : "1",
	"value": 15.00,
	"email_giver": "nataliadasilva.bezerra@gmail.com",
	"id_target": "1"
}
```

Resposta

```jsx
{
  "id": "3",
  "id_institution" : "1",
	"value": 15.00,
	"email_giver": "nataliadasilva.bezerra@gmail.com",
	"id_target": "1",
  "status": "doação realizada"
}
```

**_Listar doações_**

```jsx
https://
```

Resposta

```jsx
[
  {
    "id": "3",
    "id da instituição": "1",
    "value": 15.0,
    "email_giver": "nataliadasilva.bezerra@gmail.com",
    "id_target": "1",
    "status": "doação realizada",
  },
];
```

**_listar doação por id_**

```jsx
https:
```

Parâmetros - Corpo da Requisição

```jsx
{
    "id" : "3"
}
```

Resposta

```jsx
{
  "id": "3",
  "id_institution" : "1",
	"value": 15.00,
	"email_giver": "nataliadasilva.bezerra@gmail.com",
	"id_target": "1",
  "status": "doação realizada"
}
```

**_listar doação por id da instituição_**

```jsx
https:
```

Parâmetros - Corpo da Requisição

```jsx
{
  "id" : "1"
}
```

Resposta

```jsx
{
  "id": "3",
  "id_institution" : "1",
	"value": 15.00,
	"email_giver": "nataliadasilva.bezerra@gmail.com",
	"id_target": "1",
  "status": "doação realizada"
}
```

**_listar doação por id da meta_**

```jsx
https:
```

Parâmetros - Corpo da Requisição

```jsx
{
    "id" : "1"
}
```

Resposta

```jsx
{
  "id": "3",
  "id_institution" : "1",
	"value": 15.00,
	"email_giver": "nataliadasilva.bezerra@gmail.com",
	"id_target": "1",
  "status": "doação realizada"
}
```

**_Atualizar Doação_**

Parâmetros - Corpo da Requisição

```jsx
{
  "id": "3",
  "status": "doação realizada"
}
```

Resposta

```jsx
"Doação atualizada com sucesso";
```

**_Excluir Doação_**

Parâmetros - Corpo da Requisição

```jsx
https:
```

Resposta

```jsx
"Doação deletada com sucesso";
```

**_Criar Produto:_**

```jsx
https:
```

Parâmetros - Corpo da Requisição

```jsx
{
	"name": "arroz",
	"value": 5.00,
	"id_institution": "1"
}
```

Resposta

```jsx
{
  "id" : "47",
  "name": "arroz",
	"value": 5.00,
	"id_institution": "1"
}
```

**_listar produto por id_**

```jsx
https:
```

Parâmetros - Corpo da Requisição

```jsx
{
  "id" : "47"
}
```

Resposta

```jsx
{
  "id" : "47",
  "name": "arroz",
	"value": 5.00,
	"id_institution": "1"
}
```

**_listar produto por id da instituição_**

```jsx
https:
```

Parâmetros - Corpo da Requisição

```jsx
{
  "id" : "1"
}
```

Resposta

```jsx
{
  "id" : "47",
  "name": "arroz",
	"value": 5.00,
	"id_institution": "1"
}
```

**_Atualizar Produto_**

Parâmetros - Corpo da Requisição

```jsx
{
  "id": "47",
  "name": "arroz",
  "value": 5.00
}
```

Resposta

```jsx
"Protuto atualizado com sucesso";
```

**_Excluir Produto_**

Parâmetros - Corpo da Requisição

```jsx
https:
```

Resposta

```jsx
"Produto deletado com sucesso";
```

**_Criar Produto da meta:_**

```jsx
https:
```

Parâmetros - Corpo da Requisição

```jsx
{
	"id_product": "47",
  "id_target": "1"
}
```

Resposta

```jsx
{
  "id" : "325",
  "id_product": "47",
  "id_target": "1"
}
```

**_listar produto da meta por id do produto_**

```jsx
https:
```

Parâmetros - Corpo da Requisição

```jsx
{
  "id" : "47"
}
```

Resposta

```jsx
{
  "id" : "325",
  "id_product": "47",
  "id_target": "1"
}
```

**_listar produto por id da meta_**

```jsx
https:
```

Parâmetros - Corpo da Requisição

```jsx
{
  "id" : "1"
}
```

Resposta

```jsx
{
  "id" : "325",
  "id_product": "47",
  "id_target": "1"
}
```

**_listar produto por id do produto da meta_**

```jsx
https:
```

Parâmetros - Corpo da Requisição

```jsx
{
  "id" : "325"
}
```

Resposta

```jsx
{
  "id" : "325",
  "id_product": "47",
  "id_target": "1"
}
```

**_Excluir Produto da meta_**

Parâmetros - Corpo da Requisição

```jsx
https:
```

Resposta

```jsx
"Produto da meta deletado com sucesso";
```

**_Criar Publicação:_**

```jsx
https:
```

Parâmetros - Corpo da Requisição

```jsx
{
	"description": "Hoje istribuimos cestasn básicas no bairro de Vila Mariana",
  "id_institution": "1"
}
```

Resposta

```jsx
{
  "id": "654743",
  "description": "Hoje istribuimos cestasn básicas no bairro de Vila Mariana",
  "id_institution": "1"
}
```

**_Listar Publicações_**

```jsx
https://
```

Resposta

```jsx
[
  {
    "id": "654743",
    "description": "Hoje istribuimos cestasn básicas no bairro de Vila Mariana",
    "id_institution": "1",
  },
];
```

**_listar publicação por id_**

```jsx
https:
```

Parâmetros - Corpo da Requisição

```jsx
{
    "id" : "654743"
}
```

Resposta

```jsx
{
  "id": "654743",
  "description": "Hoje istribuimos cestasn básicas no bairro de Vila Mariana",
  "id_institution": "1"
}
```

**_listar publicação por id da instituição_**

```jsx
https:
```

Parâmetros - Corpo da Requisição

```jsx
{
  "id" : "1"
}
```

Resposta

```jsx
{
  "id": "654743",
  "description": "Hoje istribuimos cestasn básicas no bairro de Vila Mariana",
  "id_institution": "1",
}
```

**_Atualizar Publicação_**

Parâmetros - Corpo da Requisição

```jsx
{
  "id": "654743",
  "description": "Hoje istribuimos cestasn básicas no bairro de Vila Mariana"
}
```

Resposta

```jsx
"Publicação atualizada com sucesso";
```
**_Excluir Publicação_**

Parâmetros - Corpo da Requisição

```jsx
https:
```

Resposta

```jsx
"Publicação deletada com sucesso";
```