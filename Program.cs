// using System.Runtime.InteropServices;
// using System.Security.Cryptography.X509Certificates;

//ClassTask Employee

// var employees = new[]
// {
//     new Employee
//     {
//         Id = 1,
//         FirstName = "Firuz",
//         LastName = "Rahimov",
//         Age = 22,
//         Salary = 25500,
//         Experience = 15
//     },

//     new Employee
//     {
//         Id = 2,
//         FirstName = "Ali",
//         LastName = "Karimov",
//         Age = 20,
//         Salary = 6500,
//         Experience = 20
//     },

//     new Employee
//     {
//         Id = 3,
//         FirstName = "Zarina",
//         LastName = "Rahimova",
//         Age = 25,
//         Salary = 25000,
//         Experience = 25
//     },

//     new Employee
//     {
//         Id = 4,
//         FirstName = "Alexander",
//         LastName = "Smith",
//         Age = 35,
//         Salary = 8000,
//         Experience = 12
//     },

//     new Employee
//     {
//         Id = 5,
//         FirstName = "Madina",
//         LastName = "Sharipova",
//         Age = 28,
//         Salary = 5500,
//         Experience = 6
//     },

//     new Employee
//     {
//         Id = 6,
//         FirstName = "John",
//         LastName = "Brown",
//         Age = 40,
//         Salary = 9000,
//         Experience = 15
//     },

//     new Employee
//     {
//         Id = 7,
//         FirstName = "Farzona",
//         LastName = "Ismoilova",
//         Age = 26,
//         Salary = 7000,
//         Experience = 5
//     }
// };

//1
//Method
// var res = employees.Select(x=> x.Salary);

// query

// var ras = from x in employees
//           select x.Salary;

// foreach (var a in ras)
// {
//     Console.WriteLine(a);
// }

//2
//method
// var res = employees.Where(x=> x.FirstName.Length>6);

// query
// var ras = from x in employees
//         where x.FirstName.Length>6
//         select x;
// foreach (var b in ras)
// {
//     Console.WriteLine(b.FirstName);
// }

//3
//method
 
//  var res = employees.Where(x=> x.Age>employees[0].Age).Select(x=>x.FirstName);


//query

// var ras = from x in employees
//          where x.Age>employees[0].Age
//          select x.FirstName;
//  foreach(var r in  ras)
// {
//     Console.WriteLine(r);
// }


//4
//method 

// var res = employees.Where(x=>x.Experience > x.Age /2);

//query 

// var ras = from x in employees
//           where x.Experience> x.Age /2
//           select x;

// foreach (var c in ras)
// {
//     Console.WriteLine(c.FirstName);
// }

//5
//method

// var res = employees
//     .Where(x => x.Salary > 5000)
//     .OrderByDescending(x => x.Experience)
//     .Take(3);

//query
// var ras = (from x in employees
//            where x.Salary > 5000
//            orderby x.Experience descending
//            select x).Take(3);

// foreach (var x in ras)
// {
//     Console.WriteLine(x.FirstName + " " + x.Experience + " " + x.Salary);
// }

//HomeTask1 

// var students = new[]
// {
//     new Student
//     {
//         Id = 1,
//         FirstName = "Ali",
//         LastName = "Rahimov",
//         Age = 22,
//         Gender = Gender.Male,
//         Status = Status.Active,
//         DateOfStart = new DateTime(2022, 9, 1),
//         DateOfFinish = new DateTime(2026, 6, 30)
//     },

//     new Student
//     {
//         Id = 2,
//         FirstName = "Madina",
//         LastName = "Saidova",
//         Age = 19,
//         Gender = Gender.Female,
//         Status = Status.Active,
//         DateOfStart = new DateTime(2023, 9, 1),
//         DateOfFinish = new DateTime(2027, 6, 30)
//     },
//     new Student
// {
//     Id = 3,
//     FirstName = "Ivan",
//     LastName = "Petrov",
//     Age = 25,
//     Gender = Gender.Male,
//     Status = Status.InActive,
//     DateOfStart = new DateTime(2020, 9, 1),
//     DateOfFinish = new DateTime(2024, 6, 30)
// },

