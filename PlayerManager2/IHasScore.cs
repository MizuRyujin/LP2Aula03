using System;

namespace PlayerManager2
{
    interface IHasScore : IEquatable<IHasScore>
    {
        int Score { get; }
    }
}
