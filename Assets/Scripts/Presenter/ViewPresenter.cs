using System.Linq;
using UnityEngine;

public abstract class ViewPresenter<T> : Presenter where T : IView
{
    protected T View => (T) base.View;

    private T LoadView(Transform parentTransform)
    {
        var views = Resources.LoadAll<View>("Views");
        var loadedView = views.ToList().Find(f => f is T);
        var view = GameObject.Instantiate(loadedView, parentTransform);
        view.name = loadedView.name;
        return view.GetComponent<T>();
    }

    public T OpenView(Transform parentTransform, object data, bool autoShow = true)
    {
        var view = LoadView(parentTransform);
        this.SetView(view, data);
        if (autoShow) this.ShowView();
        return view;
    }
}