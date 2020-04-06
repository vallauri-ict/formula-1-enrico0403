using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormulaOneDll;

namespace FormulaOneBatchConsoleProject
{
    class Program
    {
        static DbTools db = new DbTools();

        static void Main(string[] args)
        {
            char scelta = ' ';
            do
            {
                Console.WriteLine("\n*** FORMULA ONE - BATCH SCRIPTS ***\n");
                Console.WriteLine("1 - CREATE Countries");
                Console.WriteLine("2 - CREATE Teams");
                Console.WriteLine("3 - CREATE Drivers");
                Console.WriteLine("------------------");
                Console.WriteLine("A - DROP Countries");
                Console.WriteLine("B - DROP Teams");
                Console.WriteLine("C - DROP Drivers");
                Console.WriteLine("------------------");
                Console.WriteLine("R - RESET DB");
                Console.WriteLine("------------------");
                Console.WriteLine("X - EXIT\n");
                scelta = Console.ReadKey(true).KeyChar;
                switch (scelta)
                {
                    case '1':
                        callExecuteSqlScript("Countries");
                        break;
                    case '2':
                        callExecuteSqlScript("Teams");
                        break;
                    case '3':
                        callExecuteSqlScript("Drivers");
                        break;
                    case 'A':
                        callDropTable("Countries");
                        break;
                    case 'B':
                        callDropTable("Teams");
                        break;
                    case 'C':
                        callDropTable("Drivers");
                        break;
                    case 'R':
                        resetDb();
                        break;
                    default:
                        if (scelta != 'X' && scelta != 'x') Console.WriteLine("\nUncorrect Choice - Try Again\n");
                        break;
                }
            } while (scelta != 'X' && scelta != 'x');
        }

        static bool callExecuteSqlScript(string scriptName)
        {
            try
            {
                db.ExecuteSqlScript(scriptName + ".sql");
                Console.WriteLine("\n" + scriptName + " - SUCCESS\n");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n" + scriptName + " - ERROR: " + ex.Message + "\n");
                return false;
            }
        }

        static bool callDropTable(string tableName)
        {
            try
            {
                db.DropTable(tableName);
                Console.WriteLine("\nDROP " + tableName + " - SUCCESS\n");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nDROP " + tableName + " - ERROR: " + ex.Message + "\n");
                return false;
            }
        }

        static void resetDb()
        {
            Console.Write("WARNING!!! This script will completely destroy and recreate the DB! Are you sure (s/n)? ");
            char answer = Console.ReadKey().KeyChar;
            if (answer == 's' || answer=='S')
            {
                try
                {
                    bool isOk;
                    isOk = callDropTable("Teams");
                    if (isOk) isOk = callDropTable("Drivers");
                    if (isOk) isOk = callDropTable("Countries");
                    if (isOk) isOk = callExecuteSqlScript("Countries");
                    if (isOk) isOk = callExecuteSqlScript("Drivers");
                    if (isOk) isOk = callExecuteSqlScript("Teams");
                    if (isOk) isOk = callExecuteSqlScript("SetConstraints");
                    if (isOk) Console.WriteLine("DB correctly resetted!");
                    else throw new Exception();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SORRY: something went wrong!");
                    Console.WriteLine(ex.Message);
                }
            }
        }

    }
}
