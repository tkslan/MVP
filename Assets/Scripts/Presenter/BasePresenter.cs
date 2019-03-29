public class BasePresenter : IPresenter
{ 
    protected IView view;

    public virtual void HideView()
    {
        view.Visible = view.Interactable = false;
    }

    public virtual void SetView(IView v)
    {
        view = v;
        view.SetPresenter(this);
    }

    public virtual void ShowView()
    {
        UpdateView();
        view.Interactable = view.Visible = true;
    }

    public virtual void UpdateView()
    {

    }

    public void Dispose()
    {
        view = null;
    }
}
