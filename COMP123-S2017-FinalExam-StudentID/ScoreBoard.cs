using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2017_FinalExam_StudentID
{
    public class ScoreBoard
    {
        private TextBox _finalScoreTextBox;
        private int _score;
        private TextBox _scoreTextBox;
        private int _time;
        private TextBox _timeTextBox;

        public TextBox FinalScoreTextBox { get; set; }
        public int Score
        {
            get { return _score; }
            set
            {
                ScoreTextBox.Text = value.ToString();
                FinalScoreTextBox.Text = value.ToString();
            }
        } //= this._score;
        public TextBox ScoreTextBox { set; get; }
        public int Time
        {
            get { return _time; }
            set
            {
                TimeTextBox.Text = value.ToString();
            }
        }
        public TextBox TimeTextBox { set; get; }
    }
}
