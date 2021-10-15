﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    public enum ErrorCodes
    {
        Empty
    }

    public class IdException : Exception
    {
        public IdException(ErrorCodes code)
        {
            Code = code;
        }

        public ErrorCodes Code { get; }
    }
}
