using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.Application.Exceptions
{
    public class UserCreateFailedException:Exception
    {
        public UserCreateFailedException():base("An unexpected error occurred while creating a user")
        {
            
        }
        public UserCreateFailedException(string? message) : base(message)
        {
        }

        public UserCreateFailedException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
