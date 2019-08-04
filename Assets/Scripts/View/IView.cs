using Presenter;
using UnityEngine;

namespace View
{
    public interface IView
    {
        bool Interactable { get; set; }
        bool Visible { get; set; }
        void SetPresenter(IPresenter presenter);
        GameObject GetGameObject { get; }
    }
}
