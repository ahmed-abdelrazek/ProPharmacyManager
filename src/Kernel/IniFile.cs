using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ProPharmacyManager.Kernel
{
    public class IniFile
    {
        public string FileName;
        /// <summary> 
        /// .ini files reader writer
        /// </summary> 
        /// <param name="_FileName">file name</param>
        public IniFile(string _FileName)
        {
            this.FileName = Environment.CurrentDirectory + "\\" + _FileName;
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int GetPrivateProfileStringA(string Section, string Key, string _Default, StringBuilder Buffer, int BufferSize, string FileName);
        [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int WritePrivateProfileStringA(string Section, string Key, string Arg, string FileName);
        /// <summary> 
        /// read byte from file
        /// </summary> 
        /// <param name="Section">read section string value </param>
        /// <param name="Key">read key value </param>
        public byte ReadByte(string Section, string Key, byte _Default)
        {
            byte buf = _Default;
            byte.TryParse(this.ReadString(Section, Key, _Default.ToString(), 6), out buf);
            return buf;
        }

        public short ReadInt16(string Section, string Key, short _Default)
        {
            short buf = _Default;
            short.TryParse(this.ReadString(Section, Key, _Default.ToString(), 9), out buf);
            return buf;
        }

        public int ReadInt32(string Section, string Key, int _Default)
        {
            int buf = _Default;
            int.TryParse(this.ReadString(Section, Key, _Default.ToString(), 15), out buf);
            return buf;
        }

        public sbyte ReadSByte(string Section, string Key, byte _Default)
        {
            sbyte buf = (sbyte)_Default;
            sbyte.TryParse(this.ReadString(Section, Key, _Default.ToString(), 6), out buf);
            return buf;
        }

        public string ReadString(string Section, string Key)
        {
            return this.ReadString(Section, Key, "", 400);
        }

        public string ReadString(string Section, string Key, string _Default, int BufSize)
        {
            StringBuilder Buffer = new StringBuilder(BufSize);
            GetPrivateProfileStringA(Section, Key, _Default, Buffer, BufSize, this.FileName);
            return Buffer.ToString();
        }

        public ushort ReadUInt16(string Section, string Key)
        {
            ushort buf = 0;
            ushort.TryParse(this.ReadString(Section, Key, 0.ToString(), 9), out buf);
            return buf;
        }

        public uint ReadUInt32(string Section, string Key)
        {
            uint buf = 0;
            uint.TryParse(this.ReadString(Section, Key, 0.ToString(), 15), out buf);
            return buf;
        }

        public void Write(string Section, string Key, object Value)
        {
            WritePrivateProfileStringA(Section, Key, Value.ToString(), this.FileName);
        }

        public void Write(string Section, string Key, string Value)
        {
            WritePrivateProfileStringA(Section, Key,Program.INIEncrypt(Value), this.FileName);
        }
    }
}
