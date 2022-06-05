using System;
using System.Collections.Generic;

namespace Stack
{
    public class Stack
    {
        private List<object> _list;

        public Stack()
        {
            _list = new List<object>();
        }

        public void Push(object obj)
        {
            if (obj == null) throw new InvalidOperationException("Cannot push a null reference, buddy");

            _list.Add(obj);
        }

        public object Pop()
        {
            if(_list.Count < 1) return "Empty Stack, buddy";
            
            var obj = _list[_list.Count - 1];
            _list.RemoveAt(_list.Count - 1);

            return obj;
        }

        public void Clear()
        {
            _list.Clear();
        }
    }
}