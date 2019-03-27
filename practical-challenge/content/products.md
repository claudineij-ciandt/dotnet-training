# [Story] Cadastrar produtos

## Narrativa de negócio:

**Como** gerente de uma linha de produtos
**Desejo** cadastrar produtos
**Para** consultar e obter informações do meu cátalogo de forma rápida

## Grooming de negócio

Propriedade | Tipo | Obrigatório | Regras
--- | --- | --- | ---
Id | GUID | Sim | Chave primária
Código | Texto | Sim | Deve conter exatamente 4 caracteres
Id da categoria | GUID | Sim |
Descrição | Texto | Sim |
Preço unitário | Decimal | Não | Se informado, valor deve ser maior ou igual a zero
Unidade de medida | Texto | Sim |

O cadastro de produtos deve incluir as operações CRUD: criar, ler/listar, atualizar e excluir. Deverá ser criado 3 tipos de leitura:
* Ler/listar todas os produtos;
* Ler/listar um produto específico (a partir do seu id);
* Ler/listar produtos que atendam ao termo de busca (a partir da descrição).

Nesta estória, com a inclusão de produtos no sistema, deve-se incluir uma nova regra de negócio para categorias:
* Não será possível excluir uma categoria que tenha produtos associados.

## Grooming técnico

Criar uma controller **ProdutosController** com actions que atendam aos contratos abaixo:

GET http://<api_url>/api/produtos
GET http://<api_url>/api/produtos/{id}
GET http://<api_url>/api/produtos/search?descricao={search_text}
POST http://<api_url>/api/produtos
PUT http://<api_url>/api/produtos/{id}
DELETE http://<api_url>/api/produtos/{id}

Assim como na estória anterior, deve-se seguir as mesmas práticas a respeito de exceções e responsabilidades das camadas.