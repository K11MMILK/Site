﻿using First_site_V2.Models;
using First_site_V2.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_site_V2.Interfaces
{
    public interface IProfileManager
    {
        Profile GetProfile();

    }
}
