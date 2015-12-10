using System;
using System.Collections.Generic;

namespace CodingChallenge
{
    /// <summary>
    /// Queue implementation using two stacks
    /// </summary>
    public class Queue<T>
    {
        private readonly Stack<T> _inbox = new Stack<T>();
        private readonly Stack<T> _outbox = new Stack<T>(); 

        /// <summary>
        /// Put an item into the queue
        /// </summary>
        /// <param name="item">Item to put into the queue</param>
        public void Enqueue(T item)
        {
            _inbox.Push(item);
        }

        /// <summary>
        /// Remove next item from the queue
        /// </summary>
        /// <returns>Item that was removed</returns>
        public T Dequeue()
        {
            if (_outbox.Count == 0)
            {
                while (_inbox.Count > 0)
                {
                    _outbox.Push(_inbox.Pop());
                }
            }

            if (_outbox.Count == 0)
                throw new InvalidOperationException("Queue is empty");

            return _outbox.Pop();
        }
    }
}
