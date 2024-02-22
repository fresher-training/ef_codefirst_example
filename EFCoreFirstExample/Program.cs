// See https://aka.ms/new-console-template for more information

using EFCoreFirstExample;
using EFCoreFirstExample.Entity;

using (EFCoreFirstExampleDBContext context = new EFCoreFirstExampleDBContext())
{
    List<User> users = context.Users.ToList();
}

//using (DisableObject disableObject = new DisableObject())
//{

//}

Console.WriteLine("321321");
Console.ReadLine();