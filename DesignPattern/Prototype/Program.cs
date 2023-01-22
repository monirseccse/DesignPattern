using Prototype;

Course Course = new Course
{
    Id = 1,
    Title = "C#",
    Fee = 8000,
    instructor=new Instructor { Id = 1, Name = "Monir" },
    topics=new List<Topic> 
    {
        new Topic{Id=5,Name="Data Type"},
        new Topic{Id=6,Name="Extension Method"}
    }
};

Console.WriteLine($@"Course Title = {Course.Title} , Fee = {Course.Fee}
 , InstructorName = {Course.instructor.Name} , TopicName = {Course.topics.FirstOrDefault().Name}");

Console.WriteLine();
Console.WriteLine("Cloned Object below");
Console.WriteLine();

Course course2 =(Course)Course.Clone();
course2.Title ="Java";
course2.topics.ForEach(x=>
{
    x.Name = "Generic";
});

Console.WriteLine($@"Course Title = {course2.Title} , Fee = {course2.Fee}
 , InstructorName = {course2.instructor.Name} , TopicName = {course2.topics.FirstOrDefault().Name}");
