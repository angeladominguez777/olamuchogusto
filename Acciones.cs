using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace olamuchogusto
{
    internal class Acciones
    {
        private List<Alumno> alumnoList = new List<Alumno>
        {
           new Alumno("Angela", 20, "LADD", 113149, DateTime.Today)
        };

        public List<Alumno> Mostrar()
        {
            return alumnoList;
        }
        public bool ExportaraExcel()
        {
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "Alumnos.xlsx");

                // Crear un nuevo libro de trabajo de Excel
                using (var workbook = new XLWorkbook())
                {
                    // Agregar una hoja de trabajo
                    var worksheet = workbook.Worksheets.Add("Alumnos");

                    // Definir los encabezados de las columnas
                    worksheet.Cell(1, 1).Value = "Nombre";
                    worksheet.Cell(1, 2).Value = "Edad";
                    worksheet.Cell(1, 3).Value = "Carrera";
                    worksheet.Cell(1, 4).Value = "Matrícula";
                    worksheet.Cell(1, 5).Value = "Fecha de nacimiento";

                    // Llenar los datos de la lista de alumnos
                    for (int i = 0; i < alumnoList.Count; i++)
                    {
                        var alumno = alumnoList[i];
                        worksheet.Cell(i + 2, 1).Value = alumno.Nombre;
                        worksheet.Cell(i + 2, 2).Value = alumno.Edad;
                        worksheet.Cell(i + 2, 3).Value = alumno.Carrera;
                        worksheet.Cell(i + 2, 4).Value = alumno.Matricula;
                        worksheet.Cell(i + 2, 5).Value = alumno.Fechanacimiento.ToShortDateString();
                    }

                    workbook.SaveAs(filePath);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
