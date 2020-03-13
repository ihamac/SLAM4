using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeFichier
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader a = new StreamReader(@"P:\ihamac\SLAM4\GestionDeFichier\GestionDeFichier\bin\Debug\etudiant.csv");

            LectureCSV(a);

        }

        static void LectureCSV(StreamReader sr)
        {
            int pas = 0;
            string ligne;
            Char virgule = ';';

            sr = new StreamReader(@"P:\ihamac\SLAM4\GestionDeFichier\GestionDeFichier\bin\Debug\etudiant.csv");
            while ((ligne = sr.ReadLine()) != null)
            {
                String[] tab = ligne.Split(virgule);

                foreach(var tab1 in tab)
                {
                    Console.WriteLine(tab1);
                }
                pas = pas + 1;
            }
            sr.Close();
            Console.ReadLine();

        }

            }
        
        }
    

    

