namespace FigureLibrary
{
    public class CircleFigure : Figure
    {
        public CircleFigure(double radius) : base()
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException("Радиус не может быть отрицательным");

            Radius = radius;
            Square = CalculateSquare();
        }

        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius { get; }

        protected override double CalculateSquare()
        {
            return (Math.PI * Math.Pow(Radius, 2));
        }
    }


}