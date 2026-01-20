using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson11._1
{
    public class Pair<S, T>
    {
        public S first;
        public T second;
        public Pair(S first, T second)
        {
            this.first = first;
            this.second = second;
        }
        public void SetFirst(S first) { this.first = first; }
        public void SetSecond(T second) { this.second = second; }
        public S GetFirst() { return this.first; }
        public T GetSecond() { return this.second; }
    }
}
