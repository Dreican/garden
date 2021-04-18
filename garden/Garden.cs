using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Garden
{
    public class Garden
    {
        private readonly List<bool> _garden;
        
        public static Result CanPlante(IEnumerable<int> garden, int seeds)
        {
            var g = new Garden(garden);
            
            
            return g.CanPlante();
        }

        private Garden(IEnumerable<int> garden)
        {
            var temp = garden.Select(g => g != 0).ToList();

            _garden = temp;
        }

        private Result CanPlante()
        {
            var i = 0;
            var prev = false;
            
            while (true)
            {
                bool current, next;

                if (i < _garden.Count)
                {
                    current = _garden[i];
                    next = _garden[i + 1];
                }
                else
                {
                    current = _garden[i];
                    next = false;
                }

                if (!prev && !current && !next)
                {
                    return new Result() {IsOk = true, Reason = $"can plant at position {i.ToString()}"};
                }

                if (i == _garden.Count)
                {
                    return new Result() {IsOk = false, Reason = "there are only 3 plots, and two of them can't be planted on"};
                }

                i++;

                prev = current;
            }
        }
    }
}