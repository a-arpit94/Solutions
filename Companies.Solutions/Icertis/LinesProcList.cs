using Common.Setup;
using System;
using System.Collections.Generic;
using System.Data;

namespace Companies.Solutions.Icertis
{
    public class LinesProcList : IOperation
    {
        public void Execute(DataTypes dataTypes)
        {
            IEnumerable<string> lines = new List<string>()
            {
                "Mail Server, Authentication Library, v6",
                "Video Call Server, Authentication Library, v7",
                "Mail Server, Data Storage Library, v10",
                "Chat Server, Data Storage Library, v11",
                "Mail Server, Search Library, v6",
                "Chat Server, Authentication Library, v8",
                "Chat Server, Search Library, v7",
                "Video Call Server, Data Storage Library, v10",
                "Video Call Server, Video Compression Library, v3"
            };

            //foreach (var i in processData(lines))
            //{
            //    Console.WriteLine(i);
            //}


            try
            {
                f3();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static List<String> processData(IEnumerable<string> lines)
        {
            if(lines == null)
                return new List<string>();

            var latestLibraryVersion = new Dictionary<string, int>();

            foreach (var line in lines)
            {
                var detail = line.Split(',');

                var library = detail[1].Trim();

                var version = int.Parse(detail[2].Trim().Substring(1));

                if (!latestLibraryVersion.ContainsKey(library))
                    latestLibraryVersion[library] = version;

                else if (latestLibraryVersion[library] < version)
                    latestLibraryVersion[library] = version;

            }

            var retVal = new List<String>();

            foreach (var line in lines)
            {
                var detail = line.Split(',');

                var product = detail[0].Trim();

                var library = detail[1].Trim();

                var version = int.Parse(detail[2].Trim().Substring(1));

                if (latestLibraryVersion[library] == version)
                {
                    if (!retVal.Contains(product))
                        retVal.Add(product);
                }

            }

            return retVal;
        }

        static void f1(out String s1, ref String s2)
        {
            s1 = "0";
            s2 += "0";
        }
        static String f2()
        {
            string s1 = "42", s2 = "43";
            f1(out s1, ref s2);
            return s1 + s2;
        }

        static string f3()
        {
            try
            {
                throw new ArgumentNullException();
            }
            catch (ArgumentNullException exception)
            {
                throw new ArgumentNullException();
            }
            finally
            {
                Console.WriteLine("Hello Amit");
            }
        }
    }

}