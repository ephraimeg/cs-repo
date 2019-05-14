using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTL
{
    public class FormController
    {
        private IFormView _view;
        private IList _list;

        public FormController(FormView view, IList list)
        {
            _view = view;
            _view.SetController(this);

            _list = list;
        }
        
        public bool AddItem(object item)
        {
            _list.Add(item);
            return true;
        }
        public bool RemoveItem(object item)
        {
            _list.Remove(item);
            return true;
        }

        public bool RemoveItemByIndex(int index)
        {
            _list.RemoveAt(index);
            return true;
        }

        public void ClearList()
        {
            _list.Clear();
        }

        public IList ListAllItems()
        {
            return _list;
        }
    }
}
