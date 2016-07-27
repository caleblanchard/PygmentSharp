﻿using System;
using System.Collections.Generic;
using System.Linq;

using NFluent;

using PygmentSharp.Core.Lexing;
using PygmentSharp.Core.Tokens;

using Xunit;

namespace PygmentSharp.UnitTests.Lexing
{
    public class CSharpLexerTests
    {
        [Fact]
        public void GetsCorrectTokensWhenSourceContainsChar()
        {
            const string code = "using System; namespace Foo { class Bar { private char _baz = 'c'; } }";
            var subject = new CSharpLexer();

            var tokens = subject.GetTokens(code).ToArray();

            Check.That(tokens[0]).IsEqualTo(new Token(0, TokenTypes.Keyword, "using"));
        }
    }
}