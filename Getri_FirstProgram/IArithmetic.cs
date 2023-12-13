using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getri_FirstProgram
{
    public interface IArithmetic
    {
        int Add(int a, int b);

        int Sub(int a, int b);

        int Mul(int a, int b);

        int Div(int a, int b);
    }
}
