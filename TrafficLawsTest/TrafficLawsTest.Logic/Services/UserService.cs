﻿using System.Linq;
using TrafficLawsTest.DataSource.Context;
using TrafficLawsTest.DataSource.Models;

namespace TrafficLawsTest.Logic.Services
{
    public interface IUserService
    {
        User Get(int id);
        User Get(string login, string password);
    }

    public class UserService  : IUserService
    {
        private readonly IDomainContext _domainContext;
        public UserService(IDomainContext domainContext)
        {
            _domainContext = domainContext;
        }

        public User Get(int id)
        {
            return _domainContext.Users.FirstOrDefault(u => u.Id.Equals(id));
        }

        public User Get(string login, string password)
        {
            return _domainContext.Users.FirstOrDefault(u => u.Login.Equals(login) && u.Password.Equals(u.Password));
        }
    }
}
