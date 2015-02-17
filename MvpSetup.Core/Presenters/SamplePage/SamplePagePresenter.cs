namespace MvpSetup.Core.Presenters.SamplePage
{
    public class SamplePagePresenter : PresenterBase
    {
        private readonly ISamplePageView _view;

        // Can add other dependencies to constructor.
        // EX: public SamplePagePresenter(ISamplePageView samplePageView, ILoginService loginService)
        public SamplePagePresenter(ISamplePageView view)
        {
            _view = view;
        }

        public override void Init()
        {
            // Initialization code goes here
        }

        public override void FirstTimeInit()
        {
            // If Not IsPostback kinds of initialization code.
            // Only fires on initial load of page, not postbacks.
        }

        public override void Load()
        {
            // Page load code goes here
        }

        public override void PreRender()
        {
            // PreRender code goes here
        }
    }
}
