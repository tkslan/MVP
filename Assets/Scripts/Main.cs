using System.Linq;
using UnityEngine;

public class Main : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
		Open3dApartmentView(new Apartment() { Floor = 2, Meters = 123, Rooms = 2 });
	}
	void Open3dApartmentView(Apartment apartment)
	{
		var view = OpenView<ApartmentView, ApartmentPresenter>(apartment);
	}
	T LoadView<T>()
	{
		var views = Resources.LoadAll<View>("Views");
		var loadedView = views.ToList().Find(f => f is T);
		var view = Instantiate(loadedView, transform);
		view.name = loadedView.name;
		return view.GetComponent<T>();
	}

	public Tpresenter OpenView<T, Tpresenter>(object data) where T : IView where Tpresenter : BasePresenter, new()
	{
		var view = LoadView<T>();
		var presenter = new Tpresenter();
		presenter.SetView(view, data, this);
		return presenter;
	}
}
