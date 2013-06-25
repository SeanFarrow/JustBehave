﻿using System;
using Shouldly;

namespace JustEat.Testing.Tests.Examples
{
    public class WhenTestingForExceptions : BehaviourTest<BadlyBehaved>
    {
        protected override void Given()
        {
            RecordAnyExceptionsThrown();
        }

        protected override void When()
        {
            SystemUnderTest.TakeADump();
        }

        [Then]
        public void ExceptionShouldBeOfExpectedType()
        {
            ThrownException.ShouldBeTypeOf<InvalidOperationException>();
        }
    }

    public class BadlyBehaved
    {
        public void TakeADump()
        {
            throw new InvalidOperationException();
        }
    }
}