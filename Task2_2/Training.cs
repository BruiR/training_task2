using System;

namespace Task2_2
{
    public class Training : Entity
    {
        private Lesson[] _lessons = Array.Empty<Lesson>();
        public void Add(Lesson lesson)
        {
            Array.Resize(ref _lessons, _lessons.Length + 1);
            _lessons[^1] = lesson;
        }
        public bool IsPractical()
        {
            for (int i = 0; i < _lessons.Length; i++)
            {
                if(!(_lessons[i] is Practice))
                {
                    return false;
                }
            }
            return true;
        }

        public override Training Clone()
        {
            Training trainingClone = new Training { Description = this.Description };
            for (int i = 0; i < _lessons.Length; i++)
            {
                trainingClone.Add(_lessons[i].Clone());
            }
            return trainingClone;
        }

        public override string ToString()
        {
            string outputString = string.Empty;
            outputString += $"Training: Description => {Description} \n";
            for (int i = 0; i < _lessons.Length; i++)
            {
                outputString+= _lessons[i].ToString();
            }
            return outputString;
        }
    }
}
