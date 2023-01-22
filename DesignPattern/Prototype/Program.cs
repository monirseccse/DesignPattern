using Prototype;

Course Course = new Course
{
    Id = 1,
    Title = "C#",
    Fee = 8000,
    instructor=new Instructor { Id = 1, Name = "Monir" }
};

Console.WriteLine($@"Course Title = {Course.Title} Fee = {Course.Fee}
 InstructorName = {Course.instructor.Name}");

Console.WriteLine("Cloned Object below");

Course course2 =(Course)Course.Clone();
course2.Title ="Java";

Console.WriteLine($@"Course Title = {course2.Title} Fee = {course2.Fee}
 InstructorName = {course2.instructor.Name}");
