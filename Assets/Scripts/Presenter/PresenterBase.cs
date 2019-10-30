using System;

namespace Presenter
{
    public abstract class PresenterBase : IPresenter
    {
        protected View.IView View;
        protected object Data;

        protected PresentersController Controller;
        public abstract void UpdateView();
        protected abstract void OnOpened();

        public static Action<IPresenter> OnCreated, OnDisposed = null;

        public void SetController(PresentersController controller)
        {
            Controller = controller;
        }

        public PresentersController  GetController()
        {
            return Controller;
        }

        protected PresenterBase()
        {
            OnCreated?.Invoke(this);
        }
        public virtual void HideView()
        {
            View.Visible = View.Interactable = false;
        }

        public virtual void ShowView()
        {
            UpdateView();
            View.Interactable = View.Visible = true;
            OnOpened();
        }

        public void DisposeView()
        {
            UnityEngine.Object.Destroy(View.GetGameObject);
            View = null;
            OnDisposed?.Invoke(this);
        }
        
        public virtual void SetView(View.IView view, object data)
        {
            Data = data;
            SetView(view);
        }

        private void SetView(View.IView view)
        {
            View = view;
            View.SetPresenter(this);
            HideView();
        }
    }
}