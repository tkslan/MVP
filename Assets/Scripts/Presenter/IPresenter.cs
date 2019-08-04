
namespace Presenter
{
	public interface IPresenter
	{
		void SetView(View.IView view, object data);
		void HideView();
		void ShowView();
		void UpdateView();
		void DisposeView();
	}
}
