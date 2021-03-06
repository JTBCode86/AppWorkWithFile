using System;
using System.IO;
using System.Collections.Generic;

namespace AppWorkWithFile
{
    /// <summary>
    /// Exercicios de fixação - C#
    /// Objetivo: Entender o funcionamento das classes:
    ///   -- FileInfo | File
    ///   -- StreamWriter | StreamReader | Using
    /// </summary>

    class Program
    {
        #region Métodos de estudo

        public static void trabalhandoComFileInfo() 
        {
            string sourcePath = @"C:\Temp\File1.txt";
            string targetPath = @"C:\Temp\File2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }

        public static void trabalhandoComStream() 
        {
            string Path = @"C:\Temp\File1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(Path, FileMode.Open);
                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }

                if (fs != null)
                {
                    fs.Close();
                }
            }
        }

        public static void trabalhandoComStreamResumido() 
        {
            string Path = @"C:\Temp\File1.txt";
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(Path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }

        public static void trabalhandoComUsing() 
        {
            string Path = @"C:\Temp\File1.txt";
            try
            {
                using (FileStream fs = new FileStream(Path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }

        public static void trabalhandoComUsingResumido() 
        {
            string Path = @"C:\Temp\File1.txt";
            try
            {
                using (StreamReader sr = File.OpenText(Path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }

        public static void trabalhandocomStreaWriter() 
        {
            string sourcePath = @"C:\Temp\File1.txt";
            string targetPath = @"C:\Temp\File2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
                

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }

        public static void listarDiretorios()
        {
            string Path = @"C:\Temp\MyFoder"; 
            try
            {
             IEnumerable<string> folders =  Directory.EnumerateDirectories(Path,"*.*",SearchOption.AllDirectories);
                Console.WriteLine("Folders: ");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }

        public static void listarArquivos() 
        {
            string Path = @"C:\Temp\MyFoder";
            try
            {
                IEnumerable<string> files = Directory.EnumerateFiles(Path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files: ");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }

        public static void criarDiretorio() 
        {
            string Path = @"C:\Temp\MyFoder";
            try
            {
                Directory.CreateDirectory(Path + @"\NewFolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }

        public static void TrabalhandoComPath() 
        {
            string path = @"C:\Temp\MyFoder\File1.txt";
            try
            {
                Console.WriteLine("PathSeparator: " + Path.PathSeparator);
                Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
                Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
                Console.WriteLine("GetFileName: " + Path.GetFileName(path));
                Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
                Console.WriteLine("GetExtension: " + Path.GetExtension(path));
                Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
                Console.WriteLine("GetFullPath: " + Path.GetTempPath());
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }

        #endregion

        static void Main(string[] args)
        {
            //Descomentar os métodos caso queria realizar os testes.

            #region Chamadas dos métodos

            //trabalhandoComFileInfo();
            //trabalhandoComStream();
            //trabalhandoComStreamResumido();
            //trabalhandoComUsing();
            //trabalhandoComUsingResumido();
            //trabalhandocomStreaWriter();
            //listarDiretorios();
            //listarArquivos();
            //criarDiretorio();
            //TrabalhandoComPath();
            
            #endregion
        }
    }
}
