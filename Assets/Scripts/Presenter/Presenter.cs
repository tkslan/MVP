public abstract class Presenter : IPresenter
{
    protected IView View;
    protected object Data;

    public abstract void UpdateView();

    public virtual void HideView()
    {
        View.Visible = View.Interactable = false;
    }

    public virtual void ShowView()
    {
        UpdateView();
        View.Interactable = View.Visible = true;
    }

    public void DisposeView()
    {
        UnityEngine.Object.Destroy(View.GetGameObject);
        View = null;
    }

    public virtual void SetView(IView view, object data)
    {
        Data = data;
        SetView(view);
    }

    private void SetView(IView view)
    {
        View = view;
        View.SetPresenter(this);
        HideView();
    }
}