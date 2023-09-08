using Stack;
StackClass stack = new StackClass(10);
for(int i = 0; i < stack.MaxSize; i++)
{
    stack.Push(i + 1);
    Print(stack.Peek());
}
Console.WriteLine("\n");
stack.Push(12); 
Print(stack.Pop());
Print(stack.Pop());
Print(stack.Pop());

StackClass clone = (StackClass)stack.Clone();

Console.WriteLine("\n");
Print(stack.Peek());
Print(clone.Peek());

StackClass Clone2 = new StackClass(stack);

Console.WriteLine("\n");
Print(stack.Peek());
Print(Clone2.Peek());
static void Print(int a)
{
    Console.WriteLine(a);
}
