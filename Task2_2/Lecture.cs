namespace Task2_2
{
    public class Lecture : Lesson
    {
        public string Topic { get; set; } = string.Empty;
        public override Lecture Clone()
        {
            return new Lecture {Topic = this.Topic, Description = this.Description};
        }

        public override string ToString()
        {
            string outputString = $"Lecture: Topic => {Topic}; Description => {Description} \n";
            return outputString;
        }
    }
}
