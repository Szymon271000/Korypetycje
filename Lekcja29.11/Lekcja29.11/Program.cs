/*int? x = null;
Console.WriteLine(x);*/
using Lekcja29._11;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

void CreatePassword(string password, out byte[] passwordHash, out byte[] passwordSalt)
{
    HMACSHA512 hmac = new HMACSHA512();
    passwordSalt = hmac.Key;
    passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
}

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
        CreatePassword(password, out byte[] passwordHash, out byte[] passwordSalt);
        User u1 = new User
        {
            Imie = imie,
            Password = password,
            Email = email,
            PasswordHash = passwordHash,
            PasswordSalt = passwordSalt
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
            post1.Author = user;
            p1?.Add(post1);
            p1?.SaveChanges();
        }
        else
        {
            List<Post> posty = p1.Posts.Include(x => x.Author).ToList();
            for (int i = 0; i < posty.Count; i++)
            {
                var NumberOfLikes = p1.Likes.Include(x => x.Post).Count(x => x.Post.Id == posty[i].Id);
                Console.WriteLine($"{i + 1}. {posty[i]} liczba likow: {NumberOfLikes} ");
                
            }
            Console.WriteLine("Checesz dodac like ?");
            string ?inputlike = Console.ReadLine();
            if (inputlike == "yes")
            {
                Console.WriteLine("Podaj id posta: ");
                int numerPosta = int.Parse(Console.ReadLine());
                var like = new Like();
                like.User = user;
                like.Post = posty[numerPosta - 1];
                p1.Add(like);
                p1.SaveChanges();
            }
        }
    }
}

//jak uzytkownik sie zaloguje to pobierz od niego dane do posta i utworz post i dodaj do bazy
//podczas tworzenia konta sprawdzic czy uzytkownik o danym emailu juz nie istnieje w bazie