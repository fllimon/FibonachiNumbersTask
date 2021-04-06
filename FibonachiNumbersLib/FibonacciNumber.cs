using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonachiNumbersLib
{
    public class FibonacciNumber : IEnumerable<int>
    {
        #region ======----- PRIVATE DATA ------=======

        private int _startRange = -1;
        private int _finishRange = -1;

        #endregion

        public FibonacciNumber(int startRange, int finishRange)
        {
            _startRange = startRange;
            _finishRange = finishRange;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new FibonacciIterator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new FibonacciIterator(this);
        }

        #region ========------- FIBONACCI ITERATOR --------=========

        private struct FibonacciIterator : IEnumerator<int>
        {
            #region =========------ PRIVATE DATA -------====== 

            private FibonacciNumber _number;
            private int _startNumber;
            private int _finishNumber;
            private int _firstFibonacciNumber;
            private int _secondFibonacciNumber;
            private int _currentValue;
            private int _previous;
            private bool _isPosition;

            #endregion

            #region =========------- CTOR -------========

            public FibonacciIterator(FibonacciNumber number)
            {
                _number = number;
                _startNumber = _number._startRange;
                _finishNumber = _number._finishRange;
                _firstFibonacciNumber = DefaultSettings.FIRST_FIBONACCI_NUMBER;
                _secondFibonacciNumber = DefaultSettings.SECOND_FIBONACCI_NUMBER;
                _isPosition = false;
                _currentValue = -1;
                _previous = -1;
            }

            #endregion

            public int Current => _currentValue;

            object IEnumerator.Current => _currentValue;

            public void Dispose()
            {
            }

            public bool MoveNext()
            {

                if (_isPosition)
                {
                    int tmp = _previous;
                    _previous = _currentValue;
                    _currentValue += _previous;

                }
                else
                {
                    _currentValue = GetFibonacciNumber();
                    _isPosition = true;
                }

                return _currentValue < _finishNumber;
            }

            public void Reset()
            {
                _currentValue = 0;
            }

            private int GetFibonacciNumber()
            {
                while (_number._startRange > _firstFibonacciNumber)
                {
                    _previous = _firstFibonacciNumber;
                    _firstFibonacciNumber = _secondFibonacciNumber;
                    _secondFibonacciNumber += _previous;
                }

                return _secondFibonacciNumber;
            }
        }

        #endregion
    }
}
