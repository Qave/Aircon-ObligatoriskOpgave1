using System;

namespace AirconLib
{
    public class FanOutput
    {
        // Private instance fields
        private int _id;
        private string _name;
        private int _temp;
        private int _humidity;

        /// <summary>
        /// Instantiates a new FanOutput Object.
        /// When a new FanOutput object is created, initialize given arguments
        /// </summary>
        /// <param name="id">The ID of the current FanOutput object</param>
        /// <param name="name">The name of the current FanOutput object</param>
        /// <param name="temp">The temperature of the current FanOutput object</param>
        /// <param name="humid">The humidity of the current FanOutput object</param>
        public FanOutput(int id, string name, int temp, int humid)
        {
            id = _id;
            name = _name;
            temp = Temp;
            humid = _humidity;
        }

        /// <summary>
        /// The ID of the current FanOutput object.
        /// </summary>
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// The name of the current FanOutput object.
        /// Name cannot be less than 2 characters.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("Name cannot be less than 2 characters.");
                }
                else
                {
                    _name = value;
                }
            }
        }
        /// <summary>
        /// The temperature of the current FanOutput object.
        /// Temperature has to be between 15 and 25.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public int Temp
        {
            get { return _temp; }
            set
            {
                if (_temp < 15 || _temp > 25)
                {
                    throw new ArgumentOutOfRangeException("Temperature must be between 15 and 25.");
                }
                else
                {
                    _temp = value;
                }
            }
        }
        /// <summary>
        /// The humidity of the current FanOutput object.
        /// Humidity has to be between 30 and 80.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public int Humidity
        {
            get { return _humidity; }
            set
            {
                if (_humidity < 30 || _humidity > 80)
                {
                    throw new ArgumentOutOfRangeException("Humidity must be between 30 and 80.");
                }
                else
                {
                    _humidity = value;
                }
            }
        }


    }
}
