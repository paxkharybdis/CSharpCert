using System;

namespace Week1.Week2
{
    public class NumericTypes
    {
        #region Integral - Signed
        /*private sbyte _mySbyteValue = 2;

        private short _myShortValue = 4;

        private int _myIntValue = 25000;

        private long _myLongValue = 1_234_567L;

        private long _myLongValue2 = 0x5F;
        #endregion

        #region Integral - Unsigned

        private byte _myByteValue = 3;

        private ushort _myUshortValue = 35;

        private uint _myUInt = 2345U;

        private ulong _myULong = 1234UL; */
        #endregion

        #region Real

        private float _myFloatValue = -123.6589F;

        /*  private double _myDoubleValue = 12.34D;

            private double _myDoubleValue2 = 1E06;

            private double _myDoubleValue3 = 12.34;

            private decimal _myDecimalValue =12.234M; */

        #endregion


        public void ConvertFloatToInt() // void indicates no return type
        {
            int converted = (int)_myFloatValue;

        }

        public long LongFromInt(int value) // long is the return type, which means there 
        {
            return value;
        }

        public void IncrementDecrement()
        {
            int myVal = 1, myOtherval = 10;

            Console.WriteLine(myVal++);
            Console.WriteLine(myOtherval--);
            Console.WriteLine(--myVal);
            Console.WriteLine(++myOtherval);

        }

        public void GetSomeTypes()
        {
            Console.WriteLine(3.0.GetType());
            Console.WriteLine(_myFloatValue.GetType());
        }

        public void BasicMath()
        {
            int myVal = 5, myOther = 10;

            int addVal = myVal + myOther;
            int subtractVal = myOther - myVal;
            int multiplyVal = myOther * myVal;
            int divisionVal = myVal / myOther;

            int total = (addVal * multiplyVal) - divisionVal;

            Console.WriteLine(addVal);
        }

        public void CheckOperatorType()
        {

            int val = 100, val2 = 100;

            int testValue = checked(val * val2); //one way of multiplying val and val2

            /* checked // another way of doing the same ^
                {
                    int myCheck = val * val2;
                } */

            Console.WriteLine(testValue);

        }

        public void SpecialValues()
        {
            Console.WriteLine(2.0 / 0.0);
            Console.WriteLine(-2.0 / 0.0);
            Console.WriteLine(2.0 / -0.0);
            Console.WriteLine(-2.0 / -0.0);
            Console.WriteLine(0.0 / 0.0);
            Console.WriteLine((2.0 / -0.0) - (2.0 / 0.0));
            Console.WriteLine(0.0 / -0.0 == double.NaN);
            Console.WriteLine(double.IsNaN(0.0 / 0.0));
            Console.WriteLine(object.Equals(0.0 / 0.0, double.NaN));
        }


    }
}