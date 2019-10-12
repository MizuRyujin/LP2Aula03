using System;

namespace MyInterfaces
{
    interface IHasScore : IEquatable<IHasScore>, IComparable<IHasScore>
    {
        int Score { get; }
    }
}
