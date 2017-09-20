using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using Sitecore.Diagnostics;
using Sitecore.Security.Accounts;
using Sitecore.Text;

namespace Sitecore.Foundation.Commerce.Website.Fields
{
    public interface IUsersField
    {
        IEnumerable<User> GetSelectedUsers();

        IEnumerable<User> GetUnselectedUsers();

        string GetProviderUserKey(User user);
    }

    public class UsersField : IUsersField
    {
        private static readonly string DomainParameterName = "CommerceUser";

        private ListString _SelectedUsers;
        private ListString SelectedUsers
        {
            get
            {
                if (_SelectedUsers == null)
                {
                    _SelectedUsers = new ListString(Value);
                }

                return _SelectedUsers;
            }
        }

        private IEnumerable<User> _UsersInDomain;
        private IEnumerable<User> UsersInDomain
        {
            get
            {
                if (_UsersInDomain == null)
                {
                    _UsersInDomain = GetUsersInDomain();
                }

                return _UsersInDomain;
            }
        }

        private IEnumerable<User> _Users;
        private IEnumerable<User> Users
        {
            get
            {
                if (_Users == null)
                {
                    _Users = GetUsers();
                }

                return _Users;
            }
        }

        private string _Domain;
        private string Domain
        {
            get
            {
                if (string.IsNullOrEmpty(_Domain))
                {
                    _Domain = FieldSettings[DomainParameterName];
                }

                return _Domain;
            }
        }

        private UrlString _FieldSettings;
        private UrlString FieldSettings
        {
            get
            {
                if (_FieldSettings == null)
                {
                    _FieldSettings = GetFieldSettings();
                }

                return _FieldSettings;
            }
        }

        private string Source { get; set; }
        private string Value { get; set; }

        private UsersField(string source, string value)
        {
            SetSource(source);
            SetValue(value);
        }

        private void SetSource(string source)
        {
            Source = source;
        }

        private void SetValue(string value)
        {
            Value = value;
        }

        private IEnumerable<User> GetUsersInDomain()
        {
            if (!string.IsNullOrEmpty(Domain))
            {
                return Users.Where(user => IsUserInDomain(user, Domain));
            }

            return Users;
        }

        private static IEnumerable<User> GetUsers()
        {
            IEnumerable<User> users = UserManager.GetUsers();

            if (users != null)
            {
                return users;
            }

            return new List<User>();
        }

        private static bool IsUserInDomain(User user, string domain)
        {
            Assert.ArgumentNotNull(user, "user");
            Assert.ArgumentNotNullOrEmpty(domain, "domain");

            string userNameLowerCase = user.Profile.UserName.ToLower();
            string domainLowerCase = domain.ToLower();

            return userNameLowerCase.StartsWith(domainLowerCase);
        }

        private UrlString GetFieldSettings()
        {
            try
            {
                if (!string.IsNullOrEmpty(Source))
                {
                    return new UrlString(Source);
                }
            }
            catch (Exception ex)
            {
                Log.Error(this.ToString(), ex, this);
            }

            return new UrlString();
        }

        public IEnumerable<User> GetSelectedUsers()
        {
            IList<User> selectedUsers = new List<User>();

            foreach (string providerUserKey in SelectedUsers)
            {
                User selectedUser = UsersInDomain.Where(user => GetProviderUserKey(user) == providerUserKey).FirstOrDefault();
                if (selectedUser != null)
                {
                    selectedUsers.Add(selectedUser);
                }
            }

            return selectedUsers;
        }

        public IEnumerable<User> GetUnselectedUsers()
        {
            IList<User> unselectedUsers = new List<User>();

            foreach (User user in UsersInDomain)
            {
                if (!IsUserSelected(user))
                {
                    unselectedUsers.Add(user);
                }
            }

            return unselectedUsers;
        }

        private bool IsUserSelected(User user)
        {
            string providerUserKey = GetProviderUserKey(user);
            return IsUserSelected(providerUserKey);
        }

        private bool IsUserSelected(string providerUserKey)
        {
            return SelectedUsers.IndexOf(providerUserKey) > -1;
        }

        public string GetProviderUserKey(User user)
        {
            Assert.ArgumentNotNull(user, "user");
            MembershipUser membershipUser = Membership.GetUser(user.Profile.UserName);
            return membershipUser.ProviderUserKey.ToString();
        }

        public static IUsersField CreateNewUsersField(string source, string value)
        {
            return new UsersField(source, value);
        }
    }

}