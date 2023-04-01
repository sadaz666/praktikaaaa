﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDecoration.Properties;

namespace WpfDecoration
{
    internal class Instance
    {
        private static Entities _db;
        public static Entities db
        {
            get
            {
                if(_db == null)
                    _db = new Entities();
                return _db;
            }
        }
    }
}
