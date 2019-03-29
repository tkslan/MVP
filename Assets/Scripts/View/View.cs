using UnityEngine;
[RequireComponent(typeof(CanvasGroup))]
public class View : BaseView<BasePresenter>, IView
{
    public void CloseThisView()
    {
        Presenter.HideView();
    }

}
