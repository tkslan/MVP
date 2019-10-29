using System;

namespace Presenter
{
    public abstract class Presenter : IPresenter
    {
        protected View.IView View;
        protected object Data;

        public PresentersController Controller;
        public abstract void UpdateView();
        public abstract void OnOpened();

        public static Action<IPresenter> OnCreated, OnDisposed = null;

        public void SetController(PresentersController controller)
        {
            Controller = controller;
        }

        public PresentersController  GetController()
        {
            return Controller;
        }
        
        public Presenter()
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