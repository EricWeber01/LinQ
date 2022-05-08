using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
        class Shop
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Category { get; set; }
            public double Price { get; set; }
            public override string ToString()
            {
                return $"{Id}. {Title} | {Price}$ | <{Category}> ";
            }
        }
    }
