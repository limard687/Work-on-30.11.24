using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Приложение_для_генерации_чиел_Yield_return
{
    internal class Generate
    {
        static IEnumerable<int> GenerateNumbers(int start, int end)
        {
            for (int i = 1; i <= 5; i++)
            {
                yield return i;
            }
        }
    }
}
