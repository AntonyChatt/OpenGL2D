using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tao.FreeGlut;
using Tao.OpenGl;
using Tao.Platform;

namespace OpenGL2D
{
    public partial class Form1 : Form
    {
        float[,] ShapeA = new float[6, 4];
        float[,] ShapeB = new float[4, 4];
        float angleA = 0, angleB = 0;
        float offsetBx = 0, offsetBy = 0, offsetAx = 0, offsetAy = 0;
        float scaleB = 1, scaleA = 1;

        void initializeShapes()
        {
            for (int i = 0; i < 6; i++)
            {
                ShapeA [i, 0] = 0.25f * (float)Math.Cos(Math.PI / 2 + 2 * Math.PI * i / 6);
                ShapeA [i, 1] = 0.25f * (float)Math.Sin(Math.PI / 2 + 2 * Math.PI * i / 6);
                ShapeA [i, 2] = 0;
                ShapeA [i, 3] = 1;
            }
            for (int i = 0; i < 4; i++)
            {
                ShapeB [i, 0] = 0.25f * (float)Math.Cos(Math.PI / 4 + 2 * Math.PI * i / 4);
                ShapeB [i, 1] = 0.25f * (float)Math.Sin(Math.PI / 4 + 2 * Math.PI * i / 4);
                ShapeB [i, 2] = 0;
                ShapeB [i, 3] = 1;
            }
        }

        public Form1()
        {
            InitializeComponent();
            holst.InitializeContexts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Holst_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Line_Click(object sender, EventArgs e)
        {
            float x0 = ClientSize.Width / 2;
            float y0 = ClientSize.Height / 2;

            drawAxises(x0, y0);

            Gl.glViewport(0, 0, holst.Width, holst.Height);
            Gl.glColor3f(0.392f, 0.584f, 0.929f);
            Gl.glLineWidth(2);

            Gl.glBegin(Gl.GL_LINE_LOOP);
                Gl.glVertex2f(-0.2f , 0);
                Gl.glVertex2f(-0.6f,-0.4f);
                Gl.glVertex2f(-0.4f,0.8f);
                Gl.glVertex2f(0.4f,0.4f);
                Gl.glVertex2f(-0.2f,-0.4f);
            Gl.glEnd();

            holst.Invalidate();
        }

        private void Fill_Click(object sender, EventArgs e)
        {
            float x0 = ClientSize.Width / 2;
            float y0 = ClientSize.Height / 2;

            drawAxises(x0, y0);

            Gl.glViewport(0, 0, holst.Width, holst.Height);

            Gl.glBegin(Gl.GL_POLYGON);
                Gl.glColor3f(0.274f, 0.509f, 0.705f);
                Gl.glVertex2f(-0.2f, 0);
                Gl.glColor3f(0.415f, 0.352f, 0.804f);
                Gl.glVertex2f(-0.6f, -0.4f);
                Gl.glColor3f(0.866f, 0.627f, 0.866f);
                Gl.glVertex2f(-0.4f, 0.8f);
                Gl.glColor3f(0.392f, 0.584f, 0.929f);
                Gl.glVertex2f(0.4f, 0.4f);
                Gl.glColor3f(0.254f, 0.411f, 0.882f);
                Gl.glVertex2f(-0.2f, -0.4f);
            Gl.glEnd();

            holst.Invalidate();
        }

        void drawAxises (float x0, float y0)
        {
            Gl.glViewport(0, 0, holst.Width, holst.Height);

            Gl.glLineWidth(3);
            Gl.glColor3f(0.415f, 0.352f, 0.804f);

            Gl.glBegin(Gl.GL_LINES);                
                Gl.glVertex2f(1, 0);
                Gl.glVertex2f(-1,0);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_LINES);
                Gl.glVertex2f(0, 1);
                Gl.glVertex2f(0, -1);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_TRIANGLES);
            Gl.glVertex2f(0, 1);
            Gl.glVertex2f(0.02f, 0.95f);
            Gl.glVertex2f(-0.02f, 0.95f);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_TRIANGLES);
            Gl.glVertex2f(1, 0);
            Gl.glVertex2f(0.95f, 0.02f);
            Gl.glVertex2f(0.95f, -0.02f);
            Gl.glEnd();

