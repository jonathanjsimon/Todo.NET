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

        public todoItem(String cFullLine)
        {
            fullLine = cFullLine;
        }

        public override String ToString()
        {
            String output = "";

            if (priority != "")
                output = output.Trim() + "(" + priority + ")";

            if (date != "")
                output = output.Trim() + " " + date;

            if (todo != "")
                output = output.Trim() + " " + todo;

            if (project != "")
                output = output.Trim() + " " + project;

            if (context != "")
                output = output.Trim() + " " + context;

            if (output != "")
                return output.Trim();
            else
                return "There was an error, please check your todo.txt file";
        }

    }
}
