var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


string[] greetings = {
    "Привет, мир!",
    "Здравствуй!",
    "Приветствую!"
};

// Случайное приветствие
app.MapGet("/hello", () => {
    var random = new Random();
    var greeting = greetings[random.Next(greetings.Length)];
    return new { message = greeting };
});
app.MapGet("/", () => "Добро пожаловать! Посетите /hello для приветствия");

app.Run();