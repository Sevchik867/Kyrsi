namespace lesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(4);
            Rectangle rectangle1 = new Rectangle(3, 4);
            Rectangle rectangle2 = new Rectangle(4, 5);
            Triangle triangle1 = new Triangle(3, 4, 2);
            Triangle triangle2 = new Triangle(4, 5, 3);

            Figure[] array = {circle, rectangle1, rectangle2, triangle1, triangle2};
            foreach (Figure f in array)
            {
                f.Perimeter();
            }
        }
    }
}
