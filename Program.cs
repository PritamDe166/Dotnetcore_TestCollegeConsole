

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
Console.WriteLine(studentService.GetStudentsList());

#endregion

Console.ReadLine();

