
public class ApartmentPresenter : Presenter
{
	protected ApartmentView ApartmentView;
	protected Apartment Apartment;
	public override void SetView(IView view)
	{
		base.SetView(view);
		Apartment = Data as Apartment;
		ApartmentView = View as ApartmentView;
	}
	public override void UpdateView()
	{
		ApartmentView.Floor = $"Floor : {Apartment.Floor}";
		ApartmentView.Rooms = $"Rooms : {Apartment.Rooms}";
		ApartmentView.Meters = $"Meters: {Apartment.Meters}";
	}
}

