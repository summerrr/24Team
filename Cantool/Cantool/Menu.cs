﻿using dashboard;
using Set_Com;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantool
{
    public partial class Menu : Form
    {
        public List<Message> database = new List<Message>();

        public Menu()
        {
            InitializeComponent();

        }

        private void 文件存储ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hide the last panel and add new panel
            this.panel.Controls.Clear();
            this.homePage.Visible = false;
            this.panel.Visible = true;

            //set the attribution
            FileSaver fileSaverForm = new FileSaver();
            fileSaverForm.TopLevel = false;
            fileSaverForm.Dock = System.Windows.Forms.DockStyle.Fill;
            fileSaverForm.FormBorderStyle = FormBorderStyle.None;

            this.panel.Controls.Add(fileSaverForm);
            fileSaverForm.Show();
            
            if ( FileSaver.flagLoaded == false )
                this.database = fileSaverForm.getDatabase();
            if (fileSaverForm.flagUpdated == true)
                this.database = fileSaverForm.getDatabase();
            
        }


        private void 首页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (database.Count() == 0)
                isLoadTheDatabase();
            else
            {
                this.panel.Controls.Clear();
                this.homePage.Visible = true;
                this.panel.Visible = false;
            }
        }


        private void can信息布局ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (database.Count() == 0)
                isLoadTheDatabase();
            else
            {
                //hide the last panel and add new panel
                this.panel.Controls.Clear();
                this.homePage.Visible = false;
                this.panel.Visible = true;

                //set the attribution
                CanMessageLayout layout = new CanMessageLayout();
                layout.loadData(database);

                layout.TopLevel = false;
                layout.Dock = System.Windows.Forms.DockStyle.Fill;
                layout.FormBorderStyle = FormBorderStyle.None;

                this.panel.Controls.Add(layout);
                layout.Show();
            }
        }

        private void 树状结构图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (database.Count() == 0)
                isLoadTheDatabase();
            else
            {
                //hide the last panel and add new panel
                this.panel.Controls.Clear();
                this.homePage.Visible = false;
                this.panel.Visible = true;

                //set the attribution
                TreeForm treeform = new TreeForm();
                treeform.loadData(database);

                treeform.TopLevel = false;
                treeform.Dock = System.Windows.Forms.DockStyle.Fill;
                treeform.FormBorderStyle = FormBorderStyle.None;

                this.panel.Controls.Add(treeform);
                treeform.Show();
            }
        }


        private void 实时曲线ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (database.Count() == 0)
                isLoadTheDatabase();
            else
            {
                //hide the last panel and add new panel
                this.panel.Controls.Clear();
                this.homePage.Visible = false;
                this.panel.Visible = true;

                //set the attribution
                CurveForm curveform = new CurveForm();

                curveform.TopLevel = false;
                curveform.Dock = System.Windows.Forms.DockStyle.Fill;
                curveform.FormBorderStyle = FormBorderStyle.None;

                this.panel.Controls.Add(curveform);
                curveform.Show();
            }
        }

        private void 仪表盘ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (database.Count() == 0)
                isLoadTheDatabase();
            else
            {
                //hide the last panel and add new panel
                this.panel.Controls.Clear();
                this.homePage.Visible = false;
                this.panel.Visible = true;

                //set the attribution
                boardForm boardForm = new boardForm();
                
                boardForm.TopLevel = false;
                boardForm.Dock = System.Windows.Forms.DockStyle.Fill;
                boardForm.FormBorderStyle = FormBorderStyle.None;

                this.panel.Controls.Add(boardForm);
                boardForm.Show();

                //bool open = Com.get_com().IsOpen;
                //MessageBox.Show(open.ToString());
            }
        }

        private void 用户设定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (database.Count() == 0)
                isLoadTheDatabase();
            else
            {
                SendData sendata = new SendData();
                sendata.Show();
            }
        }

        private void mitem_set_com_Click(object sender, EventArgs e)
        {
            //hide the last panel and add new panel
            this.panel.Controls.Clear();
            this.homePage.Visible = false;
            this.panel.Visible = true;

            //set the attribution of setcom
            fm_set_Com set_com = new fm_set_Com();
            set_com.TopLevel = false;
            set_com.Dock = System.Windows.Forms.DockStyle.Fill;
            set_com.FormBorderStyle = FormBorderStyle.None;

            this.panel.Controls.Add(set_com);
            set_com.Show();
        }

        private void can总线通信参数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (database.Count() == 0)
                isLoadTheDatabase();
            else
            {
                //hide the last panel and add new panel
                this.panel.Controls.Clear();
                this.homePage.Visible = false;
                this.panel.Visible = true;

                //set the attribution
                SetVelocity setVelocity = new SetVelocity();

                setVelocity.TopLevel = false;
                setVelocity.Dock = System.Windows.Forms.DockStyle.Fill;
                setVelocity.FormBorderStyle = FormBorderStyle.None;

                this.panel.Controls.Add(setVelocity);
                setVelocity.Show();
            }
        }

        private void canTool装置ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (database.Count() == 0)
                isLoadTheDatabase();
            else
            {
                //hide the last panel and add new panel
                this.panel.Controls.Clear();
                this.homePage.Visible = false;
                this.panel.Visible = true;

                //set the attribution
                SetCantool setCanTool = new SetCantool();

                setCanTool.TopLevel = false;
                setCanTool.Dock = System.Windows.Forms.DockStyle.Fill;
                setCanTool.FormBorderStyle = FormBorderStyle.None;

                this.panel.Controls.Add(setCanTool);
                setCanTool.Show();
            }
        }

        private bool isLoadTheDatabase()
        {
            DialogResult dr = MessageBox.Show(" 请先加载数据库", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                //hide the last panel and add new panel
                this.panel.Controls.Clear();
                this.homePage.Visible = false;
                this.panel.Visible = true;

                //set the attribution
                FileSaver fileSaverForm = new FileSaver();
                fileSaverForm.TopLevel = false;
                fileSaverForm.Dock = System.Windows.Forms.DockStyle.Fill;
                fileSaverForm.FormBorderStyle = FormBorderStyle.None;

                this.panel.Controls.Add(fileSaverForm);
                fileSaverForm.Show();
                this.database = fileSaverForm.getDatabase();
            }
            return true;

        }

        private void 关于CanToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

    }
}
