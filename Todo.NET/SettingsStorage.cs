using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Todo.NET
{
    class SettingsStorage
    {


        public String todoLoc;
        public Boolean backup;
        public Boolean includeDate;
        public Boolean debug;


        public SettingsStorage(String cTodoPath, Boolean cBackUp, Boolean cIncludeDate, Boolean cDebugMode)
        {
            todoLoc = cTodoPath;
            backup = cBackUp;
            includeDate = cIncludeDate;
            debug = cDebugMode;
        }
    }
}
