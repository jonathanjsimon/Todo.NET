using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Todo.NET
{
    class todoItem
    {

        String lineNum;
        String priority;
        String date;
        String todo;
        String project;
        String context;
        String fullLine;

        public todoItem(String cLineNum, String cPriority, String cDate,
            String cTodo, String cProject, String cContext, String cFullLine)
        {
            lineNum = cLineNum;
            priority = cPriority;
            date = cDate;
            todo = cTodo;
            project = cProject;
            context = cContext;
            fullLine = cFullLine;
        }

    }
}
