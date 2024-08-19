class Stack{
    private int top;
    private char[] data;
    private int size;

    public Stack(int size){
        this.size = size;
        data = new char[size];
        top = -1;
    }

    public bool IsEmpty => top == -1;

    public bool IsFull => top == size - 1;

    public char Peek(){
        if(IsEmpty) throw new Exception("Stack is empty");
        return data[top];
    }

    public void Push(char element){
        if(IsFull) throw new Exception("Stack is full");
        data[++top] = element;
    }

    public char Pop(){
        if(IsEmpty) throw new Exception("Stack is empty");
        return data[top--];
    }
}