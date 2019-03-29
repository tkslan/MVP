﻿
public interface IView
{
    bool Interactable { get; set; }
    bool Visible { get; set; }
    void SetPresenter(IPresenter presenter);
}