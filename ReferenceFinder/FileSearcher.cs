using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceFinder
{
    class FileSearcher
    {
        String fileToSearch;
        String path;

        public FileSearcher(String fts, String folder, int edit = 0)
        {
            this.fileToSearch = fts;
            this.path = "C:\\SVN\\" + folder + "\\dbo." + fts + ".StoredProcedure.sql"; 
            
        }

        public int[] SearchFile() {

            int[] toReturn = new int[2];
            String line;

            toReturn[0] = -1;
            toReturn[1] = -1;
            try
            {
                StreamReader fs = new StreamReader(this.path);
                int afterFromBeforeWhere = 0;
                while ((line = fs.ReadLine()) != null)
                {
                    /* LIVE CODE */
                    if (line.ToUpper().IndexOf("FROM") > -1 &&
                            line.ToUpper().IndexOf("SHIPFROM") < 0)
                    {
                        afterFromBeforeWhere = 1;
                        if (line.ToUpper().IndexOf("AWCSERVER3") > -1 &&
                            line.ToUpper().IndexOf("--") < 0) {
                            toReturn[0] = 1;
                        }
                        else {
                            if (toReturn[0] < 0) {
                                toReturn[0] = 0;
                            }
                        }
                    }
                    else if (afterFromBeforeWhere == 1 &&
                        line.ToUpper().IndexOf("AWCSERVER3") > -1 &&
                                line.ToUpper().IndexOf("--") < 0)
                    {
                        toReturn[0] = 1;
                    }
                    else if (line.ToUpper().IndexOf("WHERE") > -1) { afterFromBeforeWhere = 0; }
                    else
                    {
                        if (toReturn[0] < 0)
                        {
                            toReturn[0] = 0;
                        }
                    }

                    if (line.ToUpper().IndexOf("EXEC") > -1) {
                        if (line.ToUpper().IndexOf("GRANT") < 0) { toReturn[1] = 1; }
                        else {
                            if (toReturn[1] < 0) { toReturn[1] = 0; }
                        }
                    }
                    else {
                        if (toReturn[1] < 0) {
                            toReturn[1] = 0;
                        }
                    }
                }

                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine
               ("Catching the {0} exception triggers the finally block.",
               ex.GetType());
            }
            finally
            {
                if (toReturn[0] == -1)
                {
                    toReturn[0] = 9;
                }

                if (toReturn[1] == -1)
                {
                    toReturn[1] = 9;
                }
                // Suspend the screen.
                Console.ReadLine();
            }
            
            return toReturn;
        }

        public int[] SearchFile(int editFile)
        {

            int[] toReturn = new int[2];
            String line;

            /*
             * 0 - USE ____ GO 
             * 1 - DROP
             * 2 - GRANT
             * 
             * Values:
             *   0: found
             *   > 0: index of where it should be inserted
             */
            toReturn[0] = -1;
            toReturn[1] = -1;
            toReturn[2] = -1;
            try
            {
                StreamReader fs = new StreamReader(this.path);
                int afterFromBeforeWhere = 0;
                while ((line = fs.ReadLine()) != null)
                {
                    /* LIVE CODE */
                    if (line.ToUpper().IndexOf("USE") > -1 &&
                            line.ToUpper().IndexOf("SHIPFROM") < 0)
                    {
                        afterFromBeforeWhere = 1;
                        if (line.ToUpper().IndexOf("PRODUCT") > -1 &&
                            line.ToUpper().IndexOf("--") < 0)
                        {
                            toReturn[0] = 1;
                        }
                        else
                        {
                            if (toReturn[0] < 0)
                            {
                                toReturn[0] = 0;
                            }
                        }
                    }
                    else if (afterFromBeforeWhere == 1 &&
                        line.ToUpper().IndexOf("PRODUCT") > -1 &&
                                line.ToUpper().IndexOf("--") < 0)
                    {
                        toReturn[0] = 1;
                    }
                    else if (line.ToUpper().IndexOf("WHERE") > -1) { afterFromBeforeWhere = 0; }
                    else
                    {
                        if (toReturn[0] < 0)
                        {
                            toReturn[0] = 0;
                        }
                    }

                    if (line.ToUpper().IndexOf("EXEC") > -1)
                    {
                        if (line.ToUpper().IndexOf("GRANT") < 0) { toReturn[1] = 1; }
                        else
                        {
                            if (toReturn[1] < 0) { toReturn[1] = 0; }
                        }
                    }
                    else
                    {
                        if (toReturn[1] < 0)
                        {
                            toReturn[1] = 0;
                        }
                    }
                }

                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine
               ("Catching the {0} exception triggers the finally block.",
               ex.GetType());
            }
            finally
            {
                if (toReturn[0] == -1)
                {
                    toReturn[0] = 9;
                }

                if (toReturn[1] == -1)
                {
                    toReturn[1] = 9;
                }
                // Suspend the screen.
                Console.ReadLine();
            }

            return toReturn;
        }
    }
}
