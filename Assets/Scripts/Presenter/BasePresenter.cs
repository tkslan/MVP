public abstract class BasePresenter : IPresenter
{
	protected IView View;
	public abstract void UpdateView();

	public virtual void HideView()
	{
		View.Visible = View.Interactable = false;
	}

	public virtual void SetView(IView view)
	{
		View = view;
		View.SetPresenter(this);
	}

	public virtual void ShowView()
	{
		UpdateView();
		View.Interactable = View.Visible = true;
	}

	public void Dispose()
	{
		View = null;
	}
}
