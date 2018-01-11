using System;
using System.Collections.Generic;

namespace Generics
{
    public class MultipleGenericsImpl<T, U, V, W> //one of the generics will be used based on the matching where classes below
        where T : class, // T should be a reference type (array,class,delegate,interface
                  new()  // T should have a public constructor 
        where U : struct // U should be a value type (byte,double,float,int,long,struct,uint,etc.,)
        where V : GenericMethodImpl, IEnumerable<U> // V should be derived from GenericMethodImpl, V should implement IEnumerable
        where W : T, IDisposable // W should be derived from T and W should implement IDisposable interface
    {

    }
}
