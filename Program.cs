using Practice.DataContext;
using Practice.Entities;

DataContext context = new DataContext();

//Task #1
// var products = from product in context.Products
//             join category in context.Categories on product.CategoryId equals category.Id
//             group product by category into productCategory
//             select new 
//             {
//                 Category = productCategory.Key.Name,
//                 Products = productCategory.ToList()
//             };

// foreach(var i in products)
// {
//     System.Console.WriteLine("----------------------"+i.Category+"----------------------");
//     foreach(var j in i.Products)
//     {
//         System.Console.Write(j.Name+" ");
//     }
//     System.Console.WriteLine();
// }

//Task #2
// var orders = from order in context.Orders
//             // join orderItem in context.OrderItems on order.Id equals orderItem.OrderId
//             join user in context.Users on order.UserId equals user.Id
//             where order.UserId == 2
//             group order by user into userOrders
//             select new 
//             {
//                 User = userOrders.Key.Username,
//                 Orders = userOrders.ToList(),
//             };

// foreach(var i in orders)
// {
//     System.Console.WriteLine("----------------------"+i.User+"----------------------");
//     foreach(var j in i.Orders)
//     {
//         System.Console.WriteLine(j.UserId);
//     }
//     System.Console.WriteLine();
// }

//Task #3
// var productCountInCategory = from product in context.Products
//             join category in context.Categories on product.CategoryId equals category.Id
//             group product by category into productCategory
//             select new
//             {
//                 Category = productCategory.Key.Name,
//                 ProductCount = productCategory.Count()
//             };


// foreach(var i in productCountInCategory)
// {
//     System.Console.WriteLine(i.Category+" "+i.ProductCount);
// }

//Task #4
// var userOrders = from order in context.Orders
//             join user in context.Users on order.UserId equals user.Id
//             group order by user into userOrders
//             select new 
//             {
//                 User = userOrders.Key.Username,
//                 Orders = userOrders.ToList()
//             };

// foreach(var i in userOrders)
// {
//     System.Console.WriteLine("----------------------"+i.User+"----------------------");
//     foreach(var j in i.Orders)
//     {
//         System.Console.WriteLine(j.UserId+", "+j.TotalAmount);
//     }
//     System.Console.WriteLine();
// }

//Task #5
// var orders = from order in context.Orders 
//             where order.TotalAmount>400
//             select order;
// foreach(var i in orders)
// {
//     System.Console.WriteLine(i.TotalAmount);
// }

//Task #6
// var products = from product in context.Products
//             where product.Stock>0
//             select product;

// foreach(var i in products)
// {
//     System.Console.WriteLine(i.Name +" "+ i.Stock);
// }

//Task #7
// var filteringOrdersByDate = from order in context.Orders
//             where order.CreatedAt>DateTime.UtcNow.AddDays(-6)
//             select order;

// foreach(var i in filteringOrdersByDate)
// {
//     System.Console.WriteLine(i.CreatedAt);
// }

//Task #8
// var usersWithOrderCount = from order in context.Orders
//             join user in context.Users on order.UserId equals user.Id
//             group order by user into userOrders
//             select new 
//             {
//                 User = userOrders.Key.Username,
//                 OrderCount = userOrders.Count()
//             };
        
// foreach(var i in usersWithOrderCount)
// {
//     System.Console.WriteLine(i.User+" "+i.OrderCount);
// }

//9
// var users = from u in context.Users
//     join o in context.Orders on u.Id equals o.UserId
//     where o.TotalAmount > 300
//     select u.Username;
// foreach (var us in users)
// {
//     Console.WriteLine(us);
// }

//10
// var products = from p in context.Products
// orderby p.Price descending 
// select new
// {
//     Name = p.Name,
//     Price = p.Price
// };
// foreach (var pr in products)
// {
//     Console.WriteLine(pr.Name +"  "+pr.Price);
// }

//11
// var orderProducts = from o in context.Orders
// join oi in context.OrderItems on o.Id equals oi.OrderId
// join p in context.Products on oi.ProductId equals p.Id
// group p by o into po
// select new
// {
//     Order = po.Key,
//     Products = po.Select(x=>x.Name)
// };
// foreach (var r in orderProducts)
// {
//     Console.WriteLine(r.Order.Id+" "+r.Order.CreatedAt);
//     foreach (var rr in r.Products)
//     {
//         Console.WriteLine(rr);
//     }
//
//     Console.WriteLine();
// }

//12
// var categories = from c in context.Categories
// select c;
// foreach (var r in categories)
// {
//     Console.WriteLine(r.Name);
//     Console.WriteLine(r.Description);
//     Console.WriteLine();
// }

//13
// var users = from u in context.Users
// join o in context.Orders on u.Id equals o.UserId
// select u;
// foreach (var r in users)
// {
//     Console.WriteLine(r.Username);
// }

