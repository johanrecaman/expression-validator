class Expression{
    public bool IsValid(string expression){
        Dictionary<char, char> delimiters = new(){
            {')', '('},
            {']', '['},
            {'}', '{'}
        };

        Stack stack = new(expression.Length);

        foreach (char chr in expression){
            if (delimiters.ContainsValue(chr)){
                stack.Push(chr);
            } 

            else if(delimiters.ContainsKey(chr)){
                if (stack.IsEmpty) return false;

                char top = stack.Pop();
                if (top != delimiters[chr]) return false;
            }
        }
        return stack.IsEmpty;
    }
}