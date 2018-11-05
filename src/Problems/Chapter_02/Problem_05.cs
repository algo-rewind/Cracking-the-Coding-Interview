using Utilities.Collections;

namespace Problems.Chapter_02
{
    public class Problem_05
    {
        public static LinkedList<int> SumLists(LinkedList<int> augend, LinkedList<int> addend)
        {
            var sumList = new LinkedList<int>();
            int maxLength = augend.Length > addend.Length ?
                augend.Length : addend.Length;

            using (var e1 = augend.GetEnumerator())
            using (var e2 = addend.GetEnumerator())
            {
                int carry = 0;

                for (int i = 0; i < maxLength; i++)
                {
                    var a1 = e1.MoveNext() ? e1.Current : 0;
                    var a2 = e2.MoveNext() ? e2.Current : 0;

                    int sum = a1 + a2 + carry;
                    carry = sum / 10;
                    sumList.Append(sum % 10);
                }

                if (carry > 0)
                    sumList.Append(carry);
            }

            return sumList;
        }
    }
}