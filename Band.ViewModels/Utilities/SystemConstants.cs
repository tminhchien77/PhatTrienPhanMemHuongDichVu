using System;
using System.Collections.Generic;
using System.Text;

namespace Band.ViewModels.Utilities
{
    public class SystemConstants
    {
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
    }
}
