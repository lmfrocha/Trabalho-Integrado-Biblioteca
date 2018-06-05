using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public interface Dados : IEquatable<Dados>
    {
        new bool Equals(Dados o);
        int CompareTo(Dados o);
    }
}
