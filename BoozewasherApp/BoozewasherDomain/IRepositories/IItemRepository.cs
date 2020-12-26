﻿using BoozewasherDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoozewasherDomain.IRepositories
{
    public interface IItemRepository
    {
        void AddItem(Item item);
        void DeleteItem(int id);
        List<Item> GetAllItems();
        void UpdateItem(Item item);

    }
}