namespace ASafariM.Application.Interfaces
{
    public interface IUserPreferenceService
    {
        string GetPreference(string key);
        void SetPreference(string key, string value);
    }
}
