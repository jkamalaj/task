using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    interface ICity
    {
        public Human[] Human { get; set; }

         void AddHuman();
         void SearchHumans();
        
    }
}
