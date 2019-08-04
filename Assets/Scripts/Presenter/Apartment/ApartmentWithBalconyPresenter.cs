using UnityEngine;
using UnityEngine.UI;

namespace Presenter.Apartment
{
    public class ApartmentWithBalconyPresenter :
            ViewPresenter<View.Apartment.ApartmentBalconyView, Model.ApartmentBalcony>
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

        public override void OnOpened()
        {
        }


        public void ChangedBalconyToggle(bool toggleActive)
        {
            Debug.Log(this + " ChangedToggleState: " + toggleActive);
        }
    }
}