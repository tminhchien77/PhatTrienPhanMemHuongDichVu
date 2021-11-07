using System;
using System.Collections.Generic;
using System.Text;

namespace Band.ViewModels.Utilities
{
    public class SystemConstants
    {
        public const string BankAccount="123451234512345";
        public enum ActionType
        {
            CREATE,
            READ,
            UPDATE,
            DELETE
        }
        public enum ImageType
        {
            AVATAR_MEM=1,
            COVER_MEM=2,
            IMG_SHOW=3
        }

        public enum BookingErrorCode
        {
            SOLD_OUT=-3,
            BOOKED=-4
            
        }

        public enum BankErrorCode
        {
            LOGIN_FAILED = -1,
            INCORRECT_DES_ACC=-2,
            BALANCE_NOT_ENOUGH=0

        }
    }
}
