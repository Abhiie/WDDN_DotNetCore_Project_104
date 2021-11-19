using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using VotingCore.Models;

namespace VotingCore.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult>CreateUserAsync(SignUpUserModel userModel);
        Task<SignInResult> PasswordSignInAsync(SignInModel signInModel);
       
        Task SignOutAsync();
        Task<IdentityResult> ChangePasswordAsync(ChangePassword mo);
        Task<IdentityResult> ConfirmEmailAsync(string uid, string token);
    }
}