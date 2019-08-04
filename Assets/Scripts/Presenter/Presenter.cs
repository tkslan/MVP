namespace Presenter
{
    public abstract class Presenter : IPresenter
    {
        protected View.IView View;
        protected object Data;

        public abstract void UpdateView();
        public abstract void OnOpened();
        
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