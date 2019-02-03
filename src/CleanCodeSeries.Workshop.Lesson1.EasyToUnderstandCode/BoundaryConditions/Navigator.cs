using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.BoundaryConditions
{
    class Navigator<T>
    {
        private LinkedList<T> _targets;
        private LinkedListNode<T> _current;

        public Navigator(LinkedList<T> targets)
        {
            _targets = targets;
            _current = targets.First;
        }

        public T Next()
        {
            if(_current.Next == null)
            {
                _current = _targets.First;
            }
            else
            {
                _current = _current.Next;
            }
            
            
            return _current.Value;
        }

        public T Previous()
        {
            if (_current.Previous == null)
            {
                _current = _targets.Last;
            }
            else
            {
                _current = _current.Previous;
            }
            
            return _current.Value;
        }
    }
}
