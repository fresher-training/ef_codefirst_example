// See https://aka.ms/new-console-template for more information


using BusinessLogic;

UserService userService = new UserService();
await userService.InsertUser("anhdeptrai@yahoo.com", "3213124");

Console.ReadLine();
