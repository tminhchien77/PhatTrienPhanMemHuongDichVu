﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Band.ViewModels.Catalog.Show.Public
{
    public class BookingRequest: PublicDatVeVm
    {
        public string idSrcAcc { get; set; }
        public string pass { get; set; }
        public decimal payment { get; set; }
        public PublicDatVeVm chiTietDatVe { get; set; }
    }
}
