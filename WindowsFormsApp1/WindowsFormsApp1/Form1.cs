using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        RegistroHistorico nuevoregistro = new RegistroHistorico();

        Persona persona;
        Instalacion instalacion;
        

        public Form1(RegistroHistorico minuevoregistro)
        {
            InitializeComponent();

            nuevoregistro = minuevoregistro;
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            



            panel1.BringToFront();
            labelContraseñaAdmin.Hide();
            textBoxContraseñaAdmin.Hide();
            labelContraseñaAdminIncorrecta.Hide();
            buttonIngresar.Hide();


        }

        private void BotonVerificar_Click(object sender, EventArgs e)
        {
            //Agregue usuario para probar si funcionaba

            string rut = textBoxRecibirRut.Text;

            bool verificacion = nuevoregistro.VerificarUsuarioExistente(rut);
            if (verificacion == true)
            //verificacion es true cuando el usuario ya fue registrado
            {
                if (nuevoregistro.VerificarAdministrador(rut) == true)
                {
                    Persona persona2 = nuevoregistro.GetPersona(rut);
                    persona = persona2;
                    labelContraseñaAdmin.Show();
                    textBoxContraseñaAdmin.Show();
                    buttonIngresar.Show();


                }
                else
                {
                    Persona persona1 = nuevoregistro.GetPersona(rut);
                    persona = persona1;

                    panel3.BringToFront();
                    buttonCrearInstalacion.Hide();
                }


            }
            if (verificacion == false)
            //verificacion es false cuando el usuario no esta registrado
            {
                panel2.BringToFront();
                labelUsuarioCreadoExito.Hide();
                buttonIrMenu.Hide();


            }

        }

        private void labelbienvenido_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxRecibirRut_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelIngreseRut_Click(object sender, EventArgs e)
        {

        }

        private void labelEscribirNombre_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNombreNuevo_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelEscogertipodeusuario_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void buttonCrearUsuario_Click(object sender, EventArgs e)
        {
            string rut = textBoxRecibirRut.Text;
            string nombre = textBoxNombreNuevo.Text;
            string tipoUsuario = comboBoxTipoUsuario.Text;
            

            if (tipoUsuario == "Alumno")
            {
                //Alumno alumni = nuevoregistro.CrearAlumno(rut, nombre);
                nuevoregistro.AgregarAlumno(nuevoregistro.CrearAlumno(rut, nombre));
                Persona persona1 = new Persona(rut, nombre, tipoUsuario);
                nuevoregistro.AgregarUsuario(persona1);
                persona = persona1;
                //nuevoregistro.AgregarUsuario(persona1);

                labelUsuarioCreadoExito.Show();
                buttonIrMenu.Show();


            }
            if (tipoUsuario == "Profesor")
            {
                nuevoregistro.AgregarProfesor(nuevoregistro.CrearProfesor(rut, nombre));
                Persona persona1 = new Persona(rut, nombre, tipoUsuario);
                persona = persona1;
                nuevoregistro.AgregarUsuario(persona1);
                labelUsuarioCreadoExito.Show();
                buttonIrMenu.Show();

            }
            if (tipoUsuario == "Funcionario")
            {
                nuevoregistro.AgregarFuncionario(nuevoregistro.CrearFuncionario(rut, nombre));
                Persona persona1 = new Persona(rut, nombre, tipoUsuario);
                persona = persona1;
                nuevoregistro.AgregarUsuario(persona1);
                labelUsuarioCreadoExito.Show();
                buttonIrMenu.Show();


            }

        }

        private void labelUsuarioCreadoExito_Click(object sender, EventArgs e)
        {

        }

        private void buttonArrendarInstalacion_Click(object sender, EventArgs e)
        {
            panel4.BringToFront();
            labelMostrarSalasClase.Hide();
            comboBoxSalasClaseDisp.Hide();
            labelMuestraCanchas.Hide();
            comboBoxCanchasDisp.Hide();
            labelMuestraEspPublic.Hide();
            comboBoxEspaciosPublicosDisp.Hide();
            labelMuestraSalasEstudio.Hide();
            comboBoxSalaEstudioDisp.Hide();
            labelInstalacionNoDisp.Hide();
            labelCantidadParticipantes.Hide();
            textBoxCantidadParticipantes.Hide();
            buttonVerificarDispArriendo.Hide();
            buttonArrendar.Hide();
            labelArriendoExitoso.Hide();
            buttonCrearEvento.Hide();
            labelNombreEvento.Hide();
            textBoxNombreEvento.Hide();
            labelCuposDisponibles.Hide();
            textBoxCuposDisponibles.Hide();
            labelEventoFallido.Hide();
            labelEventoRealizadoConExito.Hide();
            labelInstalacionDisp.Hide();
            buttonAgendarEvento.Hide();
            labelArriendoFallido.Hide();
            labelFechaA.Hide();
            comboBoxHoraArriendo.Hide();
            dateTimeArriendoUno.Hide();
            labelHora.Hide();
        }

        private void buttonRevisarEventosDisp_Click(object sender, EventArgs e)
        {
            panel7.BringToFront();
            labelAgregarEventoFallido.Hide();
            labelAgregadoConExitoAlEvento.Hide();
            List<Eventos> eventos = nuevoregistro.ObtenerEventos();
            foreach (Eventos evento in eventos)
            {

                string nombreEvento = evento.GetNomnbreEvento();
                int disp = evento.Disponibilidad();
                int disp2 = (disp + 1);
                string disp1 = disp.ToString();
                string disp3 = disp2.ToString();
                string atributos = (nombreEvento + " " + disp1);
                string atributos1 = (nombreEvento + " " + disp3);


                if (comboBoxMostrarEventosDisponibles.Items.Contains(atributos))
                {
                    continue;
                }
                else
                {
                    this.comboBoxMostrarEventosDisponibles.Items.Remove(atributos1);
                    this.comboBoxMostrarEventosDisponibles.Items.Add(atributos);

                }

            }
        }

        private void buttonMostrarDatos_Click(object sender, EventArgs e)
        {
            panel6.BringToFront();
            listBoxMostrarArriendos.Hide();
            listBoxEventos.Hide();
            listBoxMostrarUsuario.Hide();
            listBoxMostrarInstalaciones.Hide();
            listBoxMostrarParticipantesEventos.Hide();
            textBoxDetalleUsuario.Hide();
            textBoxDetalleInstalacion.Hide();
            textBoxDetalleArriendo.Hide();
            textBoxDetalleEvento.Hide();
            buttonEliminarEvento.Hide();
            buttonEliminarArriendo.Hide();

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            BinaryFormatter bin = new BinaryFormatter();
            if (File.Exists("../../Serialized.txt"))
            {
                Stream stream = new FileStream("../../Serialized.txt", FileMode.Open, FileAccess.Write);
                bin.Serialize(stream, nuevoregistro);
                stream.Close();
            }
            else
            {
                Stream stream = new FileStream("../../Serialized.txt", FileMode.Create, FileAccess.Write);
                bin.Serialize(stream, nuevoregistro);
                stream.Close();
            }
            Application.Exit();
        }

        private void labelContraseñaAdmin_Click(object sender, EventArgs e)
        {

        }

        private void textBoxContraseñaAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonIrMenu_Click(object sender, EventArgs e)
        {
            panel3.BringToFront();
            buttonCrearInstalacion.Hide();
        }

        private void labelArrendar_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSelecTipoInstalacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonAgendarEvento.Hide();
            labelInstalacionDisp.Hide();
            string TipoInstalacion = comboBoxSelecTipoInstalacion.Text;

            if (TipoInstalacion == "Cancha")
            {
                List<Cancha> canchas = nuevoregistro.ObtenerListaCanchas();
                foreach (Cancha cancha in canchas)
                {
                    string str = cancha.GetTipoCancha();
                    if (comboBoxCanchasDisp.Items.Contains(str))
                    {
                        continue;
                    }
                    else
                    {
                        this.comboBoxCanchasDisp.Items.Add(str);

                    }

                }

                labelMuestraCanchas.Show();
                comboBoxCanchasDisp.Show();
                labelMostrarSalasClase.Hide();
                comboBoxSalasClaseDisp.Hide();
                labelMuestraEspPublic.Hide();
                comboBoxEspaciosPublicosDisp.Hide();
                labelMuestraSalasEstudio.Hide();
                comboBoxSalaEstudioDisp.Hide();
                labelInstalacionNoDisp.Hide();
                labelCantidadParticipantes.Hide();
                textBoxCantidadParticipantes.Hide();
                buttonVerificarDispArriendo.Show();
                buttonArrendar.Hide();
                labelArriendoExitoso.Hide();
                buttonCrearEvento.Hide();
                labelNombreEvento.Hide();
                textBoxNombreEvento.Hide();
                dateTimeArriendoUno.Show();
                labelFechaA.Show();
                labelHora.Show();
                comboBoxHoraArriendo.Show();


            }
            if (TipoInstalacion == "Sala de Clases")
            {
                List<SalaClases> salasclases = nuevoregistro.ObtenerListaSalaClases();
                foreach (SalaClases salaclase in salasclases)
                {
                    string str = salaclase.GetNumSala();
                    if (comboBoxSalasClaseDisp.Items.Contains(str))
                    {
                        continue;
                    }
                    else
                    {
                        this.comboBoxSalasClaseDisp.Items.Add(str);

                    }

                }
                labelMostrarSalasClase.Show();
                comboBoxSalasClaseDisp.Show();
                labelMuestraCanchas.Hide();
                comboBoxCanchasDisp.Hide();
                labelMuestraEspPublic.Hide();
                comboBoxEspaciosPublicosDisp.Hide();
                labelMuestraSalasEstudio.Hide();
                comboBoxSalaEstudioDisp.Hide();
                labelInstalacionNoDisp.Hide();
                labelCantidadParticipantes.Hide();
                textBoxCantidadParticipantes.Hide();
                buttonVerificarDispArriendo.Show();
                buttonArrendar.Hide();
                labelArriendoExitoso.Hide();
                buttonCrearEvento.Hide();
                labelNombreEvento.Hide();
                textBoxNombreEvento.Hide();
                dateTimeArriendoUno.Show();
                labelFechaA.Show();
                labelHora.Show();
                comboBoxHoraArriendo.Show();
                dateTimeArriendoUno.Show();
                labelFechaA.Show();
                labelHora.Show();
                comboBoxHoraArriendo.Show();

            }
            if (TipoInstalacion == "Sala de Estudios")
            {
                List<SalaEstudio> salasestudio = nuevoregistro.ObtenerListaSalasEstudio();
                foreach (SalaEstudio salaestudio in salasestudio)
                {
                    string str = salaestudio.GetNumSala();
                    if (comboBoxSalaEstudioDisp.Items.Contains(str))
                    {
                        continue;
                    }
                    else
                    {
                        this.comboBoxSalaEstudioDisp.Items.Add(str);

                    }

                }
                labelMuestraSalasEstudio.Show();
                comboBoxSalaEstudioDisp.Show();
                labelMuestraCanchas.Hide();
                comboBoxCanchasDisp.Hide();
                labelMuestraEspPublic.Hide();
                comboBoxEspaciosPublicosDisp.Hide();
                labelMostrarSalasClase.Hide();
                comboBoxSalasClaseDisp.Hide();
                labelInstalacionNoDisp.Hide();
                labelCantidadParticipantes.Hide();
                textBoxCantidadParticipantes.Hide();
                buttonVerificarDispArriendo.Show();
                buttonArrendar.Hide();
                labelArriendoExitoso.Hide();
                buttonCrearEvento.Hide();
                labelNombreEvento.Hide();
                textBoxNombreEvento.Hide();
                dateTimeArriendoUno.Show();
                labelFechaA.Show();
                labelHora.Show();
                comboBoxHoraArriendo.Show();
            }
            if (TipoInstalacion == "Espacios Públicos")
            {
                List<EspaciosPublicos> espaciospublicos = nuevoregistro.ObtenerListaEspaciosPublicos();
                foreach (EspaciosPublicos espaciopublico in espaciospublicos)
                {
                    string str = espaciopublico.GetTipoEspaciosPublicos();
                    if (comboBoxEspaciosPublicosDisp.Items.Contains(str))
                    {
                        continue;
                    }
                    else
                    {
                        this.comboBoxEspaciosPublicosDisp.Items.Add(str);

                    }

                }
                labelMuestraEspPublic.Show();
                comboBoxEspaciosPublicosDisp.Show();
                labelMostrarSalasClase.Hide();
                comboBoxSalasClaseDisp.Hide();
                labelMuestraCanchas.Hide();
                comboBoxCanchasDisp.Hide();
                labelMuestraSalasEstudio.Hide();
                comboBoxSalaEstudioDisp.Hide();
                labelInstalacionNoDisp.Hide();
                labelCantidadParticipantes.Hide();
                textBoxCantidadParticipantes.Hide();
                buttonVerificarDispArriendo.Show();
                buttonArrendar.Hide();
                labelArriendoExitoso.Hide();
                buttonCrearEvento.Hide();
                labelNombreEvento.Hide();
                textBoxNombreEvento.Hide();
                dateTimeArriendoUno.Show();
                labelFechaA.Show();
                labelHora.Show();
                comboBoxHoraArriendo.Show();

            }

        }

        private void labelMuestraCanchas_Click(object sender, EventArgs e)
        {

        }

        private void labelMostrarSalasClase_Click(object sender, EventArgs e)
        {

        }

        private void labelMuestraSalasEstudio_Click(object sender, EventArgs e)
        {

        }

        private void labelMuestraEspPublic_Click(object sender, EventArgs e)
        {

        }

        private void buttonCrearInstalacion_Click(object sender, EventArgs e)
        {
            panel5.BringToFront();
            labelnstalacionCreadaExito.Hide();

        }

        private void labelContraseñaAdminIncorrecta_Click(object sender, EventArgs e)
        {

        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            if (textBoxContraseñaAdmin.Text == "123456789")
            {
                panel3.BringToFront();
                buttonCrearInstalacion.Show();
                buttonAgregarseAlEvento.Hide();
                buttonArrendarInstalacion.Hide();
            }
            else
            {
                //Mostrar mensaje contraseña incorrecta
                labelContraseñaAdminIncorrecta.Show();

            }

        }

        private void comboBoxCanchasDisp_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void comboBoxSalasClaseDisp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSalaEstudioDisp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEspaciosPublicosDisp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelFechaHoraArriendo_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFechaHoraArriendo_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonVerificarDispArriendo_Click(object sender, EventArgs e)
        {
            
            string instalacionescogida = comboBoxSelecTipoInstalacion.Text;
            string fecha = dateTimeArriendoUno.Value.ToShortDateString();
            string hora = comboBoxHoraArriendo.Text;
            string fechayhora = (fecha + " " + hora);
            
            try
            {
                DateTime fecha1 = DateTime.ParseExact(fechayhora, "dd-MM-yyyy HH", System.Globalization.CultureInfo.InvariantCulture);
                if (instalacionescogida == "Cancha")
                {
                    buttonAgendarEvento.Hide();
                    labelInstalacionDisp.Hide();
                    instalacion = nuevoregistro.GetInstalacion(instalacionescogida);
                    string tipocanchaescogida = comboBoxCanchasDisp.Text;
                    Cancha cancha1 = nuevoregistro.VerificarExistenciaCancha(tipocanchaescogida);

                    bool respuestaArriendo = nuevoregistro.VerificarArriendoCanchaExistente(persona, cancha1, fecha1);
                    if (respuestaArriendo == true)
                    {
                        //La cancha esta disponible
                        labelInstalacionDisp.Show();
                        labelCantidadParticipantes.Show();
                        textBoxCantidadParticipantes.Show();
                        labelNombreEvento.Hide();

                        textBoxNombreEvento.Hide();

                        buttonArrendar.Show();
                        int cantidadparticipantes = int.Parse(textBoxCantidadParticipantes.Text);
                        buttonVerificarDispArriendo.Hide();
                        labelInstalacionNoDisp.Hide();
                        string tipopersona = persona.GetTipoPersona();
                        if (cantidadparticipantes != 0)
                        {
                            buttonArrendar.Show();
                            labelArriendoExitoso.Hide();
                            buttonCrearEvento.Hide();
                            labelNombreEvento.Hide();

                            textBoxNombreEvento.Hide();


                        }


                    }
                    else
                    {
                        //La cancha no esta disponible
                        labelInstalacionNoDisp.Show();
                        buttonVerificarDispArriendo.Show();
                        buttonArrendar.Hide();
                        labelCantidadParticipantes.Hide();
                        textBoxCantidadParticipantes.Hide();
                        labelArriendoExitoso.Hide();
                        buttonCrearEvento.Hide();
                        labelNombreEvento.Hide();

                        textBoxNombreEvento.Hide();
                        buttonAgendarEvento.Hide();


                    }
                }
                if (instalacionescogida == "Sala de Clases")
                {

                    buttonAgendarEvento.Hide();
                    labelInstalacionDisp.Hide();
                    instalacion = nuevoregistro.GetInstalacion(instalacionescogida);
                    string tipopersona = persona.GetTipoPersona();
                    string tiposalaclase = comboBoxSalasClaseDisp.Text;
                    SalaClases salaclase = nuevoregistro.VerificarExistenciaSalaClase(tiposalaclase);

                    bool respuestaArriendo = nuevoregistro.VerificarArriendoSaladeClaseExistente(persona, salaclase, fecha1);
                    if (respuestaArriendo == true)
                    {
                        //La sala esta disponible
                        labelInstalacionDisp.Show();
                        labelCantidadParticipantes.Show();
                        textBoxCantidadParticipantes.Show();
                        labelNombreEvento.Hide();

                        textBoxNombreEvento.Hide();


                        buttonArrendar.Show();
                        int cantidadparticipantes = int.Parse(textBoxCantidadParticipantes.Text);
                        buttonVerificarDispArriendo.Hide();
                        labelInstalacionNoDisp.Hide();
                        if (cantidadparticipantes != 0)
                        {
                            buttonArrendar.Show();
                            labelArriendoExitoso.Hide();
                            buttonCrearEvento.Hide();
                            labelNombreEvento.Hide();

                            textBoxNombreEvento.Hide();


                        }


                    }
                    else
                    {
                        //La sala no esta disponible
                        if (tipopersona == "Profesor")
                        {
                            Arriendo arriendoporborrar = nuevoregistro.ArriendoPorBorrar(tiposalaclase, fecha1);
                            string tipopersonaarriendo = arriendoporborrar.GetSubtipoPersona();
                            if (tipopersonaarriendo == "Profesor")
                            {
                                labelInstalacionNoDisp.Show();
                                buttonVerificarDispArriendo.Show();
                                buttonArrendar.Hide();
                                labelCantidadParticipantes.Hide();
                                textBoxCantidadParticipantes.Hide();
                                labelArriendoExitoso.Hide();
                                buttonCrearEvento.Hide();
                                labelNombreEvento.Hide();

                                textBoxNombreEvento.Hide();
                                buttonAgendarEvento.Hide();

                            }
                            else
                            {
                                nuevoregistro.EliminarArriendo(arriendoporborrar);

                                labelInstalacionNoDisp.Hide();
                                buttonVerificarDispArriendo.Hide();

                                labelCantidadParticipantes.Show();
                                textBoxCantidadParticipantes.Show();
                                labelArriendoExitoso.Hide();
                                buttonCrearEvento.Show();
                                labelNombreEvento.Hide();

                                textBoxNombreEvento.Hide();
                                buttonAgendarEvento.Hide();
                                buttonArrendar.Show();
                                int cantidadparticipantes = int.Parse(textBoxCantidadParticipantes.Text);

                                if (cantidadparticipantes != 0)
                                {
                                    buttonArrendar.Show();
                                    labelArriendoExitoso.Show();
                                    buttonCrearEvento.Hide();
                                    labelNombreEvento.Hide();
                                    textBoxNombreEvento.Hide();


                                }
                            }


                        }
                        else
                        {
                            labelInstalacionNoDisp.Show();
                            buttonVerificarDispArriendo.Show();
                            buttonArrendar.Hide();
                            labelCantidadParticipantes.Hide();
                            textBoxCantidadParticipantes.Hide();
                            labelArriendoExitoso.Hide();
                            buttonCrearEvento.Hide();
                            labelNombreEvento.Hide();

                            textBoxNombreEvento.Hide();
                            buttonAgendarEvento.Hide();
                        }
                    }
                }
                if (instalacionescogida == "Sala de Estudios")
                {
                    buttonAgendarEvento.Hide();
                    labelInstalacionDisp.Hide();
                    instalacion = nuevoregistro.GetInstalacion(instalacionescogida);
                    string tiposalaestudio = comboBoxSalaEstudioDisp.Text;
                    SalaEstudio salaestudio1 = nuevoregistro.VerificarExistenciaSalaEstudio(tiposalaestudio);

                    bool respuestaArriendo = nuevoregistro.VerificarArriendoSaladeEstudioExistente(persona, salaestudio1, fecha1);
                    if (respuestaArriendo == true)
                    {
                        //El espacio publico esta disponible
                        labelInstalacionDisp.Show();
                        labelCantidadParticipantes.Show();
                        textBoxCantidadParticipantes.Show();
                        labelNombreEvento.Hide();
                        textBoxNombreEvento.Hide();
                        buttonArrendar.Show();
                        int cantidadparticipantes = int.Parse(textBoxCantidadParticipantes.Text);
                        buttonVerificarDispArriendo.Hide();
                        labelInstalacionNoDisp.Hide();
                        string tipopersona = persona.GetTipoPersona();
                        if (cantidadparticipantes != 0)
                        {
                            buttonArrendar.Show();
                            labelArriendoExitoso.Hide();
                            buttonCrearEvento.Hide();
                            labelNombreEvento.Hide();
                            textBoxNombreEvento.Hide();
                        }

                    }
                    else
                    {
                        //La sala de estudio no esta disponible
                        labelInstalacionNoDisp.Show();
                        buttonVerificarDispArriendo.Show();
                        buttonArrendar.Hide();
                        labelCantidadParticipantes.Hide();
                        textBoxCantidadParticipantes.Hide();
                        labelArriendoExitoso.Hide();
                        buttonCrearEvento.Hide();
                        labelNombreEvento.Hide();

                        textBoxNombreEvento.Hide();
                        buttonAgendarEvento.Hide();

                    }

                }
                if (instalacionescogida == "Espacios Públicos")
                {
                    buttonAgendarEvento.Hide();
                    labelInstalacionDisp.Hide();
                    instalacion = nuevoregistro.GetInstalacion(instalacionescogida);
                    string tipoespacioescogido = comboBoxEspaciosPublicosDisp.Text;
                    EspaciosPublicos espapubl1 = nuevoregistro.VerificarExistenciaEspaciosPublicos(tipoespacioescogido);

                    bool respuestaArriendo = nuevoregistro.VerificarArriendoEspaciosPublicosExistente(persona, espapubl1, fecha1);
                    if (respuestaArriendo == true)
                    {
                        //El espacio publico esta disponible
                        labelInstalacionDisp.Show();
                        labelCantidadParticipantes.Show();
                        textBoxCantidadParticipantes.Show();
                        labelNombreEvento.Hide();

                        textBoxNombreEvento.Hide();


                        buttonArrendar.Show();
                        int cantidadparticipantes = int.Parse(textBoxCantidadParticipantes.Text);
                        buttonVerificarDispArriendo.Hide();
                        labelInstalacionNoDisp.Hide();
                        string tipopersona = persona.GetTipoPersona();
                        if (cantidadparticipantes != 0)
                        {
                            buttonArrendar.Show();
                            labelArriendoExitoso.Hide();
                            buttonCrearEvento.Hide();
                            labelNombreEvento.Hide();

                            textBoxNombreEvento.Hide();


                        }


                    }
                    else
                    {
                        //El espacio publico no esta disponible
                        labelInstalacionNoDisp.Show();
                        buttonVerificarDispArriendo.Show();
                        buttonArrendar.Hide();
                        labelCantidadParticipantes.Hide();
                        textBoxCantidadParticipantes.Hide();
                        labelArriendoExitoso.Hide();
                        buttonCrearEvento.Hide();
                        labelNombreEvento.Hide();

                        textBoxNombreEvento.Hide();
                        buttonAgendarEvento.Hide();


                    }

                }


            }
            catch
            {

            }


        }

        private void labelInstalacionNoDisp_Click(object sender, EventArgs e)
        {

        }

        private void labelCantidadParticipantes_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCantidadParticipantes_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonArrendar_Click(object sender, EventArgs e)
        {
            string tipopersona = persona.GetTipoPersona();
            if (comboBoxSelecTipoInstalacion.Text == "Cancha")
            {
                string subtipoinstalacion = comboBoxCanchasDisp.Text;
                string fecha = dateTimeArriendoUno.Value.ToShortDateString();
                string hora = comboBoxHoraArriendo.Text;
                string fechayhora = (fecha + " " + hora);
                DateTime fecha1 = DateTime.ParseExact(fechayhora, "dd-MM-yyyy HH", System.Globalization.CultureInfo.InvariantCulture);
                int cantidadparticipantes = int.Parse(textBoxCantidadParticipantes.Text);
                if (cantidadparticipantes < instalacion.GetCapacidadInstalacion())
                {
                    Arriendo arriendo1 = new Arriendo(persona, tipopersona, instalacion, subtipoinstalacion, cantidadparticipantes, fecha1);
                    nuevoregistro.AgregarArriendo(arriendo1);
                    labelArriendoFallido.Hide();
                    labelArriendoExitoso.Show();
                    buttonCrearEvento.Show();
                    labelNombreEvento.Hide();
                    labelCuposDisponibles.Hide();
                    textBoxNombreEvento.Hide();
                    textBoxCuposDisponibles.Hide();
                    labelInstalacionDisp.Hide();
                    buttonVerificarDispArriendo.Hide();
                    buttonAgendarEvento.Hide();

                }
                else
                {
                    labelArriendoFallido.Show();
                    labelArriendoExitoso.Hide();
                    buttonCrearEvento.Hide();
                    labelNombreEvento.Hide();
                    labelCuposDisponibles.Hide();
                    textBoxNombreEvento.Hide();
                    textBoxCuposDisponibles.Hide();
                    labelInstalacionDisp.Hide();
                    buttonVerificarDispArriendo.Hide();
                    buttonAgendarEvento.Hide();

                }

            }
            if (comboBoxSelecTipoInstalacion.Text == "Sala de Clases")
            {
                string subtipoinstalacion = comboBoxSalasClaseDisp.Text;
                string fecha = dateTimeArriendoUno.Value.ToShortDateString();
                string hora = comboBoxHoraArriendo.Text;
                string fechayhora = (fecha + " " + hora);
                DateTime fecha1 = DateTime.ParseExact(fechayhora, "dd-MM-yyyy HH", System.Globalization.CultureInfo.InvariantCulture);
                int cantidadparticipantes = int.Parse(textBoxCantidadParticipantes.Text);
                if (cantidadparticipantes < instalacion.GetCapacidadInstalacion())
                {
                    Arriendo arriendo1 = new Arriendo(persona, tipopersona, instalacion, subtipoinstalacion, cantidadparticipantes, fecha1);
                    nuevoregistro.AgregarArriendo(arriendo1);
                    labelArriendoFallido.Hide();
                    labelArriendoExitoso.Show();
                    buttonCrearEvento.Show();
                    labelNombreEvento.Hide();
                    labelCuposDisponibles.Hide();
                    textBoxNombreEvento.Hide();
                    textBoxCuposDisponibles.Hide();
                    labelInstalacionDisp.Hide();
                    buttonVerificarDispArriendo.Hide();
                    buttonAgendarEvento.Hide();

                }
                else
                {
                    labelArriendoFallido.Show();
                    labelArriendoExitoso.Hide();
                    buttonCrearEvento.Hide();
                    labelNombreEvento.Hide();
                    labelCuposDisponibles.Hide();
                    textBoxNombreEvento.Hide();
                    textBoxCuposDisponibles.Hide();
                    labelInstalacionDisp.Hide();
                    buttonVerificarDispArriendo.Hide();
                    buttonAgendarEvento.Hide();

                }


            }
            if (comboBoxSelecTipoInstalacion.Text == "Sala de Estudios")
            {
                string subtipoinstalacion = comboBoxSalaEstudioDisp.Text;
                string fecha = dateTimeArriendoUno.Value.ToShortDateString();
                string hora = comboBoxHoraArriendo.Text;
                string fechayhora = (fecha + " " + hora);
                DateTime fecha1 = DateTime.ParseExact(fechayhora, "dd-MM-yyyy HH", System.Globalization.CultureInfo.InvariantCulture);
                int cantidadparticipantes = int.Parse(textBoxCantidadParticipantes.Text);
                if (cantidadparticipantes < instalacion.GetCapacidadInstalacion())
                {
                    Arriendo arriendo1 = new Arriendo(persona, tipopersona, instalacion, subtipoinstalacion, cantidadparticipantes, fecha1);
                    nuevoregistro.AgregarArriendo(arriendo1);
                    labelArriendoFallido.Hide();
                    labelArriendoExitoso.Show();
                    buttonCrearEvento.Show();
                    labelNombreEvento.Hide();
                    labelCuposDisponibles.Hide();
                    textBoxNombreEvento.Hide();
                    textBoxCuposDisponibles.Hide();
                    labelInstalacionDisp.Hide();
                    buttonVerificarDispArriendo.Hide();
                    buttonAgendarEvento.Hide();

                }
                else
                {
                    labelArriendoFallido.Show();
                    labelArriendoExitoso.Hide();
                    buttonCrearEvento.Hide();
                    labelNombreEvento.Hide();
                    labelCuposDisponibles.Hide();
                    textBoxNombreEvento.Hide();
                    textBoxCuposDisponibles.Hide();
                    labelInstalacionDisp.Hide();
                    buttonVerificarDispArriendo.Hide();
                    buttonAgendarEvento.Hide();

                }

            }
            if (comboBoxSelecTipoInstalacion.Text == "Espacios Públicos")
            {
                string subtipoinstalacion = comboBoxEspaciosPublicosDisp.Text;
                string fecha = dateTimeArriendoUno.Value.ToShortDateString();
                string hora = comboBoxHoraArriendo.Text;
                string fechayhora = (fecha + " " + hora);
                DateTime fecha1 = DateTime.ParseExact(fechayhora, "dd-MM-yyyy HH", System.Globalization.CultureInfo.InvariantCulture);
                int cantidadparticipantes = int.Parse(textBoxCantidadParticipantes.Text);
                if (cantidadparticipantes < instalacion.GetCapacidadInstalacion())
                {
                    Arriendo arriendo1 = new Arriendo(persona, tipopersona, instalacion, subtipoinstalacion, cantidadparticipantes, fecha1);
                    nuevoregistro.AgregarArriendo(arriendo1);
                    labelArriendoFallido.Hide();
                    labelArriendoExitoso.Show();
                    buttonCrearEvento.Show();
                    labelNombreEvento.Hide();
                    labelCuposDisponibles.Hide();
                    textBoxNombreEvento.Hide();
                    textBoxCuposDisponibles.Hide();
                    labelInstalacionDisp.Hide();
                    buttonVerificarDispArriendo.Hide();
                    buttonAgendarEvento.Hide();

                }
                else
                {
                    labelArriendoFallido.Show();
                    labelArriendoExitoso.Hide();
                    buttonCrearEvento.Hide();
                    labelNombreEvento.Hide();
                    labelCuposDisponibles.Hide();
                    textBoxNombreEvento.Hide();
                    textBoxCuposDisponibles.Hide();
                    labelInstalacionDisp.Hide();
                    buttonVerificarDispArriendo.Hide();
                    buttonAgendarEvento.Hide();

                }

            }
            
            

        }

        private void labelArriendoExitoso_Click(object sender, EventArgs e)
        {

        }

        private void buttonCrearEvento_Click(object sender, EventArgs e)
        {

            labelNombreEvento.Show();
            textBoxNombreEvento.Show();
            labelCuposDisponibles.Show();
            textBoxCuposDisponibles.Show();
            labelAgregadoConExitoAlEvento.Hide();
            labelAgregarEventoFallido.Hide();
            labelEventoRealizadoConExito.Hide();
            string tipopersona = persona.GetTipoPersona();
            string subtipoinstalacion = comboBoxCanchasDisp.Text;
            string fecha = dateTimeArriendoUno.Value.ToShortDateString();
            string hora = comboBoxHoraArriendo.Text;
            string fechayhora = (fecha + " " + hora);
            DateTime fecha1 = DateTime.ParseExact(fechayhora, "dd-MM-yyyy HH", System.Globalization.CultureInfo.InvariantCulture);
            int cantidadparticipantes = int.Parse(textBoxCantidadParticipantes.Text);
            Arriendo arriendo1 = new Arriendo(persona, tipopersona, instalacion, subtipoinstalacion, cantidadparticipantes, fecha1);
            string nombreevento = textBoxNombreEvento.Text;
            if (nombreevento != " ")
            {
                buttonAgendarEvento.Show();
            }

        }

        private void labelNombreEvento_Click(object sender, EventArgs e)
        {

        }

        private void labelCuposDisp_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNombreEvento_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCuposDisp_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelInstalacionDisp_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgendarEvento_Click(object sender, EventArgs e)
        {
            labelNombreEvento.Show();
            textBoxNombreEvento.Show();
            labelCuposDisponibles.Show();
            textBoxCuposDisponibles.Show();
            labelEventoRealizadoConExito.Hide();
            labelEventoFallido.Hide();
            string tipopersona = persona.GetTipoPersona();
            string tipoInstalacion = comboBoxSelecTipoInstalacion.Text;
            if (tipoInstalacion == "Cancha")
            {
                string subtipoinstalacion = comboBoxCanchasDisp.Text;
                string fecha = dateTimeArriendoUno.Value.ToShortDateString();
                string hora = comboBoxHoraArriendo.Text;
                string fechayhora = (fecha + " " + hora);
                DateTime fecha1 = DateTime.ParseExact(fechayhora, "dd-MM-yyyy HH", System.Globalization.CultureInfo.InvariantCulture);
                int cantidadparticipantes = int.Parse(textBoxCantidadParticipantes.Text);
                int cuposdisponibles = int.Parse(textBoxCuposDisponibles.Text);
                Arriendo arriendo1 = new Arriendo(persona, tipopersona, instalacion, subtipoinstalacion, cantidadparticipantes, fecha1);
                string nombreevento = textBoxNombreEvento.Text;
                bool respuestacrearevento = nuevoregistro.CrearEvento(nombreevento, cuposdisponibles, arriendo1);
                if (respuestacrearevento == true)
                {
                    Eventos nuevoevento = new Eventos(arriendo1, nombreevento, cuposdisponibles);
                    nuevoregistro.AgregarEventos(nuevoevento);
                    labelEventoRealizadoConExito.Show();
                    labelEventoFallido.Hide();

                }
                else
                {
                    labelEventoRealizadoConExito.Hide();
                    labelEventoFallido.Show();
                }
            }
            if (tipoInstalacion == "Sala de Clases")
            {
                string subtipoinstalacion = comboBoxSalasClaseDisp.Text;
                string fecha = dateTimeArriendoUno.Value.ToShortDateString();
                string hora = comboBoxHoraArriendo.Text;
                string fechayhora = (fecha + " " + hora);
                DateTime fecha1 = DateTime.ParseExact(fechayhora, "dd-MM-yyyy HH", System.Globalization.CultureInfo.InvariantCulture);
                int cantidadparticipantes = int.Parse(textBoxCantidadParticipantes.Text);
                int cuposdisponibles = int.Parse(textBoxCuposDisponibles.Text);
                Arriendo arriendo1 = new Arriendo(persona, tipopersona, instalacion, subtipoinstalacion, cantidadparticipantes, fecha1);
                string nombreevento = textBoxNombreEvento.Text;
                bool respuestacrearevento = nuevoregistro.CrearEvento(nombreevento, cuposdisponibles, arriendo1);
                if (respuestacrearevento == true)
                {
                    Eventos nuevoevento = new Eventos(arriendo1, nombreevento, cuposdisponibles);
                    nuevoregistro.AgregarEventos(nuevoevento);
                    labelEventoRealizadoConExito.Show();
                    labelEventoFallido.Hide();

                }
                else
                {
                    labelEventoRealizadoConExito.Hide();
                    labelEventoFallido.Show();
                }

            }
            if (tipoInstalacion == "Salas de Estudio")
            {
                string subtipoinstalacion = comboBoxSalaEstudioDisp.Text;
                string fecha = dateTimeArriendoUno.Value.ToShortDateString();
                string hora = comboBoxHoraArriendo.Text;
                string fechayhora = (fecha + " " + hora);
                DateTime fecha1 = DateTime.ParseExact(fechayhora, "dd-MM-yyyy HH", System.Globalization.CultureInfo.InvariantCulture);
                int cantidadparticipantes = int.Parse(textBoxCantidadParticipantes.Text);
                int cuposdisponibles = int.Parse(textBoxCuposDisponibles.Text);
                Arriendo arriendo1 = new Arriendo(persona, tipopersona, instalacion, subtipoinstalacion, cantidadparticipantes, fecha1);
                string nombreevento = textBoxNombreEvento.Text;
                bool respuestacrearevento = nuevoregistro.CrearEvento(nombreevento, cuposdisponibles, arriendo1);
                if (respuestacrearevento == true)
                {
                    Eventos nuevoevento = new Eventos(arriendo1, nombreevento, cuposdisponibles);
                    nuevoregistro.AgregarEventos(nuevoevento);
                    labelEventoRealizadoConExito.Show();
                    labelEventoFallido.Hide();

                }
                else
                {
                    labelEventoRealizadoConExito.Hide();
                    labelEventoFallido.Show();
                }
            }
            if(tipoInstalacion == "Espacios Públicos")
            {
                string subtipoinstalacion = comboBoxEspaciosPublicosDisp.Text;
                string fecha = dateTimeArriendoUno.Value.ToShortDateString();
                string hora = comboBoxHoraArriendo.Text;
                string fechayhora = (fecha + " " + hora);
                DateTime fecha1 = DateTime.ParseExact(fechayhora, "dd-MM-yyyy HH", System.Globalization.CultureInfo.InvariantCulture);
                int cantidadparticipantes = int.Parse(textBoxCantidadParticipantes.Text);
                int cuposdisponibles = int.Parse(textBoxCuposDisponibles.Text);
                Arriendo arriendo1 = new Arriendo(persona, tipopersona, instalacion, subtipoinstalacion, cantidadparticipantes, fecha1);
                string nombreevento = textBoxNombreEvento.Text;
                bool respuestacrearevento = nuevoregistro.CrearEvento(nombreevento, cuposdisponibles, arriendo1);
                if (respuestacrearevento == true)
                {
                    Eventos nuevoevento = new Eventos(arriendo1, nombreevento, cuposdisponibles);
                    nuevoregistro.AgregarEventos(nuevoevento);
                    labelEventoRealizadoConExito.Show();
                    labelEventoFallido.Hide();

                }
                else
                {
                    labelEventoRealizadoConExito.Hide();
                    labelEventoFallido.Show();
                }
            }
            
        }


        private void buttonCrearInstalacionC_Click(object sender, EventArgs e)
        {

            try
            {

                string tipoInstalacion = comboBoxTipoInstalacionC.Text;
                string nombreInstalacion = textBoxNombreInstalacion.Text;
                string capacidadInstalacionTexto = textBoxCapacidadInstalacion.Text;
                int capacidad = int.Parse(capacidadInstalacionTexto);
                string ubicacion = textBoxUbicacionInstalacion.Text;
                Instalacion nuevainstalacion = new Instalacion(tipoInstalacion, capacidad, ubicacion);
                nuevoregistro.AgregarInstalacion(nuevainstalacion);
                if (tipoInstalacion == "Cancha")
                {
                    Cancha canchanueva = new Cancha(nombreInstalacion, ubicacion, capacidad, tipoInstalacion);
                    nuevoregistro.AgregarCancha(canchanueva);
                    labelnstalacionCreadaExito.Show();
                }
                if (tipoInstalacion == "Sala de Clases")
                {
                    SalaClases salaclasenueva = new SalaClases(ubicacion, nombreInstalacion, capacidad, tipoInstalacion);
                    nuevoregistro.AgregarSalaClase(salaclasenueva);
                    labelnstalacionCreadaExito.Show();
                }
                if (tipoInstalacion == "Sala de Estudios")
                {
                    SalaEstudio salaestudionueva = new SalaEstudio(nombreInstalacion, tipoInstalacion, capacidad, ubicacion);
                    nuevoregistro.AgregarSalaEstudio(salaestudionueva);
                    labelnstalacionCreadaExito.Show();
                }
                if (tipoInstalacion == "Espacios Públicos")
                {
                    EspaciosPublicos espaciospublnuevos = new EspaciosPublicos(nombreInstalacion, capacidad, ubicacion, tipoInstalacion);
                    nuevoregistro.AgregarEspacioPublico(espaciospublnuevos);
                    labelnstalacionCreadaExito.Show();
                }
            }
            catch
            {

            }

        }

        private void comboBoxTipoInstalacionC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombreInstalacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCapacidadInstalacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUbicacionInstalacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelnstalacionCreadaExito_Click(object sender, EventArgs e)
        {

        }

        private void buttonMostrarListaUsuarios_Click(object sender, EventArgs e)
        {
            
            listBoxMostrarArriendos.Hide();
            listBoxEventos.Hide();
            listBoxMostrarUsuario.Show();
            listBoxMostrarInstalaciones.Hide();
            textBoxDetalleInstalacion.Hide();
            textBoxDetalleArriendo.Hide();
            textBoxDetalleEvento.Hide();
            buttonEliminarEvento.Hide();
            buttonEliminarArriendo.Hide();
            listBoxMostrarParticipantesEventos.Hide();
          
            int elementosListBox = listBoxMostrarUsuario.Items.Count;

            if (elementosListBox == 0)
            {
                List<Persona> personas = nuevoregistro.ObtenerListaPersonas();
                if (persona.GetTipoPersona() == "Administrador")
                {                    
                    foreach (Persona persona in personas)
                    {
                        string str = persona.GetTipoPersona();
                        string nombrepersona = persona.GetNombreyApellido();
                        string atributospersona = (str + " " + nombrepersona);

                        if (!listBoxMostrarUsuario.Items.Contains(atributospersona) == true)
                        {
                            this.listBoxMostrarUsuario.Items.Add(atributospersona);
                        }

                    }

                }
                else
                {
                    string nombreusuario = persona.GetNombreyApellido();
                    foreach (Persona persona1 in personas)
                    {
                        string nombreexistente = persona1.GetNombreyApellido();
                        
                        if (nombreexistente == nombreusuario)
                        {
                            string str = persona.GetTipoPersona();
                            string nombrepersona = persona.GetNombreyApellido();
                            string atributospersona = (str + " " + nombrepersona);

                            if (!listBoxMostrarUsuario.Items.Contains(atributospersona) == true)
                            {
                                this.listBoxMostrarUsuario.Items.Add(atributospersona);
                            }

                        }
                    }

                }
                
            }       
        }
        private void buttonMostrarListaInstalaciones_Click(object sender, EventArgs e)
        {
            listBoxMostrarArriendos.Hide();
            listBoxEventos.Hide();
            listBoxMostrarUsuario.Hide();
            listBoxMostrarInstalaciones.Show();
            textBoxDetalleUsuario.Hide();
            textBoxDetalleArriendo.Hide();
            textBoxDetalleEvento.Hide();
            buttonEliminarEvento.Hide();
            buttonEliminarEvento.Hide();
            listBoxMostrarParticipantesEventos.Hide();
            int numeroinstalaciones = listBoxMostrarInstalaciones.Items.Count;

            if (numeroinstalaciones == 0)
            {
                List<Instalacion> instalaciones = nuevoregistro.ObtenerListaInstalaciones();
                List<Cancha> canchas = nuevoregistro.ObtenerListaCanchas();
                List<SalaEstudio> salasestudio = nuevoregistro.ObtenerListaSalasEstudio();
                List<SalaClases> salasclase = nuevoregistro.ObtenerListaSalaClases();
                List<EspaciosPublicos> espaciospublicos = nuevoregistro.ObtenerListaEspaciosPublicos();
                foreach (Cancha cancha in canchas)
                {
                    string tipocancha = cancha.GetTipoCancha();
                    string str = cancha.GetInstalacion().ToString();
                    string ubicacion = cancha.GetUbicacion().ToString();
                    string atributos = (tipocancha + " " + str);

                    if (!listBoxMostrarInstalaciones.Items.Contains(atributos) == true)
                    {
                        this.listBoxMostrarInstalaciones.Items.Add(atributos);
                    }
                }
                foreach (SalaClases salaclases in salasclase)
                {
                    string tiposalaclase = salaclases.GetNumSala();
                    string str = salaclases.GetInstalacion().ToString();
                    string ubicacion = salaclases.GetUbicacion().ToString();
                    string atributos = (tiposalaclase + " " + str);

                    if (!listBoxMostrarInstalaciones.Items.Contains(atributos))
                    {
                        this.listBoxMostrarInstalaciones.Items.Add(atributos);
                    }
                }
                foreach (SalaEstudio salaestudio in salasestudio)
                {
                    string tiposalaestudio = salaestudio.GetNumSala();
                    string str = salaestudio.GetInstalacion().ToString();
                    string ubicacion = salaestudio.GetUbicacion().ToString();
                    string atributos = (tiposalaestudio + " " + str);

                    if (!listBoxMostrarInstalaciones.Items.Contains(atributos))
                    {
                        this.listBoxMostrarInstalaciones.Items.Add(atributos);
                    }
                }
                foreach (EspaciosPublicos espaciopublico in espaciospublicos)
                {
                    string tipoespaciopublico = espaciopublico.GetTipoEspaciosPublicos();
                    string str = espaciopublico.GetInstalacion().ToString();
                    string ubicacion = espaciopublico.GetUbicacion().ToString();
                    string atributos = (tipoespaciopublico + " " + str);

                    if (!listBoxMostrarInstalaciones.Items.Contains(atributos))
                    {
                        this.listBoxMostrarInstalaciones.Items.Add(atributos);

                    }
                }
            }
            else
            {
                listBoxMostrarInstalaciones.Items.Clear();
                List<Instalacion> instalaciones = nuevoregistro.ObtenerListaInstalaciones();
                List<Cancha> canchas = nuevoregistro.ObtenerListaCanchas();
                List<SalaEstudio> salasestudio = nuevoregistro.ObtenerListaSalasEstudio();
                List<SalaClases> salasclase = nuevoregistro.ObtenerListaSalaClases();
                List<EspaciosPublicos> espaciospublicos = nuevoregistro.ObtenerListaEspaciosPublicos();
                foreach (Cancha cancha in canchas)
                {
                    string tipocancha = cancha.GetTipoCancha();
                    string str = cancha.GetInstalacion().ToString();
                    string ubicacion = cancha.GetUbicacion().ToString();
                    string atributos = (tipocancha + " " + str);

                    if (!listBoxMostrarInstalaciones.Items.Contains(atributos) == true)
                    {
                        this.listBoxMostrarInstalaciones.Items.Add(atributos);
                    }
                }
                foreach (SalaClases salaclases in salasclase)
                {
                    string tiposalaclase = salaclases.GetNumSala();
                    string str = salaclases.GetInstalacion().ToString();
                    string ubicacion = salaclases.GetUbicacion().ToString();
                    string atributos = (tiposalaclase + " " + str);

                    if (!listBoxMostrarInstalaciones.Items.Contains(atributos))
                    {
                        this.listBoxMostrarInstalaciones.Items.Add(atributos);
                    }
                }
                foreach (SalaEstudio salaestudio in salasestudio)
                {
                    string tiposalaestudio = salaestudio.GetNumSala();
                    string str = salaestudio.GetInstalacion().ToString();
                    string ubicacion = salaestudio.GetUbicacion().ToString();
                    string atributos = (tiposalaestudio + " " + str);

                    if (!listBoxMostrarInstalaciones.Items.Contains(atributos))
                    {
                        this.listBoxMostrarInstalaciones.Items.Add(atributos);
                    }
                }
                foreach (EspaciosPublicos espaciopublico in espaciospublicos)
                {
                    string tipoespaciopublico = espaciopublico.GetTipoEspaciosPublicos();
                    string str = espaciopublico.GetInstalacion().ToString();
                    string ubicacion = espaciopublico.GetUbicacion().ToString();
                    string atributos = (tipoespaciopublico + " " + str);

                    if (!listBoxMostrarInstalaciones.Items.Contains(atributos))
                    {
                        this.listBoxMostrarInstalaciones.Items.Add(atributos);

                    }
                }

            }

        }

        private void buttonMostrarListaArriendos_Click(object sender, EventArgs e)
        {
            listBoxMostrarArriendos.Show();
            listBoxEventos.Hide();
            listBoxMostrarUsuario.Hide();
            listBoxMostrarInstalaciones.Hide();
            textBoxDetalleInstalacion.Hide();
            textBoxDetalleUsuario.Hide();
            textBoxDetalleEvento.Hide();
            buttonEliminarEvento.Hide();
            buttonEliminarArriendo.Hide();
            
            listBoxMostrarParticipantesEventos.Hide();
            int numeroArriendos = listBoxMostrarArriendos.Items.Count;

            if (numeroArriendos == 0)
            {
                List<Arriendo> arriendos = nuevoregistro.ObtenerListaArriendos();
                string tipopersona = persona.GetTipoPersona();
                if (tipopersona == "Administrador")
                {
                    foreach (Arriendo arriendo in arriendos)
                    {
                        string subtipoinstalacion = arriendo.GetSubtipoInstalacion();
                        string subtipopersona = arriendo.GetSubtipoPersona();
                        string fechayhoraArriendo = arriendo.GetHoraFecha().ToString();
                        string atributos = (subtipoinstalacion + " " + fechayhoraArriendo);

                        if (!listBoxMostrarArriendos.Items.Contains(atributos))
                        {
                            listBoxMostrarArriendos.Items.Add(atributos);
                        }
                    }      
                }
                else
                {
                    string nombrepersona = persona.GetNombreyApellido();
                    foreach (Arriendo arriendo in arriendos)
                    {
                        Persona personaarriendo = arriendo.GetPersona();
                        string nombrepersonaarriendo = personaarriendo.GetNombreyApellido();
                        if (nombrepersonaarriendo == nombrepersona)
                        {
                            string subtipoinstalacion = arriendo.GetSubtipoInstalacion();
                            string subtipopersona = arriendo.GetSubtipoPersona();
                            string fechayhoraArriendo = arriendo.GetHoraFecha().ToString();
                            string atributos = (subtipoinstalacion + " " + fechayhoraArriendo);

                            if (!listBoxMostrarArriendos.Items.Contains(atributos))
                            {
                                this.listBoxMostrarArriendos.Items.Add(atributos);

                            }

                        }



                    }

                }


            }
            else
            {
                listBoxMostrarArriendos.Items.Clear();
                List<Arriendo> arriendos = nuevoregistro.ObtenerListaArriendos();
                string tipopersona = persona.GetTipoPersona();
                if (tipopersona == "Administrador")
                {
                    foreach (Arriendo arriendo in arriendos)
                    {
                        string subtipoinstalacion = arriendo.GetSubtipoInstalacion();
                        string subtipopersona = arriendo.GetSubtipoPersona();
                        string fechayhoraArriendo = arriendo.GetHoraFecha().ToString();
                        string atributos = (subtipoinstalacion + " " + fechayhoraArriendo);

                        if (!listBoxMostrarArriendos.Items.Contains(atributos))
                        {
                            listBoxMostrarArriendos.Items.Add(atributos);
                        }
                    }
                }
                else
                {
                    string nombrepersona = persona.GetNombreyApellido();
                    foreach (Arriendo arriendo in arriendos)
                    {
                        Persona personaarriendo = arriendo.GetPersona();
                        string nombrepersonaarriendo = personaarriendo.GetNombreyApellido();
                        if (nombrepersonaarriendo == nombrepersona)
                        {
                            string subtipoinstalacion = arriendo.GetSubtipoInstalacion();
                            string subtipopersona = arriendo.GetSubtipoPersona();
                            string fechayhoraArriendo = arriendo.GetHoraFecha().ToString();
                            string atributos = (subtipoinstalacion + " " + fechayhoraArriendo);

                            if (!listBoxMostrarArriendos.Items.Contains(atributos))
                            {
                                this.listBoxMostrarArriendos.Items.Add(atributos);

                            }

                        }



                    }

                }

            }

        }

        private void buttonMostrarListaEventos_Click(object sender, EventArgs e)
        {

            listBoxMostrarArriendos.Hide();
            listBoxEventos.Show();
            listBoxMostrarUsuario.Hide();
            listBoxMostrarInstalaciones.Hide();
            textBoxDetalleUsuario.Hide();
            textBoxDetalleArriendo.Hide();
            textBoxDetalleInstalacion.Hide();
            buttonEliminarArriendo.Hide();
            listBoxMostrarParticipantesEventos.Hide();

            List <Eventos> eventos = nuevoregistro.ObtenerEventos();
            int numeroEventos = listBoxEventos.Items.Count;
            
            if (numeroEventos == 0)
            {
                string tipopersona = persona.GetTipoPersona();
                if (tipopersona == "Administrador")
                {
                    foreach (Eventos evento in eventos)
                    {
                        string nombreEvento = evento.GetNomnbreEvento();

                        if (!listBoxEventos.Items.Contains(nombreEvento))
                        {
                            this.listBoxEventos.Items.Add(nombreEvento);
                        }
                    }
                }
                else
                {
                    foreach (Eventos evento in eventos)
                    {
                        string nombrepersona = persona.GetNombreyApellido();
                        Arriendo arriendoevento = evento.GetArriendo();
                        Persona arrendatario = arriendoevento.GetPersona();
                        string nombrearrendatario = arrendatario.GetNombreyApellido();
                        if (nombrearrendatario == nombrepersona)
                        {
                            
                            string nombreEvento = evento.GetNomnbreEvento();
                            string atributosevento = (nombrearrendatario + " " + nombreEvento);
                            

                            if (!listBoxEventos.Items.Contains(nombrearrendatario))
                            {
                                this.listBoxEventos.Items.Add(nombreEvento);
                                
                            }

                        }
                        
                    }
                }
                
            }
            else
            {
                listBoxEventos.Items.Clear();
                string tipopersona = persona.GetTipoPersona();
                if (tipopersona == "Administrador")
                {
                    foreach (Eventos evento in eventos)
                    {
                        string nombreEvento = evento.GetNomnbreEvento();

                        if (!listBoxEventos.Items.Contains(nombreEvento))
                        {
                            this.listBoxEventos.Items.Add(nombreEvento);
                        }
                    }
                }
                else
                {
                    foreach (Eventos evento in eventos)
                    {
                        string nombrepersona = persona.GetNombreyApellido();
                        Arriendo arriendoevento = evento.GetArriendo();
                        Persona arrendatario = arriendoevento.GetPersona();
                        string nombrearrendatario = arrendatario.GetNombreyApellido();
                        if (nombrearrendatario == nombrepersona)
                        {

                            string nombreEvento = evento.GetNomnbreEvento();
                            string atributosevento = (nombrearrendatario + " " + nombreEvento);


                            if (!listBoxEventos.Items.Contains(nombrearrendatario))
                            {
                                this.listBoxEventos.Items.Add(nombreEvento);

                            }

                        }

                    }
                }

            }
        }

        private void buttonIraMenu_Click(object sender, EventArgs e)
        {
            panel3.BringToFront();
        }

        private void buttonIrAlMenu_Click(object sender, EventArgs e)
        {
            panel3.BringToFront();
        }
        
        //Mostrar Datos
        

        private void buttonAgregarseAlEvento_Click(object sender, EventArgs e)
        {
            string eventos = comboBoxMostrarEventosDisponibles.Text;
            int index = eventos.LastIndexOf(" ");
            string evento1 = eventos.Remove(index);
            bool respuestaevento = nuevoregistro.InscribirseAevento(evento1);
            if (respuestaevento == true)
            {
                //Actualizar disponibilidad evento -1 cupo
                labelAgregadoConExitoAlEvento.Show();
                labelAgregarEventoFallido.Hide();
                List<Eventos> eventos2 = nuevoregistro.ObtenerEventos();
                string nombreparticipante = persona.GetNombreyApellido();
                string participanteEvento = (evento1 + " - " + nombreparticipante);
                nuevoregistro.AgregarParticipanteEvento(participanteEvento);
                
                foreach (Eventos evento in eventos2)
                {

                    string nombreEvento = evento.GetNomnbreEvento();
                    int disp = evento.Disponibilidad();
                    int disp2 = (disp + 1);
                    string disp1 = disp.ToString();
                    string disp3 = disp2.ToString();
                    string atributos = (nombreEvento + " " + disp1);
                    string atributos1 = (nombreEvento + " " + disp3);


                    if (comboBoxMostrarEventosDisponibles.Items.Contains(atributos))
                    {
                        continue;
                    }
                    else
                    {
                        this.comboBoxMostrarEventosDisponibles.Items.Remove(atributos1);
                        this.comboBoxMostrarEventosDisponibles.Items.Add(atributos);

                    }

                }


            }
            else
            {
                //Agregar label, no ha podido ingresar al evento
                labelAgregadoConExitoAlEvento.Hide();
                labelAgregarEventoFallido.Show();
            }

        }

        private void comboBoxMostrarEventosDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelAgregadoConExitoAlEvento_Click(object sender, EventArgs e)
        {

        }

        private void labelAgregarEventoFallido_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonVolverMenu_Click(object sender, EventArgs e)
        {
            panel3.BringToFront();
        }

        private void buttonVolverAlMenu_Click(object sender, EventArgs e)
        {
            panel3.BringToFront();
        }

        private void buttonVolverAlMenu3_Click(object sender, EventArgs e)
        {
            panel3.BringToFront();
        }

        private void labelEventoRealizadoConExito_Click(object sender, EventArgs e)
        {

        }

        private void labelEventoFallido_Click(object sender, EventArgs e)
        {

        }

        private void labelCuposDisponibles_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCuposDisponibles_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelArriendoFallido_Click(object sender, EventArgs e)
        {

        }
                
        private void textBoxDetalleEvento_TextChanged(object sender, EventArgs e)
        {

        }
        private void listBoxEventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemseleccionado = listBoxEventos.SelectedItem.ToString();
            List<Eventos> eventos = nuevoregistro.ObtenerEventos();
            this.textBoxDetalleEvento.Clear();


            textBoxDetalleArriendo.Hide();
            textBoxDetalleInstalacion.Hide();
            textBoxDetalleUsuario.Hide();

            foreach (Eventos evento in eventos)
            {
                string nombrevento = evento.GetNomnbreEvento();
                Arriendo eventarriendo = evento.GetArriendo();
                Persona duenoEvento = eventarriendo.GetPersona();
                string dueno = duenoEvento.GetNombreyApellido();
                string tipodueno = duenoEvento.GetTipoPersona();
                DateTime horaevento = eventarriendo.GetHoraFecha();
                string fechayhoraevento = horaevento.ToString();
                if (itemseleccionado == nombrevento)
                {
                    this.textBoxDetalleEvento.AppendText("El creador del evento es" + " " + dueno);
                    textBoxDetalleEvento.Show();
                    buttonEliminarEvento.Show();
                    listBoxMostrarParticipantesEventos.Show();

                    int elementosListBox = listBoxMostrarParticipantesEventos.Items.Count;

                    if (elementosListBox == 0)
                    {
                        List<String> participantesEvento = nuevoregistro.ObtenerListaParticipantesEvento();
                        if (persona.GetTipoPersona() == "Administrador")
                        {
                            foreach (String partevent in participantesEvento)
                            {

                                if (!listBoxMostrarParticipantesEventos.Items.Contains(nombrevento) == true)
                                {
                                    this.listBoxMostrarParticipantesEventos.Items.Add(partevent);
                                }

                            }

                        }
                        else
                        {
                            string nombreusuario = persona.GetNombreyApellido();
                            foreach (String partevent in participantesEvento)
                            {

                                if (!listBoxMostrarParticipantesEventos.Items.Contains(nombrevento) == true)
                                {
                                    this.listBoxMostrarParticipantesEventos.Items.Add(partevent);
                                }

                            }

                        }

                    }



                }
            }

        }

        private void listBoxMostrarArriendos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemseleccionado = listBoxMostrarArriendos.SelectedItem.ToString();
            List<Arriendo> arriendos = nuevoregistro.ObtenerListaArriendos();
            this.textBoxDetalleArriendo.Clear();
            textBoxDetalleEvento.Hide();
    
            textBoxDetalleInstalacion.Hide();
            textBoxDetalleUsuario.Hide();
            buttonEliminarEvento.Hide();
            buttonEliminarArriendo.Hide();

            foreach (Arriendo arriendo in arriendos)
            {
                string subtipoinstalacion = arriendo.GetSubtipoInstalacion();
                Persona arrendatario = arriendo.GetPersona();
                string nombrearrendatario = arrendatario.GetNombreyApellido();
                string tipoarrendatario = arriendo.GetSubtipoPersona();
                DateTime horarriendo = arriendo.GetHoraFecha();
                string fechayhoraarriendo = horarriendo.ToString();
                string itemarriendo = (subtipoinstalacion + " " + fechayhoraarriendo);
                string mensaje = (tipoarrendatario + " " + nombrearrendatario + " " + subtipoinstalacion);


                if (itemseleccionado == itemarriendo)
                {
                    textBoxDetalleEvento.Hide();
                    this.textBoxDetalleArriendo.AppendText(mensaje);
                    textBoxDetalleArriendo.Show();
                    textBoxDetalleInstalacion.Hide();
                    buttonEliminarArriendo.Show();

                }
            }

        }

        private void textBoxDetalleArriendo_TextChanged(object sender, EventArgs e)
        {


        }

        private void listBoxMostrarInstalaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemseleccionado = listBoxMostrarInstalaciones.SelectedItem.ToString();
            this.textBoxDetalleInstalacion.Clear();
            List<Instalacion> instalaciones = nuevoregistro.ObtenerListaInstalaciones();
            List<Cancha> canchas = nuevoregistro.ObtenerListaCanchas();
            List<SalaEstudio> salasestudio = nuevoregistro.ObtenerListaSalasEstudio();
            List<SalaClases> salasclase = nuevoregistro.ObtenerListaSalaClases();
            List<EspaciosPublicos> espaciospublicos = nuevoregistro.ObtenerListaEspaciosPublicos();
            textBoxDetalleEvento.Hide();
            textBoxDetalleArriendo.Hide();
            textBoxDetalleInstalacion.Hide();
            textBoxDetalleUsuario.Hide();
            buttonEliminarEvento.Hide();
            buttonEliminarArriendo.Hide();

            foreach (Cancha cancha in canchas)
            {
                string tipocancha = cancha.GetTipoCancha();
                string str = cancha.GetInstalacion().ToString();
                string ubicacion = cancha.GetUbicacion().ToString();
                string atributos = (tipocancha + " " + str);
                string mensaje = (tipocancha + " " + str + " " + ubicacion);


                if (itemseleccionado == atributos)
                {
                    textBoxDetalleInstalacion.Show();
                    this.textBoxDetalleInstalacion.AppendText(mensaje);

                }
            }

            foreach (SalaClases salaclases in salasclase)
            {
                string tiposalaclase = salaclases.GetNumSala();
                string str = salaclases.GetInstalacion().ToString();
                string ubicacion = salaclases.GetUbicacion().ToString();
                string atributos = (tiposalaclase + " " + str);
                string mensaje = (tiposalaclase + " " + str + " " + ubicacion);


                if (itemseleccionado == atributos)
                {
                    textBoxDetalleInstalacion.Show();
                    this.textBoxDetalleInstalacion.AppendText(mensaje);
                }
            }
            foreach (SalaEstudio salaestudio in salasestudio)
            {
                string tiposalaestudio = salaestudio.GetNumSala();
                string str = salaestudio.GetInstalacion().ToString();
                string ubicacion = salaestudio.GetUbicacion().ToString();
                string atributos = (tiposalaestudio + " " + str);
                string mensaje = (tiposalaestudio + " " + str + " " + ubicacion);

                if (itemseleccionado == atributos)
                {
                    textBoxDetalleInstalacion.Show();
                    this.textBoxDetalleInstalacion.AppendText(mensaje);
                }
            }
            foreach (EspaciosPublicos espaciopublico in espaciospublicos)
            {
                string tipoespaciopublico = espaciopublico.GetTipoEspaciosPublicos();
                string str = espaciopublico.GetInstalacion().ToString();
                string ubicacion = espaciopublico.GetUbicacion().ToString();
                string atributos = (tipoespaciopublico + " " + str);
                string mensaje = (tipoespaciopublico + " " + str + " " + ubicacion);


                if (itemseleccionado == atributos)
                {
                    textBoxDetalleInstalacion.Show();
                    this.textBoxDetalleInstalacion.AppendText(mensaje);
                }
            }


        }

        private void textBoxDetalleInstalacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDetalleUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxMostrarUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemseleccionado = listBoxMostrarUsuario.SelectedItem.ToString();
            this.textBoxDetalleUsuario.Clear();
            List<Persona> personas = nuevoregistro.ObtenerListaPersonas();
            textBoxDetalleEvento.Hide();
            textBoxDetalleArriendo.Hide();
            textBoxDetalleInstalacion.Hide();
            buttonEliminarEvento.Hide();
            buttonEliminarArriendo.Hide();

            foreach (Persona persona in personas)
            {
                string str = persona.GetTipoPersona();
                string rut = persona.GetRut();
                string nombrepersona = persona.GetNombreyApellido();
                string atributospersona = (str + " " + nombrepersona);
                string mensaje = (str + " " + nombrepersona + " " + rut);

                if (itemseleccionado == atributospersona)
                {
                    textBoxDetalleUsuario.Show();
                    this.textBoxDetalleUsuario.AppendText(mensaje);
                }

            }
        }

        private void buttonEliminarEvento_Click(object sender, EventArgs e)
        {
            string itemseleccionado = listBoxEventos.SelectedItem.ToString();
            Eventos eventoporborrar = nuevoregistro.EventoPorBorrar(itemseleccionado);
            nuevoregistro.EliminarEvento(eventoporborrar);

        }
        private void buttonEliminarArriendo_Click(object sender, EventArgs e)
        {
            string itemseleccionado = listBoxMostrarArriendos.SelectedItem.ToString();
            Arriendo arriendoporborrar = nuevoregistro.ArriendoPorBorrar2(itemseleccionado);
            nuevoregistro.EliminarArriendo(arriendoporborrar);


        }



        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            BinaryFormatter bin = new BinaryFormatter();
            if (File.Exists("../../Serialized.txt"))
            {
                Stream stream = new FileStream("../../Serialized.txt", FileMode.Open, FileAccess.Write);
                bin.Serialize(stream, nuevoregistro);
                stream.Close();
            }
            else
            {
                Stream stream = new FileStream("../../Serialized.txt", FileMode.Create, FileAccess.Write);
                bin.Serialize(stream, nuevoregistro);
                stream.Close();
            }
            base.OnFormClosing(e);
        }

        private void listBoxMostrarParticipantesEventos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButtonArriendoUnico_CheckedChanged(object sender, EventArgs e)
        {
            labelFechaA.Show();
            comboBoxHoraArriendo.Show();
            dateTimeArriendoUno.Show();
            
            labelHora.Show();
            
        }

        private void radioButtonArriendoMultiple_CheckedChanged(object sender, EventArgs e)
        {
            labelFechaA.Hide();
            comboBoxHoraArriendo.Show();
            dateTimeArriendoUno.Show();
            labelHora.Show();
            labelCantidadParticipantes.Show();
            textBoxCantidadParticipantes.Show();

        }

        private void dateTimeArriendoUno_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeArriendoDos_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelFechaFin_Click(object sender, EventArgs e)
        {

        }

        private void labelFechaA_Click(object sender, EventArgs e)
        {

        }

        private void labelHora_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxHoraArriendo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelDia_Click(object sender, EventArgs e)
        {

        }

        private void textBoxcantnoarrendados_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
