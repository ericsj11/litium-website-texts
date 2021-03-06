﻿using System.Collections.Generic;
using Litium.Runtime.DependencyInjection;

namespace Litium.Accelerator.Definitions.WebsiteTexts
{
    [Service(ServiceType = typeof(IWebsiteTextSource))]
    [RequireServiceImplementation]
    public interface IWebsiteTextSource
    {
        string Prefix { get; }

        List<WebsiteTextDefinition> GetTexts();
    }
}