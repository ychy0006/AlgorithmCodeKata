using System;
using System.Text;
using System.Collections.Generic;
public class Solution {
        public int solution(string s)
    {
        int answer = 0;
        var stack = new Stack<char>();
        var queue = new Queue<char>();
        foreach (var item in s)
            queue.Enqueue(item);
        for (int i = 0; i < queue.Count - 1; i++)
        {
            stack.Clear();
            answer += Check(queue, stack);
            queue.Enqueue(queue.Dequeue());
        }

        return answer;
    }

    private int Check(Queue<char> queue, Stack<char> stack)
    {
        foreach (var item in queue)
        {
            if (item == '[' || item == '(' || item == '{')
                stack.Push(item);
            else if (stack.Count == 0)
                return 0;
            else if (stack.Peek() == '[' && item != ']')
                return 0;
            else if (stack.Peek() == '(' && item != ')')
                return 0;
            else if (stack.Peek() == '{' && item != '}')
                return 0;
            else
                stack.Pop();
        }
        if (stack.Count != 0)
            return 0;

        return 1;
    }
}