using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Drawing.Drawing2D;

namespace Arduino_Project
{
    public partial class Form1 : Form
    {
        private Image imgInitialImage;
        private string strLEDStatus = "000000000000000000000000000";

        private Color LED_OFF = System.Drawing.Color.Orange;
        private Color LED_ON = System.Drawing.Color.Green;

        private Color DISCONNECTED_LINE_COLOR = System.Drawing.Color.LightSkyBlue;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.SystemColors.Control;
            RepaintScreen();
        }

        /*
         *  This function toggles the LED status of an LED.
         *  Parameters:
         *      intLED:       This is the index of the LED whose value needs to be changed (0...26)
         *      blnChecked:   If the LED is turned on, i.e. the checkbox is checked, this parameter is set to TRUE
         * */
        private void SetLEDStatus(int intLED, bool blnChecked)
        {
            StringBuilder sb = new StringBuilder(strLEDStatus);

            if (blnChecked)
                sb[intLED] = '1';
            else
                sb[intLED] = '0';

            strLEDStatus = sb.ToString();            
        }


        #region Drawing Functions

        private void DrawThinLine(float x1, float y1, float x2, float y2)
        {
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(DISCONNECTED_LINE_COLOR);
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            formGraphics.DrawLine(myPen, x1, y1, x2, y2);
            myPen.Dispose();
            formGraphics.Dispose();
        }

        private void DrawThickLine(float x1, float y1, float x2, float y2)
        {
            System.Drawing.Pen myPen;            
            myPen = new System.Drawing.Pen(System.Drawing.Color.Black,5);
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            formGraphics.DrawLine(myPen, x1, y1, x2, y2);
            myPen.Dispose();
            formGraphics.Dispose();
        }