// new Student
// {
//     Id = 4,
//     FirstName = "Anisa",
//     LastName = "Ahmadova",
//     Age = 21,
//     Gender = Gender.Female,
//     Status = Status.Active,
//     DateOfStart = new DateTime(2021, 9, 1),
//     DateOfFinish = new DateTime(2025, 6, 30)
// },

// new Student
// {
//     Id = 5,
//     FirstName = "Iskandar",
//     LastName = "Ismoilov",
//     Age = 15,
//     Gender = Gender.Male,
//     Status = Status.Active,
//     DateOfStart = new DateTime(2023, 9, 1),
//     DateOfFinish = new DateTime(2027, 6, 30)
// },

// new Student
// {
//     Id = 6,
//     FirstName = "Malika",
//     LastName = "Karimova",
//     Age = 17,
//     Gender = Gender.Female,
//     Status = Status.InActive,
//     DateOfStart = new DateTime(2021, 9, 1),
//     DateOfFinish = new DateTime(2025, 6, 30)
// },

// new Student
// {
//     Id = 7,
//     FirstName = "Artem",
//     LastName = "Ivanov",
//     Age = 23,
//     Gender = Gender.Male,
//     Status = Status.Active,
//     DateOfStart = new DateTime(2024, 9, 1),
//     DateOfFinish = new DateTime(2028, 6, 30)
// }
// };


// //1
// //Method

// var res1 = students.Where(x => x.Gender == Gender.Male);

// //query

// var ras1 = from x in students
//            where x.Gender == Gender.Male
//            select x;

// foreach (var a in ras1)
// {
//     Console.WriteLine(a.FirstName);
// }

// //2
// //Method

// var res2 = students.Where(x => x.Status == Status.InActive);

// //query

// var ras2 = from x in students
//            where x.Status == Status.InActive
//            select x;

// foreach (var b in ras2)
// {
//     Console.WriteLine(b.FirstName);
// }

// //4
// //Method

// var res4 = students.Where(x => x.Age > 20 && x.Status == Status.Active);

// //query

// var ras4 = from x in students
//            where x.Age > 20 && x.Status == Status.Active
//            select x;

// foreach (var d in ras4)
// {
//     Console.WriteLine(d.FirstName);
// }

// //5
// //Method

// var res5 = students.Where(x => x.Age == x.DateOfStart.Year - x.DateOfStart.Year + x.Age);

// //query

// var ras5 = from x in students
//            where x.Age == x.DateOfStart.Year - x.DateOfStart.Year + x.Age
//            select x;

// foreach (var e in ras5)
// {
//     Console.WriteLine(e.FirstName);
// }

// //6
// //Method

// var res6 = students.Where(x => x.DateOfStart.Year - x.Age >= 18);

// //query

// var ras6 = from x in students
//            where x.DateOfStart.Year - x.Age >= 18
//            select x;

// foreach (var f in ras6)
// {
//     Console.WriteLine(f.FirstName);
// }

// //7
// //Method

// var res7 = students.Where(x => x.FirstName.StartsWith("A") || x.FirstName.StartsWith("I"));

// //query

// var ras7 = from x in students
//            where x.FirstName.StartsWith("A") || x.FirstName.StartsWith("I")
//            select x;

// foreach (var g in ras7)
// {
//     Console.WriteLine(g.FirstName);
// }

// //8
// //Method

// var res8 = students.Where(x => x.FirstName[0] == x.LastName[0]);

// //query

// var ras8 = from x in students
//            where x.FirstName[0] == x.LastName[0]
//            select x;

// foreach (var h in ras8)
// {
//     Console.WriteLine(h.FirstName + " " + h.LastName);
// }

// //9
// //Method

// var res9 = students.Where(x => x.DateOfStart.Year < 2000 && x.DateOfFinish.Year > 2000);

// //query

// var ras9 = from x in students
//            where x.DateOfStart.Year < 2000 && x.DateOfFinish.Year > 2000
//            select x;

// foreach (var i in ras9)
// {
//     Console.WriteLine(i.FirstName);
// }

// //10
// //Method

// var res10 = students.Where(x =>
//     x.Gender != Gender.Female &&
//     x.Status == Status.Active &&
//     (x.DateOfFinish - x.DateOfStart).TotalDays > 730 &&
//     x.Age < 16);