            labelX.ForeColor = Color.SlateBlue;
            labelY.ForeColor = Color.SlateBlue;
            labelZero.ForeColor = Color.SlateBlue;

            labelX.Font = new Font(this.Font, FontStyle.Bold);
            labelY.Font = new Font(this.Font, FontStyle.Bold);
            labelZero.Font = new Font(this.Font, FontStyle.Bold);

            labelX.Location = new Point((int)(2*x0 - 15), (int)(y0 + 35));
            labelY.Location = new Point((int)(x0 +15), 35);
            labelZero.Location = new Point((int)(x0 + 35), (int)(y0+35));

            labelX.Visible = true;
            labelY.Visible = true;
            labelZero.Visible = true;
        }

        void DrawA()
        {
            Gl.glViewport(0, 0, holst.Width, holst.Height);

            Gl.glLineWidth(3);
            
                Gl.glBegin(Gl.GL_LINE_LOOP);
                    Gl.glColor3f(0.274f, 0.509f, 0.705f);
                    Gl.glVertex2f(ShapeA[0,0], ShapeA[0,1]);
                    Gl.glColor3f(0.415f, 0.352f, 0.804f);
                    Gl.glVertex2f(ShapeA[1,0], ShapeA[1,1]);
                    Gl.glColor3f(0.866f, 0.627f, 0.866f);
                    Gl.glVertex2f(ShapeA[2,0], ShapeA[2,1]);
                    Gl.glColor3f(0.392f, 0.584f, 0.929f);
                    Gl.glVertex2f(ShapeA[3,0], ShapeA[3,1]);
                    Gl.glColor3f(0.254f, 0.411f, 0.882f);
                    Gl.glVertex2f(ShapeA[4,0], ShapeA[4,1]);
                    Gl.glColor3f(0.125f, 0.698f, 0.666f);
                    Gl.glVertex2f(ShapeA[5,0], ShapeA[5,1]);
                Gl.glEnd();

            Gl.glEnable(Gl.GL_LINE_STIPPLE);
            Gl.glLineStipple(2, 43690);
            Gl.glLineWidth(2);

                Gl.glBegin(Gl.GL_LINE_LOOP);
                    Gl.glColor3f(0.274f, 0.509f, 0.705f);
                    Gl.glVertex2f(ShapeA[0, 0], ShapeA[0, 1]);
                    Gl.glColor3f(0.866f, 0.627f, 0.866f);
                    Gl.glVertex2f(ShapeA[2, 0], ShapeA[2, 1]);
                    Gl.glColor3f(0.254f, 0.411f, 0.882f);
                    Gl.glVertex2f(ShapeA[4, 0], ShapeA[4, 1]);
                Gl.glEnd();

                Gl.glBegin(Gl.GL_LINE_LOOP);
                    Gl.glColor3f(0.501f, 0, 0.501f);
                    Gl.glVertex2f((ShapeA[0, 0] + ShapeA[2, 0]) / 2, (ShapeA[0, 1] + ShapeA[2, 1]) / 2);
                    Gl.glColor3f(0.098f, 0.098f, 0.439f);
                    Gl.glVertex2f((ShapeA[2, 0] + ShapeA[4, 0]) / 2, (ShapeA[2, 1] + ShapeA[4, 1]) / 2);
                    Gl.glColor3f(0, 0.392f, 0);
                    Gl.glVertex2f((ShapeA[0, 0] + ShapeA[4, 0]) / 2, (ShapeA[0, 1] + ShapeA[4, 1]) / 2);
                Gl.glEnd();

                Gl.glBegin(Gl.GL_LINES);
                    Gl.glColor3f(0, 0, 0);
                    Gl.glVertex2f((ShapeA[0, 0] + ShapeA[2, 0]) / 2, (ShapeA[0, 1] + ShapeA[2, 1]) / 2);
                    Gl.glColor3f(0.415f, 0.352f, 0.804f);
                    Gl.glVertex2f(ShapeA[1, 0], ShapeA[1, 1]);
                Gl.glEnd();

                Gl.glBegin(Gl.GL_LINES);
                    Gl.glColor3f(0, 0, 0);
                    Gl.glVertex2f((ShapeA[2, 0] + ShapeA[4, 0]) / 2, (ShapeA[2, 1] + ShapeA[4, 1]) / 2);
                    Gl.glColor3f(0.392f, 0.584f, 0.929f);
                    Gl.glVertex2f(ShapeA[3, 0], ShapeA[3, 1]);
                Gl.glEnd();

                Gl.glBegin(Gl.GL_LINES);
                    Gl.glColor3f(0, 0, 0);
                    Gl.glVertex2f((ShapeA[0, 0]+ ShapeA[4, 0]) / 2, (ShapeA[0, 1] + ShapeA[4, 1]) / 2);
                    Gl.glColor3f(0.125f, 0.698f, 0.666f);
                    Gl.glVertex2f(ShapeA[5, 0], ShapeA[5, 1]);
                Gl.glEnd();

            Gl.glDisable(Gl.GL_LINE_STIPPLE);
        }

        void rotateA()
        {
            Gl.glPushMatrix();
            Gl.glRotatef(angleA, 0.0f, 0.0f, -1f);
            Gl.glTranslatef(-0.5f, -0.5f, 0.0f);
            Gl.glTranslatef(offsetAx, offsetAy, 0);
            Gl.glScalef(scaleA, scaleA, 0);
            DrawA();
            Gl.glPopMatrix();
            DrawB();
            holst.Invalidate();
        }

        void singleTransition()
        {
            Gl.glPushMatrix();            
            Gl.glTranslatef(-0.5f, -0.5f, 0.0f);
            Gl.glRotatef(angleA, 0.0f, 0.0f, -1f);
            Gl.glTranslatef(offsetAx, offsetAy, 0);
            Gl.glScalef(scaleA, scaleA, 0);
            DrawA();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(offsetBx, offsetBy, 0);
            Gl.glRotatef(angleB, 0, 0, 1f);
            Gl.glScalef(scaleB, scaleB, 0);
            DrawB();
            Gl.glPopMatrix();

            holst.Invalidate();
        }


        void DrawB()
        {
            Gl.glViewport(0, 0, holst.Width, holst.Height);
            Gl.glLineWidth(3);

            Gl.glBegin(Gl.GL_LINE_LOOP);
            Gl.glColor3f(0.862f, 0.078f, 0.235f);
            Gl.glVertex2f(ShapeB[0, 0], ShapeB[0, 1]);
            Gl.glColor3f(0.804f, 0.360f, 0.360f);
            Gl.glVertex2f(ShapeB[1, 0], ShapeB[1, 1]);
            Gl.glColor3f(0.698f, 0.133f, 0.133f);
            Gl.glVertex2f(ShapeB[2, 0], ShapeB[2, 1]);
            Gl.glColor3f(0.545f, 0, 0);
            Gl.glVertex2f(ShapeB[3, 0], ShapeB[3, 1]);
            Gl.glEnd();

              Gl.glBegin(Gl.GL_LINES);
              Gl.glColor3f(0.603f, 0.803f, 0);
              Gl.glVertex2f(ShapeB[0, 0], ShapeB[0, 1]);
              Gl.glColor3f(0, 0.392f, 0);
              Gl.glVertex2f(ShapeB[2, 0], ShapeB[2, 1]);
              Gl.glEnd();

              Gl.glBegin(Gl.GL_LINES);
              Gl.glColor3f(0.603f, 0.803f, 0);
              Gl.glVertex2f(ShapeB[1, 0], ShapeB[1, 1]);
              Gl.glColor3f(0, 0.392f, 0);
              Gl.glVertex2f(ShapeB[3, 0], ShapeB[3, 1]);
              Gl.glEnd();
        }
        
        private void holst_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Q:
                    Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                    angleA += 5;
                    rotateA();
                    break;
                case Keys.E:
                    Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                    angleA -= 5;
                    rotateA();
                    break;

                case Keys.G:
                    for( int i = 0; i < 60; i++)
                    {
                        angleA += 5;
                        rotateA();
                    }
                    break;
                case Keys.T:
                    for (int i = 0; i < 60; i++)
                    {
                        angleA -= 5;
                        rotateA();
                    }
                    break;


                case Keys.D:
                    Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                    offsetAx += 0.05f;
                    singleTransition();
                    break;
                case Keys.W:
                    Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                    offsetAy += 0.05f;
                    singleTransition();
                    break;
                case Keys.A:
                    Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                    offsetAx -= 0.05f;
                    singleTransition();
                    break;
                case Keys.S:
                    Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                    offsetAy -= 0.05f;
                    singleTransition();
                    break;
                case Keys.R:
                    Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                    angleA += 5;
                    singleTransition();
                    break;
                case Keys.F:
                    Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                    angleA -= 5;
                    singleTransition();
                    break;
                case Keys.Z:
                    Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                    scaleA += 0.5f;
                    singleTransition();
                    break;
                case Keys.X:
                    Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                    scaleA -= 0.5f;
                    singleTransition();
                    break;

                case Keys.L:
                    Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                    offsetBx += 0.05f;
                    singleTransition();
                    break;
                case Keys.I:
                    Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                    offsetBy += 0.05f;
                    singleTransition();
                    break;
                case Keys.J:
                    Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                    offsetBx -= 0.05f;
                    singleTransition();
                    break;
                case Keys.K:
                    Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                    offsetBy -= 0.05f;
                    singleTransition();
                    break;
                case Keys.O:
                    Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                    angleB += 5;
                    singleTransition();
                    break;
                case Keys.P:
                    Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                    angleB -= 5;
                    singleTransition();
                    break;
                case Keys.U:
                    Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                    scaleB += 0.5f;
                    singleTransition();
                    break;
                case Keys.H:
                    Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
                    scaleB -= 0.5f;
                    singleTransition();
                    break;

                default:
                    break;
            }
        }   
        
        void start()
        {
            Refresh();
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            angleA = 0;
            angleB = 0;
            offsetBx = 0;
            offsetBy = 0;
            offsetAx = 0;
            offsetAy = 0;
            scaleB = 1;
            scaleA = 1;

            initializeShapes();

            Gl.glPushMatrix();
            Gl.glRotatef(angleA, 0.0f, 0.0f, -1f);
            Gl.glTranslatef(-0.5f, -0.5f, 0.0f);
            Gl.glTranslatef(offsetAx, offsetAy, 0);
            Gl.glScalef(scaleA, scaleA, 0);
            DrawA();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(offsetBx, offsetBy, 0);
            Gl.glRotatef(angleB, 0, 0, 1f);
            Gl.glScalef(scaleB, scaleB, 0);
            DrawB();
            Gl.glPopMatrix();

            holst.Invalidate();
        }

        private void Holst_Click(object sender, EventArgs e)
        {
            //float x0 = ClientSize.Width / 2;
            //float y0 = ClientSize.Height / 2;
            //drawAxises(x0, y0);

            start();
        }       

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            start();
        }       
        
        private void LabelX_Click(object sender, EventArgs e)
        {
        }
        private void Holst_MouseMove(object sender, MouseEventArgs e)
        {
        }
    }
}
