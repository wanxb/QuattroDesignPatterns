namespace QuattroDesignPatterns.Behavioral.Mediator
{
    public class Radio
    {
        private IMediator _mediator;

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void PlayMusic()
        {
            Console.WriteLine("Radio is playing music.");
        }

        public void AdjustVolumeForNavigation()
        {
            Console.WriteLine("Adjusting radio volume for navigation voice prompt.");
        }
    }
}