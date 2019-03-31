using UnityEngine;

public abstract class BaseView<T> : MonoBehaviour where T : Presenter
{
	protected T Presenter;
	
	protected CanvasGroup CanvasGroup;

	public void SetPresenter(IPresenter presenter)
	{
		CanvasGroup = GetComponent<CanvasGroup>();
		Presenter = presenter as T;
	}
}
