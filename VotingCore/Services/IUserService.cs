namespace VotingCore.Services
{
    public interface IUserService
    {
        string GetuserId();
        bool IsAuthenticated();
    }
}