using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moule_9_Практикум_App
{
    public class SortHelper
    {
        public delegate void SortEventHandler(List<string> surnames, bool ascending);
        public event SortEventHandler SortEvent;

        public void TriggerSort(List<string> sernames, bool ascending)
        {
            SortEvent?.Invoke(sernames, ascending);
        }
    }
}
