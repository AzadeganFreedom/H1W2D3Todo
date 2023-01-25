namespace H1W2D3Todo
{
    internal class Menu
    {
        List<ToDoItem> todoList = new();

        //Constructor that runs when object is instantiated (with new keyword)
        public Menu()
        {
            FakeData();
            while (true)
            {
                MainMenu();
            }
            
        }

        private void FakeData()
        {
            for (int i = 0; i < 5; i++)
            {
                ToDoItem tdi = new ToDoItem() { Created = DateTime.Now, DeadLine = DateTime.Now.AddDays(1), Description = "Something" + i};
                todoList.Add(tdi);
            }
            
        }

        //Start menu
        public void MainMenu()
        {
            Console.WriteLine("Main Menu\n\n(1): Add new\n(2): Show list\n(3): Delete Item\n(4): Update Item");

            var v = Console.ReadKey(true);
            switch (v.KeyChar)
            {
                
                case '1':
                    CreateItem();
                    break;
                case '2':
                    ShowList();
                    break;
                case '3':
                    DeleteItem();
                    break;
                case '4':
                    UpdateItem();
                    break;
                default:
                    break;
            }
        }

     



        //Show TodoList show todo items
        void ShowList()
        {
            Console.Clear();
            foreach (ToDoItem item in todoList)
            {
                ShowItem(item);
            }
        }


        //Create Item
        private void CreateItem()
        {
            Console.Clear();
           ToDoItem newItem = new ToDoItem();
            newItem.Created = DateTime.Now;
            Console.WriteLine("What to do?");
            newItem.Description = Console.ReadLine();


            Console.WriteLine("When to do it?");
            string dl = Console.ReadLine(); //dl = Deadline
            //TODO Get different input regarding dates and times
            
            newItem.DeadLine = DateTime.Parse(dl); //Converting DateTime
            newItem.IsDone = false;

            Console.WriteLine("Is it important? Press Y for yes");
            newItem.IsFavorite = Console.ReadKey(true).Key == ConsoleKey.Y ? true : false; //Press Y to make item favorite or not (true or false)

            

            todoList.Add(newItem);
            Console.Clear();
            
        }

        //Read TodoItem
        private void ShowItem(ToDoItem toDoItem)
        {
            
            int i = todoList.IndexOf(toDoItem);
            Console.WriteLine($"index: {i} \tWhat: {toDoItem.Description} \tWhen: {toDoItem.DeadLine} \tisDone: {toDoItem.IsDone}");
        }

        //Delete Item

        private void DeleteItem()
        {
            Console.Clear();
            Console.WriteLine("Which item would you like to delete?\n");
            ShowList();
            int i = int.Parse(Console.ReadLine());
            
            
            Console.WriteLine("Are you sure you want to delete this item?\n\n(Y): Yes\n(N): No");
            var v = Console.ReadKey(true);
            switch (v.KeyChar)
            {
                case 'y':
                    todoList.RemoveAt(i);                    
                    break;
                case 'n':

                    break;
                default:
                    break;
            }
        }


        //Update Item
        void UpdateItem()
        {
            Console.Clear();
            Console.WriteLine("Update. Pick item index for todoitem that needs updating");
            ShowList();
            int i = int.Parse(Console.ReadLine());
            ToDoItem tdi = todoList[i];

            Console.WriteLine("What to do?");
            string input = Console.ReadLine();
            
                if (input != "")
            {
                tdi.Description = input;
            }
        }
    }
}
