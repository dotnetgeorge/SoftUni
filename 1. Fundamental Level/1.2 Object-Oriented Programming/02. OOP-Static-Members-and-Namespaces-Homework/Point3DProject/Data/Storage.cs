using System.Linq;

namespace Point3DProject.Data
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    internal static class Storage
    {
        private static readonly string FileName = "Paths.txt";

        /// <summary>
        /// Initializes the <see cref="Storage"/> class.
        /// </summary>
        static Storage()
        {
        }

        /// <summary>
        /// Saves the path.
        /// </summary>
        /// <param name="path">The path.</param>
        public static void SavePath(Path3D path)
        {
            SavePath(path, FileName);
        }

        /// <summary>
        /// Saves the path.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="fileName">Name of the file.</param>
        private static async void SavePath(Path3D path, string fileName)
        {
            try
            {
                var writer = new StreamWriter(fileName);
                var points = new StringBuilder();

                using (writer)
                {
                    for (var i = 0; i < path.Count; i++)
                    {
                        points.AppendFormat("{0} ", path.Point[i]);
                    }

                    var result = points.ToString();

                    await writer.WriteLineAsync(result);
                    points.AppendLine();
                }
            }
            catch (FileLoadException fle)
            {
                Console.WriteLine("File can't load!\nException: {0}", fle.Message);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!");
            }
            catch (AccessViolationException)
            {
                Console.WriteLine("{0} you can't write to protected file!", fileName);
            }
            catch (DriveNotFoundException)
            {
                Console.WriteLine("Drive not found!");
            }
            catch (IOException ioe)
            {
                Console.WriteLine("Exception: {0}", ioe.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }
        }

        /// <summary>
        /// Loads the paths.
        /// </summary>
        /// <returns></returns>
        public static List<Path3D> LoadPaths()
        {
            return LoadPaths(FileName);
        }

        /// <summary>
        /// Loads the paths.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <returns></returns>
        private static List<Path3D> LoadPaths(string fileName)
        {
            var loadPaths = new List<Path3D>();

            try
            {
                var reader = new StreamReader(fileName);
                char[] separator = {' '};

                using (reader)
                {
                    var line = reader.ReadLine();

                    while (line != null)
                    {
                        var path = new Path3D();

                        var points = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);

                        foreach (var point in points.Where(point => point != string.Empty))
                        {
                            var pointX = Convert.ToInt32(point[0] - 48);
                            var pointY = Convert.ToInt32(point[2] - 48);
                            var pointZ = Convert.ToInt32(point[4] - 48);

                            path.Point.Add(new Point3D(pointX, pointY, pointZ));
                        }

                        loadPaths.Add(path);

                        line = reader.ReadLine();
                    }
                }
            }
            catch (FileLoadException fle)
            {
                Console.WriteLine("File can't load!\nException: {0}", fle.Message);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!");
            }
            catch (AccessViolationException)
            {
                Console.WriteLine("{0} you can't read protected file!", fileName);
            }
            catch (DriveNotFoundException)
            {
                Console.WriteLine("Drive not found!");
            }
            catch (IOException ioe)
            {
                Console.WriteLine("I/O Exception: {0}", ioe.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }

            return loadPaths;
        }
    }
}