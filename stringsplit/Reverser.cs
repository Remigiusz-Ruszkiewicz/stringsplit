using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace stringsplit
{
    public class Reverser
    {
        private string result;

        public string Reverse(string text)
        {

            Stack myStack = new Stack();
            string[] ssize = text.Split(null);
            foreach (var item in ssize)
            {
                myStack.Push(item);
            }
            while (myStack.Count > 0)
            {
                result = result + myStack.Pop().ToString() + " ";
            }
            return result.Trim();
        }
    }
}
