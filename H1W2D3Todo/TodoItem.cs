namespace H1W2D3Todo
{
    /*
 * To do item
 * Date created
 * Date Deadline
 * Do / Done
 * Favorite
 * What to do Text
 * Repeat
 * 
 * Create/Read/Update/Delete
 * */

    internal class ToDoItem
    {
        public DateTime Created { get; set; }
        public DateTime DeadLine { get; set; }
        public bool IsDone { get; set; }
        public bool IsFavorite { get; set; }
        public string Description { get; set; }
        //public long Repeat { get; set; } //If repeat > 0 the repeat is on

    }
}
