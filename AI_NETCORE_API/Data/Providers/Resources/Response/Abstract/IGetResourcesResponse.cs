﻿using Data.BuisnessObject;
using Data.Providers.Common.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Providers.Resources.Response.Abstract
{
    public interface IGetResourcesResponse : IProvideResult
    {
        IList<Resource> Resources { get; }
    }
}
