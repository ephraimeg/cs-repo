using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTL
{
    public partial class FormView : Form, IFormView
    {
        private FormController _controller;
        private object _item;
        private int _index;

        public FormView()
        {
            InitializeComponent();
        }

        public void AddListItem(object item)
        {
            _controller.AddItem(item);
        }

        public void ClearListView()
        {
            _controller.ClearList();
            lbxMyList.Items.Clear();
        }
        
        public void RemoveListItem(object item)
        {
            _controller.RemoveItem(item);
        }

        public void RemoveListItemByIndex(int index)
        {
            _controller.RemoveItemByIndex(index);
        }

        public void SetController(FormController controller)
        {
            _controller = controller;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            _item = rtbxInBox.Text.Trim();
            if((string)_item != string.Empty)
            {
                AddListItem(_item);
                lbxMyList.Items.Add(_item);
                rtbxInBox.Text = "";
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            object _selectedItem = lbxMyList.SelectedItem;
            if (_selectedItem != null)
            {
                _controller.RemoveItem(_selectedItem);
                lbxMyList.Items.Remove(_selectedItem);
            }
            else
            {
                _controller.RemoveItemByIndex(0);
                lbxMyList.Items.RemoveAt(0);
            }
        }

        private void btnClearTextBox_Click(object sender, EventArgs e)
        {
            rtbxInBox.Text = "";
        }

        private void btnClearListBox_Click(object sender, EventArgs e)
        {
            ClearListView();
        }
    }
}
