﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treeSol
{
    internal class Node
    {
       
            public string Value { get; set; }
            public Node Left { get; set; }

            public Node Right { get; set; }


            public Node(string Str)
            {
                Value = Str;
                Left = null;
                Right = null;
            }

        
    }
}
