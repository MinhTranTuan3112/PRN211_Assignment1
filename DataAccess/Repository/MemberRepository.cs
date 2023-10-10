using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void AddNewMember(MemberObject member)
        {
            MemberDAO.Instance.AddNewMember(member);
        }

        public void DeleteMember(string MemberID)
        {
            MemberDAO.Instance.DeleteMember(MemberID);
        }

        public List<MemberObject> getAllMembers()
        {
            return MemberDAO.Instance.getAllMembers();
        }

        public MemberObject getMemberByID(string MemberID)
        {
            return MemberDAO.Instance.GetMemberByID(MemberID);
        }

        public MemberObject Login(string Email, string Password)
        {
            return MemberDAO.Instance.Login(Email, Password);
        }

        public void UpdateMember(MemberObject member)
        {
            MemberDAO.Instance.UpdateMember(member);
        }
    }
}
