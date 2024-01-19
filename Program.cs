// See https://aka.ms/new-console-template for more information
using Balta.ContentContext;
using ContentContext;

var articles = new List<Article>();
articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
articles.Add(new Article("Artigo sobre C#", "csharp"));
articles.Add(new Article("Artigo sobre .NET", "dotnet"));

// foreach (var article in articles)
// {
//     Console.WriteLine(article.Id);
//     Console.WriteLine(article.Title);
//     Console.WriteLine(article.Url);
// }

var courses = new List<Course>();
var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
var courseCSharp = new Course("Fundamentos C#", "fundamentos-csharp");
var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");

courses.Add(courseOOP);
courses.Add(courseCSharp);
courses.Add(courseAspNet);

var careers = new List<Career>();
var careerDotNet = new Career("Especialista .NET", "especialista-dotnet");
var careerItem2 = new Careeritem(2, "Aprenda OOP", "", courseOOP);
var careerItem1 = new Careeritem(3, "Comece por aqui", "", courseCSharp);
var careerItem3 = new Careeritem(1, "Aprenda .NET", "", courseAspNet);
careerDotNet.Items.Add(careerItem2);
careerDotNet.Items.Add(careerItem3);
careerDotNet.Items.Add(careerItem1);
careers.Add(careerDotNet);

foreach (var career in careers)
{
    Console.WriteLine(career.Title);
    foreach (var item in career.Items.OrderBy(x => x.Order))
    {
        Console.WriteLine($"{item.Order} - {item.Title}");
        Console.WriteLine(item.Course.Title);
        Console.WriteLine(item.Course.Level);
    }
}
