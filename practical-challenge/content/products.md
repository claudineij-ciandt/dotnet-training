# [Story] Cadastrar produtos

## Narrativa de negócio:

**Como** gerente de uma linha de produtos<br/>
**Desejo** cadastrar produtos<br/>
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

O cadastro de produtos deve incluir as operações CRUD: **criar, ler/listar, atualizar e excluir**. Deverá existir 3 tipos de leitura:
* Ler/listar todas os produtos;
* Ler/listar um produto específico (a partir do seu id);
* Ler/listar produtos que atendam ao termo de busca (a partir da descrição).

Nesta estória, com a inclusão de produtos no sistema, deve-se **incluir uma nova regra de negócio para categorias**:
* Não será possível excluir uma categoria que tenha produtos associados.

## Grooming técnico

Criar uma controller **ProdutosController** com actions que atendam aos contratos abaixo:

Produto JSON (valores arbitrários):
```json
{
    "Id": "cfb5c11e-affb-4ac0-a0a0-d098351dba87",
    "Codigo": "gh82",
    "Descricao": "Arroz",
    "Categoria": "",
    "Preco": 10.99,
    "UnidadeMedida": "kg"
}
```

Listar todas os produtos:
```
Request URL: GET http://<api_url>/api/produtos
Response code: 200
Response body: array de produtos
```

Listar um produtop pelo seu ID:
```
Request URL: GET http://<api_url>/api/produtos/{id}
Response code: 200
Response body: produto
```

Listar produto pesquisando pela descrição (ou parte dela):
```
Request URL: GET http://<api_url>/api/produtos/search?descricao={search_text}
Response code: 200
Response body: array de produtos
```

Criar um produto:
```
Request URL: POST http://<api_url>/api/produtos
Request body: produto
Response code: 200
```

Atualizar um produto:
```
Request URL: PUT http://<api_url>/api/produtos/{id}
Request body: produto
Response code: 200
```

Excluir um produto:
```
Request URL: DELETE http://<api_url>/api/produtos/{id}
Response code: 200
```

Assim como na estória anterior, deve-se seguir as mesmas práticas a respeito de exceções e responsabilidades das camadas.