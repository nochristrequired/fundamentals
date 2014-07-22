﻿//-------------------------------------------------------------------------------
// <copyright file="TypeExtensionsFacts.cs" company="Appccelerate">
//   Copyright (c) 2008-2014
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------

namespace Appccelerate.Formatters
{
    using System;
    using System.Collections.Generic;
    using FluentAssertions;
    using Xunit.Extensions;

    public class TypeExtensionsFacts
    {
        [Theory]
        [InlineData(
            typeof(KeyValuePair<string, string>), 
            "System.Collections.Generic.KeyValuePair<System.String,System.String>")]
        [InlineData(
            typeof(ICollection<int>), 
            "System.Collections.Generic.ICollection<System.Int32>")]
        public void PrintsFullNameOfAGenericTypeWithReadableTypeParameters(Type type, string expectedPrettyPrint)
        {
            type.FullNameToString()
                .Should().Be(expectedPrettyPrint);
        }
    }
}