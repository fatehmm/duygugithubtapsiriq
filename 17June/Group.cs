using System;
namespace _17June
{
	public class Group
	{
		public Group()
		{
			_no = $"{Type[0]}{_totalValue}";
			_totalValue++;

		}
		private int _totalValue = 1000;
		private string _no;
		public string No
        {
			get => _no;
            set
            {
                
				_no = value;
            }
        }
		public string Type;
		private int _studentLimit;
		public int StudentLimit
        {
			get
			{
				return StudentLimit;

			}
            set
            {
                if (value<20 && value<0)
                {
					_studentLimit = value;

				}
				
            }
        }
	}
}

