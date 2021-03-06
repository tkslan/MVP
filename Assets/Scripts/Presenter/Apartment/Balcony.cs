using UnityEngine;
using UnityEngine.UI;

namespace Presenter.Apartment
{
    public class Balcony :
            Presenter<View.Apartment.ApartmentBalconyView, Model.ApartmentBalcony>
    {
        public override void UpdateView()
        {
            base.UpdateView();
            View.Floor = $"Floor : {Data.Floor}";
            View.Rooms = $"Rooms : {Data.Rooms}";
            View.Meters = $"Meters: {Data.Meters}";
            View.HasBalcony = Data.Balcony;
            View.BalconyMeters = "Balcony meters:" + Data.BalconyMeters;
        }

        protected override void OnOpened()
        {
        }


        public void ChangedBalconyToggle(bool toggleActive)
        {
            Debug.Log(this + " ChangedToggleState: " + toggleActive);
        }
    }
}