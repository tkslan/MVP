public class ApartmentPresenter : ViewPresenter
{
    protected ApartmentView ApartmentView;
    protected Apartment Apartment;

    public override void UpdateView()
    {
        Apartment = Data as Apartment;
        ApartmentView = View as ApartmentView;
        ApartmentView.Floor = $"Floor : {Apartment.Floor}";
        ApartmentView.Rooms = $"Rooms : {Apartment.Rooms}";
        ApartmentView.Meters = $"Meters: {Apartment.Meters}";
    }

}