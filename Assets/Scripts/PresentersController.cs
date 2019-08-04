using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using UnityEngine;

public class PresentersController : MonoBehaviour
{
    private List<IPresenter> _presenters;

    // Start is called before the first frame update
    void Start()
    {
        var apartment = new Apartment() {Floor = 2, Meters = 123, Rooms = 2};

        Open3dApartmentView(apartment);
    }

    void Open3dApartmentView(Apartment apartment)
    {
        var apartmentPresenter = new Apartment3dPresenter();
        apartmentPresenter.OpenView(transform, apartment);
        AddPresenter(apartmentPresenter);
    }
    
    public void AddPresenter(IPresenter newViewPresenter)
    {
        _presenters = _presenters ?? new List<IPresenter>();
        _presenters.Add(newViewPresenter);
    }

    public T GetPresenter<T>() where T : Presenter
    {
        if (_presenters == null)
            throw new NoNullAllowedException("There is no presenters at the moment");

        var requestedPresenter = _presenters.Find(f => f is T);
        if (requestedPresenter == null)
            throw new Exception($"Requested presenter [{typeof(T)} not found");

        return requestedPresenter as T;
    }
}