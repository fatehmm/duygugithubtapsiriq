using System;
namespace _17June
{
	public interface IAcademy
	{
		public Group[] Groups { get; }
		public abstract void AddGroup(ref Group group);
		public abstract Group[] GetGroupsByType(string type);
		public abstract Group[] Search(string value);
		public abstract void UpdateGroup(string No, string updatedNo, int studentLimit);
        
        
	}
	
}

