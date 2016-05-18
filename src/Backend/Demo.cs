using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Backend
{
    public class Demo
    {
        public bool ContainsFive(List<int> l)
        {
            return l.Any(i => i == 5);
        }

       public string GetText(IDemo demo)
       {
          return demo.GetText();
       }
    }

   public interface IDemo
   {
      string GetText();
   }
}
