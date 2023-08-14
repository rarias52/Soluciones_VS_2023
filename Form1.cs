using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaTareas
{

    public partial class Form1 : Form
    {
        private List<Tarea> tareasPorRealizar = new List<Tarea>();
        private List<Tarea> tareasEnProgreso = new List<Tarea>();
        private List<Tarea> tareasCompletadas = new List<Tarea>();

        public Form1()
        {
            InitializeComponent();
        }


            private void ModificarTareaPorRealizar(int indice, string nuevaDescripcion)
            {
                if (indice >= 0 && indice < tareasPorRealizar.Count)
                {
                    Tarea tarea = tareasPorRealizar[indice];
                    tarea.Descripcion = nuevaDescripcion;
                    lbxA_Realizar.Items[indice] = tarea;
                    lbxEnProgreso.Items[indice] = tarea;
                    lbxCompletadas.Items[indice] = tarea;
            }
            }

            private void btnAgregarPorRealizar_Click(object sender, EventArgs e)
            {
                string descripcion = txtPorRealizar.Text; // Obtén la descripción de la tarea desde un TextBox u otro control de entrada

                if (!string.IsNullOrEmpty(descripcion))
                {
                    Tarea nuevaTarea = new Tarea(descripcion); // Crea una nueva instancia de la clase Tarea
                    tareasPorRealizar.Add(nuevaTarea); // Agrega la tarea a la lista de "Tareas por realizar"
                    lbxA_Realizar.Items.Add(nuevaTarea); // Agrega la tarea al ListBox correspondiente

                    // Limpia el TextBox o control de entrada
                    txtPorRealizar.Text = "";

                    // Opcional: Puedes mostrar un mensaje de éxito o realizar otras acciones después de agregar la tarea
                    MessageBox.Show("Tarea agregada exitosamente.");
                }
                else
                {
                    // Si no se proporciona una descripción, puedes mostrar un mensaje de error o tomar otras medidas
                    MessageBox.Show("Por favor, ingresa una descripción para la tarea.");
                }
            }

            private void btnModificarPorRealizar_Click(object sender, EventArgs e)
            {
            
            if (lbxA_Realizar.SelectedItem != null)
            {
                Tarea tareaSeleccionada = (Tarea)lbxA_Realizar.SelectedItem;
                tareaSeleccionada.Descripcion = txtNuevaDescripcion.Text;
                lbxA_Realizar.Items[lbxA_Realizar.SelectedIndex] = tareaSeleccionada;
                txtNuevaDescripcion.Text = "";
                MessageBox.Show("Tarea modificada exitosamente.");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una tarea para modificar.");
            }
        }
            private void EliminarTareaPorRealizar(int indice)
            {
                if (indice >= 0 && indice < tareasPorRealizar.Count)
                {
                    tareasPorRealizar.RemoveAt(indice);
                    lbxA_Realizar.Items.RemoveAt(indice);
                }
            }

        private void lbxA_Realizar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxA_Realizar.SelectedItem != null)
            {
                Tarea tareaSeleccionada = (Tarea)lbxA_Realizar.SelectedItem;
                txtNuevaDescripcion.Text = tareaSeleccionada.Descripcion;
            }
            else
            {
                txtNuevaDescripcion.Text = "";
            }
        }
        private void lbxEnProgreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxEnProgreso.SelectedItem != null)
            {
                Tarea tareaSeleccionada = (Tarea)lbxEnProgreso.SelectedItem;
                txtNuevaDescripcion.Text = tareaSeleccionada.Descripcion;
            }
            else
            {
                txtNuevaDescripcion.Text = "";
            }
        }
        private void lbxCompletadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxCompletadas.SelectedItem != null)
            {
                Tarea tareaSeleccionada = (Tarea)lbxCompletadas.SelectedItem;
                txtNuevaDescripcion.Text = tareaSeleccionada.Descripcion;
            }
            else
            {
                txtNuevaDescripcion.Text = "";
            }
        }
        private void btnEliminarPorRealizar_Click(object sender, EventArgs e)
        {
            if (lbxA_Realizar.SelectedItem != null)
            {
                Tarea tareaSeleccionada = (Tarea)lbxA_Realizar.SelectedItem;
                tareasPorRealizar.Remove(tareaSeleccionada);
                lbxA_Realizar.Items.RemoveAt(lbxA_Realizar.SelectedIndex);
                MessageBox.Show("Tarea eliminada exitosamente.");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una tarea para eliminar.");
            }
        }

        private void btnAgregarEnProgreso_Click(object sender, EventArgs e)
        {
            if (lbxA_Realizar.SelectedItem != null)
            {
                Tarea tareaSeleccionada = (Tarea)lbxA_Realizar.SelectedItem;
                tareasPorRealizar.Remove(tareaSeleccionada);
                tareasEnProgreso.Add(tareaSeleccionada);
                lbxA_Realizar.Items.Remove(tareaSeleccionada);
                lbxEnProgreso.Items.Add(tareaSeleccionada);
                MessageBox.Show("Tarea movida a 'Tareas en progreso' exitosamente.");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una tarea para mover a 'Tareas en progreso'.");
            }
        }

        private void btnModificarEnProgreso_Click(object sender, EventArgs e)
        {
            if (lbxEnProgreso.SelectedItem != null)
            {
                Tarea tareaSeleccionada = (Tarea)lbxEnProgreso.SelectedItem;
                tareaSeleccionada.Descripcion = txtNuevaDescripcion.Text;
                lbxEnProgreso.Items[lbxEnProgreso.SelectedIndex] = tareaSeleccionada;
                txtNuevaDescripcion.Text = "";
                MessageBox.Show("Tarea modificada exitosamente.");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una tarea para modificar.");
            }
        }
        private void btnModificarCompletadas_Click(object sender, EventArgs e)
        {
            if (lbxCompletadas.SelectedItem != null  )
            {
                Tarea tareaSeleccionada = (Tarea)lbxCompletadas.SelectedItem;
                tareaSeleccionada.Descripcion = txtNuevaDescripcion.Text;
                lbxCompletadas.Items[lbxCompletadas.SelectedIndex] = tareaSeleccionada;
                txtNuevaDescripcion.Text = "";
                MessageBox.Show("Tarea modificada exitosamente.");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una tarea para modificar.");
            }
        }
        private void btnEliminarEnProgreso_Click(object sender, EventArgs e)
        {
            if (lbxEnProgreso.SelectedItem != null)
            {
                Tarea tareaSeleccionada = (Tarea)lbxEnProgreso.SelectedItem;
                tareasPorRealizar.Remove(tareaSeleccionada);
                lbxEnProgreso.Items.RemoveAt(lbxEnProgreso.SelectedIndex);
                MessageBox.Show("Tarea eliminada exitosamente.");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una tarea para eliminar.");
            }
        }

        private void btnAgregarCompletadas_Click(object sender, EventArgs e)
        {
            if (lbxEnProgreso.SelectedItem != null)
            {
                Tarea tareaSeleccionada = (Tarea)lbxEnProgreso.SelectedItem;
                tareasEnProgreso.Remove(tareaSeleccionada);
                tareasCompletadas.Add(tareaSeleccionada);
                lbxEnProgreso.Items.Remove(tareaSeleccionada);
                lbxCompletadas.Items.Add(tareaSeleccionada);
                MessageBox.Show("Tarea movida a 'Tareas completadas' exitosamente.");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una tarea para mover a 'Tareas completadas'.");
            }
        }

        private void btnEliminarCompletadas_Click(object sender, EventArgs e)
        {
            if (lbxCompletadas.SelectedItem != null)
            {
                Tarea tareaSeleccionada = (Tarea)lbxCompletadas.SelectedItem;
                tareasPorRealizar.Remove(tareaSeleccionada);
                lbxCompletadas.Items.RemoveAt(lbxCompletadas.SelectedIndex);
                MessageBox.Show("Tarea eliminada exitosamente.");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una tarea para eliminar.");
            }
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
    }

        
    

