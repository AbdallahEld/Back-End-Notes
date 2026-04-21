namespace The_Object_Type
{
    public class Stack
    {
        int position;
        object[] items = new object[10];
        
        public void Push(object item)
        {
            items[position] = item;
            position++;
        }

        public object Pop()
        {
            position--;
            return items[position];
        }
    }
}
