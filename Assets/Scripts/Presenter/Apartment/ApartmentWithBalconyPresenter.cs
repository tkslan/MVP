using UnityEditor.UIElements;
using UnityEngine;

public class ApartmentWithBalconyPresenter : ViewPresenter
{
    ApartmentBalcony Apartment;
    ApartmentBalconyView ApartmentView;

    public override void UpdateView()
    {
        Apartment = Data as ApartmentBalcony;
        ApartmentView = View as ApartmentBalconyView;
        ApartmentView.Floor = $"Floor : {Apartment.Floor}";
        ApartmentView.Rooms = $"Rooms : {Apartment.Rooms}";
        ApartmentView.Meters = $"Meters: {Apartment.Meters}";
        ApartmentView.HasBalcony = Apartment.Balcony;
        ApartmentView.BalconyMeters = "Balcony meters:" + Apartment.BalconyMeters.ToString();
    }

    public void ChangedBalconyToggle(bool toggleActive)
    {
        Debug.Log(this + " ChangedToggleState: " + toggleActive);
    }
}