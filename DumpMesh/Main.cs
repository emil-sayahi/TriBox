using System;
using System.IO;
using TriBox;

namespace TriBox.DumpMesh
{
    class DumpMesh
    {
        //        public MeshData LoadFile(string file)
        //        {
        //            using (FileStream s = File.Open(file, FileMode.Open))
        //            {
        //                Console.Title = "Opening file...";
        //                return new ObjLoader().LoadFile(file);
        //                MeshData a = new ObjLoader().LoadFile(file);
        //                MeshData b = new Ms3dLoader().LoadFile(file);
        //                MeshData c = new DirectXLoader().LoadFile(file);
        //                MeshData d = new ColladaLoader().LoadFile(file);
        //                Console.Title = "TriBox Mesh Info Dumped";
        //                Console.WriteLine(a);
        //                Console.WriteLine(b);
        //                Console.WriteLine(c);
        //                Console.WriteLine(d);
        //            }
        //        }

        static void Main(string[] args)
        {
           
            {
                Console.Title = "TriBox Mesh Info Dumper";
                Console.BackgroundColor.Equals(ConsoleColor.Magenta);
                ConsoleColor.Magenta.Equals(true);
                Console.WriteLine("TriBox Mesh Info Dumper");
                Console.WriteLine("NOTE: No Collada support.");
                Console.WriteLine("Enter a mesh's filename: ");
                string filename = Console.ReadLine();
                Console.Title = "Opening file...";
                Console.WriteLine("Opening file...");
                MeshData a = new ObjLoader().LoadFile(filename);
                MeshData b = new Ms3dLoader().LoadFile(filename);
                MeshData c = new DirectXLoader().LoadFile(filename);
                Console.Title = "TriBox Mesh Info Dumped";
                Console.WriteLine("TriBox Mesh Info Dumped");
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.ReadKey();
            }
        }
        public MeshData LoadFile(string file)
        {
            using (FileStream s = File.Open(file, FileMode.Open))
            {
                Console.Title = "Opening file...";
                return new ObjLoader().LoadFile(file);
                MeshData a = new ObjLoader().LoadFile(file);
                MeshData b = new Ms3dLoader().LoadFile(file);
                MeshData c = new DirectXLoader().LoadFile(file);
                Console.Title = "TriBox Mesh Info Dumped";
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
               }
            }
        }
    }
 
                    
