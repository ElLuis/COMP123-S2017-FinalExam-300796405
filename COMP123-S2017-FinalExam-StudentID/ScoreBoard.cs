using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2017_FinalExam_StudentID
{

    //Luis Sanchez - 3007964905
    //Score class and properties
    //Test # 2
    //8/17/2017
    public class ScoreBoard : PickHighestCardForm
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

        public ScoreBoard(TextBox scoreTextBox,TextBox timeTextBox, TextBox finalScoreTextBox)
        {
            ScoreTextBox = scoreTextBox;
            TimeTextBox = timeTextBox;
            FinalScoreTextBox = finalScoreTextBox;
        }

        public static void UpdateTime()
        {
            
        }
    }
}
