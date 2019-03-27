# Acesso a Banco de dados com Entity Framework
No ASP.NET core, existem diversos frameworks para acesso a dados.

Existe uma técnica de mapeamento objeto relacional chamada ORM (Mapeamento objeto-relacional) que permite fazer uma relação dos objetos com os dados.

A Microsoft disponibiliza um framework, chamado Entity Framework Core, que possibilita o desenvolvedor trabalhar com banco dados usando objetos .NET e eliminando a maior parte do trabalho relacionado a escrever código para acessar o banco de dados. O EF Core pode se conectar a mais de um provider de banco de dados (ex: SQL Server, In Memory, SQL Lite, MySQL, etc..)

O acesso a dados do EF Core é feito através do **Model**, que representa um Entity Class, e um **context**, que representa a session com o banco de dados, assim permitindo query e save data.

```csharp
public class BloggingContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Server=(localdb)\mssqllocaldb;Database=Blogging;Integrated Security=True");
    }
}

public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }
    public int Rating { get; set; }
    public List<Post> Posts { get; set; }
}

public class Post
{
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public int BlogId { get; set; }
    public Blog Blog { get; set; }
}
```

#### Query
```csharp
using (var db = new BloggingContext())
{
    var blogs = db.Blogs
        .Where(b => b.Rating > 3)
        .OrderBy(b => b.Url)
        .ToList();
}
```

#### Save
```csharp
using (var db = new BloggingContext())
{
    var blog = new Blog { Url = "http://sample.com" };
    db.Blogs.Add(blog);
    db.SaveChanges();
}
```