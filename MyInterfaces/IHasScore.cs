﻿using System;

namespace MyInterfaces
{
    interface IHasScore : IEquatable<IHasScore>
    {
        int Score { get; }
    }
}