//14
// var products = from p in context.Products
// join c in context.Categories on p.CategoryId equals c.Id
// where c.Name == "Books"
// select p;
// foreach (var r in products)
// {
//     Console.WriteLine(r.Name);
// }

//15
// var orders = from o in context.Orders
// join oi in context.OrderItems on o.Id equals oi.OrderId
// join p in context.Products on oi.ProductId equals p.Id
// where p.Name == "Laptop"
// select o;
// foreach (var o in orders)
// {
//     Console.WriteLine(o.Id + " "+ o.OrderDate);
// }

//16
// var lastUserOrder = from u in context.Users
// join o in context.Orders on u.Id equals o.UserId
// orderby o.OrderDate descending 
// group o by u into uo
// select new
// {
//     Name = uo.Key.Username,
//     LastOrder = uo.FirstOrDefault().OrderDate
// };
// foreach (var r in res)
// {
//     Console.WriteLine(r.Name+"  "+r.LastOrder);
// }

//17
// var res = context.Products.Count();
// Console.WriteLine(res);

//18
// var res = from o in context.Orders
// select o;
// foreach (var r in res)
// {
//     Console.WriteLine(r.Id +" "+r.TotalAmount);
// }

//19 
// var products = context.Products.Where(x => x.IsDeleted == true).Select(x => x.Name);
// foreach (var p in products)
// {
//     Console.WriteLine(p);
// }

//20
// var res = from u in context.Users
//     join o in context.Orders on u.Id equals o.UserId into userOrders
//     from o in userOrders.DefaultIfEmpty() 
//     where o == null 
//     select u;
// foreach (var r in res)
// {
//     Console.WriteLine(r.Username);
// }

//21
// var products = from p in context.Products
// where p.CreatedAt > DateTime.UtcNow.AddMonths(-3) && p.Stock>0
// select p.Name;
// foreach (var p in products)
// {
//     Console.WriteLine(p);
// }

//22
// var users = from u in context.Users
// join o in context.Orders on u.Id equals o.UserId
// join oi in context.OrderItems on o.Id equals oi.OrderId
// join p in context.Products on oi.ProductId equals p.Id
// group p by u into pu
// select new
// {
//     Name = pu.Key.Username,
//     Product = pu.Distinct().Count()
// };
// foreach (var u in users)
// {
//     Console.WriteLine(u.Name+"  "+u.Product);
// }

//23
// var orders = from o in context.Orders
// where o.CreatedAt > DateTime.UtcNow.AddYears(-1)
// group o.CreatedAt.Month by o into g
//     select new
//     {
//         Order = g.Key,
//         OrderCount = g.Count()
//     };
// foreach (var o in orders)
// {
//     Console.WriteLine(o.Order.OrderDate+" "+o.OrderCount);
// }

//24
// var res = from o in context.Orders
//     join oi in context.OrderItems on o.Id equals oi.OrderId
//     join p in context.Products on oi.ProductId equals p.Id
//     group p by o into po
//     select new
//     {
//         Order = po.Key,
//         ProductsCount = po.Count()
//     };
// foreach (var r in res)
// {
//     Console.WriteLine(r.Order.Id+" "+r.Order.CreatedAt);
//     Console.WriteLine(r.ProductsCount);
//     Console.WriteLine();
// }

//26
// var users = from u in context.Users
// join o in context.Orders on u.Id equals o.UserId
// join oi in context.OrderItems on o.Id equals oi.OrderId 
// join p in context.Products on oi.ProductId equals p.Id
// where p.Name == "Smartphone"
// select u.Username;
// foreach (var u in users)
// {
//     Console.WriteLine(u);
// }

//27
// var users = from u in context.Users
//     join o in context.Orders on u.Id equals o.UserId
//     where o.TotalAmount > 400 && o.OrderDate > DateTime.UtcNow.AddYears(-1)
//     select u.Username;
// foreach (var u in users)
// {
//     Console.WriteLine(u);
// }

//28
// var users = from u in context.Users
//     where u.CreatedAt>DateTime.UtcNow.AddMonths(-1)
//     select u.Username;
// foreach (var u in users)
// {
//     Console.WriteLine(u);
// }

//30
// var products = from order in context.Orders
//                join orderItem in context.OrderItems on order.Id equals orderItem.OrderId
//                join product in context.Products on orderItem.ProductId equals product.Id
//                group order by product into productOrders 
//                where productOrders.Count()>=10
//                select new
//                {
//                    Product = productOrders.Key.Name,
//                    OrderCount = productOrders.Count()
//                };
//
// foreach (var i in products)
// {
//     Console.WriteLine(i.Product+" "+i.OrderCount);
// }
