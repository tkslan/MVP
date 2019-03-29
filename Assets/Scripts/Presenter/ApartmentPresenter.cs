using System.Collections;


public class ApartmentPresenter: BasePresenter
{
    private readonly Apartment _apartment;
    private ApartmentView apartmentView;

    public ApartmentPresenter(Apartment apartment, ApartmentView view)
    {
        _apartment = apartment;
        apartmentView = view;
        view.SetPresenter(this);
        base.SetView(view);
    }

    public override void UpdateView()
    {
        apartmentView.SetFloor(_apartment.Floor);
        apartmentView.SetRooms(_apartment.Rooms);
        apartmentView.SetMeters(_apartment.Meters);
    }
}
