using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class BasicStack<T> : IEnumerable<T>
    {
        private T[] arrayData;
        private int version;
        private const int defaultSize = 2;
        private int index;

        public BasicStack()
        {
            arrayData = new T[defaultSize];
            index = 0;
            version = 0;
        }

        public BasicStack(int size)
        {
            if (size < 0)
                throw new ArgumentOutOfRangeException("size", "Size must be a positive number");

            arrayData = new T[size];
            index = 0;
            version = 0;
        }

        public T Pop()
        {
            if (index == 0)
                throw new InvalidOperationException("Exception: Empty stack");

            version++;
            return arrayData[--index];

        }

        public T Peek()
        {
            if (index == 0)
                throw new InvalidOperationException("Exception: Empty stack");

            return arrayData[index - 1];

        }

        public void Push(T obj)
        {
            if (index == arrayData.Length)
            {
                T[] newArray = new T[2 * arrayData.Length];
                Array.Copy(arrayData, 0, newArray, 0, index);
                arrayData = newArray;
            }
            arrayData[index] = obj;
            version++;
            index++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator(this);
        }

        public class Enumerator : IEnumerator<T>
        {
            private BasicStack<T> _stack;
            private int _index;
            private int _version;
            internal Enumerator(BasicStack<T> stack)
            {

                this._stack = stack;
                this._index = stack.index;
                this._version = stack.version;
            }

            public T Current
            {
                get
                {
                    if (_index < 0) throw new InvalidOperationException("Enumerator Ended");

                    return _stack.arrayData[_index];
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    if (_index < 0) throw new InvalidOperationException("Enumerator Ended");
                    return _stack.arrayData[_index];
                }
            }

            public void Dispose()
            {
                _index = -1;
            }

            public bool MoveNext()
            {
                if (_version != _stack.version) throw new InvalidOperationException("Collection modified");
                _index = _index - 1;
                // End of enumeration.
                if (_index < 0)
                {
                    return false;
                }
                else
                    return true;
            }

            public void Reset()
            {
                if (_version != _stack.version) new InvalidOperationException("Collection modified");
                _index = _stack.index;
            }
        }
    }
    public class BasicStack1
    {
        public static void Main()
        {
            BasicStack<int> b = new BasicStack<int>();
            b.Push(1);
            b.Push(2);
            b.Push(3);
            b.Push(4);
            b.Push(5);
            foreach(var i in b)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(b.Pop());
        }
    }
}
