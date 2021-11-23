namespace Domain.Contracts;

public interface IWebDriverBase
{
    public void NavigateTo(string url);

    public void OpenTab(string url);
}