﻿using Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IManagers
{
    public interface ISendEmailManager
    {
        Task SendEmail(SendEmailDto sendEmail);
    }
}
