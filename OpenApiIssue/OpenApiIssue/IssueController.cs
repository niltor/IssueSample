using Microsoft.AspNetCore.Mvc;

namespace OpenApiIssue;


[ApiController]
[Route("[controller]")]
public class IssueController : ControllerBase
{

    [HttpGet("test-issue")]
    public ActionResult<User> TestIssue()
    {
        var user = new User() { Name = "User" };
        return user;
    }
}

public class User
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public ICollection<Order> Orders { get; set; } = [];
    public ICollection<Product> Products { get; set; } = [];
    public ICollection<Course> Courses { get; set; } = [];
    public ICollection<Car> Cars { get; set; } = [];
    public ICollection<Hourse> Hourses { get; set; } = [];
    public ICollection<Plan> Plans { get; set; } = [];
    public ICollection<Rights> Rightss { get; set; } = [];
    public ICollection<Salary> Salarys { get; set; } = [];
    //public ICollection<Article> Articles { get; set; } = [];
    //public ICollection<Record> Records { get; set; } = [];
    //public ICollection<Permission> Permissions { get; set; } = [];
    //public ICollection<UserTask> UserTasks { get; set; } = [];
    //public ICollection<UserWord> UserWords { get; set; } = [];
    //public ICollection<UserDict> UserDicts { get; set; } = [];
    //public ICollection<UserGame> UserGames { get; set; } = [];
    //public ICollection<UserMedal> UserMedals { get; set; } = [];
    //public ICollection<UserPractice> UserPractices { get; set; } = [];
    //public ICollection<UserTicket> UserTickets { get; set; } = [];
}

public class Order { public User? User { get; set; } }
public class Product { public User? User { get; set; } }
public class Course { public User? User { get; set; } }
public class Car { public User? User { get; set; } }
public class Hourse { public User? User { get; set; } }
public class Plan { public User? User { get; set; } }
public class Rights { public User? User { get; set; } }
public class Salary { public User? User { get; set; } }
public class Article { public User? User { get; set; } }
public class Record { public User? User { get; set; } }
public class Permission { public User? User { get; set; } }
public class UserTask { public User? User { get; set; } }
public class UserWord { public User? User { get; set; } }
public class UserDict { public User? User { get; set; } }
public class UserGame { public User? User { get; set; } }
public class UserMedal { public User? User { get; set; } }

public class UserPractice { public User? User { get; set; } }
public class UserTicket { public User? User { get; set; } }