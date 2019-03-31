

public class Presenter : IPresenter
{
	protected IView View;
	protected object Data;
	protected Main Controller;
	public virtual void UpdateView() { }

	public virtual void HideView()
	{
		View.Visible = View.Interactable = false;
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

	public virtual void SetView(IView view)
	{
		View = view;
		View.SetPresenter(this);
		HideView();
	}

	public virtual void SetView(IView view, object data)
	{
		Data = data;
		SetView(view);
	}
	public virtual void SetView(IView view, object data, Main controller)
	{
		Controller = controller;
		SetView(view, data);
	}
}
