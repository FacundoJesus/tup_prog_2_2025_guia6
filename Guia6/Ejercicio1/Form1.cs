using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Persona> listaPersonas = new List<Persona>();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FDatos fDatos = new FDatos();
            

            bool volverAMostrar = true;

            while (volverAMostrar && fDatos.ShowDialog() == DialogResult.OK)
            {
                try { 

                    string nombre = fDatos.tbNombre.Text;
                    string cuit = fDatos.tbCUIT.Text;

                    Persona persona = null;
                    if (fDatos.rbFisica.Checked)
                    {
                        persona = new Persona(nombre);

                    }
                    else
                    if (fDatos.rbJuridica.Checked)
                    {
                        persona = new PersonaJuridica(nombre, cuit);
                    }


                    if(persona != null) {
                        listaPersonas.Add(persona);
                        ActualizarListado();

                        /*#region Limpio Campos
                        fDatos.tbNombre.Clear();
                        fDatos.tbCUIT.Clear();
                        fDatos.lbCuitExcept.Text = "";
                        fDatos.lbNombreExcept.Text = "";
                        #endregion*/

                        volverAMostrar = false;
                    }
                    else
                    {
                        MessageBox.Show("Debes seleccionar un Tipo de Persona");
                    }



                }catch (FormatoNombreNoValidoException ex){
                    fDatos.lbNombreExcept.Text = ex.Message;
                }catch (FormatoCUITNoValidoException ex){
                    fDatos.lbCuitExcept.Text = ex.Message;
                }
                catch (Exception ex){
                    MessageBox.Show("Otro tipo de excepción capturada");
                }

                
                    
            }

            fDatos.Dispose();
        }


        private void btnQuitar_Click(object sender, EventArgs e){

            int idxSeleccionado = lsbListado.SelectedIndex;

            if (idxSeleccionado > -1)
            {
                listaPersonas.RemoveAt(idxSeleccionado);
                ActualizarListado();

            }
            else
            {
            MessageBox.Show("Debes seleccionar una persona de la Lista para Quitarlo.");
            }
        }

        public void ActualizarListado()
        {
            listaPersonas.Sort();

            lsbListado.Items.Clear();
            foreach(Persona p in listaPersonas) {
                lsbListado.Items.Add(p.Describir());
            }
        }

    }
}
