namespace TodoApp.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public bool IsCompleted { get; set; }
        public DateTimeOffset DateCompleted { get; set; }
    }
}
