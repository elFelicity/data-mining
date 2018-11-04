using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace Proyecto
{
    public partial class PrincipalForm : Form
    {
        bool band1 = false;
        bool band2 = false;
        Archivo l = new Archivo();
        public string ruta = "";
        int posC = 0;
        int posR = 0;

        public PrincipalForm()
        {
            InitializeComponent();
        }

        /*private void nuevoNombreToolStripTextBox_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nuevoNombreToolStripTextBox.Text) && !string.IsNullOrWhiteSpace(nuevoNombreToolStripTextBox.Text))
            {
                datosDataGridView.Columns[0].HeaderText = nuevoNombreToolStripTextBox.ToString();
            }
        }*/

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(300, 300);
            cargarArchivoButton.BringToFront();
            cargarArchivoButton.Location = new Point(90, 95);
        }

        private void abrirArchivoButton_Click(object sender, EventArgs e)
        {
            this.openFileDialog.ShowDialog();
            if (!string.IsNullOrEmpty(this.openFileDialog.FileName))
            {
                ruta = this.openFileDialog.FileName;
                l.lecturaArchivo(datosDataGridView, ',', ruta);
                foreach (DataGridViewRow row in datosDataGridView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        int valor = getValor(cell.Value.ToString());
                        switch (valor)
                        {
                            case 1:
                                datosDataGridView.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Style.BackColor = System.Drawing.Color.Red;
                                break;
                            case 2:
                                datosDataGridView.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Style.BackColor = System.Drawing.Color.Yellow;
                                break;
                        }
                    }
                }
                
                this.datosDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.datosDataGridView_RowPostPaint);
                actualizarForm();
            }
            else
            {
                MessageBox.Show("Apertura de archivo cancelada");
            }
        }

        public int getValor(string dato)
        {
            int valor = 0;
            if (String.IsNullOrEmpty(dato) || String.IsNullOrWhiteSpace(dato)) valor = 1;
            else if (dato == "?") valor = 2;
            return valor;
        }

        private void datosDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(datosDataGridView.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void actualizarForm()
        {
            cargarArchivoButton.Location = new Point(12, 12);
            this.Size = new System.Drawing.Size(960, 330);
            datosDataGridView.Visible = true;
            this.datosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            guardarButton.Visible = true;
            guardarComoButton.Visible = true;
            preProcesamientoButton.Visible = true;
            analisisEButton.Visible = true;
            machineLButton.Visible = true;
            archivoLabel.Visible = true;
            nombreALabel.Visible = true;
            //nombreALabel.Text = ruta;
            nombreALabel.Text = obtenerNombreArchivo();
            band1 = true;
            band2 = true;
        }

        private string obtenerNombreArchivo()
        {
            int cont = 0;
            for (int i = ruta.Length; i > 0; i--)
            {
                if (Convert.ToString(ruta[i - 1]) == @"\")
                {
                    string nombreArchivo = ruta.Substring(ruta.Length - cont);
                    return nombreArchivo;
                }
                cont++;
            }
            return "";
        }
        //cerrar programa
        private void PrincipalFormClosing(object sender, FormClosingEventArgs e)
        {
            if (band1 == true)
            {
                DialogResult dialogo = MessageBox.Show("¿Desea guardar cambios antes de salir?", "Cerrar el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.Yes)
                {
                    e.Cancel = true;
                    //guarda cambios automatico
                    Archivo archivo = new Archivo();
                    archivo.escribirArchivo(ruta, lecturaDataGrid());
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = false;
                }
            }
        }
        //guardado de archivo
        private void guardarButton_Click(object sender, EventArgs e)
        {
            Archivo archivo = new Archivo();
            archivo.escribirArchivo(ruta, lecturaDataGrid());
        }

        private void guardarComoButton_Click(object sender, EventArgs e)
        {
            Archivo archivo = new Archivo();
            archivo.escribirArchivoComo(ruta, lecturaDataGrid());
        }

        public List<string> lecturaDataGrid()
        {
            List<string> lf = new List<string>();
            string header = "";
            for (int i = 0; i < this.datosDataGridView.Columns.Count; i++)
            {
                header = header + this.datosDataGridView.Columns[i].HeaderText + ",";
            }
            string cabecera = header.Substring(0, (header.Count() - 1));
            lf.Add(cabecera);
            foreach (DataGridViewRow row in datosDataGridView.Rows)
            {
                string strLinea = "";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null || String.IsNullOrEmpty(cell.Value.ToString()) || String.IsNullOrWhiteSpace(cell.Value.ToString()))
                        strLinea += "?";
                    else
                        strLinea += cell.Value.ToString();
                    strLinea += ",";
                }
                lf.Add(strLinea.TrimEnd(','));
            }
            return lf;
        }

        private void datosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewColumn column in datosDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            //MessageBox.Show("Fila: " + e.RowIndex.ToString() + " Columna: " + e.ColumnIndex.ToString());
        }

        private void datosDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new ContextMenuStrip();
                if (e.ColumnIndex > -1 && e.RowIndex > -1)
                {
                    menu.Items.Add("Eliminar Atributo").Name = "eliminarAtributo";
                    menu.Items.Add("Eliminar instancia").Name = "eliminarInstancia";
                    menu.Items.Add("Agregar Atributo").Name = "agregarAtributo";
                    menu.Items.Add("Agregar instancia").Name = "agregarInstancia";
                    posC = e.ColumnIndex;
                    posR = e.RowIndex;
                    //Coordenadas de la celda seleccionada. 
                    Rectangle coordenada = datosDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                    int anchoCelda = coordenada.Location.X; //Ancho de la localizacion de la celda
                    int altoCelda = coordenada.Location.Y;  //Alto de la localizacion de la celda
                    //Mostrar menu
                    int X = anchoCelda;
                    int Y = altoCelda + 35;
                    menu.Show(datosDataGridView, new Point(X, Y));
                    //se agregan eventos click correspondientes
                    menu.Items[0].Click += new EventHandler(eliminarAtributoToolStripMenuItemClick);
                    menu.Items[1].Click += new EventHandler(eliminarInstanciaToolStripMenuItemClick);
                    menu.Items[2].Click += new EventHandler(agregarAtributoToolStripMenuItemClick);
                    menu.Items[3].Click += new EventHandler(agregarInstanciaToolStripMenuItemClick);
                }
                else if(e.RowIndex == -1 && e.ColumnIndex > -1)
                {
                    menu.Items.Add("Cambiar nombre").Name = "cambiarNombre";
                    posC = e.ColumnIndex;
                    Rectangle coordenada = datosDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                    int anchoCelda = coordenada.Location.X; //Ancho de la localizacion de la celda
                    int altoCelda = coordenada.Location.Y;  //Alto de la localizacion de la celda
                    //Mostrar menu
                    int X = anchoCelda;
                    int Y = altoCelda + 35;
                    menu.Show(datosDataGridView, new Point(X, Y));
                    menu.Items[0].Click += new EventHandler(cambiarNombreToolStripMenuItemClick);
                }
            }
        }

        void eliminarAtributoToolStripMenuItemClick(object sender, EventArgs e)
        {
            datosDataGridView.Columns.RemoveAt(posC);
        }

        void eliminarInstanciaToolStripMenuItemClick(object sender, EventArgs e)
        {
            datosDataGridView.Rows.RemoveAt(posR);
        }

        void agregarAtributoToolStripMenuItemClick(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Ingrese nombre del atributo", "Nombre atributo", "");
            if (!string.IsNullOrEmpty(nombre) || !string.IsNullOrWhiteSpace(nombre))
                datosDataGridView.Columns.Add(nombre, nombre);
            else
                MessageBox.Show("Debe ingresar un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void agregarInstanciaToolStripMenuItemClick(object sender, EventArgs e)
        {
            datosDataGridView.Rows.Add();
        }
        
        //metodo que cambia el nombre a header
        void cambiarNombreToolStripMenuItemClick(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Ingrese nuevo nombre", "Nuevo nombre", "");
            //evaluar con la expresion regular
            if (!string.IsNullOrEmpty(nombre) || !string.IsNullOrWhiteSpace(nombre))
                datosDataGridView.Columns[posC].HeaderText = nombre;
            else
                MessageBox.Show("Debe ingresar nombre");
        }
        
        private void datosDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (band2 == true)
            {
                string valor = Convert.ToString(datosDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                //string valor = datosDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (esFaltante(valor) == false)
                {
                    datosDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = System.Drawing.Color.White;
                }
            }
        }

        bool esFaltante(string cadena)
        {
            if (cadena == null || string.IsNullOrEmpty(cadena) || string.IsNullOrWhiteSpace(cadena)) return true;
            for (int i = 0; i < cadena.Length; i++) if (cadena[i] == Convert.ToChar("?")) return true;
            return false;
        }
    }
}
