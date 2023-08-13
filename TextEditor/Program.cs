using System;
using System.IO;
using System.Runtime.InteropServices;

//INPORTAÇÕES



namespace TextEditor
{
    class Program
    {

        [StructLayout(LayoutKind.Sequential)]
        public struct KeyboardInput
        {
            public ushort wVk;
            public ushort wScan;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MouseInput
        {
            public int dx;
            public int dy;
            public uint mouseData;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct HardwareInput
        {
            public uint uMsg;
            public ushort wParamL;
            public ushort wParamH;
        }


        [StructLayout(LayoutKind.Explicit)]
        public struct InputUnion
        {
            [FieldOffset(0)] public MouseInput mi;
            [FieldOffset(0)] public KeyboardInput ki;
            [FieldOffset(0)] public HardwareInput hi;
        }

        public struct Input
        {
            public int type;
            public InputUnion u;
        }

        [Flags]
        public enum InputType
        {
            Mouse = 0,
            Keyboard = 1,
            Hardware = 2
        }

        [Flags]
        public enum KeyEventF
        {
            KeyDown = 0x0000,
            ExtendedKey = 0x0001,
            KeyUp = 0x0002,
            Unicode = 0x0004,
            Scancode = 0x0008
        }

        public enum MouseEventF
        {
            Absolute = 0x8000,
            HWheel = 0x01000,
            Move = 0x0001,
            MoveNoCoalesce = 0x2000,
            LeftDown = 0x0002,
            LeftUp = 0x0004,
            RightDown = 0x0008,
            RightUp = 0x0010,
            MiddleDown = 0x0020,
            MiddleUp = 0x0040,
            VirtualDesk = 0x4000,
            Wheel = 0x0800,
            XDown = 0x0080,
            XUp = 0x0100
        }

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint SendInput(uint nInputs, Input[] pInputs, int cbSize);

        [DllImport("user32.dll")]
        private static extern IntPtr GetMessageExtraInfo();



        static void Main()
        {

            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("Oque deseja fazer?");
            Console.WriteLine("[1] - Abir arquivo");
            Console.WriteLine("[2] - Criar novo arquivo");
            Console.WriteLine("[3] - Sair");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: System.Environment.Exit(0); break;
            }
        }

        static void Abrir()
        {
            Console.WriteLine("Qual o caminho do arquivo?");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);

                Console.WriteLine("");
                Console.ReadLine();
                Console.Clear();
                Menu();
            }
        }
        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("+---------------+");
            string text = "";
            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;

                Input[] inputs = new Input[]
                {
                    new Input
                    {
                        type = (int)InputType.Keyboard,
                        u = new InputUnion
                        {
                            ki = new KeyboardInput
                            {
                                wVk = 0,
                                wScan = 0x39, // ESPACE
                                dwFlags = (uint)(KeyEventF.KeyDown | KeyEventF.Scancode),
                                dwExtraInfo = GetMessageExtraInfo()
                            }
                        }
                    },
                    new Input
                    {
                        type = (int)InputType.Keyboard,
                        u = new InputUnion
                        {
                            ki = new KeyboardInput
                            {
                                wVk = 0,
                                wScan = 0x11, // W
                                dwFlags = (uint)(KeyEventF.KeyUp | KeyEventF.Scancode),
                                dwExtraInfo = GetMessageExtraInfo()
                            }
                        }
                    }
                };

                Console.WriteLine("Next Line? [1] - sim [2] - não");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1: SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(Input))); break;
                    default: Console.WriteLine("Aperte ESC pra sair"); break;
                }

            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(text);
            Menu();
        }
        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso!");

        }
        static void InputKey()
        {

        }

    }
}
