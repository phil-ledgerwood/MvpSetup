using System;
using System.Web;
using System.Web.UI;
using MvpSetup.Core.Framework;

namespace MvpSetup.Core.Presenters
{
    public class PresentedControlBase<T> : UserControl, IView where T : PresenterBase
    {
        protected T Presenter;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Presenter = CreatePresenter();

            if (!IsPostBack)
                Presenter.FirstTimeInit();

            Presenter.Load();
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            Presenter.PreRender();
        }

        protected T CreatePresenter()
        {
            return Ioc.GetPresenter<T>(this);
        }

        public MasterPage MasterPage
        {
            get { return Page.Master; }
        }

        public Uri Uri
        {
            get { return HttpContext.Current.Request.Url; }
        }
    }
}
