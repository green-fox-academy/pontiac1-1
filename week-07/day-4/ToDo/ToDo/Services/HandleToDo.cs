using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Models;
using System.Xml.Serialization;
using System.IO;

namespace ToDo.Services
{
    public class HandleToDo : IToDo
    {
        public void AddToDo(ToDos a)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ToDos));
            using (TextWriter tw = new StreamWriter(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-07\day-4\ToDo\ToDo\SavedToDos\"+ToDoList.myList.Count+".xml"))
            {
                serializer.Serialize(tw, a);
            }
        }

        public void DelToDo(ToDos a)
        {
            ToDoList.myList.Remove(a);
        }

        public void Read()
        {
                XmlSerializer deserializer = new XmlSerializer(typeof(ToDos));
                TextReader reader = new StreamReader(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-07\day-4\ToDo\ToDo\SavedToDos\" + ToDoList.myList.Count + ".xml");
                object obj = deserializer.Deserialize(reader);
                ToDoList.myList.Add((ToDos)obj);
                reader.Close();          
        }

        public void ReadAll()
        {
            var fileCount = Directory.EnumerateFiles(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-07\day-4\ToDo\ToDo\SavedToDos\", "*.xml", SearchOption.AllDirectories).Count();
            for (int i = 0; i < fileCount; i++)
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(ToDos));
                TextReader reader = new StreamReader(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-07\day-4\ToDo\ToDo\SavedToDos\" + i + ".xml");
                object obj = deserializer.Deserialize(reader);
                ToDoList.myList.Add((ToDos)obj);
                reader.Close();
            }
        }
    }
}
