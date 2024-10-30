namespace QuattroDesignPatterns.Behavioral.Mediator
{
    public class NavigationSystem
    {
        private IMediator _mediator;

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void IssueVoicePrompt()
        {
            Console.WriteLine("Navigation system is issuing a voice prompt.");
            _mediator.Notify(this, "NavigationVoice");
        }
    }
}