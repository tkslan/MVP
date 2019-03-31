using UnityEngine;
[RequireComponent(typeof(CanvasGroup))]
public class View : BaseView<Presenter>, IView
{
	public void CloseThisView()
	{
		Presenter.HideView();
		Destroy(this.gameObject);
	}
}
