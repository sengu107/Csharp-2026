using System;

namespace HotelManagement.BUS
{
   
    public class BusinessException : Exception
    {
        public BusinessException(string message) : base(message)
        {
        }
    }
}
