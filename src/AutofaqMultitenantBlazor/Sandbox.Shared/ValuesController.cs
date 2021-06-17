// Copyright (c) Autofac Project. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Microsoft.AspNetCore.Mvc;

namespace AutofaqMultitenantBlazor.Sandbox.Shared
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        public ValuesController(IDependency dependency)
        {
            Dependency = dependency;
        }

        public IDependency Dependency { get; set; }

        [HttpGet]
        public string Get()
        {
            return Dependency.Id;
        }
    }
}
