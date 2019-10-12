using System;

namespace PlayerManager4
{
    interface IHasScore : IEquatable<IHasScore>
    {
        int Score { get; }
    }
}
