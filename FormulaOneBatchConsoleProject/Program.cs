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
                Console.WriteLine("1 - Create Countries");
                Console.WriteLine("2 - Create Teams");
                Console.WriteLine("3 - Create Drivers");
                Console.WriteLine("4 - Create Circuits");
                Console.WriteLine("5 - Create Races");
                Console.WriteLine("6 - Create RacesScores");
                Console.WriteLine("7 - Create Scores");
                Console.WriteLine("8 - Set Constraints");
                Console.WriteLine("------------------");
                Console.WriteLine("R - Reset");
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
                    case '4':
                        callExecuteSqlScript("Circuits");
                        break;
                    case '5':
                        callExecuteSqlScript("Races");
                        break;
                    case '6':
                        callExecuteSqlScript("RacesScores");
                        break;
                    case '7':
                        callExecuteSqlScript("Scores");
                        break;
                    case '8':
                        callExecuteSqlScript("SetConstraints");
                        break;
                    case 'R':
                        bool OK;
                        //System.IO.File.Copy(DbTools.WORKINGPATH + "FormulaOne.mdf", DbTools.WORKINGPATH + "Backup.mdf");
                        OK = callDropTable("RacesScores");
                        if (OK) OK=callDropTable("Scores");
                        if (OK) OK = callDropTable("Races");
                        if (OK) OK = callDropTable("Circuits");
                        if (OK) OK = callDropTable("Teams");
                        if (OK) OK = callDropTable("Drivers");
                        if (OK) OK = callDropTable("Countries");
                        if (OK) OK = callExecuteSqlScript("Countries");
                        if (OK) OK = callExecuteSqlScript("Drivers");
                        if (OK) OK = callExecuteSqlScript("Teams");
                        if (OK) OK = callExecuteSqlScript("Circuits");
                        if (OK) OK = callExecuteSqlScript("Races");
                        if (OK) OK = callExecuteSqlScript("Scores");
                        if (OK) OK = callExecuteSqlScript("RacesScores");
                        if (OK) OK = callExecuteSqlScript("SetConstraints");
                        if (OK)
                        {
                            //System.IO.File.Delete(DbTools.WORKINGPATH + "Backup.mdf");
                            Console.WriteLine("OK");
                        }
                        else
                        {
                            //System.IO.File.Copy(DbTools.WORKINGPATH + "Backup.mdf", DbTools.WORKINGPATH + "FormulaOne.mdf", true);
                            //System.IO.File.Delete(DbTools.WORKINGPATH + "Backup.mdf");
                        }
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
                Console.WriteLine("\nCreate " + scriptName + " - SUCCESS\n");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nCreate " + scriptName + " - ERROR: " + ex.Message + "\n");
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

    }
}
