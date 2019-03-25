# Trabalhando com data e hora

A estrutura DateTime do C# é utilizada para representar um momento no tempo, armazenando tanto data quanto hora.

* Formas simples para criar um objeto do tipo DateTime:
    ```csharp
    var date1 = DateTime.Parse("01/03/2019");
    var date2 = new DateTime(2019,03,02);
    var date3 = new DateTime(2019,03,03,0,0,0);
    var date4 = DateTime.Now;
    ```

* Formatações simples:
    ```csharp
    var myDateTime1 = DateTime.Now;
    Console.WriteLine($"Datetime now: {myDateTime1.ToString()}");
    Console.WriteLine($"ShortDate:{myDateTime1.ToShortDateString()}");
    Console.WriteLine($"ShortTime:{myDateTime1.ToShortTimeString()}");
    Console.WriteLine($"LongDate:{myDateTime1.ToLongDateString()}");
    Console.WriteLine($"LongTime:{myDateTime1.ToLongTimeString()}");
    ```

* Adicões de tempo em datas:
    ```csharp
    var myDateTime2 = DateTime.Now;
    Console.WriteLine($"myDateTime2:{myDateTime2.ToLongDateString()}");
    Console.WriteLine("");
    Console.WriteLine($"+3 dias: {myDateTime2.AddDays(3).ToLongDateString()}");
    Console.WriteLine($"-3 dias: {myDateTime2.AddDays(-3).ToLongDateString()}");
    Console.WriteLine($"+3 horas: {myDateTime2.AddHours(3).ToLongTimeString()}");
    Console.WriteLine($"+3 minutos: {myDateTime2.AddMinutes(3).ToLongTimeString()}");
    Console.WriteLine($"+3 segundos: {myDateTime2.AddSeconds(3).ToLongTimeString()}");
    ```

* Encontrando intervalo entre duas datas:
    ```csharp
    DateTime myBirthday = DateTime.Parse("22/08/1990");
    TimeSpan interval = DateTime.Now.Subtract(myBirthday);
    Console.WriteLine($"Total de dias: {interval.TotalDays}");
    ```

**Referências:**
* [Complete Reference of DateTime](https://docs.microsoft.com/pt-br/dotnet/api/system.datetime?view=netframework-4.7.2)
* [Calendar class](https://docs.microsoft.com/pt-br/dotnet/api/system.globalization.calendar?view=netframework-4.7.2)
* [TimeZone Overview](https://docs.microsoft.com/pt-br/dotnet/standard/datetime/time-zone-overview)
