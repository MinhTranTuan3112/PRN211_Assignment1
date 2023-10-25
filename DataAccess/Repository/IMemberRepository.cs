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
        IEnumerable<MemberObject> getMemberList();
        IEnumerable<MemberObject> SearchAll(bool hasSort, string keyword, string City, string Country);
        MemberObject getMemberByID(string MemberID);
        void addNewMember(MemberObject newMember);
        void updateMember(MemberObject member);
        void deleteMember(string MemberID);
        IEnumerable<MemberObject> SortDescendingMemberName();
        MemberObject Login(string email, string password);
        IEnumerable<MemberObject> search(string keyword);
    }
}
