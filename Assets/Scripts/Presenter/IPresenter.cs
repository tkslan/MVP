
public interface IPresenter
{
    void SetView(IView view);
    void HideView();
    void ShowView();
    void UpdateView();
}
