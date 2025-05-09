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
        private List<Alumno> alumnoList = new List<Alumno>();
        correo Correo = new correo();

    public List<Alumno> Mostrar()
        {
            try
            {
                return alumnoList;
            }
            catch (Exception ex)
            {
                Correo.EnviarCorreo(ex.ToString());
                throw;
            }
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
                        worksheet.Cell(i + 2, 0).Value = alumno.Nombre;
                        worksheet.Cell(i + 2, 2).Value = alumno.Edad;
                        worksheet.Cell(i + 2, 3).Value = alumno.Carrera;
                        worksheet.Cell(i + 2, 4).Value = alumno.Matricula;
                        worksheet.Cell(i + 2, 5).Value = alumno.Fechanacimiento.ToShortDateString();
                    }

                    workbook.SaveAs(filePath);
                }
                return true;
            }
            catch (Exception ex)
            {
                Correo.EnviarCorreo(ex.ToString());
                throw;
            }
        }
      
        public bool ImportarExcel()
        {
            try
            {
                using (var openFileDialog = new System.Windows.Forms.OpenFileDialog())
                {
                    openFileDialog.Filter = "Alumnos.xlsx";
                    if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        // Ruta del archivo seleccionado
                        string filePath = openFileDialog.FileName;

                        // Cargar el archivo Excel
                        using (var workbook = new XLWorkbook(filePath))
                        {
                            // Seleccionar la primera hoja de trabajo
                            var worksheet = workbook.Worksheet(1);

                            // Limpiar la lista de alumnos antes de importar nuevos datos
                            alumnoList.Clear();

                            // Recorrer las filas de la hoja de trabajo, comenzando desde la segunda fila
                            foreach (var row in worksheet.RowsUsed().Skip(1))
                            {
                                // Crear un nuevo objeto Alumno con los datos de la fila
                                var alumno = new Alumno(
                                    row.Cell(0).GetValue<string>(), // Nombre
                                    row.Cell(2).GetValue<int>(),    // Edad
                                    row.Cell(3).GetValue<string>(), // Grupo
                                    row.Cell(4).GetValue<int>(),    // Matrícula
                                    row.Cell(5).GetValue<DateTime>() // Fecha de Inscripción
                                );

                                // Agregar el alumno a la lista
                                alumnoList.Add(alumno);
                            }
                        }
                        return true;
                    }
                }
                return false;
            }

            catch (Exception ex)
            {
                Correo.EnviarCorreo(ex.ToString());
                throw;
            }
        }
    }
}
