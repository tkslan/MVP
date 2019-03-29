
public class ApartmentPresenter : BasePresenter
{
	private readonly Apartment _apartment;
	private ApartmentView _apartmentView;

	public ApartmentPresenter(Apartment apartment, ApartmentView view)
	{
		_apartment = apartment;
		_apartmentView = view;
		view.SetPresenter(this);
		base.SetView(view);
	}

	public override void UpdateView()
	{
		_apartmentView.Floor =$"Floor : {_apartment.Floor}";
		_apartmentView.Rooms = $"Rooms : {_apartment.Rooms}";
		_apartmentView.Meters = $"Meters: {_apartment.Meters}";
	}
}
