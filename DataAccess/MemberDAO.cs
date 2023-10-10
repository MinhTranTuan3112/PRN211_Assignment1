using BusinessObject;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MemberDAO
    {
        //Fields
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private static List<MemberObject> MemberList = new List<MemberObject>()
        {
            new MemberObject()
            {
                Email = "john@gmail.com",
                Password = "123"
            }
        };

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

        public List<MemberObject> getAllMembers()
        {
            return MemberList;
        }

        public MemberObject GetMemberByID(string MemberID)
        {
            var member = MemberList.FirstOrDefault(m => m.MemberID.Equals(MemberID));
            return member;
        }

        public void AddNewMember(MemberObject member)
        {
            var memberInList = GetMemberByID(member.MemberID);
            if (memberInList is not null)
            {
                return;
            }
            MemberList.Add(member);
        }

        public void UpdateMember(MemberObject newMember)
        {
            int memberIndex = MemberList.IndexOf(newMember);
            if (memberIndex == -1)
            {
                return;
            }
            MemberList[memberIndex] = newMember;
        }

        public void DeleteMember(string MemberID)
        {
            var memberInList = GetMemberByID(MemberID);
            if (memberInList is not null)
            {
                return;
            }
            MemberList.Remove(memberInList);
        }

        public MemberObject Login(string Email, string Password)
        {
            var member = MemberList.FirstOrDefault(m => m.Email.Equals(Email) && m.Password.Equals(Password));
            return member;
        }
    }
}
