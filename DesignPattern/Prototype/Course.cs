namespace Prototype
{
    internal class Course : ICloneable
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Fee { get; set; }
        public Instructor instructor { get; set; }
        public List<Topic>topics{ get; set; }

        public object Clone()
        {
            Course course = (Course)this.MemberwiseClone();
            course.instructor = (Instructor)this.instructor.Clone();
            course.topics = (List<Topic>)this.topics.Clone();

            return course;
        }
    }
}
