using System.Collections.Generic;
using System.Linq;
using TodoAPI.Interfaces;
using TodoAPI.Models;

namespace TodoAPI.Services
{
    public class TodoRepository : ITodoRepository
    {
        private List<TodoItem> _todoList;

        public TodoRepository()
        {
            InitializeData();
        }

        public IEnumerable<TodoItem> All
        {
            get { return _todoList; }
        }

        public bool DoesItemExist(string id)
        {
            return _todoList.Any(item => item.ID == id);
        }

        public TodoItem Find(string id)
        {
            return _todoList.FirstOrDefault(item => item.ID == id);
        }

        public void Insert(TodoItem item)
        {
            _todoList.Add(item);
        }

        public void Update(TodoItem item)
        {
            var todoItem = this.Find(item.ID);
            var index = _todoList.IndexOf(todoItem);
            _todoList.RemoveAt(index);
            _todoList.Insert(index, item);
        }

        public void Delete(string id)
        {
            _todoList.Remove(this.Find(id));
        }

        private void InitializeData()
        {
            _todoList = new List<TodoItem>();

            var todoItem1 = new TodoItem
            {
                ID = "1",
                category = " Agriculture ",
                task_subject = " Water issue ",
                priority = " High ",
                Alloted_to = " Agriculture Ministry ",
                Target_Date = "09-2021",
                year = " 2021 ",
                end_Date = " 07-2021 "
                
            };

            var todoItem2 = new TodoItem
            {
                ID = "2",
                category = " Healthcare ",
                task_subject = " Water Clogging causing dengue ",
                priority = " High ",
                Alloted_to = " Muncipality ",
                Target_Date = "07-2021",
                year = " 2021 ",
                end_Date = " - "
            };

            var todoItem3 = new TodoItem
            {
                ID = "3",
                category = " Public Welfare ",
                task_subject = " Damaged Roads ",
                priority = " Medium ",
                Alloted_to = " PWD ",
                Target_Date = "01-2022",
                year = " 2021 ",
                end_Date = " - "
            };

            _todoList.Add(todoItem1);
            _todoList.Add(todoItem2);
            _todoList.Add(todoItem3);
        }
    }
}
