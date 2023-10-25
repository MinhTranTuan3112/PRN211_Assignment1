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
        public void addNewMember(MemberObject newMember)
        {
            MemberDAO.Instance.addNewMember(newMember);
        }

        public void deleteMember(string MemberID)
        {
            MemberDAO.Instance.Delete(MemberID);
        }

        public MemberObject getMemberByID(string MemberID)
        {
            return MemberDAO.Instance.getMemberByID(MemberID);
        }

        public IEnumerable<MemberObject> getMemberList()
        {
            return MemberDAO.Instance.getMemberList();
        }

        public MemberObject Login(string email, string password)
        {
            return MemberDAO.Instance.Login(email, password);
        }

        public IEnumerable<MemberObject> search(string keyword)
        {
            if (string.IsNullOrEmpty(keyword))
            {
                return getMemberList();
            }
            return getMemberList().Where(member
                => member.MemberName.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 || member.MemberID.Equals(keyword)).ToList();
        }

        public IEnumerable<MemberObject> SearchAll(bool hasSort, string keyword, string City, string Country)
        {
            return MemberDAO.Instance.SearchAll(hasSort, keyword, City, Country);
        }

        public IEnumerable<MemberObject> SortDescendingMemberName()
        {
            return MemberDAO.Instance.SortByMemberNameDescending();
        }

        public void updateMember(MemberObject member)
        {
            MemberDAO.Instance.Update(member);
        }
    }
}
