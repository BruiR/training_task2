namespace Task2_2
{
    public abstract class Entity
    {
        public string Description { get; set; } = string.Empty;
        public abstract Entity Clone();
    }
}
