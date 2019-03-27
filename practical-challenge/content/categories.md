# [Story] Cadastrar categorias

## Narrativa de negócio

**Como** gerente de uma linha de produtos<br/>
**Desejo** cadastrar categorias de produtos<br/>
**Para** poder organizar os itens do meu catálogo

## Grooming de negócio

Propriedade | Tipo | Obrigatório | Regras
--- | --- | --- | ---
Id | GUID | Sim | Chave primária
Código | Texto | Sim | Deve conter exatamente 4 caracteres
Descrição | Texto | Sim |
Data de criação | Data/hora | Sim | Neste momento **não** é necessário alterar o formato de exibição

O cadastro de categorias deve incluir as operações CRUD: criar, ler/listar, atualizar e excluir. Deverá ser criado 3 tipos de leitura:
* Ler/listar todas as categorias;
* Ler/listar uma categoria específica (a partir do seu id);
* Ler/listar categorias que atendam ao termo de busca (a partir da descrição).

## Grooming técnico

Criar uma controller **CategoriasController** com actions que atendam aos contratos abaixo:

```
GET http://<api_url>/api/categorias
GET http://<api_url>/api/categorias/{id}
GET http://<api_url>/api/categorias/search?descricao={search_text}
POST http://<api_url>/api/categorias
PUT http://<api_url>/api/categorias/{id}
DELETE http://<api_url>/api/categorias/{id}
```

Criar uma classe **BusinessException**, que estende a classe **Exception**, no projeto **Business**. Ela deverá ter apenas um construtor que recebe um parâmetro **string errorMessage**, que será repassado à propriedade **Message** da classe base. Todas exceções de negócio devem ser lançadas por esta classe, porém com mensagens de erro diferentes para cada exceção de negócio.

**Atenção às responsabilidades de cada camada:**
* **Repository:** deve conter entidades e classes de repositório, que por sua vez utilizam expressões LINQ para acessar os dados do banco;
* **Business:** deve realizar validações de negócio, invocar os métodos do repositório e, caso necessário, lançar exceções.
* **API:** deve receber os parâmetros da requisição e invocar os métodos de business. Também será responsável por capturar possíveis exceções de negócio e retornar um **BadRequest** (ou **Ok**, se não houver erros).