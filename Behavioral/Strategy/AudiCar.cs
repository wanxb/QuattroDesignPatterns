namespace QuattroDesignPatterns.Behavioral.Strategy
{
    public class AudiCar
    {
        private IDrivingMode _drivingMode;

        public AudiCar(IDrivingMode drivingMode)
        {
            _drivingMode = drivingMode;
        }

        public void SetDrivingMode(IDrivingMode drivingMode)
        {
            _drivingMode = drivingMode;
        }

        public void Drive()
        {
            _drivingMode.Drive();
        }
    }
}