// //query

// var ras10 = from x in students
//             where x.Gender != Gender.Female &&
//                   x.Status == Status.Active &&
//                   (x.DateOfFinish - x.DateOfStart).TotalDays > 730 &&
//                   x.Age < 16
//             select x;

// foreach (var j in ras10)
// {
//     Console.WriteLine(j.FirstName);
// }


//ClassTask 2


using System;
using System.Linq;

// var people = new[]
// {
//     new Person
//     {
//         Id = 1,
//         Name = "Ali",
//         Age = 22,
//         CityId = 1
//     },
//     new Person
//     {
//         Id = 2,
//         Name = "Anna",
//         Age = 27,
//         CityId = 2
//     },
//     new Person
//     {
//         Id = 3,
//         Name = "John",
//         Age = 30,
//         CityId = 1
//     },
//     new Person
//     {
//         Id = 4,
//         Name = "Ivan",
//         Age = 5,
//         CityId = 3
//     },
//     new Person
//     {
//         Id = 5,
//         Name = "Amina",
//         Age = 6,
//         CityId = 2
//     },
//     new Person
//     {
//         Id = 6,
//         Name = "David",
//         Age = 25,
//         CityId = 4
//     },
//     new Person
//     {
//         Id = 7,
//         Name = "Emma",
//         Age = 35,
//         CityId = 5
//     },
//     new Person
//     {
//         Id = 8,
//         Name = "Artem",
//         Age = 4,
//         CityId = 6
//     }
// };

// var cities = new[]
// {
//     new City
//     {
//         Id = 1,
//         Name = "Dushanbe"
//     },
//     new City
//     {
//         Id = 2,
//         Name = "Almaty"
//     },
//     new City
//     {
//         Id = 3,
//         Name = "Istaravshan"
//     },
//     new City
//     {
//         Id = 4,
//         Name = "Moscow"
//     },
//     new City
//     {
//         Id = 5,
//         Name = "Ankara"
//     },
//     new City
//     {
//         Id = 6,
//         Name = "Astana"
//     }
// };

// // 1

// // Method
// var res1 = people
//     .Where(x => x.Age > 25)
//     .Select(x => new { x.Name, x.Age });

// foreach (var x in res1)
// {
//     Console.WriteLine(x.Name + " " + x.Age);
// }

// // Query
// var ras1 = from x in people
//            where x.Age > 25
//            select new { x.Name, x.Age };

// foreach (var x in ras1)
// {
//     Console.WriteLine(x.Name + " " + x.Age);
// }


// // 2

// // Method
// var res2 = people
//     .OrderBy(x => x.Age)
//     .ThenBy(x => x.Name);

// foreach (var x in res2)
// {
//     Console.WriteLine(x.Name + " " + x.Age);
// }

// // Query
// var ras2 = from x in people
//            orderby x.Age, x.Name
//            select x;

// foreach (var x in ras2)
// {
//     Console.WriteLine(x.Name + " " + x.Age);
// }


// // 3

// // Method
// var res3 = people.GroupBy(x => x.Name[0]);

// foreach (var group in res3)
// {
//     Console.WriteLine(group.Key);

//     foreach (var x in group)
//     {
//         Console.WriteLine(x.Name);
//     }
// }

// // Query
// var ras3 = from x in people
//            group x by x.Name[0];

// foreach (var group in ras3)
// {
//     Console.WriteLine(group.Key);

//     foreach (var x in group)
//     {
//         Console.WriteLine(x.Name);
//     }
// }


// // 4

// // Method
// var res4 = people.Join(
//     cities,
//     p => p.CityId,
//     c => c.Id,
//     (p, c) => new { p.Name, CityName = c.Name }
// );

// foreach (var x in res4)
// {
//     Console.WriteLine(x.Name + " " + x.CityName);
// }

// // Query
// var ras4 = from p in people
//            join c in cities on p.CityId equals c.Id
//            select new { p.Name, CityName = c.Name };

// foreach (var x in ras4)
// {
//     Console.WriteLine(x.Name + " " + x.CityName);
// }


// // 5

// // Method
// var res5 = people
//     .Where(x => "AEIOU".Contains(char.ToUpper(x.Name[0])))
//     .Sum(x => x.Age);

