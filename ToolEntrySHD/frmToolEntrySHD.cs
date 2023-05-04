using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ToolEntrySHD
{
    public partial class frmToolEntrySHD : Form
    {

        public frmToolEntrySHD()
        { InitializeComponent(); }
        List<string> locFile = new List<string>();
        List<string> FileResult = new List<string>();
        FolderBrowserDialog fd = new FolderBrowserDialog();
        int counter = 0;
        Bitmap imageClone;
        private void showImage()
        {
            try
            {
                if (counter == locFile.Count())
                {
                    MessageBox.Show("Complete!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    //imageClone = (Bitmap)Image.FromFile(locFile[counter]);
                    ImageView.Image = Image.FromFile(locFile[counter]);
                    imageClone = (Bitmap)ImageView.Image;

                    lblValueIndex.Text = Convert.ToInt32(counter + 1) + "/" + locFile.Count.ToString();
                    this.txtEntry.Focus();
                    checkName();
                }
            }
            catch (Exception ex) { MessageBox.Show("Clear folder Result!! If folder exited \n"); }
        }
        public void checkName()
        {
            if (Path.GetFileName(locFile[counter]).IndexOf('_') != -1 && Path.GetFileName(locFile[counter]).IndexOf('_') <= 9)
            {
                txtNameImage.Text = Path.GetFileName(locFile[counter]).Split('_')[1].Split('.')[0].Trim();
            }
            else if (Path.GetFileName(locFile[counter]).IndexOf('_') == -1 || Path.GetFileName(locFile[counter]).IndexOf('_') > 9)
            {
                txtNameImage.Text = Path.GetFileName(locFile[counter]).Split('.')[0].Trim();
            }
        }
        private void btnInputPath_Click(object sender, EventArgs e)
        {
            try
            {
                fd.ShowDialog();
                locFile = Directory.GetFiles(fd.SelectedPath, "*.jpg", SearchOption.TopDirectoryOnly).ToList();
                txtPath.Text = fd.SelectedPath.ToString();
                if (locFile.Count() == 0)
                {
                    MessageBox.Show("This Folder Don't Have A Picture!!!\nPlease, Pick Folder Another.", "Alert Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DirectoryInfo dir = new DirectoryInfo(fd.SelectedPath + "\\result");
                    if (!dir.Exists)
                    {
                        dir.Create();
                        FileResult = Directory.GetFiles(fd.SelectedPath + "\\result", "*.jpg", SearchOption.TopDirectoryOnly).ToList();
                        counter = FileResult.Count();
                        showImage();
                        this.txtEntry.Clear();
                        //txtNameImage.Text = Path.GetFileName(locFile[counter]).Split('_')[1].Split('.')[0].Trim();

                    }
                    else
                    {

                        FileResult = Directory.GetFiles(fd.SelectedPath + "\\result", "*.jpg", SearchOption.TopDirectoryOnly).ToList();
                        counter = FileResult.Count();
                        showImage();
                        //txtNameImage.Text = Path.GetFileName(locFile[counter]).Split('_')[1].Split('.')[0].Trim();
                        this.txtEntry.Clear();

                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void txtEntry_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    //ImageView.Image.Save(txtPath.Text + "\\result\\" + (counter + 1).ToString().PadLeft(6, '0') + "_" + txtEntry.Text.Trim() + ".jpg");
                    //ImageView.Image.Dispose();
                    imageClone.Save(txtPath.Text + "\\result\\" + (counter + 1).ToString().PadLeft(6, '0') + "_" + txtEntry.Text.Trim() + ".jpg");
                    counter += 1;
                    imageClone.Dispose();
                    showImage();
                    this.txtEntry.Clear();
                    //txtNameImage.Text = Path.GetFileName(locFile[counter]).Split('_')[1].Split('.')[0].Trim();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void frmToolEntrySHD_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyData)
                {
                    case Keys.Escape:
                        DialogResult dg = MessageBox.Show("Bạn muốn thoát hệ thống.!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (dg == DialogResult.OK)
                        { Application.Exit(); }
                        break;
                    case Keys.Delete:
                        ImageView.Image.Dispose();
                        File.Delete(locFile[counter]);
                        
                        locFile.RemoveAt(counter);
                        showImage();

                        this.txtEntry.Clear();
                        checkName();

                        //txtNameImage.Text = Path.GetFileName(locFile[counter]).Split('_')[1].Split('.')[0].Trim();
                        break;
                    case Keys.F1:
                        ImageView.Image.Save(txtPath.Text + "\\result\\" + (counter + 1).ToString().PadLeft(6, '0') + "_" + Path.GetFileName(locFile[counter]).Split('_').Last().Trim());
                        //ImageView.Image.Save(txtPath.Text + "\\result\\" + (counter + 1).ToString().PadLeft(6, '0') + "_" + lblNameImage.Text.Split('_').Last().Trim() + ".jpg");
                        ImageView.Image.Dispose();
                        counter += 1;
                        showImage();
                        this.txtEntry.Clear();
                        //txtNameImage.Text = Path.GetFileName(locFile[counter]).Split('_')[1].Split('.')[0].Trim();
                        break;
                    case Keys.F2:
                        counter -= 1;
                        showImage();

                        FileResult = Directory.GetFiles(fd.SelectedPath + "\\result", "*.jpg", SearchOption.TopDirectoryOnly).ToList();
                        //txtNameImage.Text = Path.GetFileName(locFile[counter]).Split('_')[1].Split('.')[0].Trim();
                        txtEntry.Text = Path.GetFileName(FileResult[counter]).Split('_')[1].Split('.')[0].Trim();
                        File.Delete(FileResult[counter]);
                        FileResult.RemoveAt(counter);

                        break;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void txtNameImage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                txtNameImage.SelectAll();
            }
            if (e.Control && e.KeyCode == Keys.C)
            {

            }
        }

        private void frmToolEntrySHD_Load(object sender, EventArgs e)
        {
        }
    }
}