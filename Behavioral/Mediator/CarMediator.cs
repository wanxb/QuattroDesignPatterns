namespace QuattroDesignPatterns.Behavioral.Mediator
{
    public class CarMediator : IMediator
    {
        private readonly Radio _radio;
        private readonly NavigationSystem _navigationSystem;

        public CarMediator(Radio radio, NavigationSystem navigationSystem)
        {
            _radio = radio;
            _radio.SetMediator(this);

            _navigationSystem = navigationSystem;
            _navigationSystem.SetMediator(this);
        }

        public void Notify(object sender, string ev)
        {
            if (ev == "NavigationVoice")
            {
                _radio.AdjustVolumeForNavigation();
            }
        }
    }
}