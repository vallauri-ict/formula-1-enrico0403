using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOneDll
{
    public class Scores
    {
        private int pos;
        private int score;
        private string details;

        public Scores(int pos, int score, string details)
        {
            this.pos = pos;
            this.score = score;
            this.details = details;
        }

        public int Pos { get => pos; set => pos = value; }
        public int Score { get => score; set => score = value; }
        public string Details { get => details; set => details = value; }
    }
}
