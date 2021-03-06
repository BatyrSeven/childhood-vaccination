﻿using System;
using System.Collections.Generic;
using Playground.Models;

namespace Playground.Services
{
    public interface ITicketService
    {
        IEnumerable<Ticket> GetAll();
        Ticket Get(int id);
        Ticket Add(Ticket ticket);
        void Delete(int id);
    }
}
