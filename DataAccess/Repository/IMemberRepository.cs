using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        public List<MemberObject> getAllMembers();
        public MemberObject getMemberByID(string MemberID);
        public void AddNewMember(MemberObject member);
        public void UpdateMember(MemberObject member);
        public void DeleteMember(string MemberID);
        public MemberObject Login(string Email, string Password);
    }
}
