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
            Gl.glViewport(0, 0, holst.Width, holst.Height);
            Gl.glClearColor(0.0f, 0.0f, 0.250f, 1);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
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
            Gl.glViewport(0, 0, holst.Width, holst.Height);
            Gl.glClearColor(0.0f, 0.0f, 0.250f, 1);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
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
    }
}
