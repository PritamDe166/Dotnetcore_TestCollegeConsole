
#region ConfigureServices

var host = Host.CreateDefaultBuilder(args)
            .ConfigureServices((context, services) =>
            {
                services.AddStudentServices();
            })
            .Build();
#endregion

#region StudentService

var studentService = host.Services.GetRequiredService<IStudentService>();
IEnumerable<Student> students = await studentService.GetStudentsListAsync();

foreach(var student in students)
{
    Console.WriteLine($"Student Name: {student.Name}");
}

#endregion

Console.ReadLine();

