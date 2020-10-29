using System;
using System.Collections.Generic;
using System.Text;

namespace Fractales
{
    class Convert
    {
        public double SexaToRadian(int value)
        {
            //80 * Pi/180
            if(value % 90 == 90)
                return (value * Math.PI / 180);
            if(value == 135)
                return (value * Math.PI / 180);
            return (value * Math.PI / 180);
        }
        public double RadianToSex(int value)
        {
            //80 * Pi/180
            return (value * Math.PI / 180);

        }
        public double Cos(int arbolAngle, int angle, char operation)
        {
            if(operation == '+')
                return Math.Cos(SexaToRadian(arbolAngle + angle));
            else
                return Math.Cos(SexaToRadian(arbolAngle - angle));
        }
        public double Sen(int arbolAngle, int angle, char operation)
        {
            if (operation == '+')
                return Math.Sin(SexaToRadian(arbolAngle + angle));
            else
                return Math.Sin(SexaToRadian(arbolAngle - angle));
        }
    }
}
