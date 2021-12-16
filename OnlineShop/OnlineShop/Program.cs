using OnlineShop;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;
using System;
using System.Linq;
using System.Collections.Generic;

void CreatePassword(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {
        HMACSHA512 hmac = new HMACSHA512();
        passwordSalt = hmac.Key;
        passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
    }

    bool CorrectPassword(string password, byte[] passwordHash, byte[] passwordSalt)
    {
        HMACSHA512 hmac = new HMACSHA512(passwordSalt);
        byte[] passwordHash2 = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        for (int i = 0; i < passwordHash.Length; i++)
        {
            if (passwordHash[i] != passwordHash2[i])
            {
                return false;
            }
        }
        return true;
    }

ShopContext shopcontext1 = new ShopContext();
Console.WriteLine("Do you want to sign in or sign up ?");
string input = Console.ReadLine();
if (input.ToLower() == "sign up")
{
    Console.WriteLine("Podaj imie: ");
    string imie = Console.ReadLine();
    Console.WriteLine("Podaj email: ");
    string email = Console.ReadLine();
    Console.WriteLine("Podaj haslo: ");
    string password = Console.ReadLine();
    Console.WriteLine("Podaj znowu haslo: ");
    string password2 = Console.ReadLine();
    var user = shopcontext1.Users.FirstOrDefault(x => x.Email == email);
    if (user != null)
    {
        Console.WriteLine("Taki uzytkownik juz istnieje");
        return;
    }
    if (password == password2)
    {
        CreatePassword(password, out byte[] passwordHash, out byte[] passwordSalt);
        User u1 = new User
        {
            Imie = imie,
            Email = email,
            PasswordHash = passwordHash,
            Passwordsalt = passwordSalt
        };
        shopcontext1.Add(u1);
        shopcontext1.SaveChanges();
    }
    else
    {
        Console.WriteLine("Hasla sa rozne");
    }
}
else if (input.ToLower() == "sign in")
{
    Console.WriteLine("Podaj email");
    string email = Console.ReadLine();
    Console.WriteLine("Podaj haslo: ");
    string password = Console.ReadLine();
    var user = shopcontext1.Users.FirstOrDefault(x => x.Email == email);
    if (user != null)
    {
        Console.WriteLine("Taki uzytkownik nie istnieje");
    }
    else
    {
        if (!CorrectPassword(password, user.PasswordHash, user.Passwordsalt))
        {
            Console.WriteLine("Niepoprawne haslo");
        }
        else
        {
            Console.WriteLine("Jestes adminem ?");
            string inputadmin = Console.ReadLine();
            if (inputadmin.ToLower() == "tak")
            {
                Console.WriteLine("Podaj nazwe produktu: ");
                string nazwa = Console.ReadLine();
                string kategoria1 = Console.ReadLine();
                float cena = float.Parse(Console.ReadLine());
                Item i = new Item();
                i.Nazwa = nazwa;
                i.Kategoria = kategoria1;
                i.Cena = cena;
                shopcontext1.Add(i);
                shopcontext1.SaveChanges();
            }
            else
            {
                Console.WriteLine("Zalogowany");
                Console.WriteLine("Chcesz cos kupic: ");
                string inputuser = Console.ReadLine();
                if (inputuser.ToLower() == "tak")
                {
                    string[] productsnames = new string[] { "Iphone", "Samsung", "Huawei", "Xiaomi" };
                    string kategoria = "Mobiles";
                    float[] prices = new float[] { 799.99f, 899.99f, 1099.99f };
                    Random rnd = new Random();
                    List<Item> items = shopcontext1.Items.ToList();

                    /*for (int i = 0; i < 5; i++)
                    {
                        Item u1 = new Item();
                        int losowo = rnd.Next(0, productsnames.Length);
                        u1.Nazwa = productsnames[losowo];
                        u1.Kategoria = kategoria;
                        int losowacena = rnd.Next(0, prices.Length);
                        u1.Cena = prices[losowacena];
                        items.Add(u1);
                        shopcontext1.Add(u1);
                    }*/
                    //shopcontext1.SaveChanges();
                    for (int i = 0; i < items.Count; i++)
                    {
                        Console.WriteLine(items[i]);
                    }

                    Console.WriteLine("Co chcesz kupic? Podaj id produktu :");
                    int id = int.Parse(Console.ReadLine());
                    Order o1 = new Order();
                    o1.buyer = user;
                    Console.WriteLine(o1);
                    OrderItem orderItem1 = new OrderItem();
                    orderItem1.order = o1;

                    //orderitem z wieloma produktami
                    orderItem1.item = shopcontext1.Items.FirstOrDefault(x => x.Id == id);
                    Console.WriteLine(orderItem1);
                    shopcontext1.Add(o1);
                    shopcontext1.Add(orderItem1);
                    shopcontext1.SaveChanges();

                }
            }
        }
    }
}
    

