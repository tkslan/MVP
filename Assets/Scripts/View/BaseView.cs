using UnityEngine;

public abstract class BaseView<T>: MonoBehaviour where T: BasePresenter
{
    protected T Presenter;

    public bool Interactable
    {
        get
        {
        return canvasGroup.interactable;
        }
        set
        {
            canvasGroup.interactable = value;
        }
    }
    public bool Visible
    {
        get { return canvasGroup.alpha < 0.1f; }
        set { canvasGroup.alpha = value ? 1f : 0f; }
    }
    private CanvasGroup canvasGroup;
    public void SetPresenter(IPresenter presenter)
    {
        canvasGroup = GetComponent<CanvasGroup>();
        Presenter = presenter as T;
    }
}
