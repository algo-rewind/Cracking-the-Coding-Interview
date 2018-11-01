using System.Linq;

namespace Problems.Chapter_01
{
    public class Problem_03
    {
		public static char[] URLify(char[] input)
		{
			char[] urlified = new char[input.Length + 2 * input.Count(x => x == ' ')];

			int j = 0;
			foreach (char ch in input)
				switch (ch)
				{
					case ' ':
						urlified[j++] = '%';
						urlified[j++] = '2';
						urlified[j++] = '0';
						break;
					default:
						urlified[j++] = ch;
						break;
				}

			return urlified;
		}
    }
}
