using System;

namespace GenericsIntro
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] _keys;
        TValue[] _values;

        TKey[] _tempKeys;
        TValue[] _tempValues;

        public MyDictionary()
        {
            _keys = new TKey[0];
            _values = new TValue[0];
        }

        public void Add(TKey key,TValue value)
        {
            _tempKeys = _keys;
            _tempValues = _values;

            _keys = new TKey[_keys.Length + 1];
            _values = new TValue[_values.Length + 1];

            for (int i = 0; i < _tempKeys.Length; i++)
            {
                _keys[i] = _tempKeys[i];
            }

            for (int i = 0; i < _tempValues.Length; i++)
            {
                _values[i] = _tempValues[i];
            }

            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;
        }

        public int Count { get { return _keys.Length; }  }
        public TKey[] Keys { get { return _keys; } }
        public TValue[] Values { get { return _values; } }

        public void List()
        {
            for (int i = 0; i < _keys.Length; i++)
            {
                Console.WriteLine("Key :"+ _keys[i] + "Value :" + _values[i]);
            }
        }
    }
}
