using System;

namespace Assignment_Q4_staticVariableScope
{
    
    class staticVariableScope
    {   
        //static variable...
        static public int staticVar = 10;

        //Non static Variable...
        public int nonStaticVar = 20;

        public staticVariableScope()
        {
            staticVar++;
            Console.WriteLine($"staticVar = {staticVar}");
            nonStaticVar++;
            Console.WriteLine($"nonStaticVar = {nonStaticVar}");
        }
    }
}
