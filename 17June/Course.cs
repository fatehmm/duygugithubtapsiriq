using System;
namespace _17June
{
	public class Course:IAcademy
    {
		public Course()
		{
		}
        public Group[] groups = new Group[0];
        public Group[] Groups { get => groups; }
        public int GroupLimit;

        public void AddGroup(ref Group group)
        {
            bool sameNo = false;
            foreach (var item in groups)
            {
                if (item.No == group.No)
                {
                    sameNo = true;
                    break;
                }
            }
            if (groups.Length<GroupLimit && sameNo==false)
            {
                Array.Resize(ref groups, groups.Length + 1);
                groups[groups.Length - 1] = group;
            }
            
        }

        public Group[] GetGroupsByType(string type)
        {
            Group[] typeGroups = new Group[0];
            foreach (var item in groups)
            {
                if (item.Type == type)
                {
                    Array.Resize(ref typeGroups, typeGroups.Length + 1);
                    typeGroups[typeGroups.Length - 1] = item;
                }
            }
            return typeGroups;
        }

        public Group[] Search(string value)
        {
            Group[] searchedGroups = new Group[0];
            foreach (var item in groups)
            {
                if (item.Type.Contains(value) || item.No.Contains(value))
                {
                    Array.Resize(ref searchedGroups, searchedGroups.Length + 1);
                    searchedGroups[searchedGroups.Length - 1] = item;
                }
            }
            return searchedGroups;
        }

        public void UpdateGroup(string No, string updatedNo, int studentLimit)
        {
            bool checkGroup = false;
            Group updatedGroup = new Group();
            foreach (var item in groups)
            {
                if (item.No == No)
                {
                    checkGroup = true;
                    updatedGroup = item;
                    break;

                }
            }
            if (checkGroup == true)
            {
                updatedGroup.No = updatedNo;
            }
            if (updatedGroup.StudentLimit != studentLimit)
            {
                updatedGroup.StudentLimit = studentLimit;
                Console.WriteLine("update olundu");
            }
            else
            {
                Console.WriteLine("Onsuz da yazdigin deyer student limite beraberdi");
            }

        }
    }
}

