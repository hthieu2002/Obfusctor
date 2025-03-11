using Mono.Cecil;
using Mono.Cecil.Cil;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ObfuscationWindowFormNet.Models
{
    public enum LogType
    {
        Select,
        Warning,
        Error,
        Success
    }

    public partial class SettingObfuscation
    {
        public delegate void LogHandler(string message, LogType type);
        public event LogHandler OnLog;
        public SettingObfuscation() { }

        // Phát hiện debugger
        public async Task AntiDebuger(string exePath)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string dllPath = Path.Combine(basePath, @"..\..\..\AntiDebug\bin\Debug\net9.0\AntiDebugPatch.dll");

            string patchDllPath = Path.GetFullPath(dllPath);

            try
            {
                if (string.IsNullOrEmpty(exePath) || !File.Exists(exePath))
                {
                    OnLog?.Invoke("❌ Không tìm thấy file EXE để bảo vệ!", LogType.Error);
                    return;
                }

                if (string.IsNullOrEmpty(patchDllPath) || !File.Exists(patchDllPath))
                {
                    OnLog?.Invoke("❌ Không tìm thấy `AntiDebugPatch.dll`!", LogType.Error);
                    return;
                }

                string outputFile = Path.Combine(Path.GetDirectoryName(exePath), "ProtectedApp.exe");

                var resolver = new DefaultAssemblyResolver();
                resolver.AddSearchDirectory(Path.GetDirectoryName(exePath));

                var readerParams = new ReaderParameters
                {
                    ReadWrite = true,
                    AssemblyResolver = resolver
                };

                using (var assembly = AssemblyDefinition.ReadAssembly(exePath, readerParams))
                {
                    var module = assembly.MainModule;
                    var entryPoint = module.EntryPoint;

                    if (entryPoint == null)
                    {
                        OnLog?.Invoke("❌ Không tìm thấy `Main()` trong EXE!", LogType.Error);
                        return;
                    }

                    OnLog?.Invoke("✅ Đã tìm thấy `Main()`, Inject Harmony Patch...", LogType.Select);

                    var ilProcessor = entryPoint.Body.GetILProcessor();
                    var firstInstruction = entryPoint.Body.Instructions.First();

                    // Import `AntiDebug.ApplyPatch()` từ DLL
                    AssemblyDefinition patchAssembly = AssemblyDefinition.ReadAssembly(patchDllPath);
                    TypeDefinition patchType = patchAssembly.MainModule.Types.First(t => t.Name == "AntiDebug");
                    MethodDefinition patchMethod = patchType.Methods.First(m => m.Name == "ApplyPatch");

                    MethodReference applyPatchRef = module.ImportReference(patchMethod);

                    // Inject `AntiDebug.ApplyPatch();` vào đầu `Main()`
                    ilProcessor.InsertBefore(firstInstruction, ilProcessor.Create(OpCodes.Call, applyPatchRef));

                    // 💾 Lưu EXE đã được bảo vệ
                    var writerParams = new WriterParameters { WriteSymbols = true };
                    assembly.Write(outputFile, writerParams);
                }

                OnLog?.Invoke($"✅ Đã Inject Harmony Patch vào EXE! File đã bảo vệ: {outputFile}", LogType.Success);
            }
            catch (Exception ex)
            {
                OnLog?.Invoke("❌ Lỗi khi Inject Harmony Patch: " + ex.Message, LogType.Error);
            }
        }
    
        //Phát hiện sửa đổi EXE
        public async Task AntiTamper()
        {

        }
        //Rối loạn luồng điều khiển
        public async Task ControlFlow()
        {

        }
        //Mã hóa hằng số
        public async Task ConstantsProtection()
        {

        }
        //Chèn metadata sai
        public async Task invalidMetadata()
        {

        }
        //Chèn lệnh IL sai
        public async Task InvalidOpcode()
        {

        }
        //Xáo trộn tên biến
        public async Task NameObfuscation()
        {

        }
        //Proxy hóa hàm
        public async Task ReferenceProxy()
        {

        }
        //Mã hóa tài nguyên
        public async Task ResourcesEncryption()
        {

        }
        //Mã hóa chuỗi
        public async Task StringEncryption()
        {

        }
        //Nhúng dấu bản quyền
        public async Task Watermark()
        {

        }
    }
}
