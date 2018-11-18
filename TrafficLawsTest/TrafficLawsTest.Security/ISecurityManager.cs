using System;
using TrafficLawsTest.Security.Models;

namespace TrafficLawsTest.Security
{
    public interface ISecurityManager
    {
        event EventHandler UserLogOut;
        ApplicationUser CurrentPrincipal { get; set; }

        bool Authorized { get; }

        bool TryLogIn(string login);
        void LogOut();
        bool CheckRole(string roleName);
    }
}