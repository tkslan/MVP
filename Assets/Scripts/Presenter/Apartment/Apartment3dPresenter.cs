using Model;
using UnityEngine;

namespace Presenter.Apartment
{
    public class Apartment3dPresenter : ApartmentPresenter
    {
        public override void UpdateView()
        {
            base.UpdateView();
            View.Meters = $"Meters in 3D: {(Data.Meters * 1.2f)}";
        }

        public void DebugInfo()
        {
            UnityEngine.Debug.Log(this + "" + Data.Rooms);
        }

        public void ShowBasePanel()
        {
            var cachedTransform = View.GetGameObject.transform.parent;
            DisposeView();
            var view=OpenView(cachedTransform, new Model.Apartment() {Meters = 255, Floor = 128, Rooms = 64});
            view.transform.Translate(new Vector3(200,0));
        }

        public void OpenBalconyApartmentView()
        {
            var apartment = new Model.ApartmentBalcony()
                {Balcony = true, BalconyMeters = 7, Floor = 1, Meters = 77, Rooms = 3};

            var balconyPresenter = new ApartmentWithBalconyPresenter();
            balconyPresenter.OnViewUpdate += OnBalconyViewUpdate;

            balconyPresenter.OpenView(View.transform.parent, apartment);
        }

        private void OnBalconyViewUpdate(ApartmentBalcony obj)
        {
            UnityEngine.Debug.Log("Updated Balcony Meters: " + obj.BalconyMeters);
        }

    }
}