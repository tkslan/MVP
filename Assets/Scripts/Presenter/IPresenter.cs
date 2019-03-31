
public interface IPresenter
{
	void SetView(IView view, object data);
	void HideView();
	void ShowView();
	void UpdateView();
}
