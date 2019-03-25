# (Hands-on) Lab 6: generics

## Preparação

1. Crie uma nova pasta:
    ```console
    user:~$ mkdir lab6-generics
    ```

2. Abra o VS Code nesta pasta.

3. Abra o terminal integrado do VS Code (View > Terminal).

4. No terminal, crie um projeto do tipo console application:
    ```console
    user:~$ dotnet new console -lang C# -n ConsoleApp
    ```

5. Acesse o diretório do novo projeto:
    ```console
    user:~$ cd ConsoleApp
    ```

6. Copie a classe abaixo e cole dentro do namespace ConsoleApp, abaixo da classe Program:
    ```csharp
    public class RepositorioGenerico
    {
        public Guid Save(Object obj)
        {
            return Guid.NewGuid();
        }

        public void Update(Object obj)
        {
        }

        public void Delete(Object obj)
        {
        }

        public Object Get(Guid id)
        {
            return null;
        }
    }

    public class Cliente
    {
    }

    public class Produto
    {
    }
    ```

7. Refatore a classe RepositorioGenerico. Utilize generics para que seja possível reutilizar todo o código existente para manipular as entidades Cliente e Produto.
    1. Requisitos técnicos:
        * Restringir para que o tipo genérico seja uma classe;
        * Restringir para garantir que o tipo genérico tenha um construtor vazio;
        * Tipos de retorno devem ser genéricos;
        * Os parâmetros também devem ser genéricos.

8. Dentro do método Main crie uma instância do repositório genérico, que deve ser tipado com a classe Cliente.

9. Compile a aplicação utilizando o seguinte comando no terminal:
    ```console
    user:~$ dotnet build
    Resultado esperado: A aplicação deve compilar com sucesso
    ```
10. Dentro do método Main crie uma instância do repositório genérico, que deve ser tipado com a classe Produto.

11. Compile a aplicação utilizando o seguinte comando no terminal:
    ```console
    user:~$ dotnet build
    Resultado esperado: A aplicação deve compilar com sucesso
    ```

12. **Ao concluir, chame os instrutores para apresentar sua solução.**

**Dicas:**
* Consulte a tabela de restrições.
* Quando há mais de uma restrição para o mesmo tipo, separamo-as por vírgula na mesma linha.