using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace HW2___mySolution
{
    public static class PathStorage
    {
        public static void SavePath(Path path, string fileName)
        {
            using (StreamWriter streamWriter = new StreamWriter(fileName))
            {
                foreach (Point3D point in path.Points)
                {
                    streamWriter.WriteLine(point);
                }
            }
        }

        public static Path LoadPath(string fileName)
        {
            List<Point3D> points = new List<Point3D>();

            using (StreamReader streamReader = new StreamReader(fileName))
            {
                char[] splitCharacters = new char[] { 'X', 'Y', 'Z', ':', ' ', ';' };

                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    int[] pointCoordinates = 
                        line.Split(splitCharacters, StringSplitOptions.RemoveEmptyEntries).
                        Select(int.Parse).ToArray();
                    Point3D point = 
                        new Point3D(pointCoordinates[0], pointCoordinates[1], pointCoordinates[2]);

                    points.Add(point);
                }
            }

            Path result = new Path(points);

            return result;

        }
    }
}