// Console.WriteLine(res5);

// // Query
// var ras5 = (from x in people
//             where "AEIOU".Contains(char.ToUpper(x.Name[0]))
//             select x.Age).Sum();

// Console.WriteLine(ras5);


// // 6

// // Method
// var res6 = people
//     .GroupBy(x => x.Name[0])
//     .Select(x => new { Letter = x.Key, Count = x.Count() });

// foreach (var x in res6)
// {
//     Console.WriteLine(x.Letter + " " + x.Count);
// }

// // Query
// var ras6 = from x in people
//            group x by x.Name[0] into g
//            select new { Letter = g.Key, Count = g.Count() };

// foreach (var x in ras6)
// {
//     Console.WriteLine(x.Letter + " " + x.Count);
// }


// // 7


// // Method
// var res7 = cities
//     .Select(c => new
//     {
//         c.Name,
//         Count = people.Count(p => p.CityId == c.Id)
//     })
//     .OrderByDescending(x => x.Count)
//     .Take(1);

// foreach (var x in res7)
// {
//     Console.WriteLine(x.Name + " " + x.Count);
// }

// // Query
// var ras7 = (from c in cities
//             let count = people.Count(p => p.CityId == c.Id)
//             orderby count descending
//             select new { c.Name, Count = count }).Take(1);

// foreach (var x in ras7)
// {
//     Console.WriteLine(x.Name + " " + x.Count);
// }


// // 8

// // Method
// var res8 = people.Join(
//     cities,
//     p => p.CityId,
//     c => c.Id,
//     (p, c) => new { p.Name, p.Age, CityName = c.Name }
// )
// .Where(x => x.Age >= 2 && x.Age <= 7 && x.CityName.StartsWith("A"));

// foreach (var x in res8)
// {
//     Console.WriteLine(x.Name + " " + x.Age + " " + x.CityName);
// }

// // Query
// var ras8 = from p in people
//            join c in cities on p.CityId equals c.Id
//            where p.Age >= 2 && p.Age <= 7 && c.Name.StartsWith("A")
//            select new { p.Name, p.Age, CityName = c.Name };

// foreach (var x in ras8)
// {
//     Console.WriteLine(x.Name + " " + x.Age + " " + x.CityName);
// }





using System;
using System.Linq;

var students = new[]
{
    new Student
    {
        Id = 1,
        Name = "Alice",
        DateOfBirth = new DateTime(2000, 5, 15)
    },
    new Student
    {
        Id = 2,
        Name = "Bob",
        DateOfBirth = new DateTime(1999, 8, 25)
    },
    new Student
    {
        Id = 3,
        Name = "Charlie",
        DateOfBirth = new DateTime(2001, 3, 10)
    },
    new Student
    {
        Id = 4,
        Name = "David",
        DateOfBirth = new DateTime(2004, 7, 12)
    },
    new Student
    {
        Id = 5,
        Name = "Emma",
        DateOfBirth = new DateTime(2003, 2, 20)
    },
    new Student
    {
        Id = 6,
        Name = "Frank",
        DateOfBirth = new DateTime(2002, 11, 5)
    }
};

var courses = new[]
{
    new Course
    {
        Id = 101,
        Title = "Mathematics",
        Credits = 4
    },
    new Course
    {
        Id = 102,
        Title = "Computer Science",
        Credits = 3
    },
    new Course
    {
        Id = 103,
        Title = "Physics",
        Credits = 4
    },
    new Course
    {
        Id = 104,
        Title = "English",
        Credits = 2
    }
};

