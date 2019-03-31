using System.Linq;
using UnityEngine;

public abstract class ViewPresenter : Presenter
{
	private T LoadView<T>(Transform parentTransform)
	{
		var views = Resources.LoadAll<View>("Views");
		var loadedView = views.ToList().Find(f => f is T);
		var view = GameObject.Instantiate(loadedView, parentTransform);
		view.name = loadedView.name;
		return view.GetComponent<T>();
	}

	public T OpenView<T>(Transform parentTransform, object data, bool autoShow=true) where T : IView
	{
		var view = LoadView<T>(parentTransform);
		this.SetView(view, data);
		if(autoShow) this.ShowView();
		return view;
	}
}
