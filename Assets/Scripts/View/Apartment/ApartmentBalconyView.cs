using System;
using UnityEngine;

public sealed class ApartmentBalconyView : View, IView
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
        set => (Presenter as ApartmentWithBalconyPresenter)?.ChangedBalconyToggle(value);
    }

    public string BalconyMeters
    {
        get => balconyMetersText.text;
        set => balconyMetersText.text = value;
    }

    public bool Interactable
    {
        get => CanvasGroup.interactable;
        set => CanvasGroup.interactable = CanvasGroup.blocksRaycasts = value;
    }
    public bool Visible
    {
        get => CanvasGroup.alpha > 0.9f;
        set => CanvasGroup.alpha = value ? 1f : 0f;
    }
    public GameObject GetGameObject => gameObject;
}