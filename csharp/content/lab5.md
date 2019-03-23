# Hands on: lab 5

## Preparação

1. Crie uma nova pasta:
    ```console
    user:~$ mkdir lab5-classes-and-interfaces
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

## Problema

1. Crie uma pasta chamada entities, dentro da pasta src.

2. Crie uma pasta chamada interfaces, dentro da pasta src.

3. Crie uma interface chamada ICustomer.cs, dentro da pasta src/interfaces, com os seguintes membros:
    ```
    Propriedades:
    Codigo → Tipo String
    Nome → Tipo String

    Método:
    Save → parametro: Customer → tipo de retorno: void
    ```
4. Crie uma classe chamada Customer.cs na pasta src/entities que implemente a interface ICustomer.cs.

5. Na classe Program, dentro do método Main, defina uma variável do tipo da interface ICustomer.cs e inicialize esta variável com um objeto da classe Customer.cs.

6. No terminal do VS Code, rode o comando abaixo na pasta do projeto:
    ```console
    user:~$ dotnet build
    ```
    Resultado esperado: a aplicação deve compilar com sucesso.

**Ao concluir chame os instrutores num hangout para apresentar sua solução.**