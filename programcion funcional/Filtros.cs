﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARQUITECTURAS.programcion_funcional
{
    internal class Filtros
    {
        public void filtros()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var result = numbers
                .Where(n => n > 4)
                .Select(n => n * 2)
                .ToList();
        }
           

           
        
    }
}
