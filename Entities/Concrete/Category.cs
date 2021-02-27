﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    // Çıplak Class Kalmasın
    // Eğer class bir veritabanı tablosunu temsil ediyorsa, IEntity ile imzala.
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}