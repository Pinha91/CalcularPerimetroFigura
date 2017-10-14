using System;
using System.Windows.Forms;

namespace CalcularPerimetroFigura
{
    public partial class CalculateFigure : Form
    {
        /// <summary>
        /// Constant of mistake by system.
        /// </summary>
        const String MESSAGE_NULLORNUMBER = "you must write a number in each section.";
        const String MESSAGE_NEGATIVE = "you must write positive numbers in each section.";
        /// <summary>
        ///  objects that calculate area and perimeter definition in variable.
        /// </summary>
        Rectangle r = new Rectangle();
        Triangule t = new Triangule();
        Circule c = new Circule();
        /// <summary>
        /// Utility Variables
        /// </summary>
        private float number1, number2, number3;
        /// <summary>
        /// Where the program starts
        /// </summary>
        public CalculateFigure()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Select the type of the figure to show the image
        //  and the different calculation characteristics of the figure.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KindFigure_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if i don't select some option, it won't show anything.
            if (kindFigure.SelectedIndex != -1) {

                pictureFigure.Visible = true;//I change at visibily of pictureBox

                switch (kindFigure.Text)//Depend of select kind shows a kind figure.
                {
                    case "Rectangle":
                        pictureFigure.Image = imageFigure.Images[1];
                        break;

                    case "Triangule":
                        pictureFigure.Image = imageFigure.Images[2];
                        break;

                    case "Circule":
                        pictureFigure.Image = imageFigure.Images[0];
                        break;

                }

                //Active visibility others options
                questionKindCalculate.Visible = true;
                selectCalculate.Visible = true;

                //Back Control calculate options about visibility
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;

                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;

                buttonCalculate.Visible = false;

                resultKind.Visible = false;
                resultValue.Visible = false;
                messageFail.Visible = false;

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

                number1 = 0;
                number2 = 0;
                number3 = 0;

            }

        }
        /// <summary>
        /// Select the type of calculation and it will show the necessary boxes for it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectCalculate_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if i don't select some option, it won't show anything.
            if (selectCalculate.SelectedIndex != -1)
            {

                switch (kindFigure.Text)//Depend of select kind shows diferents kind calculate.
                {
                    case "Rectangle":

                        //Control visibility
                        label1.Visible = true;
                        label2.Visible = true;
                        label3.Visible = false;

                        //Wrinting type data
                        label1.Text = "Base";
                        label2.Text = "Height";

                        //Control visibility textBox
                        textBox1.Visible = true;
                        textBox2.Visible = true;
                        textBox3.Visible = false;

                        break;

                    case "Triangule":

                        if (selectCalculate.Text == "Area")
                        {
                            //Control visibility
                            label1.Visible = true;
                            label2.Visible = true;
                            label3.Visible = false;

                            //Wrinting type data
                            label1.Text = "Base";
                            label2.Text = "Height";

                            //Control visibility textBox
                            textBox1.Visible = true;
                            textBox2.Visible = true;
                            textBox3.Visible = false;

                        }
                        else
                        {
                            //Control visibility
                            label1.Visible = true;
                            label2.Visible = true;
                            label3.Visible = true;

                            //Wrinting type data
                            label1.Text = "Side Right";
                            label2.Text = "Side Left";
                            label3.Text = "Side Based";

                            //Control visibility textBox
                            textBox1.Visible = true;
                            textBox2.Visible = true;
                            textBox3.Visible = true;

                        }

                        break;

                    case "Circule":

                        //Control visibility
                        label1.Visible = true;
                        label2.Visible = false;
                        label3.Visible = false;

                        //Wrinting type data
                        label1.Text = "Radio";

                        //Control visibility textBox
                        textBox1.Visible = true;
                        textBox2.Visible = false;
                        textBox3.Visible = false;

                        break;

                }

                buttonCalculate.Visible = true;
                buttonCalculate.Enabled = false;
                messageFail.Visible = false;
                resultKind.Visible = false;
                resultValue.Visible = false;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

                number1 = 0;
                number2 = 0;
                number3 = 0;
            }

        }
        /// <summary>
        /// Control of textBox1 about data correct to active calculate button and depend of vibility.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            resultKind.Visible = false;//it's posible change about the result.
            resultValue.Visible = false;

            if (textBox1.Visible)
            {
                if (ValueNotNullIsNumber(textBox1))
                {
                    buttonCalculate.Enabled = false;//Not shows button
                    messageFail.Visible = true;
                    messageFail.Text = MESSAGE_NULLORNUMBER;//Message of mistake null or not number

                }
                else
                {
                    number1 = float.Parse(textBox1.Text);

                    if (ValueNegative(number1))
                    {
                        buttonCalculate.Enabled = false;//Not shows button
                        messageFail.Visible = true;
                        messageFail.Text = MESSAGE_NEGATIVE;//Message of mistake null or not number
                    }
                    else
                    {
                        buttonCalculate.Enabled = true;
                        messageFail.Visible = false;
                    }

                }
            }
        }
        /// <summary>
        /// Control of textBox2 about data correct to active calculate button and depend of vibility.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            resultKind.Visible = false;//it's posible change about the result.
            resultValue.Visible = false;

            if (textBox2.Visible)
            {
                if (ValueNotNullIsNumber(textBox2))
                {
                    buttonCalculate.Enabled = false;//Not shows button
                    messageFail.Visible = true;
                    messageFail.Text = MESSAGE_NULLORNUMBER;//Message of mistake null or not number

                }
                else
                {
                    number2 = float.Parse(textBox2.Text);

                    if (ValueNegative(number2))
                    {
                        buttonCalculate.Enabled = false;//Not shows button
                        messageFail.Visible = true;
                        messageFail.Text = MESSAGE_NEGATIVE;//Message of mistake null or not number
                    }
                    else
                    {
                        buttonCalculate.Enabled = true;
                        messageFail.Visible = false;
                    }

                }
            }
        }
        /// <summary>
        /// Control of textBox3 about data correct to active calculate button and depend of vibility.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            resultKind.Visible = false;//it's posible change about the result.
            resultValue.Visible = false;

            if (textBox3.Visible)
            {
                if (ValueNotNullIsNumber(textBox3))
                {
                    buttonCalculate.Enabled = false;//Not shows button
                    messageFail.Visible = true;
                    messageFail.Text = MESSAGE_NULLORNUMBER;//Message of mistake null or not number

                }
                else
                {
                    number3 = float.Parse(textBox3.Text);

                    if (ValueNegative(number3))
                    {
                        buttonCalculate.Enabled = false;//Not shows button
                        messageFail.Visible = true;
                        messageFail.Text = MESSAGE_NEGATIVE;//Message of mistake null or not number
                    }
                    else
                    {
                        buttonCalculate.Enabled = true;
                        messageFail.Visible = false;
                    }

                }
            }
        }
        /// <summary>
        /// Pressing the button displays the result depending on the previously selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCalculate_Click(object sender, EventArgs e)
        {

            resultKind.Visible = true;
            resultValue.Visible = true;

            switch (kindFigure.Text)//Depend of kind selecting  is doing a calculation kind or other
            {
                case "Rectangle":

                    r.Based = number1;
                    r.Height = number2;

                    if(selectCalculate.Text == "Area")
                    {
                        resultValue.Text = String.Format("{0}",r.CalculateArea());
                    }
                    else
                    {
                        resultValue.Text = String.Format("{0}", r.CalculatePerimeter());
                    }
                   
                    break;

                case "Triangule":

                    if(selectCalculate.Text == "Area")
                    {
                        t.Based = number1;
                        t.Height = number2;

                        resultValue.Text = String.Format("{0}", t.CalculateArea());

                    }
                    else
                    {
                        t.SideBased = number1;
                        t.SideLeft = number2;
                        t.SideRight = number3;

                        resultValue.Text = String.Format("{0}", t.CalculatePerimeter());
                    }
                    break;

                case "Circule":

                    c.Radio = number1;

                    if (selectCalculate.Text == "Area")
                    {
                        resultValue.Text = String.Format("{0}", c.CalculateArea());
                    }
                    else
                    {
                        resultValue.Text = String.Format("{0}", c.CalculatePerimeter());
                    }

                    break;

            }

        }
        /// <summary>
        /// If it isn't null and not numbers 
        /// </summary>
        /// <param name="textBox">it's the value for TextBox</param>
        /// <returns>It's true or false about that has all conditions</returns>
        public Boolean ValueNotNullIsNumber(TextBox textBox)
        {
            float value;

            return String.IsNullOrWhiteSpace(textBox.Text) || !float.TryParse(textBox.Text, out value);
        }
        /// <summary>
        /// Controls the negative value
        /// </summary>
        /// <param name="value"></param>
        /// <returns>boolean</returns>
        public Boolean ValueNegative(float value)
        {

            return value<0;
        }

    }
}
