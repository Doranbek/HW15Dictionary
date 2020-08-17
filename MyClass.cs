using System;
using System.Collections.Generic;

namespace DictionaryLibrary
{
    public class MyClass
    {
       public Dictionary<int, string> MyDictionary = new Dictionary<int, string>();
       

        public MyClass()
        {

        }

        public void Add(int key,string val)
        {
            try
            {
                MyDictionary.Add(key, val);
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Элемент с ключом {key} существует");
            }
            
        }

        public string GetValue(int key) 
        {
            string result = null;
            try
            {
                 foreach (var item in MyDictionary)                    
                    if (key == item.Key)
                        result += $"key:{item.Key}--> val:{item.Value}";
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Элемент с Key{key} не существует");
            }
            
            return result;
        }

        public void Remove(int key) 
        {
            try
            {
                foreach (var item in MyDictionary)

                    if (key == item.Key)
                    {
                        MyDictionary.Remove(item.Key);
                        break;
                    }
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Элемент с ключом {key} в словаре не существует");
            }
            
        }

        public void Print() 
        {
            foreach (var item in MyDictionary)
            {
                Console.WriteLine($"key:{item.Key}-> val:{item.Value}");
            }
        }
    }
}
