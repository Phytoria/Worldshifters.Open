﻿// <copyright file="AbilityEffect.cs" company="Worldshifters">
// Copyright (c) Worldshifters. All rights reserved.
// </copyright>

#pragma warning disable CA1034 // Nested types should not be visible

namespace Worldshifters.Data.Hero
{
    using Google.Protobuf;

    public class AbilityEffect
    {
        public Types.AbilityEffectType Type { get; set; }

        public ByteString ExtraData { get; set; }

        public static class Types
        {
            public enum AbilityEffectType
            {
                ApplyStatusEffect,
                Healing,
                MultihitDamage,
            }
        }
    }
}
