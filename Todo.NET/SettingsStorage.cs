using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Todo.NET
{
    class SettingsStorage
    {


        String todoLoc;
        Boolean backup;
        Boolean includeDate;
        Boolean debug;


        public SettingsStorage(String cTodoPath, Boolean cBackUp, Boolean cIncludeDate, Boolean cDebugMode)
        {
            todoLoc = cTodoPath;
            backup = cBackUp;
            includeDate = cIncludeDate;
            debug = cDebugMode;
        }
    }
}
