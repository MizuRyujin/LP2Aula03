using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace PlayerManager4
{
    class CompareByName : IComparer<Player>
    {
        private bool alphabetOrder;

        public CompareByName(bool order)
        {
            alphabetOrder = order;
        }

        public int Compare([AllowNull] Player x, [AllowNull] Player y)
        {
            if (!alphabetOrder)
            {
                if (x.Name.CompareTo(y.Name) == 0)
                {
                    return x.Name.CompareTo(y.Name);
                }

                else if (x.Name.CompareTo(y.Name) == -1)
                {
                    return 1;
                }

                else if (x.Name.CompareTo(y.Name) == 1)
                {
                    return -1;
                }
            }

            if (alphabetOrder)
            {
                if (x.Name.CompareTo(y.Name) == 0)
                {
                    return x.Name.CompareTo(y.Name);
                }

                else if (x.Name.CompareTo(y.Name) == -1)
                {
                    return x.Name.CompareTo(y.Name);
                }

                else if (x.Name.CompareTo(y.Name) == 1)
                {
                    return x.Name.CompareTo(y.Name);
                }
            }

            return -1;
        }
    }
}

