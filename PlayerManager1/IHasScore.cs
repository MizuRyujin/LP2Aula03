using System;

namespace PlayerManager1
{
    interface IHasScore : IEquatable<IHasScore>
    {
        int Score { get; }
    }
}
