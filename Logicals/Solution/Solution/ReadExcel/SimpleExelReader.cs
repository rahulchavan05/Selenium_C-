using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using NUnit.Framework;

namespace Logicals.ReadExcel
{
    internal class SimpleExcelReader
    {

        public static IEnumerable<TestCaseData> GetTestCasedata()
        {

            using (var workbook = new XLWorkbook("E:\\Study_Projects\\Test_Data\\Test.xlsx"))
            {
                var worksheet = workbook.Worksheet(1);
                var rows = worksheet.RangeUsed().RowsUsed();

                foreach (var row in rows.Skip(1))
                {
                    yield return new TestCaseData(
                        row.Cell(1).IsEmpty() ? "Null" : row.Cell(1).Value.ToString(),
                        row.Cell(2).IsEmpty() ? "Null" : row.Cell(2).Value.ToString()
                        );
                }
            }

        }

    }
    [TestFixture] 
   
    public class ExcelDrivenTest
    {
        [Test, TestCaseSource(typeof(test), nameof(test.testing2))]

        public void PrintExcelData(String row1,  String row2)
        {
            Console.Write($"Name = {row1}, Age = {row2}");
        }

    }

    public class test
    {

        public static IEnumerable<TestCaseData> testing2()
        {
            using(var workbook = new XLWorkbook("E:\\Study_Projects\\Test_Data\\Test.xlsx"))
            {
                var rows = workbook.Worksheet(1).RangeUsed().RowsUsed();

                foreach(var row in rows.Skip(1))
                {
                    yield return new TestCaseData(
                        row.Cell(1).Value.ToString(),
                        row.Cell(2).Value.ToString()
                        );
                }
            }
        }
    }















    //internal class SimpleExcelReader
    //{
    //    public static IEnumerable<TestCaseData> GetTestCasedata()
    //    {
    //        string filePath = "D:\\Excel\\Test.xlsx";

    //        if (!System.IO.File.Exists(filePath))
    //        {
    //            throw new Exception($"File not found: {filePath}");
    //        }

    //        using (var workbook = new XLWorkbook(filePath))
    //        {
    //            var worksheet = workbook.Worksheet(1);
    //            if (worksheet == null)
    //            {
    //                throw new Exception("Worksheet not found.");
    //            }

    //            var range = worksheet.RangeUsed();
    //            if (range == null)
    //            {
    //                throw new Exception("No data found in the worksheet.");
    //            }

    //            var rows = range.RowsUsed();
    //            foreach (var row in rows.Skip(1))
    //            {
    //                yield return new TestCaseData(
    //                    row.Cell(1).GetString().Trim(),
    //                    row.Cell(2).GetString().Trim()
    //                );
    //            }
    //        }
    //    }
    //}
}
