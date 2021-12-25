namespace Task2_2
{
    public class Practice : Lesson
    {
        public string Task { get; set; } = string.Empty;
        public string Solution { get; set; } = string.Empty;
        public override Practice Clone()
        {
            return new Practice {Task = this.Task, Solution = this.Solution,  Description = this.Description};
        }


        public override string ToString()
        {
            string outputString = $"Practice: Task => {Task}; Solution => {Solution}; Description => {Description} \n";
            return outputString;
        }
    }
}
