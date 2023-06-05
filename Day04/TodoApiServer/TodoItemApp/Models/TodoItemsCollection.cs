using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace TodoItemApp.Models
{
    public class TodoItemsCollection : ObservableCollection<TodoItem> // IList<TodoItem>, List<TodoItem>
    {
        public void CopyFrom(IEnumerable<TodoItem> todoItems)
        {
            this.Items.Clear(); // ObservableColection<T> 자체가 Items 속성을 가지고 있음.

            foreach (TodoItem item in todoItems)
            {
                this.Items.Add(item);
            }

            this.OnCollectionChanged(new NotifyCollectionChangedEventArgs
                (NotifyCollectionChangedAction.Reset));
        }
    }
}
