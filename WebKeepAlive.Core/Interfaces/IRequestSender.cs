﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebKeepAlive.Core.Interfaces;
public interface IRequestSender
{
     Task<bool> SendRequestAsync(string url);
}
