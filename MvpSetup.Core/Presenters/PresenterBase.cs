namespace MvpSetup.Core.Presenters
{
    public abstract class PresenterBase
    {       
        public virtual void Init() { } // First to fire
        public virtual void FirstTimeInit() { } // First part of Load
        public virtual void Load() { } // 2nd or 3rd to fire
        public virtual void PreRender() { } // Last to fire
    }
}
