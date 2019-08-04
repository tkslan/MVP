using UnityEngine;

namespace View.Apartment
{
    public sealed class ApartmentView : View
    {
        [SerializeField] private UnityEngine.UI.Text metersText, floorText, roomsText;

        public string Meters
        {
            get => metersText.text;
            set => metersText.text = value;
        }

        public string Rooms
        {
            get => roomsText.text;
            set => roomsText.text = value;
        }

        public string Floor
        {
            get => floorText.text;
            set => floorText.text = value;
        }

        public void OpenBaseView()
        {
            (Presenter as Presenter.Apartment.Apartment3dPresenter)?.ShowBasePanel();
        }

        public void OpenVariantView()
        {
            (Presenter as Presenter.Apartment.Apartment3dPresenter)?.OpenBalconyApartmentView();
        }

        public void CloseThis()
        {
            Presenter.HideView();
            Presenter.DisposeView();
        }
    }
}