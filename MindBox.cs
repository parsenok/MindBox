namespace MindBox
{
    public interface IShape
    {
        double CalculateArea();
    }

    public class Circle : IShape
    {
        public double radius { get; set; }
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

    }
    public class Triangle : IShape
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public double side3 { get; set; }
        public double CalculateArea()
        {
            double Perimeter = (side1 + side2 + side3) / 2;
            return Math.Sqrt(Perimeter * (Perimeter - side1) * (Perimeter - side2) * (Perimeter - side3));
        }

    }
}
