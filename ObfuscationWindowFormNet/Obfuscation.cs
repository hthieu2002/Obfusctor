using AntiDebug;
using Microsoft.VisualBasic.Logging;
using Mono.Cecil;
using ObfuscationWindowFormNet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObfuscationWindowFormNet
{

    public partial class Obfuscation : Form
    {
        private SettingObfuscation _obfuscation;
        // 
        private bool _antiDebug = false; //Chống Debugger
        private bool _antiTamper = false; //Chống Sửa Đổi
        private bool _controlFlow = false; // Bảo Vệ Luồng Điều Khiển
        private bool _constantsProtection = false; //Bảo Vệ Hằng Số
        private bool _invalidMetadata = false; //Metadata Không Hợp Lệ
        private bool _invalidOpcode = false; //OpCode Không Hợp Lệ 
        private bool _nameObfuscation = false; //Xáo Trộn Tên Biến 
        private bool _referenceProxy = false; // Proxy Tham Chiếu
        private bool _resourcesEncryption = false; //Mã Hóa Resource
        private bool _stringEncryption = false; //Mã Hóa Chuỗi
        private bool _watermark = false; //Dấu Vết Bảo Vệ

        public Obfuscation()
        {
            InitializeComponent();
            _obfuscation = new SettingObfuscation();
            _obfuscation.OnLog += Log;
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Executable Files (*.exe)|*.exe",
                Title = "Select EXE File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFileExe.Text = openFileDialog.FileName;
                AppendLog($"📌 Selected EXE: {openFileDialog.FileName}", "select");
            }
        }
        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFolder.Text = folderDialog.SelectedPath;
                    AppendLog($"📁 Selected Dependency Folder: {folderDialog.SelectedPath}", "select");
                }
            }
        }

        // log 
        private void AppendLog(string message, string type = "info")
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string, string>(AppendLog), message, type);
                return;
            }

            Color logColor = Color.Black;
            switch (type.ToLower())
            {
                case "select": logColor = Color.Blue; break;
                case "warning": logColor = Color.Orange; break;
                case "error": logColor = Color.Red; break;
                case "success": logColor = Color.DarkGreen; break;
            }

            rtbLogs.SelectionStart = rtbLogs.TextLength;
            rtbLogs.SelectionLength = 0;
            rtbLogs.SelectionColor = logColor;
            rtbLogs.AppendText($"{DateTime.Now:HH:mm:ss} - {message}\n");
            rtbLogs.SelectionColor = rtbLogs.ForeColor;
            rtbLogs.ScrollToCaret();

            // Dùng StreamWriter để tránh lock file khi nhiều log được ghi
            using (StreamWriter writer = new StreamWriter("log.txt", true))
            {
                writer.WriteLine($"{DateTime.Now:HH:mm:ss} - {message}");
            }
        }

        // private enum LogType { Select, Warning, Error, Success }
        private void Log(string message, LogType type)
        {
            rtbLogs.Invoke((MethodInvoker)delegate
            {
                rtbLogs.SelectionStart = rtbLogs.TextLength;
                rtbLogs.SelectionLength = 0;

                switch (type)
                {
                    case LogType.Select:
                        rtbLogs.SelectionColor = System.Drawing.Color.Blue;
                        break;
                    case LogType.Warning:
                        rtbLogs.SelectionColor = System.Drawing.Color.Orange;
                        break;
                    case LogType.Error:
                        rtbLogs.SelectionColor = System.Drawing.Color.Red;
                        break;
                    case LogType.Success:
                        rtbLogs.SelectionColor = System.Drawing.Color.DarkGreen;
                        break;
                }

                rtbLogs.AppendText(message + Environment.NewLine);
                rtbLogs.SelectionColor = rtbLogs.ForeColor;
            });
        }
        private async void Play_Click(object sender, EventArgs e)
        {
            rtbLogs.Clear();
            var exePath = txtFileExe.Text;
            var folderPath = txtFolder.Text;
            var ouputName = txtFileNameOutput.Text;
            var nameAttribus = txtNameAttribus.Text;

            if (string.IsNullOrWhiteSpace(exePath))
            {
                Log("❌Lỗi. Vui lòng chọn file EXE!", LogType.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(folderPath))
            {
                Log("❌Lỗi. Vui lòng chọn thư mục chứa!", LogType.Error);
            }

            if (string.IsNullOrWhiteSpace(ouputName))
            {
                Log($"❌Warning. Vui lòng nhập tên file đầu ra! tên mặc định Obfuscation", LogType.Warning);
                ouputName = "Obfuscation";
            }

            if (string.IsNullOrWhiteSpace(nameAttribus))
            {
                Log($"❌Warning. Vui lòng nhập thuộc tính. Mặc định là 10", LogType.Warning);
                nameAttribus = "10";
            }

            Log("🔄 Bắt đầu bảo vệ mã nguồn", LogType.Select);
            await Task.Run(async () =>
            {
                try
                {
                    if (_antiDebug == true)
                    {
                        Log("🔄 Thêm chức năng chống debug", LogType.Select);
                        await _obfuscation.AntiDebuger(exePath);
                    }
                    if (_antiTamper == true)
                    {
                        Log("🔄 Thêm chức năng chống sửa đổi", LogType.Select);
                    }
                    if (_constantsProtection == true)
                    {
                        Log("🔄 Thêm chức năng bảo vệ hằng số", LogType.Select);
                    }
                    if (_controlFlow == true)
                    {
                        Log("🔄 Thêm chức năng bảo vệ luồng điều khiển", LogType.Select);
                    }
                    if (_invalidMetadata == true)
                    {
                        Log("🔄 Chèn metadata giả", LogType.Select);
                    }
                    if (_invalidOpcode == true)
                    {
                        Log("🔄 Chèn OpCode giả", LogType.Select);
                    }
                    if (_nameObfuscation == true)
                    {
                        Log("🔄 Đổi tên biến, phương thức, class", LogType.Select);
                    }
                    if (_referenceProxy == true)
                    {
                        Log("🔄 Thay đổi cách gọi phương thức", LogType.Select);
                    }
                    if (_resourcesEncryption == true)
                    {
                        Log("🔄 Mã hóa tài nguyên nhúng", LogType.Select);
                    }
                    if (_stringEncryption == true)
                    {
                        Log("🔄 Mã hóa tất cả chuỗi", LogType.Select);
                    }
                    if (_watermark == true)
                    {
                        Log("🔄 Nhúng thông tin bảo vệ bản quyền vào file EXE/DLL.", LogType.Select);
                    }
                }
                catch (Exception ex)
                {
                    Log($"❌ Lỗi không bảo vệ thành công ! Chi tiết lỗi{ex}", LogType.Error);
                }
            });
        }

        private void chkAntiDebug_CheckedChanged(object sender, EventArgs e)
        {
            _antiDebug = !_antiDebug;
        }

        private void chkAntiTamper_CheckedChanged(object sender, EventArgs e)
        {
            _antiTamper = !_antiTamper;
        }

        private void chkControlFlow_CheckedChanged(object sender, EventArgs e)
        {
            _controlFlow = !_controlFlow;
        }

        private void chkEncryptConstants_CheckedChanged(object sender, EventArgs e)
        {
            _constantsProtection = !_constantsProtection;
        }

        private void chkInvalidMetadata_CheckedChanged(object sender, EventArgs e)
        {
            _invalidMetadata = !_invalidMetadata;
        }

        private void chkInvalidOpcode_CheckedChanged(object sender, EventArgs e)
        {
            _invalidOpcode = !_invalidOpcode;
        }

        private void chkRenameSymbols_CheckedChanged(object sender, EventArgs e)
        {
            _nameObfuscation = !_nameObfuscation;
        }

        private void chkReferenceProxy_CheckedChanged(object sender, EventArgs e)
        {
            _referenceProxy = !_referenceProxy;
        }

        private void chkEncryptResources_CheckedChanged(object sender, EventArgs e)
        {
            _resourcesEncryption = !_resourcesEncryption;
        }

        private void chkEncryptStrings_CheckedChanged(object sender, EventArgs e)
        {
            _stringEncryption = !_stringEncryption;
        }

        private void chkWatermark_CheckedChanged(object sender, EventArgs e)
        {
            _watermark = !_watermark;
        }
    }
}
