﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
    public abstract class CondimentDecorator : ThongTinHoaDon
    {
        protected ThongTinHoaDon wrapObj;
    }
}
