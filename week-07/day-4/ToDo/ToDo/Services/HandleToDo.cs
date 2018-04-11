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
            using (TextWriter tw = new StreamWriter(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-07\day-4\ToDo\ToDo\SavedToDos\"+ a.Content + ".xml"))
            {
                serializer.Serialize(tw, a);
            }
        }

        public void DelToDo(string content, int id = 0)
        {
            File.Delete(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-07\day-4\ToDo\ToDo\SavedToDos\" + content + ".xml");
        }

        public void Read(string content)
        {
                XmlSerializer deserializer = new XmlSerializer(typeof(ToDos));
                TextReader reader = new StreamReader(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-07\day-4\ToDo\ToDo\SavedToDos\" + content + ".xml");
                object obj = deserializer.Deserialize(reader);
                ToDoList.myList.Add((ToDos)obj);
                reader.Close();          
        }

        public void ReadAll()
        {
            string[] files = Directory.GetFiles(@"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-07\day-4\ToDo\ToDo\SavedToDos\", "*.xml");
            foreach (var file in files)
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(ToDos));
                TextReader reader = new StreamReader(file);
                object obj = deserializer.Deserialize(reader);
                ToDoList.myList.Add((ToDos)obj);
                reader.Close();
            }
            ToDoList.myList.GroupBy(x => x.Priority==true);
        }
    }
}
