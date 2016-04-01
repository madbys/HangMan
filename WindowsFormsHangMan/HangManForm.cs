using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHangMan
{
    public partial class HangManForm : Form
    {
        //Private 
        private string word = "";
        private List<Label> labelList = new List<Label>();
        private int amount = 0;


        public HangManForm()
        {
            InitializeComponent();
        }
                
        private void Form1_Shown(object sender, EventArgs e)
        {
            Reset();
        }


        private void Reset()
        {
            Graphics g = panel1.CreateGraphics();
            g.Clear(panel1.BackColor);
            GetRandomWord();
            DoLabels();
            DrawingHangPost();
            labelMissedLetters.Text = "Missed: ";
            textBoxLetter.Text = "";
        }

        private string GetRandomWord()
        {
            RandomWord rw = new RandomWord();
            string randomWord = rw.GetRandomWord();
            return randomWord;
        }

        private void DoLabels()
        {
            word = GetRandomWord();
            char[] chars = word.ToCharArray(); //\n
            int pxlsBetween = 200 / chars.Length - 1;

            for (int i = 0; i < chars.Length; i++)
            {
                labelList.Add(new Label());
                labelList[i].Location = new Point((i * pxlsBetween) + 10, 80);
                labelList[i].Text = "_";
                labelList[i].Parent = groupBoxWord;
                labelList[i].BringToFront();
                labelList[i].CreateControl();
            }
            labelWorldLength.Text = "Word length: " + (chars.Length).ToString();
        }

        private void DrawingHangPost()
        {
            Graphics g = panel1.CreateGraphics();
            Pen pen = new Pen(Color.BurlyWood, 10); //Draw post
            g.DrawLine(pen, new Point(150, 240),new Point(150, 5));
            g.DrawLine(pen, new Point(155, 5), new Point(75, 5));
            g.DrawLine(pen, new Point(70, 0), new Point(70, 50));
        }

        private void DrawBodyParts(BodyParts bp)
        {
            Graphics g = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Black, 2);

            if (bp == BodyParts.Head)
            {
                g.DrawEllipse(pen, 50, 50, 40, 40);
            }
            else if (bp == BodyParts.Left_Eye)
            {
                SolidBrush sb = new SolidBrush(Color.Blue);
                g.FillEllipse(sb, 60, 60, 7, 5);
            }
            else if (bp == BodyParts.Right_Eye)
            {
                SolidBrush sb = new SolidBrush(Color.Blue);
                g.FillEllipse(sb, 75, 60, 7, 5);
            }
            else if (bp == BodyParts.Mouth)
            {
                g.DrawArc(pen, 60, 60, 20, 20, 45, 90);
            }
            else if (bp == BodyParts.Body)
            {
                g.DrawLine(pen, new Point(70, 90), new Point(70, 180));
            }
            else if (bp == BodyParts.Left_Arm)
            {
                g.DrawLine(pen, new Point(70, 100), new Point(30, 115));
            }
            else if (bp == BodyParts.Right_Arm)
            {
                g.DrawLine(pen, new Point(70, 100), new Point(110, 115));
            }
            else if (bp == BodyParts.Left_Leg)
            {
                g.DrawLine(pen, new Point(70, 180), new Point(30, 200));
                g.DrawLine(pen, new Point(30, 200), new Point(20, 190));
            }
            else if (bp == BodyParts.Right_Leg)
            {
                g.DrawLine(pen, new Point(70, 180), new Point(110, 200));
                g.DrawLine(pen, new Point(110, 200), new Point(120, 190));
            }
                
        }

        private void buttonSubmitLetter_Click(object sender, EventArgs e)
        {
            if(textBoxLetter.Text == null || textBoxLetter.Text == "")
            {
                MessageBox.Show("You can only submit letters", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxLetter.Clear();
                return;
            }


            char letter = textBoxLetter.Text.ToLower().ToCharArray()[0];

            if (!char.IsLetter(letter))
            {
                MessageBox.Show("You can only submit letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxLetter.Clear();
                return;
            }

            if (word.Contains(letter))
            {
                char[] letters = word.ToCharArray();
                for (int i = 0; i < letters.Length; i++)
                {
                    if (letters[i] == letter)
                    {
                        labelList[i].Text = letter.ToString();
                        textBoxLetter.Clear();
                    }
                }

                 foreach (Label l in labelList)
                {
                    if (l.Text == "_") 
                        return;
                }
                        
                    
                MessageBox.Show("You have won!", "Congratz!!");
                    Reset();
            }
            else
            {
                labelMissedLetters.Text += " " + letter.ToString() + ",";

                textBoxLetter.Clear();

                DrawBodyParts((BodyParts)amount);
                
                amount++;
                if(amount == 9)
                {
                    MessageBox.Show("Sorry, you lost the game. The word was " + word, "Lost!");
                    Reset();
                }

            }
   
        }

        private void buttonSubmitWord_Click(object sender, EventArgs e)
        {
            if (textBoxWord.Text == word)
            {
                MessageBox.Show("You have WON!", "Congratz!!");
                Reset();
            }
            else
            {
                MessageBox.Show("The word you guessed is not correct", "Sorry");
                DrawBodyParts((BodyParts)amount);
                amount++;

                if (amount == 9)
                {
                    MessageBox.Show("Sorry, you lost. The word was " + word, "Lost!");
                    Reset();
                }
            }
        }

    }
}
