using System;

namespace InterfacesImpl
{
    enum planets
    {
        Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune, Pluto   
    }

    class EnumImpl
    {
        enum weekdays
        {
            Sunday = 1,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        enum months : byte
        {
            Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec
        }
        public void PlayEnum()
        {
            int _firstDayOfWeek = (int) weekdays.Sunday;
            int _lastDayofWeek = (int)weekdays.Saturday;

            Console.WriteLine("First day of week: " + _firstDayOfWeek);
            Console.WriteLine("Last day of week: " + _lastDayofWeek);
            Console.WriteLine("What's weekdays.friday enum has got: " + weekdays.Friday);
            Console.WriteLine("Third month of the 'months' enum: {0}", (byte) months.Mar);
            //months.Jan = 1; // this is not possible. 
            Console.WriteLine("months.Jan = 1 (or) months.jan = (cast) 1 isn't possible");

            //Fifth planet in the milkyway
            Console.WriteLine("Fifth planet in the milkyway: " + planets.Jupiter);

        }
    }
}