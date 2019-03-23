using System.Collections.Generic;

namespace CleanCodeSeries.Workshop.Lesson3.EasyOOP.BoundaryConditions
{
    // Note: ignore the use of ??
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
