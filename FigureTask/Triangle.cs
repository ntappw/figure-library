namespace FigureTask
{
    public class Triangle : IFigure
    {
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;

        #region Fields
        public double FirstSide
        {
            get => _firstSide;
            set => _firstSide = value;
        }
        public double SecondSide
        {
            get => _secondSide;
            set => _secondSide = value;
        }
        public double ThirdSide
        {
            get => _thirdSide;
            set => _thirdSide = value;
        }
        #endregion

        public Triangle() { }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }

        public double GetСapacity()
        {
            double p = GetHalfPerimeter();
            return Math.Sqrt(p * (p - _firstSide) * (p - _secondSide) * (p - _thirdSide));
        }

        /// <summary>
        /// Is the triangle right angled
        /// </summary>
        /// <returns>True or false value</returns>
        public bool IsRectangular()
            => (Math.Pow(_firstSide,2) == Math.Pow(_secondSide, 2) + Math.Pow(_thirdSide, 2))
        || (Math.Pow(_secondSide, 2) == Math.Pow(_firstSide, 2) + Math.Pow(_thirdSide, 2))
        || (Math.Pow(_thirdSide, 2) == Math.Pow(_firstSide, 2) + Math.Pow(_secondSide, 2)) ? true : false;

        public double GetPerimeter() => _firstSide + _secondSide + _thirdSide;

        public double GetHalfPerimeter() => GetPerimeter() / 2;

        public override string ToString()
                => $"[Triangle]" +
                   $"\nFirstSide = {_firstSide} | SecondSide = {_secondSide} | ThirdSide = {_thirdSide}" +
                   $"\nCapacity = {GetСapacity()}" +
                   $"\nPerimiter = {GetPerimeter()}";
    }
}