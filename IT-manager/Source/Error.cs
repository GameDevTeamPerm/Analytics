using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_manager
{
    public class Error
    {
        static Random random = new Random();
        public ErrorType Type { get; set; }

        public enum ErrorType
        {
            None,
            DivisionByZero,
            RangeCheckError,
            StackOverflowError,
            HeapOverflowError,
            InvalidPointerOperation,
            FloatinPointOverflow,
            FloatingPointUnderflow,
            InvalidFloatingPointOperation,
            OverlayManagerNotInstalled,
            OverlayFileReadError,

            Count
        }

        public Error()
        {
            Type = ErrorType.None;
        }

        public Error(ErrorType errType)
        {
            Type = errType;
        }

        public void SetErrorType()
        {
            Type = (ErrorType)random.Next(1, (int)ErrorType.Count);
        }

        public override string ToString()
        {
            return Type.ToString();
        }
    }
}
