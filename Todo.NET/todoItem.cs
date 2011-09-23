using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Todo.NET
{
    class todoItem
    {

        String line;
        String priority;
        String date;
        String todo;
        String project;
        String context;

        public todoItem(String cLine, String cPriority, String cDate,
            String cTodo, String cProject, String cContext)
        {
            line = cLine;
            priority = cPriority;
            date = cDate;
            todo = cTodo;
            project = cProject;
            context = cContext;
        }

    }
}
