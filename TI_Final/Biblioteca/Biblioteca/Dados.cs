using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
	/// <summary>
	/// Interface que possibilita a conversão entre os tipos de dados
	/// Deverá ser implementado a "classe : dados" e obrigatóriamente
	/// os métodos Equals e o método CompareTo via "override"
	/// </summary>
    public interface Dados : IEquatable<Dados>
    {
        new bool Equals(Dados o);
        int CompareTo(Dados o);
    }
}
