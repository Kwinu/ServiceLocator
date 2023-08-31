using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursDLC

    public interface IServiceScore
{
    void Add(int pPoints);
    int Get();
}

{
    internal class ScoreService : IServiceScore
    {
        private int Value;

        public ScoreService()
        {
            Value = 0;
            ServiceLocator.RegisterService<IServiceScore>(this);
        }

        public void Add(int pPoints)
        {
            Value += pPoints;
        }

        public int Get()
        {
            return Value;
        }

        public void Display()
        {
            Debug.WriteLine(Value);
        }
    }
}
