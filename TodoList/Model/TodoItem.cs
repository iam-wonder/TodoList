using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListApp
{
    public class TodoItem

    {
        public string TodoText { get; set; }
        public bool complete { get; set; }

        public TodoItem(string TodoText, bool complete)
        {
            this.TodoText = TodoText;
            this.complete = complete;
        }
    }
}
