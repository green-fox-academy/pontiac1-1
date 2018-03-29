using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Shapes;
using System.Windows.Media;

namespace Sudoku.Model
{
    class Evaluate
    {
        public static void ToEvaluate(System.Windows.Controls.Primitives.UniformGrid board)
        {

            //checking columns
            int columnCheck = 0;
            for (int i = 0; i < 9; i++)
            {
                var columnValues = new List<int>();

                for (int j = 0; j < 9; j++)
                {
                    columnValues.Add(Values.lvlValues[i + j * 9]);
                }

                var checkColumn = columnValues.Distinct();
                if (checkColumn.Count() != 9)
                {
                    break;
                }
                else
                {
                    columnCheck++;
                }
            }

            //check for columns
            int rowCheck = 0;
            for (int i = 0; i == 72; i+=9)
            {
                var rowValues = new List<int>();

                for (int j = 0; j < 9; j++)
                {
                    rowValues.Add(Values.lvlValues[i + j]);
                }

                var checkRow = rowValues.Distinct();
                if (checkRow.Count() != 9)
                {
                    break;
                }
                else
                {
                    rowCheck++;
                }
            }

            //check for tables
            //table1
            int tableCheck1 = 0;
            var table1 = new List<int>();
            table1.Add(Values.lvlValues[0]);
            table1.Add(Values.lvlValues[1]);
            table1.Add(Values.lvlValues[2]);
            table1.Add(Values.lvlValues[9]);
            table1.Add(Values.lvlValues[10]);
            table1.Add(Values.lvlValues[11]);
            table1.Add(Values.lvlValues[18]);
            table1.Add(Values.lvlValues[19]);
            table1.Add(Values.lvlValues[20]);

            var CheckTable = table1.Distinct();
            if (CheckTable.Count() != 9)
            {
                
            }
            else
            {
                tableCheck1++;
            }

            //table2
            int tableCheck2 = 0;
            var table2 = new List<int>();
            table2.Add(Values.lvlValues[3]);
            table2.Add(Values.lvlValues[4]);
            table2.Add(Values.lvlValues[5]);
            table2.Add(Values.lvlValues[12]);
            table2.Add(Values.lvlValues[13]);
            table2.Add(Values.lvlValues[14]);
            table2.Add(Values.lvlValues[21]);
            table2.Add(Values.lvlValues[22]);
            table2.Add(Values.lvlValues[23]);

            var CheckTable2 = table2.Distinct();
            if (CheckTable2.Count() != 9)
            {

            }
            else
            {
                tableCheck2++;
            }

            //table3
            int tableCheck3 = 0;
            var table3 = new List<int>();
            table3.Add(Values.lvlValues[6]);
            table3.Add(Values.lvlValues[7]);
            table3.Add(Values.lvlValues[8]);
            table3.Add(Values.lvlValues[15]);
            table3.Add(Values.lvlValues[16]);
            table3.Add(Values.lvlValues[17]);
            table3.Add(Values.lvlValues[24]);
            table3.Add(Values.lvlValues[25]);
            table3.Add(Values.lvlValues[26]);

            var CheckTable3 = table3.Distinct();
            if (CheckTable3.Count() != 9)
            {

            }
            else
            {
                tableCheck3++;
            }

            //table4
            int tableCheck4 = 0;
            var table4 = new List<int>();
            table4.Add(Values.lvlValues[27]);
            table4.Add(Values.lvlValues[28]);
            table4.Add(Values.lvlValues[29]);
            table4.Add(Values.lvlValues[36]);
            table4.Add(Values.lvlValues[37]);
            table4.Add(Values.lvlValues[38]);
            table4.Add(Values.lvlValues[45]);
            table4.Add(Values.lvlValues[46]);
            table4.Add(Values.lvlValues[47]);

            var CheckTable4 = table4.Distinct();
            if (CheckTable4.Count() != 9)
            {

            }
            else
            {
                tableCheck4++;
            }

            //table5
            int tableCheck5 = 0;
            var table5 = new List<int>();
            table5.Add(Values.lvlValues[30]);
            table5.Add(Values.lvlValues[31]);
            table5.Add(Values.lvlValues[32]);
            table5.Add(Values.lvlValues[39]);
            table5.Add(Values.lvlValues[40]);
            table5.Add(Values.lvlValues[41]);
            table5.Add(Values.lvlValues[48]);
            table5.Add(Values.lvlValues[49]);
            table5.Add(Values.lvlValues[50]);

            var CheckTable5 = table5.Distinct();
            if (CheckTable5.Count() != 9)
            {

            }
            else
            {
                tableCheck5++;
            }

            //table6
            int tableCheck6 = 0;
            var table6 = new List<int>();
            table6.Add(Values.lvlValues[33]);
            table6.Add(Values.lvlValues[34]);
            table6.Add(Values.lvlValues[35]);
            table6.Add(Values.lvlValues[42]);
            table6.Add(Values.lvlValues[43]);
            table6.Add(Values.lvlValues[44]);
            table6.Add(Values.lvlValues[51]);
            table6.Add(Values.lvlValues[52]);
            table6.Add(Values.lvlValues[53]);

            var CheckTable6 = table6.Distinct();
            if (CheckTable6.Count() != 9)
            {

            }
            else
            {
                tableCheck6++;
            }

            //table7
            int tableCheck7 = 0;
            var table7 = new List<int>();
            table7.Add(Values.lvlValues[54]);
            table7.Add(Values.lvlValues[55]);
            table7.Add(Values.lvlValues[56]);
            table7.Add(Values.lvlValues[63]);
            table7.Add(Values.lvlValues[64]);
            table7.Add(Values.lvlValues[65]);
            table7.Add(Values.lvlValues[72]);
            table7.Add(Values.lvlValues[73]);
            table7.Add(Values.lvlValues[74]);

            var CheckTable7 = table7.Distinct();
            if (CheckTable7.Count() != 9)
            {

            }
            else
            {
                tableCheck7++;
            }

            //table8
            int tableCheck8 = 0;
            var table8 = new List<int>();
            table8.Add(Values.lvlValues[57]);
            table8.Add(Values.lvlValues[58]);
            table8.Add(Values.lvlValues[59]);
            table8.Add(Values.lvlValues[66]);
            table8.Add(Values.lvlValues[67]);
            table8.Add(Values.lvlValues[68]);
            table8.Add(Values.lvlValues[75]);
            table8.Add(Values.lvlValues[76]);
            table8.Add(Values.lvlValues[77]);

            var CheckTable8 = table8.Distinct();
            if (CheckTable8.Count() != 9)
            {

            }
            else
            {
                tableCheck8++;
            }

            //table9
            int tableCheck9 = 0;
            var table9 = new List<int>();
            table9.Add(Values.lvlValues[60]);
            table9.Add(Values.lvlValues[61]);
            table9.Add(Values.lvlValues[62]);
            table9.Add(Values.lvlValues[69]);
            table9.Add(Values.lvlValues[70]);
            table9.Add(Values.lvlValues[71]);
            table9.Add(Values.lvlValues[78]);
            table9.Add(Values.lvlValues[79]);
            table9.Add(Values.lvlValues[80]);

            var CheckTable9 = table9.Distinct();
            if (CheckTable9.Count() != 9)
            {

            }
            else
            {
                tableCheck9++;
            }


            //
            int totalcheck = rowCheck + tableCheck1 + tableCheck2 + tableCheck3 + tableCheck4 + tableCheck5 + tableCheck5 + tableCheck6 + tableCheck7 + tableCheck8 + tableCheck9;

            if (totalcheck == 27)
            {
                var indicator = new Rectangle();
                indicator.Fill = Brushes.Green;
                board.Children.Clear();
                board.Children.Add(indicator);
            }
            else
            {
                var indicator = new Rectangle();
                indicator.Fill = Brushes.Red;
                board.Children.Clear();
                board.Children.Add(indicator);
            }
        }
    }
}
