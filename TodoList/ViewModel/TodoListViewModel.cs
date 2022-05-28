using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

using System.ComponentModel;
using TodoList.ViewModel;

namespace ToDoListApp
{


        class TodoListViewModel
    {
        private readonly Commands Ncommand = new Commands(); 
   
       
        public ObservableCollection<TodoItem> TodoItems { get; set; }

        
        public TodoListViewModel()
        {
            TodoItems = new ObservableCollection<TodoItem>();

            TodoItems.Add(new TodoItem("todo1", false));
            TodoItems.Add(new TodoItem("todo2", false));
            TodoItems.Add(new TodoItem("todo3", true));
        }

        public ICommand AddTodoCommand => new Command(AddTodoItem);
        public string NewTodoInputValue { get; set; }

        void AddTodoItem()
        {
            
            TodoItems.Add(new TodoItem(NewTodoInputValue,false));
            NewTodoInputValue = string.Empty; 
            Ncommand.CloseWindow();

        }

       public ICommand RemoveTodoCommand => new Command(RemoveTodoItem);
       public void RemoveTodoItem(object o)

        {
            TodoItem todoItemBeingRemoved = o as TodoItem;
            //TodoItems.Remove(todoItemBeingRemoved);
            Console.WriteLine(todoItemBeingRemoved.TodoText );
            
        }

      
    }
}
