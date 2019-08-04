using Presenter;
using UnityEngine;

namespace View
{
    public abstract class BaseView<T> : MonoBehaviour where T : IPresenter
    {
        protected IPresenter Presenter;
        
        protected CanvasGroup CanvasGroup;

        public void SetPresenter(IPresenter presenter)
        {
            CanvasGroup = GetComponent<CanvasGroup>();
            Presenter = presenter;
        }
    }
}