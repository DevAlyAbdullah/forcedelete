using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ForceDelete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Delete_Folder_Click(object sender, EventArgs e)
        {
            if (TXT_Location_Folder.Text != string.Empty && TXT_Name_Folder.Text != string.Empty)
            {
                if (MessageBox.Show("Are you sure you want to delete this Folder?\nThis action can not be undone.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string TXTLOCATION = $"{TXT_Location_Folder.Text}";
                    string TXTNAME = $"{TXT_Name_Folder.Text}";
                    if (MessageBox.Show($"You are about to delete this Folder from This location.\n\nLocation: {TXTLOCATION}\nName: {TXTNAME}", "Last Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        string strCmdText = $"/C cd /d {TXT_Location_Folder.Text}&rmdir /q /s {TXT_Name_Folder.Text}";
                        Process.Start("CMD.exe", strCmdText);
                        return;
                    }
                    return;
                }
                else
                {
                    return;
                }
            }
            MessageBox.Show("You need to fill the two boxes first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void BTN_Clear_Folder_Click(object sender, EventArgs e)
        {
            TXT_Location_Folder.Clear();
            TXT_Name_Folder.Clear();
            return;
        }

        private void BTN_Delete_TXT_Click(object sender, EventArgs e)
        {
            if (TXT_Location_TXT.Text != string.Empty && TXT_Name_TXT.Text != string.Empty)
            {
                if (MessageBox.Show("Are you sure you want to delete this TXT?\nThis action can not be undone.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string TXTLOCATION = $"{TXT_Location_TXT.Text}";
                    string TXTNAME = $"{TXT_Name_TXT.Text}";
                    if (MessageBox.Show($"You are about to delete this TXT from This location.\n\nLocation: {TXTLOCATION}\nName: {TXTNAME}", "Last Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        string strCmdText = $"/C cd /d {TXT_Location_TXT.Text}&del /f {TXT_Name_TXT.Text}.txt";
                        Process.Start("CMD.exe", strCmdText);
                        return;
                    }
                    return;
                }
                else
                {
                    return;
                }
            }
            MessageBox.Show("You need to fill the two boxes first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void BTN_Clear_TXT_Click(object sender, EventArgs e)
        {
            TXT_Location_TXT.Clear();
            TXT_Name_TXT.Clear();
            return;
        }

        private void BTN_Delete_PNG_Click(object sender, EventArgs e)
        {
            if (TXT_Location_PNG.Text != string.Empty && TXT_Name_PNG.Text != string.Empty)
            {
                if (MessageBox.Show("Are you sure you want to delete this PNG?\nThis action can not be undone.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string TXTLOCATION = $"{TXT_Location_PNG.Text}";
                    string TXTNAME = $"{TXT_Name_PNG.Text}";
                    if (MessageBox.Show($"You are about to delete this PNG from This location.\n\nLocation: {TXTLOCATION}\nName: {TXTNAME}", "Last Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        string strCmdText = $"/C cd /d {TXT_Location_PNG.Text}&del /f {TXT_Name_PNG.Text}.png";
                        Process.Start("CMD.exe", strCmdText);
                        return;
                    }
                    return;
                }
                else
                {
                    return;
                }
            }
            MessageBox.Show("You need to fill the two boxes first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void BTN_Clear_PNG_Click(object sender, EventArgs e)
        {
            TXT_Location_PNG.Clear();
            TXT_Name_PNG.Clear();
            return;
        }

        private void BTN_Delete_ICO_Click(object sender, EventArgs e)
        {
            if (TXT_Location_ICO.Text != string.Empty && TXT_Name_ICO.Text != string.Empty)
            {
                if (MessageBox.Show("Are you sure you want to delete this ICO?\nThis action can not be undone.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string TXTLOCATION = $"{TXT_Location_ICO.Text}";
                    string TXTNAME = $"{TXT_Name_ICO.Text}";
                    if (MessageBox.Show($"You are about to delete this ICO from This location.\n\nLocation: {TXTLOCATION}\nName: {TXTNAME}", "Last Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        string strCmdText = $"/C cd /d {TXT_Location_ICO.Text}&del /f {TXT_Name_ICO.Text}.ico";
                        Process.Start("CMD.exe", strCmdText);
                        return;
                    }
                    return;
                }
                else
                {
                    return;
                }
            }
            MessageBox.Show("You need to fill the two boxes first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void BTN_Clear_ICO_Click(object sender, EventArgs e)
        {
            TXT_Location_ICO.Clear();
            TXT_Name_ICO.Clear();
            return;
        }

        private void BTN_Delete_PDF_Click(object sender, EventArgs e)
        {
            if (TXT_Location_PDF.Text != string.Empty && TXT_Name_PDF.Text != string.Empty)
            {
                if (MessageBox.Show("Are you sure you want to delete this PDF?\nThis action can not be undone.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string TXTLOCATION = $"{TXT_Location_PDF.Text}";
                    string TXTNAME = $"{TXT_Name_PDF.Text}";
                    if (MessageBox.Show($"You are about to delete this PDF from This location.\n\nLocation: {TXTLOCATION}\nName: {TXTNAME}", "Last Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        string strCmdText = $"/C cd /d {TXT_Location_PDF.Text}&del /f {TXT_Name_PDF.Text}.pdf";
                        Process.Start("CMD.exe", strCmdText);
                        return;
                    }
                    return;
                }
                else
                {
                    return;
                }
            }
            MessageBox.Show("You need to fill the two boxes first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void BTN_Clear_PDF_Click(object sender, EventArgs e)
        {
            TXT_Location_PDF.Clear();
            TXT_Name_PDF.Clear();
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You need to fill this box with Folder's Location\nHere is how you can get the location of the Folder\n\n1) Right click the Folder\n2) Click Proparties\n3) Copy the location and past it in the box.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You need to fill this box with Folder's Name\nHere is how you can get the name of the Folder\n\n1) Right click the Folder\n2) Click Rename\n3) Copy the name and past it in the box.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You need to fill this box with TXT's Location\nHere is how you can get the location of the TXT\n\n1) Right click the TXT\n2) Click Proparties\n3) Copy the location and past it in the box.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You need to fill this box with TXT's Name\nHere is how you can get the name of the TXT\n\n1) Right click the TXT\n2) Click Rename\n3) Copy the name and past it in the box.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You need to fill this box with PNG's Location\nHere is how you can get the location of the PNG\n\n1) Right click the PNG\n2) Click Proparties\n3) Copy the location and past it in the box.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You need to fill this box with PNG's Name\nHere is how you can get the name of the PNG\n\n1) Right click the PNG\n2) Click Rename\n3) Copy the name and past it in the box.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You need to fill this box with ICO's Location\nHere is how you can get the location of the ICO\n\n1) Right click the ICO\n2) Click Proparties\n3) Copy the location and past it in the box.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You need to fill this box with ICO's Name\nHere is how you can get the name of the ICO\n\n1) Right click the ICO\n2) Click Rename\n3) Copy the name and past it in the box.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You need to fill this box with PDF's Location\nHere is how you can get the location of the PDF\n\n1) Right click the PDF\n2) Click Proparties\n3) Copy the location and past it in the box.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You need to fill this box with PDF's Name\nHere is how you can get the name of the PDF\n\n1) Right click the PDF\n2) Click Rename\n3) Copy the name and past it in the box.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
    }
}
