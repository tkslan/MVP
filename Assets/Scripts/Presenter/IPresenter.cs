
namespace Presenter
{
	public interface IPresenter
	{
		void SetView(View.IView view, object data);
		void SetController(PresentersController controller);
		void HideView();
		void ShowView();
		void UpdateView();
		void DisposeView();
		PresentersController GetController();
	}
}