        private void ClearThinLine(float x1, float y1, float x2, float y2)
        {
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.SystemColors.Window);
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            formGraphics.DrawLine(myPen, x1, y1, x2, y2);
            myPen.Dispose();
            formGraphics.Dispose();
        }

        private void ClearThickLine(float x1, float y1, float x2, float y2)
        {
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(System.Drawing.SystemColors.Window, 5);
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            formGraphics.DrawLine(myPen, x1, y1, x2, y2);
            myPen.Dispose();
            formGraphics.Dispose();

            DrawThinLine(x1, y1, x2, y2);
        }



        private void RepaintScreen()
        {

            if (chk01.BackColor == LED_ON)
            {
                if (chk02.BackColor == LED_ON)
                    DrawThickLine(chk01.Location.X, chk01.Location.Y, chk02.Location.X, chk02.Location.Y);

                if (chk10.BackColor == LED_ON)
                    DrawThickLine(chk01.Location.X, chk01.Location.Y, chk10.Location.X, chk10.Location.Y);

                if (chk04.BackColor == LED_ON)
                    DrawThickLine(chk01.Location.X, chk01.Location.Y, chk04.Location.X, chk04.Location.Y);

            }
            else
            {
                ClearThickLine(chk01.Location.X, chk01.Location.Y, chk10.Location.X, chk10.Location.Y);
                ClearThickLine(chk01.Location.X, chk01.Location.Y, chk04.Location.X, chk04.Location.Y);
                ClearThickLine(chk01.Location.X, chk01.Location.Y, chk02.Location.X, chk02.Location.Y);
            }



            if (chk02.BackColor == LED_ON)
            {
                if (chk01.BackColor == LED_ON)
                    DrawThickLine(chk02.Location.X, chk02.Location.Y, chk01.Location.X, chk01.Location.Y);

                if (chk03.BackColor == LED_ON)
                    DrawThickLine(chk02.Location.X, chk02.Location.Y, chk03.Location.X, chk03.Location.Y);

                if (chk05.BackColor == LED_ON)
                    DrawThickLine(chk02.Location.X, chk02.Location.Y, chk05.Location.X, chk05.Location.Y);

            }
            else
            {
                ClearThickLine(chk02.Location.X, chk02.Location.Y, chk01.Location.X, chk01.Location.Y);
                ClearThickLine(chk02.Location.X, chk02.Location.Y, chk03.Location.X, chk03.Location.Y);
                ClearThickLine(chk02.Location.X, chk02.Location.Y, chk05.Location.X, chk05.Location.Y);
            }




            if (chk03.BackColor == LED_ON)
            {
                if (chk02.BackColor == LED_ON)
                    DrawThickLine(chk03.Location.X, chk03.Location.Y, chk02.Location.X, chk02.Location.Y);

                if (chk06.BackColor == LED_ON)
                    DrawThickLine(chk03.Location.X, chk03.Location.Y, chk06.Location.X, chk06.Location.Y);

                if (chk12.BackColor == LED_ON)
                    DrawThickLine(chk03.Location.X, chk03.Location.Y, chk12.Location.X, chk12.Location.Y);

            }
            else
            {
                ClearThickLine(chk03.Location.X, chk03.Location.Y, chk02.Location.X, chk02.Location.Y);
                ClearThickLine(chk03.Location.X, chk03.Location.Y, chk06.Location.X, chk06.Location.Y);
                ClearThickLine(chk03.Location.X, chk03.Location.Y, chk12.Location.X, chk12.Location.Y);
            }



            if (chk04.BackColor == LED_ON)
            {
                if (chk01.BackColor == LED_ON)
                    DrawThickLine(chk04.Location.X, chk04.Location.Y, chk01.Location.X, chk01.Location.Y);

                if (chk05.BackColor == LED_ON)
                    DrawThickLine(chk04.Location.X, chk04.Location.Y, chk05.Location.X, chk05.Location.Y);

                if (chk07.BackColor == LED_ON)
                    DrawThickLine(chk04.Location.X, chk04.Location.Y, chk07.Location.X, chk07.Location.Y);

                if (chk13.BackColor == LED_ON)
                    DrawThickLine(chk04.Location.X, chk04.Location.Y, chk13.Location.X, chk13.Location.Y);
            }
            else
            {
                ClearThickLine(chk04.Location.X, chk04.Location.Y, chk13.Location.X, chk13.Location.Y);
                ClearThickLine(chk04.Location.X, chk04.Location.Y, chk01.Location.X, chk01.Location.Y);
                ClearThickLine(chk04.Location.X, chk04.Location.Y, chk05.Location.X, chk05.Location.Y);
                ClearThickLine(chk04.Location.X, chk04.Location.Y, chk07.Location.X, chk07.Location.Y);
            }


            if (chk05.BackColor == LED_ON)
            {
                if (chk02.BackColor == LED_ON)
                    DrawThickLine(chk05.Location.X, chk05.Location.Y, chk02.Location.X, chk02.Location.Y);

                if (chk04.BackColor == LED_ON)
                    DrawThickLine(chk05.Location.X, chk05.Location.Y, chk04.Location.X, chk04.Location.Y);

                if (chk06.BackColor == LED_ON)
                    DrawThickLine(chk05.Location.X, chk05.Location.Y, chk06.Location.X, chk06.Location.Y);

                if (chk08.BackColor == LED_ON)
                    DrawThickLine(chk05.Location.X, chk05.Location.Y, chk08.Location.X, chk08.Location.Y);                
            }
            else
            {
                ClearThickLine(chk05.Location.X, chk05.Location.Y, chk02.Location.X, chk02.Location.Y);
                ClearThickLine(chk05.Location.X, chk05.Location.Y, chk04.Location.X, chk04.Location.Y);
                ClearThickLine(chk05.Location.X, chk05.Location.Y, chk06.Location.X, chk06.Location.Y);
                ClearThickLine(chk05.Location.X, chk05.Location.Y, chk08.Location.X, chk08.Location.Y);
            }


            if (chk06.BackColor == LED_ON)
            {
                if (chk03.BackColor == LED_ON)
                    DrawThickLine(chk06.Location.X, chk06.Location.Y, chk03.Location.X, chk03.Location.Y);

                if (chk05.BackColor == LED_ON)
                    DrawThickLine(chk06.Location.X, chk06.Location.Y, chk05.Location.X, chk05.Location.Y);

                if (chk09.BackColor == LED_ON)
                    DrawThickLine(chk06.Location.X, chk06.Location.Y, chk09.Location.X, chk09.Location.Y);

                if (chk15.BackColor == LED_ON)
                    DrawThickLine(chk06.Location.X, chk06.Location.Y, chk15.Location.X, chk15.Location.Y);
            }
            else
            {
                ClearThickLine(chk06.Location.X, chk06.Location.Y, chk03.Location.X, chk03.Location.Y);
                ClearThickLine(chk06.Location.X, chk06.Location.Y, chk09.Location.X, chk09.Location.Y);
                ClearThickLine(chk06.Location.X, chk06.Location.Y, chk15.Location.X, chk15.Location.Y);
                ClearThickLine(chk06.Location.X, chk06.Location.Y, chk05.Location.X, chk05.Location.Y);
            }


            if (chk07.BackColor == LED_ON)
            {
                if (chk04.BackColor == LED_ON)
                    DrawThickLine(chk07.Location.X, chk07.Location.Y, chk04.Location.X, chk04.Location.Y);

                if (chk08.BackColor == LED_ON)
                    DrawThickLine(chk07.Location.X, chk07.Location.Y, chk08.Location.X, chk08.Location.Y);

                if (chk16.BackColor == LED_ON)
                    DrawThickLine(chk07.Location.X, chk07.Location.Y, chk16.Location.X, chk16.Location.Y);
            }
            else
            {
                ClearThickLine(chk07.Location.X, chk07.Location.Y, chk04.Location.X, chk04.Location.Y);
                ClearThickLine(chk07.Location.X, chk07.Location.Y, chk08.Location.X, chk08.Location.Y);
                ClearThickLine(chk07.Location.X, chk07.Location.Y, chk16.Location.X, chk16.Location.Y);
            }


            if (chk08.BackColor == LED_ON)
            {
                if (chk05.BackColor == LED_ON)
                    DrawThickLine(chk08.Location.X, chk08.Location.Y, chk05.Location.X, chk05.Location.Y);

                if (chk07.BackColor == LED_ON)
                    DrawThickLine(chk08.Location.X, chk08.Location.Y, chk07.Location.X, chk07.Location.Y);

                if (chk09.BackColor == LED_ON)
                    DrawThickLine(chk08.Location.X, chk08.Location.Y, chk09.Location.X, chk09.Location.Y);

                if (chk17.BackColor == LED_ON)
                    DrawThickLine(chk08.Location.X, chk08.Location.Y, chk17.Location.X, chk17.Location.Y);
            }
            else
            {
                ClearThickLine(chk08.Location.X, chk08.Location.Y, chk05.Location.X, chk05.Location.Y); 
                ClearThickLine(chk08.Location.X, chk08.Location.Y, chk07.Location.X, chk07.Location.Y);
                ClearThickLine(chk08.Location.X, chk08.Location.Y, chk09.Location.X, chk09.Location.Y);
                ClearThickLine(chk08.Location.X, chk08.Location.Y, chk17.Location.X, chk17.Location.Y);
            }



            if (chk09.BackColor == LED_ON)
            {
                if (chk06.BackColor == LED_ON)
                    DrawThickLine(chk09.Location.X, chk09.Location.Y, chk06.Location.X, chk06.Location.Y);

                if (chk08.BackColor == LED_ON)
                    DrawThickLine(chk09.Location.X, chk09.Location.Y, chk08.Location.X, chk08.Location.Y);

                if (chk18.BackColor == LED_ON)
                    DrawThickLine(chk09.Location.X, chk09.Location.Y, chk18.Location.X, chk18.Location.Y);
            }
            else
            {
                ClearThickLine(chk09.Location.X, chk09.Location.Y, chk06.Location.X, chk06.Location.Y);
                ClearThickLine(chk09.Location.X, chk09.Location.Y, chk08.Location.X, chk08.Location.Y);
                ClearThickLine(chk09.Location.X, chk09.Location.Y, chk18.Location.X, chk18.Location.Y);
            }



            if (chk10.BackColor == LED_ON)
            {
                if (chk01.BackColor == LED_ON)
                    DrawThickLine(chk10.Location.X, chk10.Location.Y, chk01.Location.X, chk01.Location.Y);

                if (chk11.BackColor == LED_ON)
                    DrawThickLine(chk10.Location.X, chk10.Location.Y, chk11.Location.X, chk11.Location.Y);

                if (chk19.BackColor == LED_ON)
                    DrawThickLine(chk10.Location.X, chk10.Location.Y, chk19.Location.X, chk19.Location.Y);
            }
            else
            {
                ClearThickLine(chk10.Location.X, chk10.Location.Y, chk01.Location.X, chk01.Location.Y);
                ClearThickLine(chk10.Location.X, chk10.Location.Y, chk11.Location.X, chk11.Location.Y);
                ClearThickLine(chk10.Location.X, chk10.Location.Y, chk19.Location.X, chk19.Location.Y);
            }



            if (chk11.BackColor == LED_ON)
            {
                if (chk02.BackColor == LED_ON)
                    DrawThickLine(chk11.Location.X, chk11.Location.Y, chk02.Location.X, chk02.Location.Y);

                if (chk10.BackColor == LED_ON)
                    DrawThickLine(chk11.Location.X, chk11.Location.Y, chk10.Location.X, chk10.Location.Y);

                if (chk12.BackColor == LED_ON)
                    DrawThickLine(chk11.Location.X, chk11.Location.Y, chk12.Location.X, chk12.Location.Y);

                if (chk20.BackColor == LED_ON)
                    DrawThickLine(chk11.Location.X, chk11.Location.Y, chk20.Location.X, chk20.Location.Y);
            }
            else
            {
                ClearThickLine(chk11.Location.X, chk11.Location.Y, chk02.Location.X, chk02.Location.Y);
                ClearThickLine(chk11.Location.X, chk11.Location.Y, chk10.Location.X, chk10.Location.Y);
                ClearThickLine(chk11.Location.X, chk11.Location.Y, chk12.Location.X, chk12.Location.Y);
                ClearThickLine(chk11.Location.X, chk11.Location.Y, chk20.Location.X, chk20.Location.Y);
            }



            if (chk12.BackColor == LED_ON)
            {
                if (chk03.BackColor == LED_ON)
                    DrawThickLine(chk12.Location.X, chk12.Location.Y, chk03.Location.X, chk03.Location.Y);

                if (chk11.BackColor == LED_ON)
                    DrawThickLine(chk12.Location.X, chk12.Location.Y, chk11.Location.X, chk11.Location.Y);

                if (chk15.BackColor == LED_ON)
                    DrawThickLine(chk12.Location.X, chk12.Location.Y, chk15.Location.X, chk15.Location.Y);

                if (chk21.BackColor == LED_ON)
                    DrawThickLine(chk12.Location.X, chk12.Location.Y, chk21.Location.X, chk21.Location.Y);
            }
            else
            {
                ClearThickLine(chk12.Location.X, chk12.Location.Y, chk03.Location.X, chk03.Location.Y);
                ClearThickLine(chk12.Location.X, chk12.Location.Y, chk11.Location.X, chk11.Location.Y);
                ClearThickLine(chk12.Location.X, chk12.Location.Y, chk15.Location.X, chk15.Location.Y);
                ClearThickLine(chk12.Location.X, chk12.Location.Y, chk21.Location.X, chk21.Location.Y);
            }



            if (chk13.BackColor == LED_ON)
            {
                if (chk04.BackColor == LED_ON)
                    DrawThickLine(chk13.Location.X, chk13.Location.Y, chk04.Location.X, chk04.Location.Y);

                if (chk10.BackColor == LED_ON)
                    DrawThickLine(chk13.Location.X, chk13.Location.Y, chk10.Location.X, chk10.Location.Y);

                if (chk16.BackColor == LED_ON)
                    DrawThickLine(chk13.Location.X, chk13.Location.Y, chk16.Location.X, chk16.Location.Y);

                if (chk22.BackColor == LED_ON)
                    DrawThickLine(chk13.Location.X, chk13.Location.Y, chk22.Location.X, chk22.Location.Y);
            }
            else
            {
                ClearThickLine(chk13.Location.X, chk13.Location.Y, chk04.Location.X, chk04.Location.Y);
                ClearThickLine(chk13.Location.X, chk13.Location.Y, chk10.Location.X, chk10.Location.Y);
                ClearThickLine(chk13.Location.X, chk13.Location.Y, chk16.Location.X, chk16.Location.Y);
                ClearThickLine(chk13.Location.X, chk13.Location.Y, chk22.Location.X, chk22.Location.Y);
            }




            if (chk14.BackColor == LED_ON)
            {
                if (chk05.BackColor == LED_ON)
                    DrawThickLine(chk14.Location.X, chk14.Location.Y, chk05.Location.X, chk05.Location.Y);

                if (chk11.BackColor == LED_ON)
                    DrawThickLine(chk14.Location.X, chk14.Location.Y, chk11.Location.X, chk11.Location.Y);

                if (chk13.BackColor == LED_ON)
                    DrawThickLine(chk14.Location.X, chk14.Location.Y, chk13.Location.X, chk13.Location.Y);

                if (chk15.BackColor == LED_ON)
                    DrawThickLine(chk14.Location.X, chk14.Location.Y, chk15.Location.X, chk15.Location.Y);

                if (chk17.BackColor == LED_ON)
                    DrawThickLine(chk14.Location.X, chk14.Location.Y, chk17.Location.X, chk17.Location.Y);

                if (chk23.BackColor == LED_ON)
                    DrawThickLine(chk14.Location.X, chk14.Location.Y, chk23.Location.X, chk23.Location.Y);
            }
            else
            {
                ClearThickLine(chk14.Location.X, chk14.Location.Y, chk05.Location.X, chk05.Location.Y);
                ClearThickLine(chk14.Location.X, chk14.Location.Y, chk11.Location.X, chk11.Location.Y);
                ClearThickLine(chk14.Location.X, chk14.Location.Y, chk13.Location.X, chk13.Location.Y);
                ClearThickLine(chk14.Location.X, chk14.Location.Y, chk15.Location.X, chk15.Location.Y);
                ClearThickLine(chk14.Location.X, chk14.Location.Y, chk17.Location.X, chk17.Location.Y);
                ClearThickLine(chk14.Location.X, chk14.Location.Y, chk23.Location.X, chk23.Location.Y);
            }



            if (chk15.BackColor == LED_ON)
            {
                if (chk06.BackColor == LED_ON)
                    DrawThickLine(chk15.Location.X, chk15.Location.Y, chk06.Location.X, chk06.Location.Y);

                if (chk12.BackColor == LED_ON)
                    DrawThickLine(chk15.Location.X, chk15.Location.Y, chk12.Location.X, chk12.Location.Y);

                if (chk18.BackColor == LED_ON)
                    DrawThickLine(chk15.Location.X, chk15.Location.Y, chk18.Location.X, chk18.Location.Y);

                if (chk24.BackColor == LED_ON)
                    DrawThickLine(chk15.Location.X, chk15.Location.Y, chk24.Location.X, chk24.Location.Y);
            }
            else
            {
                ClearThickLine(chk15.Location.X, chk15.Location.Y, chk06.Location.X, chk06.Location.Y);
                ClearThickLine(chk15.Location.X, chk15.Location.Y, chk12.Location.X, chk12.Location.Y);
                ClearThickLine(chk15.Location.X, chk15.Location.Y, chk18.Location.X, chk18.Location.Y);
                ClearThickLine(chk15.Location.X, chk15.Location.Y, chk24.Location.X, chk24.Location.Y);
            }



            if (chk16.BackColor == LED_ON)
            {
                if (chk07.BackColor == LED_ON)
                    DrawThickLine(chk16.Location.X, chk16.Location.Y, chk07.Location.X, chk07.Location.Y);

                if (chk13.BackColor == LED_ON)
                    DrawThickLine(chk16.Location.X, chk16.Location.Y, chk13.Location.X, chk13.Location.Y);

                if (chk17.BackColor == LED_ON)
                    DrawThickLine(chk16.Location.X, chk16.Location.Y, chk17.Location.X, chk17.Location.Y);

                if (chk25.BackColor == LED_ON)
                    DrawThickLine(chk16.Location.X, chk16.Location.Y, chk25.Location.X, chk25.Location.Y);
            }
            else
            {
                ClearThickLine(chk16.Location.X, chk16.Location.Y, chk07.Location.X, chk07.Location.Y);
                ClearThickLine(chk16.Location.X, chk16.Location.Y, chk13.Location.X, chk13.Location.Y);
                ClearThickLine(chk16.Location.X, chk16.Location.Y, chk17.Location.X, chk17.Location.Y);
                ClearThickLine(chk16.Location.X, chk16.Location.Y, chk25.Location.X, chk25.Location.Y);
            }



            if (chk17.BackColor == LED_ON)
            {
                if (chk08.BackColor == LED_ON)
                    DrawThickLine(chk17.Location.X, chk17.Location.Y, chk08.Location.X, chk08.Location.Y);

                if (chk14.BackColor == LED_ON)
                    DrawThickLine(chk17.Location.X, chk17.Location.Y, chk14.Location.X, chk14.Location.Y);

                if (chk16.BackColor == LED_ON)
                    DrawThickLine(chk17.Location.X, chk17.Location.Y, chk16.Location.X, chk16.Location.Y);

                if (chk18.BackColor == LED_ON)
                    DrawThickLine(chk17.Location.X, chk17.Location.Y, chk18.Location.X, chk18.Location.Y);

                if (chk26.BackColor == LED_ON)
                    DrawThickLine(chk17.Location.X, chk17.Location.Y, chk26.Location.X, chk26.Location.Y);
            }
            else
            {
                ClearThickLine(chk17.Location.X, chk17.Location.Y, chk08.Location.X, chk08.Location.Y);
                ClearThickLine(chk17.Location.X, chk17.Location.Y, chk14.Location.X, chk14.Location.Y);
                ClearThickLine(chk17.Location.X, chk17.Location.Y, chk16.Location.X, chk16.Location.Y);
                ClearThickLine(chk17.Location.X, chk17.Location.Y, chk18.Location.X, chk18.Location.Y);
                ClearThickLine(chk17.Location.X, chk17.Location.Y, chk26.Location.X, chk26.Location.Y);
            }



            if (chk18.BackColor == LED_ON)
            {
                if (chk09.BackColor == LED_ON)
                    DrawThickLine(chk18.Location.X, chk18.Location.Y, chk09.Location.X, chk09.Location.Y);

                if (chk15.BackColor == LED_ON)
                    DrawThickLine(chk18.Location.X, chk18.Location.Y, chk15.Location.X, chk15.Location.Y);

                if (chk17.BackColor == LED_ON)
                    DrawThickLine(chk18.Location.X, chk18.Location.Y, chk17.Location.X, chk17.Location.Y);

                if (chk27.BackColor == LED_ON)
                    DrawThickLine(chk18.Location.X, chk18.Location.Y, chk27.Location.X, chk27.Location.Y);
            }
            else
            {
                ClearThickLine(chk18.Location.X, chk18.Location.Y, chk09.Location.X, chk09.Location.Y);
                ClearThickLine(chk18.Location.X, chk18.Location.Y, chk15.Location.X, chk15.Location.Y);
                ClearThickLine(chk18.Location.X, chk18.Location.Y, chk17.Location.X, chk17.Location.Y);
                ClearThickLine(chk18.Location.X, chk18.Location.Y, chk27.Location.X, chk27.Location.Y);
            }



            if (chk19.BackColor == LED_ON)
            {
                if (chk10.BackColor == LED_ON)
                    DrawThickLine(chk19.Location.X, chk19.Location.Y, chk10.Location.X, chk10.Location.Y);

                if (chk20.BackColor == LED_ON)
                    DrawThickLine(chk19.Location.X, chk19.Location.Y, chk20.Location.X, chk20.Location.Y);

                if (chk22.BackColor == LED_ON)
                    DrawThickLine(chk19.Location.X, chk19.Location.Y, chk22.Location.X, chk22.Location.Y);

            }
            else
            {
                ClearThickLine(chk19.Location.X, chk19.Location.Y, chk10.Location.X, chk10.Location.Y);
                ClearThickLine(chk19.Location.X, chk19.Location.Y, chk20.Location.X, chk20.Location.Y);
                ClearThickLine(chk19.Location.X, chk19.Location.Y, chk22.Location.X, chk22.Location.Y);
            }



            if (chk20.BackColor == LED_ON)
            {
                if (chk11.BackColor == LED_ON)
                    DrawThickLine(chk20.Location.X, chk20.Location.Y, chk11.Location.X, chk11.Location.Y);

                if (chk19.BackColor == LED_ON)
                    DrawThickLine(chk20.Location.X, chk20.Location.Y, chk19.Location.X, chk19.Location.Y);

                if (chk21.BackColor == LED_ON)
                    DrawThickLine(chk20.Location.X, chk20.Location.Y, chk21.Location.X, chk21.Location.Y);

                if (chk23.BackColor == LED_ON)
                    DrawThickLine(chk20.Location.X, chk20.Location.Y, chk23.Location.X, chk23.Location.Y);

            }
            else
            {
                ClearThickLine(chk20.Location.X, chk20.Location.Y, chk11.Location.X, chk11.Location.Y);
                ClearThickLine(chk20.Location.X, chk20.Location.Y, chk19.Location.X, chk19.Location.Y);
                ClearThickLine(chk20.Location.X, chk20.Location.Y, chk21.Location.X, chk21.Location.Y);
                ClearThickLine(chk20.Location.X, chk20.Location.Y, chk23.Location.X, chk23.Location.Y);
            }



            if (chk21.BackColor == LED_ON)
            {
                if (chk12.BackColor == LED_ON)
                    DrawThickLine(chk21.Location.X, chk21.Location.Y, chk12.Location.X, chk12.Location.Y);

                if (chk20.BackColor == LED_ON)
                    DrawThickLine(chk21.Location.X, chk21.Location.Y, chk20.Location.X, chk20.Location.Y);

                if (chk24.BackColor == LED_ON)
                    DrawThickLine(chk21.Location.X, chk21.Location.Y, chk24.Location.X, chk24.Location.Y);

                
            }
            else
            {
                ClearThickLine(chk21.Location.X, chk21.Location.Y, chk12.Location.X, chk12.Location.Y);
                ClearThickLine(chk21.Location.X, chk21.Location.Y, chk20.Location.X, chk20.Location.Y);
                ClearThickLine(chk21.Location.X, chk21.Location.Y, chk24.Location.X, chk24.Location.Y);                
            }



            if (chk22.BackColor == LED_ON)
            {
                if (chk13.BackColor == LED_ON)
                    DrawThickLine(chk22.Location.X, chk22.Location.Y, chk13.Location.X, chk13.Location.Y);

                if (chk19.BackColor == LED_ON)
                    DrawThickLine(chk22.Location.X, chk22.Location.Y, chk19.Location.X, chk19.Location.Y);

                if (chk23.BackColor == LED_ON)
                    DrawThickLine(chk22.Location.X, chk22.Location.Y, chk23.Location.X, chk23.Location.Y);

                if (chk25.BackColor == LED_ON)
                    DrawThickLine(chk22.Location.X, chk22.Location.Y, chk25.Location.X, chk25.Location.Y);

            }
            else
            {
                ClearThickLine(chk22.Location.X, chk22.Location.Y, chk13.Location.X, chk13.Location.Y);
                ClearThickLine(chk22.Location.X, chk22.Location.Y, chk19.Location.X, chk19.Location.Y);
                ClearThickLine(chk22.Location.X, chk22.Location.Y, chk23.Location.X, chk23.Location.Y); 
                ClearThickLine(chk22.Location.X, chk22.Location.Y, chk25.Location.X, chk25.Location.Y);
            }



            if (chk23.BackColor == LED_ON)
            {
                if (chk14.BackColor == LED_ON)
                    DrawThickLine(chk23.Location.X, chk23.Location.Y, chk14.Location.X, chk14.Location.Y);

                if (chk20.BackColor == LED_ON)
                    DrawThickLine(chk23.Location.X, chk23.Location.Y, chk20.Location.X, chk20.Location.Y);

                if (chk22.BackColor == LED_ON)
                    DrawThickLine(chk23.Location.X, chk23.Location.Y, chk22.Location.X, chk22.Location.Y);

                if (chk24.BackColor == LED_ON)
                    DrawThickLine(chk23.Location.X, chk23.Location.Y, chk24.Location.X, chk24.Location.Y);

                if (chk26.BackColor == LED_ON)
                    DrawThickLine(chk23.Location.X, chk23.Location.Y, chk26.Location.X, chk26.Location.Y);

            }
            else
            {
                ClearThickLine(chk23.Location.X, chk23.Location.Y, chk14.Location.X, chk14.Location.Y);
                ClearThickLine(chk23.Location.X, chk23.Location.Y, chk20.Location.X, chk20.Location.Y);
                ClearThickLine(chk23.Location.X, chk23.Location.Y, chk22.Location.X, chk22.Location.Y);
                ClearThickLine(chk23.Location.X, chk23.Location.Y, chk24.Location.X, chk24.Location.Y);
                ClearThickLine(chk23.Location.X, chk23.Location.Y, chk26.Location.X, chk26.Location.Y);
            }



            if (chk24.BackColor == LED_ON)
            {
                if (chk15.BackColor == LED_ON)
                    DrawThickLine(chk24.Location.X, chk24.Location.Y, chk15.Location.X, chk15.Location.Y);

                if (chk21.BackColor == LED_ON)
                    DrawThickLine(chk24.Location.X, chk24.Location.Y, chk21.Location.X, chk21.Location.Y);

                if (chk23.BackColor == LED_ON)
                    DrawThickLine(chk24.Location.X, chk24.Location.Y, chk23.Location.X, chk23.Location.Y);

                if (chk27.BackColor == LED_ON)
                    DrawThickLine(chk24.Location.X, chk24.Location.Y, chk27.Location.X, chk27.Location.Y);

            }
            else
            {
                ClearThickLine(chk24.Location.X, chk24.Location.Y, chk15.Location.X, chk15.Location.Y);
                ClearThickLine(chk24.Location.X, chk24.Location.Y, chk21.Location.X, chk21.Location.Y);
                ClearThickLine(chk24.Location.X, chk24.Location.Y, chk23.Location.X, chk23.Location.Y);
                ClearThickLine(chk24.Location.X, chk24.Location.Y, chk27.Location.X, chk27.Location.Y);
            }



            if (chk25.BackColor == LED_ON)
            {
                if (chk16.BackColor == LED_ON)
                    DrawThickLine(chk25.Location.X, chk25.Location.Y, chk16.Location.X, chk16.Location.Y);

                if (chk22.BackColor == LED_ON)
                    DrawThickLine(chk25.Location.X, chk25.Location.Y, chk22.Location.X, chk22.Location.Y);

                if (chk26.BackColor == LED_ON)
                    DrawThickLine(chk25.Location.X, chk25.Location.Y, chk26.Location.X, chk26.Location.Y);

            }
            else
            {
                ClearThickLine(chk25.Location.X, chk25.Location.Y, chk16.Location.X, chk16.Location.Y);
                ClearThickLine(chk25.Location.X, chk25.Location.Y, chk22.Location.X, chk22.Location.Y);
                ClearThickLine(chk25.Location.X, chk25.Location.Y, chk26.Location.X, chk26.Location.Y);
            }



            if (chk26.BackColor == LED_ON)
            {
                if (chk17.BackColor == LED_ON)
                    DrawThickLine(chk26.Location.X, chk26.Location.Y, chk17.Location.X, chk17.Location.Y);

                if (chk23.BackColor == LED_ON)
                    DrawThickLine(chk26.Location.X, chk26.Location.Y, chk23.Location.X, chk23.Location.Y);

                if (chk25.BackColor == LED_ON)
                    DrawThickLine(chk26.Location.X, chk26.Location.Y, chk25.Location.X, chk25.Location.Y);

                if (chk27.BackColor == LED_ON)
                    DrawThickLine(chk26.Location.X, chk26.Location.Y, chk27.Location.X, chk27.Location.Y);

            }
            else
            {
                ClearThickLine(chk26.Location.X, chk26.Location.Y, chk17.Location.X, chk17.Location.Y);
                ClearThickLine(chk26.Location.X, chk26.Location.Y, chk23.Location.X, chk23.Location.Y);
                ClearThickLine(chk26.Location.X, chk26.Location.Y, chk25.Location.X, chk25.Location.Y);
                ClearThickLine(chk26.Location.X, chk26.Location.Y, chk27.Location.X, chk27.Location.Y);
            }


            if (chk27.BackColor == LED_ON)
            {
                if (chk18.BackColor == LED_ON)
                    DrawThickLine(chk27.Location.X, chk27.Location.Y, chk18.Location.X, chk18.Location.Y);

                if (chk24.BackColor == LED_ON)
                    DrawThickLine(chk27.Location.X, chk27.Location.Y, chk24.Location.X, chk24.Location.Y);

                if (chk26.BackColor == LED_ON)
                    DrawThickLine(chk27.Location.X, chk27.Location.Y, chk26.Location.X, chk26.Location.Y);

            }
            else
            {
                ClearThickLine(chk27.Location.X, chk27.Location.Y, chk18.Location.X, chk18.Location.Y);
                ClearThickLine(chk27.Location.X, chk27.Location.Y, chk24.Location.X, chk24.Location.Y);
                ClearThickLine(chk27.Location.X, chk27.Location.Y, chk26.Location.X, chk26.Location.Y);
                
            }
        }



        #endregion




        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (((LEDNode)sender).BackColor == LED_OFF)
            {
                ((LEDNode)sender).BackColor = LED_ON;
                SetLEDStatus(System.Convert.ToInt32(((LEDNode)sender).Name.Replace("chk", "")) - 1, true);
            }
            else if (((LEDNode)sender).BackColor == LED_ON)
            {
                ((LEDNode)sender).BackColor = LED_OFF;
                SetLEDStatus(System.Convert.ToInt32(((LEDNode)sender).Name.Replace("chk", "")) - 1, false);
            }

            RepaintScreen();
            
            WriteToDatabase(strLEDStatus);
            lblStatus.Text = strLEDStatus + " updated to DB";
        }


        private void WriteToDatabase(string strLEDStatus)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            string strConnString1 = "server=68.178.142.189;UID=ledmatrix;password=M@trix01;database=ledmatrix;";
            string strConnString3 = "server=ledmatrix.db.8422518.hostedresource.com ;UID=ledmatrix;password=M@trix01;database=ledmatrix;";
            string strConnString2 = "server=p3nlhdb5039-17.shr.prod.phx3.secureserver.net;UID=ledmatrix;password=M@trix01;database=ledmatrix;";
            string strConnString = "server=sql3.freemysqlhosting.net;UID=sql314986;password=gP4*cG1%;database=sql314986;";
            
            
            string strSQLStr = "INSERT INTO led_indicators(status_string) VALUES ('ledstatus/" + strLEDStatus + "/*')";

            try
            {
                cn = new MySqlConnection(strConnString);
                cn.Open();
                cmd = new MySqlCommand(strSQLStr, cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                cmd.Dispose();
                cn.Dispose();
            }



        }

        

        






        
        










        




    }

    public class LEDNode : Button
    {
        private System.ComponentModel.Container components = null;
        private Pen _pen = null;
        SolidBrush _brushInside = null;
        private byte _colorStepGradient = 2;

        public LEDNode()
        {
            InitializeComponent();            
            _pen = new Pen(BackColor);
            _brushInside = new SolidBrush(BackColor);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                    components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.BackColorChanged += new System.EventHandler(this.RoundButton_BackColorChanged);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            Graphics g = pe.Graphics;
            ColorButton(g, _pen, _brushInside);

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(path);
        }

        void ColorButton(Graphics g, Pen pen, SolidBrush brush)
        {
            int x = 0, y = 0;
            int width = ClientSize.Width, height = ClientSize.Height;

            for (; x <= width / 2 && y <= height / 2; x += _colorStepGradient, y += _colorStepGradient, width -= 2 * _colorStepGradient, height -= 2 * _colorStepGradient)
            {
                g.FillEllipse(brush, x, y, width, height);

                byte newR = pen.Color.R;
                byte newG = pen.Color.G;
                byte newB = pen.Color.B;
                Color newcolor = Color.FromArgb(newR, newG, newB);
                pen.Color = newcolor;
                brush.Color = newcolor;
            }
        }

        private void RoundButton_BackColorChanged(object sender, System.EventArgs e)
        {
            _pen.Color = BackColor;
            _brushInside.Color = BackColor;
        }

    }

}
