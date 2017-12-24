using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using System.Diagnostics;

namespace ExcelPic
{

    public struct CellPos
    {
        public int rowNum, colNum;

        public CellPos(int row, int col)
        {
            rowNum = row;
            colNum = col;
        }
    }


    public partial class FrmMain : Form
    {
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnDoIt_Click(object sender, EventArgs e)
        {
            string filNameOrigin = TxtFilePicked.Text;
            
            
            if (TxtFilePicked.Text == "")
            {
                MessageBox.Show("You need to pick a image file first", "warning", MessageBoxButtons.OK);
                return;
            }

            int iColSpan=0;
            if (!Int32.TryParse(TxtColSpan.Text, out iColSpan) || iColSpan<10||iColSpan>500)
            {
                MessageBox.Show("Column span has to be an integer between 10 to 500", "warning", MessageBoxButtons.OK);
                return;
            }

            int iCellUnitHeight=0;
            if (!Int32.TryParse(TxtCellUnitHeight.Text, out iCellUnitHeight) || iCellUnitHeight < 10 || iCellUnitHeight > 20)
            {
                MessageBox.Show("Cell Unit Height has to be an integer between 10 to 20", "warning", MessageBoxButtons.OK);
                return;
            }

            Bitmap bitmapNewImg = ResizeImageWithRatio(filNameOrigin, iColSpan);
            if (bitmapNewImg != null)
            {
                ExcelProc(bitmapNewImg, iCellUnitHeight);
                bitmapNewImg.Dispose();
            }

        }

        private void ExcelProc(Bitmap bitmapImg, int cellUnitHeight)
        {
            Microsoft.Office.Interop.Excel.Application xlApp = null;
            try
            {
                xlApp = new Microsoft.Office.Interop.Excel.Application();

                if (xlApp == null)
                {
                    MessageBox.Show("EXCEL could not be started. Make sure that MS Office installation and project references are all right.", "info", MessageBoxButtons.OK);
                    return;
                }
                xlApp.Visible = true;
                xlApp.WindowState = XlWindowState.xlMaximized;
                SetForegroundWindow(this.Handle);
                FrmProgress frmProgress = new FrmProgress();
                frmProgress.Show();
                frmProgress.Location = this.Location;
                this.Visible = false;


                Workbooks wbs = xlApp.Workbooks;
                Workbook wb = wbs.Add(XlWBATemplate.xlWBATWorksheet);
                Worksheet ws = (Worksheet)wb.Worksheets[1];

                if (ws == null)
                {
                    MessageBox.Show("Worksheet could not be created. Make sure that MS Office installation and project references are all right.", "info", MessageBoxButtons.OK);
                }

                ws.Cells.Select();

                xlApp.Selection.RowHeight = cellUnitHeight;
                xlApp.Selection.ColumnWidth = cellUnitHeight / 6;

                ws.Cells[1, 1].Select();


                Bitmap newBitmap = bitmapImg;
                int imgWidth = newBitmap.Width;
                int imgHeight = newBitmap.Height;


               List<CellPos> lstCellPos = new List<CellPos>();
                for (int i = 0; i < imgHeight; i++)
                {
                    for (int j = 0; j < imgWidth; j++)
                    {
                        lstCellPos.Add(new CellPos(i + 1, j + 1));
                    }
                }

                if (ChkRandomize.Checked)
                {
                    HelperExt.Shuffle(lstCellPos);
                }

                int cellCountAll = lstCellPos.Count();
                for (int i = 0; i < cellCountAll; i++)
                {
                    Color pixelColor = newBitmap.GetPixel(lstCellPos[i].colNum - 1, lstCellPos[i].rowNum - 1);
                    ws.Cells[lstCellPos[i].rowNum, lstCellPos[i].colNum].Interior.Color = pixelColor;


                    System.Windows.Forms.Label lblCtl = (System.Windows.Forms.Label)frmProgress.Controls["LblPerc"];
                    lblCtl.Text = (1.0 * i / cellCountAll).ToString("p0");

                }



               Marshal.ReleaseComObject(wb);
                Marshal.ReleaseComObject(wbs);
                Marshal.ReleaseComObject(xlApp);

                this.Visible = true;
                frmProgress.Close();

                MessageBox.Show("Done!", "FYI");
            }
            catch
            {
                MessageBox.Show("Make sure that MS Office installation and project references are all right.", "ERROR");
            }

        }

        private void BtnFilePicker_Click(object sender, EventArgs e)
        {
            DialogResult dr = OpenFileDlg.ShowDialog();
            TxtFilePicked.Text = OpenFileDlg.FileName;
        }

        private void BtnClearMem_Click(object sender, EventArgs e)
        {
            DialogResult rsltYesNo = MessageBox.Show("This will clean all running Excel applications in memory (assume you already saved all your works). Continue?", "warning", MessageBoxButtons.YesNo);
            
            if (rsltYesNo == DialogResult.Yes)
            {
                var prs = Process.GetProcessesByName("EXCEL");
                foreach (Process p in prs)
                {
                    p.Kill();
                }

            }
        }

        private Bitmap ResizeImageWithRatio(string fileName, int newWidth)
        {
            Bitmap newBitmap = null;
            try
            {
                Image originImg = Image.FromFile(fileName);
                float ratio = (float)originImg.Height / (float)originImg.Width;

                int newHeight = (int)(newWidth * ratio);


                newBitmap = new Bitmap(newWidth, newHeight, originImg.PixelFormat);
                Graphics newGraphic = Graphics.FromImage(newBitmap);
                newGraphic.DrawImage(originImg, 0, 0, newWidth, newHeight);

                originImg.Dispose();
                newGraphic.Dispose();
            }
            catch
            {
                MessageBox.Show("Image is broken. Pick another imgage file.", "Error");

            }
            
            return newBitmap;

        }
     
    }

     public static class HelperExt
    {
        private static Random rnd = new Random();
        public static void Shuffle<T>(this IList<T> lst)
        {
            int cnt = lst.Count;
            while (cnt > 1)
            {
                cnt--;
                int nxt = rnd.Next(cnt + 1);
                T item = lst[nxt];
                lst[nxt] = lst[cnt];
                lst[cnt] = item;
            }
        }

    }


}
