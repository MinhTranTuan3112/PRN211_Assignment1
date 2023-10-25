using BusinessObject;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace DataAccess
{
    public class MemberDAO
    {
        //Fields
        private static List<MemberObject> member_list = new List<MemberObject>()
        {
            new MemberObject
    {
        MemberID = "1",
        MemberName = "John Doe",
        Email = "john@example.com",
        Password = "password1",
        City = "New York",
        Country = "USA",
        Role = "User"
    },
    new MemberObject
    {
        MemberID = "2",
        MemberName = "Alice Smith",
        Email = "alice@example.com",
        Password = "password2",
        City = "Los Angeles",
        Country = "USA",
         Role = "User"
    },
    new MemberObject
    {
        MemberID = "3",
        MemberName = "Bob Johnson",
        Email = "bob@example.com",
        Password = "password3",
        City = "London",
        Country = "UK",
        Role = "User"
    },
    new MemberObject
    {
        MemberID = "4",
        MemberName = "Eva Rodriguez",
        Email = "eva@example.com",
        Password = "password4",
        City = "Miami",
        Country = "USA",
        Role = "User"
    },
    new MemberObject
    {
        MemberID = "5",
        MemberName = "Maria Garcia",
        Email = "maria@example.com",
        Password = "password5",
        City = "Madrid",
        Country = "Spain",
        Role = "User"
    }
        };
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();

        //Constructor
        private MemberDAO()
        {

        }

        //Methods
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance is null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        public List<MemberObject> getMemberList() => member_list;
        public MemberObject getMemberByID(string MemberID)
        {
            var member = member_list.FirstOrDefault(member =>
            member.MemberID is not null && member.MemberID.Equals(MemberID));
            return member;
        }
        public void addNewMember(MemberObject newMember)
        {
            if (getMemberByID(newMember.MemberID) is not null)
            {
                return;
            }
            member_list.Add(newMember);
        }
        public void Update(MemberObject newMember)
        {
            var memberInList = getMemberByID(newMember.MemberID);
            if (memberInList is null)
            {
                return;
            }
            var updateIndex = member_list.IndexOf(memberInList);
            member_list[updateIndex] = newMember;
        }
        public void Delete(string MemberID)
        {
            if (member_list is null || member_list.Count == 0)
            {
                return;
            }
            var memberInList = getMemberByID(MemberID);
            member_list?.Remove(memberInList);
        }
        public List<MemberObject> Search(string keyword)
        {
            return member_list.Where(member => member.MemberName.Contains(keyword) || member.MemberID.Equals(keyword)).ToList();
        }
        public MemberObject Login(string email, string password)
        {
            var memberLogin = member_list.FirstOrDefault(member => member.Email.Equals(email) && password.Equals(password));
            return memberLogin;
        }

        public List<MemberObject> FilterByCityAndCountry(string city, string country)
        {
            var query = member_list.AsQueryable();
            if (!string.IsNullOrEmpty(city))
            {
                query = query.Where(member => member.City.Equals(city));
            }
            if (!string.IsNullOrEmpty(country))
            {
                query = query.Where(member => member.Country.Equals(country));
            }
            return query.ToList();
        }

        public List<MemberObject> SearchAll(bool hasSort, string keyword, string City, string Country)
        {
            var query = member_list.AsQueryable();
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(member => member.MemberName.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0
                || member.MemberID.Equals(keyword));
            }
            if (!string.IsNullOrEmpty(City))
            {
                query = query.Where(member => member.City.Equals(City));
            }
            if (!string.IsNullOrEmpty(Country))
            {
                query = query.Where(member => member.Country.Equals(Country));
            }
            if (hasSort)
            {
                query = query.OrderByDescending(member => member.MemberName);
            }
            return query.ToList();
        }
        public List<MemberObject> SortByMemberNameDescending()
        {
            var newMemberList = member_list.OrderByDescending(member => member.MemberName).ToList();
            return newMemberList;
        }
    }
}
