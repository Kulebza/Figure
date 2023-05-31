
namespace FigureLibrary
{
    public class TriangleFigure : Figure
    {
        public TriangleFigure(double a, double b, double c) : base()
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentOutOfRangeException("Сторона треугольника должна быть больше 0");

            A = a;
            B = b;
            C = c;
            IsRectangular = CheckIfIsRectangular();
            Square = CalculateSquare();
        }

        public double A { get; }
        public double B { get; }
        public double C { get; }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IsRectangular { get; }

        protected override double CalculateSquare()
        {
            double HalfPerimeter = (A + B + C) / 2;
            return Math.Sqrt(HalfPerimeter * 
                            (HalfPerimeter - A) *
                            (HalfPerimeter - B) *
                            (HalfPerimeter - C));
        }

        private bool CheckIfIsRectangular()
        {
            var maxSide = A;
            if (B > A)
                maxSide = B;
            if (C > B)
                maxSide = C;
            return 2*Math.Pow(maxSide, 2) == Math.Pow(A, 2) + Math.Pow(B, 2) + Math.Pow(C, 2);
        }
    }
}
