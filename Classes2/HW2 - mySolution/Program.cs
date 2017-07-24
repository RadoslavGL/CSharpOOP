using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2___mySolution
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Point3D point3D = new Point3D(1, 2, 3);
            //Console.WriteLine(point3D);

            //PlayWithPaths();

            GenericList<int> list = new GenericList<int>(4);
            list.Add(12);
            list.Add(2);
            list.Add(3);
            list.Add(5);


            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        public static void PlayWithPaths()
        {
            Point3D point = new Point3D(1, 2, 4);
            Point3D point2 = new Point3D(5, 10, 15);
            Point3D point3 = new Point3D(15, 20, 25);

            Path path = new Path(new List<Point3D>() { point, point2, point3 });

            PathStorage.SavePath(path, @"C:\Users\RadoG\Desktop\testSave.txt");

            Path pathLoaded = PathStorage.LoadPath(@"C:\Users\RadoG\Desktop\testSave.txt");
            foreach (Point3D pathPoint in pathLoaded.Points)
            {
                Console.WriteLine(pathPoint);
            }
        }
    }
}
