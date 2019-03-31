public class Apartment3dPresenter : ApartmentPresenter
{
    public override void UpdateView()
    {
        base.UpdateView();
        ApartmentView.Meters = $"Meters in 3D: {(Apartment.Meters * 1.2f).ToString()}";
    }

    public void DebugInfo()
    {
        UnityEngine.Debug.Log(this + "" + Apartment.Rooms);
    }

    public void ShowBasePanel()
    {
        var cachedTransform = View.GetGameObject.transform.parent;
        DisposeView();
        OpenView<ApartmentView>(cachedTransform, new Apartment() {Meters = 255, Floor = 128, Rooms = 64});
    }
    public void OpenBalconyApartmentView()
    {
        var apartment = new ApartmentBalcony()
            {Balcony = true, BalconyMeters = 7, Floor = 1, Meters = 77, Rooms = 3};
        var apartmentPresenter = new ApartmentWithBalconyPresenter();
        apartmentPresenter.OpenView<ApartmentBalconyView>(ApartmentView.transform.parent, apartment);
        //  AddPresenter(apartmentPresenter);
    }
}