var enrollments = new[]
{
    new Enrollment
    {
        Id = 1,
        StudentId = 1,
        CourseId = 101,
        EnrollmentDate = new DateTime(2023, 1, 15)
    },
    new Enrollment
    {
        Id = 2,
        StudentId = 1,
        CourseId = 102,
        EnrollmentDate = new DateTime(2023, 1, 20)
    },
    new Enrollment
    {
        Id = 3,
        StudentId = 2,
        CourseId = 101,
        EnrollmentDate = new DateTime(2023, 1, 18)
    },
    new Enrollment
    {
        Id = 4,
        StudentId = 3,
        CourseId = 103,
        EnrollmentDate = new DateTime(2023, 1, 22)
    },
    new Enrollment
    {
        Id = 5,
        StudentId = 3,
        CourseId = 101,
        EnrollmentDate = new DateTime(2023, 1, 25)
    },
    new Enrollment
    {
        Id = 6,
        StudentId = 3,
        CourseId = 102,
        EnrollmentDate = new DateTime(2023, 1, 30)
    },
    new Enrollment
    {
        Id = 7,
        StudentId = 4,
        CourseId = 104,
        EnrollmentDate = new DateTime(2023, 2, 1)
    },
    new Enrollment
    {
        Id = 8,
        StudentId = 4,
        CourseId = 103,
        EnrollmentDate = new DateTime(2023, 2, 5)
    },
    new Enrollment
    {
        Id = 9,
        StudentId = 5,
        CourseId = 102,
        EnrollmentDate = new DateTime(2023, 2, 10)
    },
    new Enrollment
    {
        Id = 10,
        StudentId = 6,
        CourseId = 104,
        EnrollmentDate = new DateTime(2023, 2, 15)
    },
    new Enrollment
    {
        Id = 11,
        StudentId = 6,
        CourseId = 101,
        EnrollmentDate = new DateTime(2023, 2, 20)
    }
};

// 1

var res1 = students.Join(
    enrollments,
    s => s.Id,
    e => e.StudentId,
    (s, e) => new { s, e }
)
.Join(
    courses,
    x => x.e.CourseId,
    c => c.Id,
    (x, c) => new { x.s.Name, CourseName = c.Title }
)
.Where(x => x.CourseName == "Mathematics");

foreach (var x in res1)
{
    Console.WriteLine(x.Name);
}

var ras1 = from s in students
           join e in enrollments on s.Id equals e.StudentId
           join c in courses on e.CourseId equals c.Id
           where c.Title == "Mathematics"
           select s;

foreach (var x in ras1)
{
    Console.WriteLine(x.Name);
}

// 2

var res2 = students.Join(
    enrollments,
    s => s.Id,
    e => e.StudentId,
    (s, e) => new { s, e }
)
.Join(
    courses,
    x => x.e.CourseId,
    c => c.Id,
    (x, c) => new { x.s.Name, c.Title }
)
.Where(x => x.Name == "Charlie");

foreach (var x in res2)
{
    Console.WriteLine(x.Title);
}

var ras2 = from s in students
           join e in enrollments on s.Id equals e.StudentId
           join c in courses on e.CourseId equals c.Id
           where s.Name == "Charlie"
           select c;

foreach (var x in ras2)
{
    Console.WriteLine(x.Title);
}

// 3

var res3 = students
    .SelectMany(
        s => enrollments.Where(e => e.StudentId == s.Id),
        (s, e) => new { s.Name, e.CourseId }
    )
    .GroupBy(x => x.Name)
    .Where(g => g.Select(x => x.CourseId).Distinct().Count() > 1)
    .Select(g => g.Key);

foreach (var x in res3)
{
    Console.WriteLine(x);
}

var ras3 = (from s in students
            from e in enrollments
            where s.Id == e.StudentId
            select new { s.Name, e.CourseId })
           .GroupBy(x => x.Name)
           .Where(g => g.Select(x => x.CourseId).Distinct().Count() > 1)
           .Select(g => g.Key);

foreach (var x in ras3)
{
    Console.WriteLine(x);
}

// 4

var res4 = enrollments
    .Join(students, e => e.StudentId, s => s.Id,
        (e, s) => new { s, e })
    .Join(courses, x => x.e.CourseId, c => c.Id,
        (x, c) => new
        {
            Age = GetAge(x.s.DateOfBirth),
            x.s.Name,
            Course = c.Title
        })
    .GroupBy(x =>
        x.Age <= 20 ? "18-20" :
        x.Age <= 23 ? "21-23" : "24+")
    .Select(g => new
    {
        AgeRange = g.Key,
        Courses = g.GroupBy(x => x.Course)
            .Select(c => new
            {
                Course = c.Key,
                AverageAge = c.Average(x => x.Age)
            })
    });

foreach (var group in res4)
{
    Console.WriteLine(group.AgeRange);

    foreach (var x in group.Courses)
    {
        Console.WriteLine(x.Course + " " + x.AverageAge);
    }
}

