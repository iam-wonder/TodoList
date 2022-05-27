using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

using System.ComponentModel;

namespace ToDoListApp
{


    class TodoListViewModel:INotifyPropertyChanged
    {
        string _summaryText = string.Empty;
        public string summaryText
        {
            get => _summaryText;
            set
            {
                if (_summaryText == value)
                    return;

                _summaryText = value;
                OnPropertyChanged(nameof(summaryText));
                OnPropertyChanged(nameof(DisplayName ));
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<TodoItem> TodoItems { get; set; }

        public string DisplayName => summaryText;
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
        }
        public ICommand RemoveTodoCommand => new Command(RemoveTodoItem);
       public void RemoveTodoItem(object o)
        {
            TodoItem todoItemBeingRemoved = o as TodoItem;
            //TodoItems.Remove(todoItemBeingRemoved);
            Console.WriteLine(todoItemBeingRemoved.TodoText );
        }

        

        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
