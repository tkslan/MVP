using UnityEngine;

public class ApartmentView : View
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
        (Presenter as Apartment3dPresenter)?.ShowBasePanel();
    }

    public void CloseThis()
    {
        Presenter.HideView();
        Presenter.DisposeView();
    }
}