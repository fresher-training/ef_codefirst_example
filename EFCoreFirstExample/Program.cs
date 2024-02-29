// See https://aka.ms/new-console-template for more information

// Tạo thêm UserOrders => 1-n: 1 user có nhiều đơn hàng
// Tạo thêm Product => 1 table
// Tạo bảng UserOrderProduct (giống bảng product: quantity, note, discount) quan hệ 1-n với UserOrder 

using Microsoft.EntityFrameworkCore;
using EFCoreFirstExample;
using EFCoreFirstExample.Entity;

using (EFCoreFirstExampleDBContext context = new EFCoreFirstExampleDBContext())
{
    List<User> users = context.Users.ToList();
    var data = context.Database.SqlQuery<User>($"SELECT * FROM \"tbl_user\"").ToList();

    User user = new User
    {
        FirstName = "TestFirstName",
        LastName = "TestLastName",
        Email = "test@test.com"
    };

    context.Users.Add(user);
    context.SaveChanges();

    Console.WriteLine("Inserted Name: " + user.Name);
}

//using (DisableObject disableObject = new DisableObject())
//{

//}

Console.WriteLine("321321");
Console.ReadLine();