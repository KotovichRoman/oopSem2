using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab67
{
    public static class State
    {
        public static Stack<List<Game>> undoStack = new Stack<List<Game>>();
        public static Stack<List<Game>> redoStack = new Stack<List<Game>>();
    }
}
