namespace FiyiStackDeskApp.Generators.G1.Modules.CSharp
{
    public static partial class CSharp
    {
        public static string ExportationService(G1ConfigurationComponent GeneratorConfigurationComponent, Areas.FiyiStackDeskApp.TableBack.Entities.Table Table)
        {
            try
            {
                GeneratorConfigurationComponent.G1FieldChainer.iForImportInService = 7;

                string Content =
                $@"using ClosedXML.Excel;
using IronPdf;
using CsvHelper;
using {GeneratorConfigurationComponent.ChosenProject.Name}.Areas.{Table.Area}.{Table.Name}Back.Entities;
using {GeneratorConfigurationComponent.ChosenProject.Name}.Areas.{Table.Area}.{Table.Name}Back.Interfaces;
using System.Data;
using System.Globalization;

namespace {GeneratorConfigurationComponent.ChosenProject.Name}.Areas.{Table.Area}.{Table.Name}Back.Services
{{
    public class {Table.Name}ExportationService : I{Table.Name}ExportationService
    {{
        public void ExportToExcel(string path, DataTable dataTable{Table.Name})
        {{
            using XLWorkbook XLWorkbook = new();

            DataTable DataTable{Table.Name}Original = new()
            {{
                TableName = ""{Table.Name}""
            }};

            //We define another DataTable DataTable{Table.Name}Copy to avoid issue related to DateTime conversion
            DataTable DataTable{Table.Name}Copy = new()
            {{
                TableName = ""{Table.Name}""
            }};

            #region Define columns for DataTable{Table.Name}Copy
            {GeneratorConfigurationComponent.G1FieldChainer.Properties_ForExcel_Converter_DefineDataColumns}
            #endregion

            DataTable{Table.Name}Original = dataTable{Table.Name};

            foreach (DataRow DataRow in DataTable{Table.Name}Original.Rows)
            {{
                DataTable{Table.Name}Copy.Rows.Add(DataRow.ItemArray);
            }}

            IXLWorksheet XLWorksheet = XLWorkbook.Worksheets.Add(DataTable{Table.Name}Copy);

            XLWorksheet.ColumnsUsed().AdjustToContents();

            XLWorkbook.SaveAs(path);
        }}

        public void ExportToCSV(string path, List<{Table.Name}> List{Table.Name})
        {{
            StreamWriter StreamWriter = new(path);

            using CsvWriter CsvWriter = new(StreamWriter, CultureInfo.InvariantCulture);

            CsvWriter.WriteRecords(List{Table.Name});
        }}

        public void ExportToPDF(string path, List<{Table.Name}> List{Table.Name})
        {{
            string ProjectName = ""{GeneratorConfigurationComponent.ChosenProject.Name}"";

            string Table = ""{Table.Name}"";

            ChromePdfRenderer ChromePdfRenderer = new();

            string RowsAsHTML = """";

            foreach ({Table.Name}? {Table.Name} in List{Table.Name})
            {{
                RowsAsHTML += $@""
<tr>
    {GeneratorConfigurationComponent.G1FieldChainer.PropertiesInHTML_TD_ForExportationService}
</tr>"";
            }}

            string FullHTMLContent = $@""
<table cellpadding=""""0"""" cellspacing=""""0"""" border=""""0"""" width=""""88%"""" style=""""width: 88% !important; min-width: 88%; max-width: 88%;"""">
    <tr>
    <td align=""""left"""" valign=""""top"""">
        <font face=""""'Source Sans Pro', sans-serif"""" color=""""#1a1a1a"""" style=""""font-size: 52px; line-height: 55px; font-weight: 300; letter-spacing: -1.5px;"""">
            <span style=""""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #1a1a1a; font-size: 52px; line-height: 55px; font-weight: 300; letter-spacing: -1.5px;"""">{{ProjectName}}</span>
        </font>
        <div style=""""height: 25px; line-height: 25px; font-size: 23px;"""">&nbsp;</div>
        <font face=""""'Source Sans Pro', sans-serif"""" color=""""#4c4c4c"""" style=""""font-size: 36px; line-height: 45px; font-weight: 300; letter-spacing: -1px;"""">
            <span style=""""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #4c4c4c; font-size: 36px; line-height: 45px; font-weight: 300; letter-spacing: -1px;"""">Registers of {{Table}}</span>
        </font>
        <div style=""""height: 35px; line-height: 35px; font-size: 33px;"""">&nbsp;</div>
    </td>
    </tr>
</table>
<br>
<table cellpadding=""""0"""" cellspacing=""""0"""" border=""""0"""" width=""""100%"""" style=""""width: 100% !important; min-width: 100%; max-width: 100%;"""">
    <tr>
        {GeneratorConfigurationComponent.G1FieldChainer.PropertiesInHTML_TH_ForExportationService}
    </tr>
    {{RowsAsHTML}}
</table>
<br>
<font face=""""'Source Sans Pro', sans-serif"""" color=""""#868686"""" style=""""font-size: 17px; line-height: 20px;"""">
    <span style=""""font-family: 'Source Sans Pro', Arial, Tahoma, Geneva, sans-serif; color: #868686; font-size: 17px; line-height: 20px;"""">Printed on: {{DateTime.Now}}</span>
</font>
"";

            ChromePdfRenderer.RenderHtmlAsPdf(FullHTMLContent).SaveAs(path);
        }}
    }}
}}";

                return Content;
            }
            catch (Exception) { throw; }
        }
    }
}
