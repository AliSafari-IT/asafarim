namespace ASafariM.Application.Services
{
    public interface IUserPreferenceService
    {
        string GetPreference(string key);
        void SetPreference(string key, string value);
    }
}
