using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace HybridizationTool
{
    public partial class HybridizationToolWindow : Form
    {
        OpenFileDialog openFastaFileDialog;
        OpenFileDialog openBLASTFileDialog;
        OpenFileDialog openRNAFoldFileDialog;
        OpenFileDialog openDatabaseFileDialog;
        string appPath = Path.GetDirectoryName(Application.ExecutablePath);
        Dictionary<string, PartDetail> dicPartDetail = new Dictionary<string, PartDetail>();
        DataTable dtParts = new DataTable();

        public HybridizationToolWindow()
        {
            InitializeComponent();

            openFastaFileDialog = new OpenFileDialog();
            openFastaFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFastaFileDialog.RestoreDirectory = true;
            openFastaFileDialog.CheckFileExists = true;
            openFastaFileDialog.CheckPathExists = true;
            openFastaFileDialog.Title = "Select FASTA file";
            openFastaFileDialog.Filter = "FASTA File (*.fasta) | *.fasta";

            openBLASTFileDialog = new OpenFileDialog();
            openBLASTFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openBLASTFileDialog.RestoreDirectory = true;
            openBLASTFileDialog.CheckFileExists = true;
            openBLASTFileDialog.CheckPathExists = true;
            openBLASTFileDialog.Title = "Select blastn executable";
            openBLASTFileDialog.Filter = "Executable File (*.exe)| *.exe";

            openRNAFoldFileDialog = new OpenFileDialog();
            openRNAFoldFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openRNAFoldFileDialog.RestoreDirectory = true;
            openRNAFoldFileDialog.CheckFileExists = true;
            openRNAFoldFileDialog.CheckPathExists = true;
            openRNAFoldFileDialog.Title = "Select RNAfold executable";
            openRNAFoldFileDialog.Filter = "Executable File (*.exe)| *.exe";

            openDatabaseFileDialog = new OpenFileDialog();
            openDatabaseFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openDatabaseFileDialog.RestoreDirectory = true;
            openDatabaseFileDialog.CheckFileExists = true;
            openDatabaseFileDialog.CheckPathExists = true;
            openDatabaseFileDialog.Title = "Select blast database alias file (.nal)";
            openDatabaseFileDialog.Filter = "Database Alias File (*.nal)| *.nal";

            dtParts.Columns.Add("Part Name");
            dtParts.Columns.Add("Status");
            dgvParts.DataSource = dtParts;
            dgvParts.Columns["Part Name"].Width = 150;
            dgvParts.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnAddFasta_Click(object sender, EventArgs e)
        {
            DialogResult result = openFastaFileDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                PartDetail part = new PartDetail();
                //Get the path of specified file
                part.PartPath = openFastaFileDialog.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFastaFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    part.FASTAFormat = reader.ReadToEnd();
                }
                DataRow newRow = dtParts.NewRow();
                string sPartName = openFastaFileDialog.SafeFileName.Split('.')[0];
                newRow["Part Name"] = sPartName;
                part.PartName = sPartName;
                newRow["Status"] = "Tests pending...";
                dtParts.Rows.Add(newRow);

                dicPartDetail.Add(sPartName, part);
                dgvParts.DataSource = dtParts;
                if (dtParts.Rows.Count == 1) dgvParts.Rows[0].Selected = true;
            }
        }

        private void btnBlastPath_Click(object sender, EventArgs e)
        {
            DialogResult result = openBLASTFileDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                txtBlastPath.Text = openBLASTFileDialog.FileName;
            }
        }

        private void btnDbPath_Click(object sender, EventArgs e)
        {
            DialogResult result = openDatabaseFileDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                txtDbPath.Text = openDatabaseFileDialog.FileName;
            }
        }

        private void btnViennaPath_Click(object sender, EventArgs e)
        {
            DialogResult result = openRNAFoldFileDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                txtViennaPath.Text = openRNAFoldFileDialog.FileName;
            }
        }

        private void btnTestPart_Click(object sender, EventArgs e)
        {
            if (txtBlastPath.Text == "" || txtDbPath.Text == "" || txtViennaPath.Text == "") return;
            if (dtParts.Rows.Count > 0)
            {
                Cursor.Current = Cursors.WaitCursor;
                string selectedPartName = dgvParts.SelectedRows[0].Cells["Part Name"].Value.ToString();
                int selectedPartIndex = dgvParts.SelectedRows[0].Index;
                PartDetail part = dicPartDetail[selectedPartName];


                //Reset status
                dtParts.Rows[selectedPartIndex]["Status"] = "Tests pending...";
                part.bBlastSuccess = false;
                part.bFoldSuccess = false;

                //BLAST Process
                Process proc1 = new Process();
                proc1.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
                proc1.StartInfo.FileName = txtBlastPath.Text;
                proc1.StartInfo.Arguments = "-query " + part.PartPath + " -db " + txtDbPath.Text.Split('.')[0] + " -out " + part.PartName + ".txt -evalue 1e-3 -num_threads 5";
                proc1.StartInfo.UseShellExecute = false;
                proc1.StartInfo.RedirectStandardError = true;
                proc1.StartInfo.RedirectStandardOutput = true;
                if (!proc1.Start())
                {
                    MessageBox.Show("Please check that the blastn path is correct.");
                    return;
                }
                proc1.WaitForExit();
                proc1.Close();

                string blastout = File.ReadAllText(part.PartName + ".txt", Encoding.UTF8);
                if (blastout.Contains("***** No hits found *****"))
                {
                    part.bBlastSuccess = true;
                }

                //RNAfold Process

                Process proc2 = new Process();
                proc2.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
                proc2.StartInfo.FileName = txtViennaPath.Text;
                proc2.StartInfo.Arguments = "-i " + part.PartPath + " -o";
                proc2.StartInfo.UseShellExecute = false;
                proc2.StartInfo.RedirectStandardError = true;
                proc2.StartInfo.RedirectStandardOutput = true;
                if (!proc2.Start())
                {
                    MessageBox.Show("Please check that the RNAfold path is correct.");
                    return;
                }
                proc2.WaitForExit();
                proc2.Close();

                string foldout = File.ReadAllText(part.PartName + ".fold", Encoding.UTF8);
                if (foldout.Contains("(  0.00)"))
                {
                    part.bFoldSuccess = true;
                }

                //Report results under status
                if(part.bFoldSuccess && part.bBlastSuccess)
                {
                    dtParts.Rows[selectedPartIndex]["Status"] = "Tests Successful";
                }
                else if (!part.bFoldSuccess && part.bBlastSuccess)
                {
                    dtParts.Rows[selectedPartIndex]["Status"] = "Blast test successful, Fold test failed";
                }
                else if (!part.bFoldSuccess && !part.bBlastSuccess)
                {
                    dtParts.Rows[selectedPartIndex]["Status"] = "Tests failed";
                }
                else if (part.bFoldSuccess && !part.bBlastSuccess)
                {
                    dtParts.Rows[selectedPartIndex]["Status"] = "Blast test failed, Fold test successful";
                }
            }
            Cursor.Current = Cursors.Default;

        }
    }


}
