using UnityEditor.UIElements;
using UnityEngine;

public class ApartmentWithBalconyPresenter : ViewPresenter<ApartmentBalconyView>
{
    ApartmentBalcony Apartment;

    public override void UpdateView()
    {
        Apartment = Data as ApartmentBalcony; ;
        View.Floor = $"Floor : {Apartment.Floor}";
        View.Rooms = $"Rooms : {Apartment.Rooms}";
        View.Meters = $"Meters: {Apartment.Meters}";
        View.HasBalcony = Apartment.Balcony;
        View.BalconyMeters = "Balcony meters:" + Apartment.BalconyMeters.ToString();
    }

    public void ChangedBalconyToggle(bool toggleActive)
    {
        Debug.Log(this + " ChangedToggleState: " + toggleActive);
    }
}