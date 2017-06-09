using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Pop
{
    interface IWebPage
    {
        string iniWebPage
        {
            get;
            set;
        }
        string currentWebPage
        {
            get;
            set;
        }
        string nextWebPage
        {
            get;
            set;
        }
        string elementName
        {
            get;
            set;
        }
        string forwardButtonName
        {
            get;
            set;
        }
    }
}
