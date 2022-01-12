using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoItemsLearn
{
    public class TodoState
    {
        public readonly Stack<IEnumerable<TodoItem>> TodoBuffer = new();
        public IEnumerable<TodoItem> Current => TodoBuffer.Any() ? TodoBuffer.Peek() : new List<TodoItem>();
        public List<TodoItem> todoItems { get; set; }

        public bool CantUndo => TodoBuffer.Count > 0;
        public bool CanClear => !Current.Any(i => i.IsDone);

        public void addTodo(TodoItem newTodo)
        {
            var newState = new List<TodoItem>(Current) { newTodo };
            //todoItems.Add(newTodo);
            TodoBuffer.Push(newState);
        }

        public void ClearTodos()
        {
            //push
            TodoBuffer.Push(Current.Where(i => !i.IsDone));
            //todoItems = todoItems.Where(i => !i.IsDone).ToList();
        }

        public void Undo()
        {
            if(CantUndo)
            {
                TodoBuffer.Pop();
            }
             

        }
    }
}
