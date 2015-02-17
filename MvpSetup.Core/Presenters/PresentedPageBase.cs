using System;
using System.Web;
using System.Web.UI;
using MvpSetup.Core.Framework;

namespace MvpSetup.Core.Presenters
{
    public abstract class PresentedPageBase<TPresenterType> : Page, IView where TPresenterType : PresenterBase
    {
        protected TPresenterType Presenter;

        protected override void OnInit(EventArgs e)
        {
            Presenter = CreatePresenter();
            base.OnInit(e);
            Presenter.Init();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (!IsPostBack)
                Presenter.FirstTimeInit();

            Presenter.Load();
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            Presenter.PreRender();
        }

        protected TPresenterType CreatePresenter()
        {
            return Ioc.GetPresenter<TPresenterType>(this);
        }

        public MasterPage MasterPage { get { return Page.Master; } }

        public virtual Uri Uri { get { return HttpContext.Current.Request.Url; } }
    }
}
