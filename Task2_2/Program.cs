using System;

namespace Task2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Practice practice1 = new Practice() 
            { 
                Task = "practice1_Task_String",
                Solution = "practice1_Solution_String",
                Description= "practice1_Description_String"
            };
            Practice practice2 = new Practice()
            {
                Task = "practice2_Task_String",
                Solution = "practice2_Solution_String",
                Description = "practice2_Description_String"
            };

            Training training = new Training() {Description = "training_Description_String"};
            training.Add(practice1);
            training.Add(practice2);
            Console.WriteLine($"training.IsPractical() => {training.IsPractical()}");
            Console.WriteLine(training);

            Training trainingClone = training.Clone();
            Console.WriteLine("trainingClone:");
            Console.WriteLine($"trainingClone.IsPractical() => {trainingClone.IsPractical()}");
            Console.WriteLine(trainingClone);


            Lecture lecture1 = new Lecture()
            {
                Topic = "lecture1_Topic_String",
                Description = "lecture1_Description_String"
            };

            Lecture lecture2 = new Lecture()
            {
                Topic = "lecture2_Topic_String",
                Description = "lecture2_Description_String"
            };
            training.Add(lecture1);
            training.Add(lecture2);
            Console.WriteLine("after adding lessons:");
            Console.WriteLine($"training.IsPractical() => {training.IsPractical()}");
            Console.WriteLine($"trainingClone.IsPractical() => {trainingClone.IsPractical()}\n");
            Console.WriteLine($"trainingClone => \n{trainingClone}");
            Console.WriteLine($"training => \n{training}");


        }
    }
}
