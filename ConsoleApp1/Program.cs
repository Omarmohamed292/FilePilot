using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var comm=""; var path="";
                var SourcePath = ""; var DestPath="";
                Console.Write(Directory.GetCurrentDirectory());
                Console.WriteLine(">>>");
                var complete_comm = Console.ReadLine().Trim();
                if (string.IsNullOrWhiteSpace(complete_comm)) continue;
                int FirestSpaceIndex = complete_comm.IndexOf(' ');
               
                if (FirestSpaceIndex == -1)
                {
                    comm = complete_comm;
                    path = "";
                }
                else
                {
                    comm = complete_comm.Substring(0, FirestSpaceIndex);
                    path = complete_comm.Substring(FirestSpaceIndex + 1).Trim();
                }
                if (path.Contains("|"))
                {
                    int dashIndx = path.IndexOf("|");
                    SourcePath = path.Substring(0, dashIndx).Trim();
                    DestPath = path.Substring(dashIndx + 1).Trim();
                }
                if (string.IsNullOrWhiteSpace(path)) path=Directory.GetCurrentDirectory();

                switch (comm)
                {
                    case "list":
                        foreach (var dir in Directory.GetDirectories(path))
                        {
                            Console.WriteLine($" dir {dir}");
                        }
                        foreach (var file in Directory.GetFiles(path))
                        {
                            Console.WriteLine($" File {file}");
                        }
                        break;
                    case "info":
                        if (Directory.Exists(path))
                        {
                        var dirinfo=new DirectoryInfo(path);
                            Console.WriteLine("type Directory");
                            Console.WriteLine($"created at {dirinfo.CreationTime}");
                            Console.WriteLine($"last modified at {dirinfo.LastWriteTime}");
                        }
                        if (File.Exists(path))
                        {
                            var fileinfo = new FileInfo(path);
                            Console.WriteLine("type File");
                            Console.WriteLine($"created at {fileinfo.CreationTime}");
                            Console.WriteLine($"last modified at {fileinfo.LastWriteTime}");

                            Console.WriteLine($" size is {fileinfo.Length}");
                        }
                        break;
                    case "remove":
                        if (Directory.Exists(path))
                        {
                            Directory.Delete(path);

                        }
                        if (File.Exists(path))
                        {
                            File.Delete(path); 
                        }
                        break;
                    case "read":
                        if (File.Exists(path))
                        {
                           var content= File.ReadAllText(path);
                            Console.WriteLine(content);
                        }
                        break;
                    case "mkdir":
                             Directory.CreateDirectory(path);
                        break;
                    case"mkfile":
                        if (!File.Exists(path))
                        {
                            using (File.Create(path)) { }

                        }
                        else { Console.WriteLine("file olready exist"); }
                            break;
                    case "write":
                        if (File.Exists(path))
                        {
                            Console.WriteLine("enter text");
                            String text=Console.ReadLine();
                            File.AppendAllText(path, text+Environment.NewLine); 
                        }
                        break;
                    case "cd":
                        if(Directory.Exists(path)) Directory.SetCurrentDirectory(path);
                        break;
                    case "copy":
                        if (!path.Contains('|'))
                        {
                            Console.WriteLine("use copy source|destination");
                            break;
                        }
                        if (File.Exists(DestPath))
                        {
                            Console.WriteLine("Destination file olready exist");
                            break ;
                        }
                        try
                        {
                            if (File.Exists(SourcePath))
                            {
                                File.Copy(SourcePath, DestPath);
                                Console.WriteLine("copied done");
                                break;
                            }
                        }
                        catch (Exception e){ Console.WriteLine(e); }
                        break;
                    case "move":
                        if (!path.Contains('|'))
                        {
                            Console.WriteLine("use move source|destination");
                            break;
                        }
                        if (File.Exists(DestPath))
                        {
                            Console.WriteLine("Destination file olready exist");
                            break ;
                        }
                        try
                        {
                            if (File.Exists(SourcePath))
                            {
                                File.Move(SourcePath, DestPath);
                                Console.WriteLine("moved done");
                                break;
                            }
                        }
                        catch (Exception e) { Console.WriteLine(e); }
                        break;

                    case "stop":return;
                }
            }

        }
    }
}
