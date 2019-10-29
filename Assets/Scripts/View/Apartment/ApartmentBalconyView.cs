using System;
using Presenter.Apartment;
using UnityEngine;

namespace View.Apartment
{
    public sealed class ApartmentBalconyView : View
    {
        [SerializeField] private UnityEngine.UI.Text balconyMetersText;
        [SerializeField] private UnityEngine.UI.Toggle balconyToggle;
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

        public bool HasBalcony
        {
            set
            {
                if (Presenter is Balcony balconyPresenter)
                    balconyPresenter.ChangedBalconyToggle(value);
                else
                    throw new NotSupportedException("This is not Balcony Presenter");
            }
        }

        public void UpdateBalconySize()
        {
            if (!(Presenter is Balcony balconyPresenter))
                return;

            balconyPresenter.Data.BalconyMeters++;
            balconyPresenter.UpdateView();
        }

        public void OpenBaseVariant()
        {
            //Presenter can be different type and operate on different model, lets check 
            //that we have a good instance with proper data 
            if (Presenter is Balcony apartmentPresenter)
                Presenter.GetController().Open3dApartmentView(apartmentPresenter.Data);
        }

        public string BalconyMeters
        {
            get => balconyMetersText.text;
            set => balconyMetersText.text = value;
        }
    }
}