using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Proyecto
{
    public class Archivo
    {
        //List<string> listaLines = new List<string>();
        //Leer el archivo y llama al metodo agregarFilaDatagridview para que por cada linea del bloc agregue una linea en el datagridview
        public void lecturaArchivo(DataGridView tabla, char caracter, string ruta)
        {
            StreamReader objReader = new StreamReader(ruta);
            string sLine = "";
            int fila = 0;
            tabla.Rows.Clear();
            tabla.AllowUserToAddRows = false;

            do
            {
                sLine = objReader.ReadLine();
                if ((sLine != null))
                {
                    if (fila == 0)
                    {
                        tabla.ColumnCount = sLine.Split(caracter).Length;
                        nombrarTitulo(tabla, sLine.Split(caracter));
                        fila += 1;
                    }
                    else
                    {
                        agregarFilaDatagridview(tabla, sLine, caracter);
                        fila += 1;
                    }
                }
            } 
            
            while (!(sLine == null));
            objReader.Close();
        }
        //Agregar el HeaderText al datagridview(SON LOS TITULOS)
        public static void nombrarTitulo(DataGridView tabla, string[] titulos)
        {
            int x = 0;
            for (x = 0; x <= tabla.ColumnCount - 1; x++)
            {
                tabla.Columns[x].HeaderText= titulos[x];
            }
        }
        //Agrega una fila por cada linea de Bloc de notas
        public static void agregarFilaDatagridview(DataGridView tabla, string linea,char caracter)
        {
            string[] arreglo = linea.Split(caracter);
            tabla.Rows.Add(arreglo);
        }

        public void escribirArchivo(string ruta, List<string> listaFilas)
        {
            //Borra fichero para volver a empezar
            if (File.Exists(ruta))
            {
                File.Delete(ruta);
                File.WriteAllLines(ruta, listaFilas);
                MessageBox.Show("Archivo guardado con éxito", "Archivo guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void escribirArchivoComo(string ruta, List<string> listaFilas)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "";
            save.Filter = "Text File | *.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());
                for (int i = 0; i < listaFilas.Count; i++)
                {
                    writer.WriteLine(listaFilas[i].ToString());
                }
                writer.Dispose();
                writer.Close();
                MessageBox.Show("Archivo guardado con éxito", "Nuevo archivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
