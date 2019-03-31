using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using UnityEngine;

public class PresentersController : MonoBehaviour
{
    private List<ViewPresenter> _presenters;

    // Start is called before the first frame update
    void Start()
    {
        Open3dApartmentView(new Apartment() {Floor = 2, Meters = 123, Rooms = 2});
    }

    void Open3dApartmentView(Apartment apartment)
    {
        var apartmentPresenter = new Apartment3dPresenter();
        apartmentPresenter.OpenView<ApartmentView>(transform, apartment);
        apartmentPresenter.ShowView();
        AddPresenter(apartmentPresenter);
    }

    public void AddPresenter(ViewPresenter newViewPresenter)
    {
        _presenters = _presenters ?? new List<ViewPresenter>();
        _presenters.Add(newViewPresenter);
    }

    public T GetPresenter<T>() where T : ViewPresenter
    {
        if (_presenters == null)
            throw new NoNullAllowedException("There is no presenters at the moment");

        var requestedPresenter = _presenters.Find(f => f is T);
        if (requestedPresenter == null)
            throw new Exception($"Requested presenter [{typeof(T)} not found");

        return requestedPresenter as T;
    }
}