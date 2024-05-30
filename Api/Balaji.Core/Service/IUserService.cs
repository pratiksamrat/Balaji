﻿using Balaji.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balaji.Core.Service
{
    public interface IUserService
    {
        public Task<dynamic> GetUserAsync(UserApiModel model);
    }
}