var ras4 = (from e in enrollments
            join s in students on e.StudentId equals s.Id
            join c in courses on e.CourseId equals c.Id
            select new
            {
                Age = GetAge(s.DateOfBirth),
                s.Name,
                Course = c.Title
            })
           .GroupBy(x =>
               x.Age <= 20 ? "18-20" :
               x.Age <= 23 ? "21-23" : "24+")
           .Select(g => new
           {
               AgeRange = g.Key,
               Courses = g.GroupBy(x => x.Course)
                   .Select(c => new
                   {
                       Course = c.Key,
                       AverageAge = c.Average(x => x.Age)
                   })
           });

foreach (var group in ras4)
{
    Console.WriteLine(group.AgeRange);

    foreach (var x in group.Courses)
    {
        Console.WriteLine(x.Course + " " + x.AverageAge);
    }
}

// 5

var res5 = students.Join(
    enrollments,
    s => s.Id,
    e => e.StudentId,
    (s, e) => new { s, e }
)
.Join(
    courses,
    x => x.e.CourseId,
    c => c.Id,
    (x, c) => new
    {
        Student = x.s.Name,
        Course = c.Title,
        x.e.EnrollmentDate,
        c.Credits
    }
)
.Where(x =>
    x.EnrollmentDate >= new DateTime(2023, 1, 20)
    && x.Credits >= 4);

foreach (var x in res5)
{
    Console.WriteLine(x.Student + " " + x.Course);
}

var ras5 = from s in students
           join e in enrollments on s.Id equals e.StudentId
           join c in courses on e.CourseId equals c.Id
           where e.EnrollmentDate >= new DateTime(2023, 1, 20)
                 && c.Credits >= 4
           select new
           {
               Student = s.Name,
               Course = c.Title,
               e.EnrollmentDate,
               c.Credits
           };

foreach (var x in ras5)
{
    Console.WriteLine(x.Student + " " + x.Course);
}

// 6

var res6 = students.Select(s => new
{
    s.Name,
    TotalCredits = enrollments
        .Where(e => e.StudentId == s.Id)
        .Join(courses,
            e => e.CourseId,
            c => c.Id,
            (e, c) => c.Credits)
        .Sum()
});

foreach (var x in res6)
{
    Console.WriteLine(x.Name + " " + x.TotalCredits);
}

var ras6 = from s in students
           let total = (from e in enrollments
                        join c in courses on e.CourseId equals c.Id
                        where e.StudentId == s.Id
                        select c.Credits).Sum()
           select new
           {
               s.Name,
               TotalCredits = total
           };

foreach (var x in ras6)
{
    Console.WriteLine(x.Name + " " + x.TotalCredits);
}

// 7

var res7 = courses.Select(c => new
{
    c.Title,
    Count = enrollments
        .Where(e => e.CourseId == c.Id)
        .Select(e => e.StudentId)
        .Distinct()
        .Count()
});

foreach (var x in res7)
{
    Console.WriteLine(x.Title + " " + x.Count);
}

var ras7 = from c in courses
           select new
           {
               c.Title,
               Count = (from e in enrollments
                        where e.CourseId == c.Id
                        select e.StudentId).Distinct().Count()
           };

foreach (var x in ras7)
{
    Console.WriteLine(x.Title + " " + x.Count);
}

// 8

var res8 = courses.Where(c =>
    !enrollments.Any(e =>
        e.CourseId == c.Id &&
        students.Any(s => s.Id == e.StudentId && s.Name == "Bob")
    )
);

foreach (var x in res8)
{
    Console.WriteLine(x.Title);
}

var ras8 = from c in courses
           where !(from e in enrollments
                   join s in students on e.StudentId equals s.Id
                   where s.Name == "Bob" && e.CourseId == c.Id
                   select e).Any()
           select c;

foreach (var x in ras8)
{
    Console.WriteLine(x.Title);
}

int GetAge(DateTime dateOfBirth)
{
    int age = DateTime.Today.Year - dateOfBirth.Year;

    if (dateOfBirth.Date > DateTime.Today.AddYears(-age))
    {
        age--;
    }

    return age;
}





               