﻿using System;
using System.Linq;
using TrafficLawsTest.Logic.Services;
using TrafficLawsTest.Security.Models;

namespace TrafficLawsTest.Security
{
    public class SecurityManager : ISecurityManager
    {
        private readonly IUserService _userService;

        public SecurityManager(IUserService userService)
        {
            _userService = userService;
        }

        public event EventHandler UserLogOut;
        public ApplicationUser CurrentPrincipal { get; set; }

        public bool Authorized => CurrentPrincipal != null;

        public bool TryLogIn(string login, string password)
        {
            var user = _userService.Get(login, password);
            if (user == null) return false;
            CurrentPrincipal = new ApplicationUser
            {
                Id = user.Id,
                Name = user.Login,
                Roles = user.Roles.Select(r => new ApplicationRole {Name = r.Name}).ToList()
            };
            return true;
        }

        public void LogOut()
        {
            CurrentPrincipal = null;
            OnUserLogOut();
        }

        public bool CheckRole(string roleName)
        {
            return CurrentPrincipal?.Roles?.Any(r => r.Name.ToLower().Equals(roleName.ToLower())) ?? false;
        }

        protected virtual void OnUserLogOut()
        {
            UserLogOut?.Invoke(this, EventArgs.Empty);
        }
    }
}