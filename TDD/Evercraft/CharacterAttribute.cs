using System;

namespace Evercraft
{
    public class CharacterAttribute
    {
        private int _value;

        public int Modifier
        {
            get
            {
                return (int)Math.Floor((_value-10.0)/2);
            }
        }

        public CharacterAttribute()
        {
            _value = 10;
        }

        public int GetValue()
        {
            return _value;
        }

        public void SetValue(int newValue)
        {
            if (newValue < 1 || newValue > 20)
            {
                throw new ArgumentOutOfRangeException();
            }

            _value = newValue;
        }

    }
}
