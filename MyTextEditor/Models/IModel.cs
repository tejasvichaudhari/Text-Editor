using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication3
{
    public interface IModel
    {
        List<String> setInfo(string text, string operation);
    }
}
