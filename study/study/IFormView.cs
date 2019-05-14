using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTL
{
    public interface IFormView
    {
        void SetController(FormController controller);
        void AddListItem(object item);
        void RemoveListItem(object item);
        void RemoveListItemByIndex(int index);
        void ClearListView();
    }
}
