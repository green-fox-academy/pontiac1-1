using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp78
{
    class BlogPost
    {
        public string AuthorName;
        public string Title;
        public string Text;
        public string PubDate;

        public BlogPost(string AuthorName, string Title, string Text, string PubDate)
        {
            this.AuthorName = AuthorName;
            this.Title = Title;
            this.Text = Text;
            this.PubDate = PubDate;
        }
    }

}
