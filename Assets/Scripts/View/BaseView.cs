using UnityEngine;

public abstract class BaseView<T> : MonoBehaviour where T : BasePresenter
{
	protected T Presenter;
	protected GameObject GetGameObject { get { return gameObject; } }
	public bool Interactable
	{
		get { return _canvasGroup.interactable; }
		set { _canvasGroup.interactable = _canvasGroup.blocksRaycasts = value; }
	}
	public bool Visible
	{
		get { return _canvasGroup.alpha > 0.9f; }
		set { _canvasGroup.alpha = value ? 1f : 0f; }
	}

	private CanvasGroup _canvasGroup;

	public void SetPresenter(IPresenter presenter)
	{
		_canvasGroup = GetComponent<CanvasGroup>();
		Presenter = presenter as T;
	}
}
