# Hands-on Lab #1 - Criar uma API

## Visão Geral
Criar uma API que suporte operações CRUD. As APIs devem usar o padrão REST.

## Pré-Requisito
- Visual Studio ou VS Code
- .NET Framework instalado
- Postman ou similar

### Requisitos

- Criar API para produtos
    - GET /api/produtos/
    - GET /api/produtos/{id}
    - POST /api/produtos/
    - PUT /api/produtos/{id}
    - DELETE /api/produtos/{id}

- Fazer validação nos métodos GET, PUT e DELETE para verificar se registro existe, caso não, retornar erro 404.

### Passos Iniciais

1. Criar uma aplicação web
    ```
    dotnet new webapi -n lab1
    ```

2. Adicionar classe Model a solution
    ```
    public class Produto
    {
        public Produto()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }
    ```

3. Adicionar classe Repositorio a solution
    ```
    public class ProdutoRepositorio
    {
        private static readonly List<Produto> produtos = new List<Produto>();

        public Produto Get(Guid id)
        {
            return produtos.SingleOrDefault(c => c.Id == id);
        }

        public IList<Produto> GetAll()
        {
            return produtos;
        }

        public void Add(Produto produto)
        {
            produtos.Add(produto);
        }

        public void Update(Produto produto)
        {
            var index = produtos.FindIndex(c => c.Id == produto.Id);

            if(index < 0)
            {
                return;
            }

            produtos[index] = produto;
        }
        
        public void Remove(Guid id)
        {
            var oldProduto = produtos.SingleOrDefault(c => c.Id == id);

            if(oldProduto == null)
            {
                return;
            }

            produtos.Remove(oldProduto);
        }
    }
    ```