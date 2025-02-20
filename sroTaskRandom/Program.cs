var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


string[] greetings = {
    "������, ���!",
    "����������!",
    "�����������!"
};

// ��������� �����������
app.MapGet("/hello", () => {
    var random = new Random();
    var greeting = greetings[random.Next(greetings.Length)];
    return new { message = greeting };
});
app.MapGet("/", () => "����� ����������! �������� /hello ��� �����������");

app.Run();