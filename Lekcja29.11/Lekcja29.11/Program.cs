/*int? x = null;
Console.WriteLine(x);*/
using Lekcja29._11;

PostContext p1 = new PostContext();
Console.WriteLine("Do you want to sign in or sign up");
string? Input = Console.ReadLine();
if (Input?.ToLower() == "sign up") //?.ToLower() - zabezpieczenie ze jak Input bedzie null to ta funkcja sie nie wykona (ToLower())
{
    Console.WriteLine("Podaj imie: ");
    string? imie = Console.ReadLine();
    Console.WriteLine("Podaj email: ");
    string ?email = Console.ReadLine();
    Console.WriteLine("Podaj haslo: ");
    string ? password = Console.ReadLine();
    Console.WriteLine("Podaj znowu haslo");
    string? password2 = Console.ReadLine();
    var user = p1?.Users?.FirstOrDefault(x => x.Email == email);
    if (user != null)
    {
        Console.WriteLine("Taki uzytkonik juz istnieje");
        return;
    }
    if (password == password2)
    {
        User u1 = new User
        {
            Imie = imie,
            Password = password,
            Email = email
        };
        p1.Add(u1);
        p1.SaveChanges();
        Console.WriteLine($"Utworzony uzytkownik ma id: {u1.Id}");
    }
    else
    {
        Console.WriteLine("Hasla sa rozne");
    }
}
else if (Input?.ToLower() == "sign in") 
{
    Console.WriteLine("Podaj email:");
    string ?email = Console.ReadLine();
    Console.WriteLine("Podaj haslo: ");
    string ?password = Console.ReadLine();
    var user = p1?.Users?.FirstOrDefault(x => x.Email == email && x.Password == password);
    if (user == null)
    {
        Console.WriteLine("Nie znaleziono uzytkownika");
    }
    else
    {
        Console.WriteLine("Zalogowany");
        Console.WriteLine("Chcesz dodac posta?");
        string ?input = Console.ReadLine();
        if (input?.ToLower() == "tak")
        {
            Console.WriteLine("Napisz post: ");
            string ?post = Console.ReadLine();
            Post post1 = new Post();
            post1.Text = post;
            var userdId = p1?.Users?.FirstOrDefault(x => x.Id == user.Id);
            post1.Author = userdId;
            p1?.Add(post1);
            p1?.SaveChanges();
        }   
    }
}

//jak uzytkownik sie zaloguje to pobierz od niego dane do posta i utworz post i dodaj do bazy
//podczas tworzenia konta sprawdzic czy uzytkownik o danym emailu juz nie istnieje w bazie