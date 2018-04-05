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
            ToDoList.myList.Add(a);
        }

        public void DelToDo(ToDos a)
        {
            ToDoList.myList.Remove(a);
        }

        public void SaveToDo(ToDos a)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ToDos));
            using (TextWriter tw = new StreamWriter(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-07\day-4\ToDo\ToDo\SavedToDos\saved.xml"))
            {
                serializer.Serialize(tw, a);
            }
        }
    }
}
