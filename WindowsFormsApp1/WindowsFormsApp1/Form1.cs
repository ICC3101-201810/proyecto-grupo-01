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
            labelFechaHoraArriendo.Hide();
            textBoxFechaHoraArriendo.Hide();
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
                string atributos = (nombreEvento);


                if (comboBoxMostrarEventosDisponibles.Items.Contains(atributos))
                {
                    continue;
                }
                else
                {
                    this.comboBoxMostrarEventosDisponibles.Items.Add(atributos);

                }

            }
        }

        private void buttonMostrarDatos_Click(object sender, EventArgs e)
        {
            panel6.BringToFront();
            comboBoxMostrarArriendos.Hide();
            comboBoxMostrarEventos.Hide();
            comboBoxMostrarUsuarios.Hide();
            comboBoxMostrarInstalaciones.Hide();
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
                labelFechaHoraArriendo.Show();
                textBoxFechaHoraArriendo.Show();
                labelInstalacionNoDisp.Hide();
                labelCantidadParticipantes.Hide();
                textBoxCantidadParticipantes.Hide();
                buttonVerificarDispArriendo.Show();
                buttonArrendar.Hide();
                labelArriendoExitoso.Hide();
                buttonCrearEvento.Hide();
                labelNombreEvento.Hide();
                textBoxNombreEvento.Hide();


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
                labelFechaHoraArriendo.Show();
                textBoxFechaHoraArriendo.Show();
                labelInstalacionNoDisp.Hide();
                labelCantidadParticipantes.Hide();
                textBoxCantidadParticipantes.Hide();
                buttonVerificarDispArriendo.Show();
                buttonArrendar.Hide();
                labelArriendoExitoso.Hide();
                buttonCrearEvento.Hide();
                labelNombreEvento.Hide();

                textBoxNombreEvento.Hide();

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
                labelFechaHoraArriendo.Show();
                textBoxFechaHoraArriendo.Show();
                labelInstalacionNoDisp.Hide();
                labelCantidadParticipantes.Hide();
                textBoxCantidadParticipantes.Hide();
                buttonVerificarDispArriendo.Show();
                buttonArrendar.Hide();
                labelArriendoExitoso.Hide();
                buttonCrearEvento.Hide();
                labelNombreEvento.Hide();

                textBoxNombreEvento.Hide();

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
                labelFechaHoraArriendo.Show();
                textBoxFechaHoraArriendo.Show();
                labelInstalacionNoDisp.Hide();
                labelCantidadParticipantes.Hide();
                textBoxCantidadParticipantes.Hide();
                buttonVerificarDispArriendo.Show();
                buttonArrendar.Hide();
                labelArriendoExitoso.Hide();
                buttonCrearEvento.Hide();
                labelNombreEvento.Hide();

                textBoxNombreEvento.Hide();

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
            string fechayhora = textBoxFechaHoraArriendo.Text;

            try
            {
                DateTime fecha1 = DateTime.ParseExact(fechayhora, "yyyy-MM-dd HH", System.Globalization.CultureInfo.InvariantCulture);
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
                        if(tipopersona == "Profesor")
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
            string subtipoinstalacion = comboBoxCanchasDisp.Text;
            string fechayhora = textBoxFechaHoraArriendo.Text;
            DateTime fecha1 = DateTime.ParseExact(fechayhora, "yyyy-MM-dd HH", System.Globalization.CultureInfo.InvariantCulture);
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
            string fechayhora = textBoxFechaHoraArriendo.Text;
            DateTime fecha1 = DateTime.ParseExact(fechayhora, "yyyy-MM-dd HH", System.Globalization.CultureInfo.InvariantCulture);
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
                string fechayhora = textBoxFechaHoraArriendo.Text;
                DateTime fecha1 = DateTime.ParseExact(fechayhora, "yyyy-MM-dd HH", System.Globalization.CultureInfo.InvariantCulture);
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
                string fechayhora = textBoxFechaHoraArriendo.Text;
                DateTime fecha1 = DateTime.ParseExact(fechayhora, "yyyy-MM-dd HH", System.Globalization.CultureInfo.InvariantCulture);
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
                string fechayhora = textBoxFechaHoraArriendo.Text;
                DateTime fecha1 = DateTime.ParseExact(fechayhora, "yyyy-MM-dd HH", System.Globalization.CultureInfo.InvariantCulture);
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
                string fechayhora = textBoxFechaHoraArriendo.Text;
                DateTime fecha1 = DateTime.ParseExact(fechayhora, "yyyy-MM-dd HH", System.Globalization.CultureInfo.InvariantCulture);
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
            comboBoxMostrarArriendos.Hide();
            comboBoxMostrarEventos.Hide();
            comboBoxMostrarUsuarios.Show();
            comboBoxMostrarInstalaciones.Hide();
            string Usuarios = comboBoxMostrarUsuarios.Text;

            if (Usuarios != null)
            {
                List<Persona> personas = nuevoregistro.ObtenerListaPersonas();
                foreach (Persona persona in personas)
                {
                    string str = persona.GetTipoPersona();
                    string nombrepersona = persona.GetNombreyApellido();
                    string atributospersona = (str + " " + nombrepersona);
                    if (comboBoxMostrarUsuarios.Items.Contains(atributospersona))
                    {
                        continue;
                    }
                    else
                    {
                        this.comboBoxMostrarUsuarios.Items.Add(atributospersona);

                    }

                }
            }

        }

        private void buttonMostrarListaInstalaciones_Click(object sender, EventArgs e)
        {
            comboBoxMostrarArriendos.Hide();
            comboBoxMostrarEventos.Hide();
            comboBoxMostrarUsuarios.Hide();
            comboBoxMostrarInstalaciones.Show();
            string Instalaciones = comboBoxMostrarInstalaciones.Text;

            if (Instalaciones != null)
            {
                List<Instalacion> instalaciones = nuevoregistro.ObtenerListaInstalaciones();
                List<Cancha> canchas = nuevoregistro.ObtenerListaCanchas();
                List<SalaEstudio> salasestudio = nuevoregistro.ObtenerListaSalasEstudio();
                List<SalaClases> salasclase = nuevoregistro.ObtenerListaSalaClases();
                List<EspaciosPublicos> espaciospublicos = nuevoregistro.ObtenerListaEspaciosPublicos();
                foreach (Instalacion instalacion in instalaciones)
                {
                    string str = instalacion.GetInstalacion();
                    string ubicacion = instalacion.GetUbicacion();
                    if (instalacion.GetInstalacion() == "Cancha")
                    {
                        foreach (Cancha cancha in canchas)
                        {
                            string tipocancha = cancha.GetTipoCancha();
                            string atributos = (tipocancha + " " + str + " " + ubicacion);

                            if (comboBoxMostrarInstalaciones.Items.Contains(atributos))
                            {
                                continue;
                            }
                            else
                            {
                                this.comboBoxMostrarInstalaciones.Items.Add(atributos);

                            }

                        }
                    }
                    if (instalacion.GetInstalacion() == "Sala de Clases")
                    {
                        foreach (SalaClases salaclases in salasclase)
                        {
                            string tiposalaclase = salaclases.GetNumSala();
                            string atributos = (tiposalaclase + " " + str + " " + ubicacion);

                            if (comboBoxMostrarInstalaciones.Items.Contains(atributos))
                            {
                                continue;
                            }
                            else
                            {
                                this.comboBoxMostrarInstalaciones.Items.Add(atributos);

                            }

                        }

                    }
                    if (instalacion.GetInstalacion() == "Sala de Estudios")
                    {
                        foreach (SalaEstudio salaestudio in salasestudio)
                        {
                            string tiposalaestudio = salaestudio.GetNumSala();
                            string atributos = (tiposalaestudio + " " + str + " " + ubicacion);

                            if (comboBoxMostrarInstalaciones.Items.Contains(atributos))
                            {
                                continue;
                            }
                            else
                            {
                                this.comboBoxMostrarInstalaciones.Items.Add(atributos);

                            }

                        }

                    }
                    if (instalacion.GetInstalacion() == "Espacios Públicos")
                    {
                        foreach (EspaciosPublicos espaciopublico in espaciospublicos)
                        {
                            string tipoespaciopublico = espaciopublico.GetTipoEspaciosPublicos();
                            string atributos = (tipoespaciopublico + " " + str + " " + ubicacion);

                            if (comboBoxMostrarInstalaciones.Items.Contains(atributos))
                            {
                                continue;
                            }
                            else
                            {
                                this.comboBoxMostrarInstalaciones.Items.Add(atributos);

                            }

                        }

                    }
                    

                }
            }

        }
        // Este esta raro porque tiene que mostrar todos los datos del arriendo
        private void buttonMostrarListaArriendos_Click(object sender, EventArgs e)
        {
            comboBoxMostrarArriendos.Show();
            comboBoxMostrarEventos.Hide();
            comboBoxMostrarUsuarios.Hide();
            comboBoxMostrarInstalaciones.Hide();
            string Arriendos = comboBoxMostrarArriendos.Text;

            if (Arriendos != null)
            {
                List<Arriendo> arriendos = nuevoregistro.ObtenerListaArriendos();
                foreach (Arriendo arriendo in arriendos)
                {
                    string subtipoinstalacion = arriendo.GetSubtipoInstalacion();
                    string subtipopersona = arriendo.GetSubtipoPersona();
                    string fechayhoraArriendo = arriendo.GetHoraFecha().ToString();
                    string atributos = (subtipopersona + " " + subtipoinstalacion + " " + fechayhoraArriendo);

                    if (comboBoxMostrarArriendos.Items.Contains(atributos))
                    {
                        continue;
                    }
                    else
                    {
                        this.comboBoxMostrarArriendos.Items.Add(atributos);

                    }

                }
            }

        }
        private void buttonMostrarListaEventos_Click(object sender, EventArgs e)
        {
            comboBoxMostrarArriendos.Hide();
            comboBoxMostrarEventos.Show();
            comboBoxMostrarUsuarios.Hide();
            comboBoxMostrarInstalaciones.Hide();
            List < Eventos> eventos = nuevoregistro.ObtenerEventos();

            foreach (Eventos evento in eventos)
            {
                string nombreEvento = evento.GetNomnbreEvento();

                if (comboBoxMostrarEventos.Items.Contains(nombreEvento))
                {
                    continue;
                }
                else
                {
                    this.comboBoxMostrarEventos.Items.Add(nombreEvento);

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
        private void comboBoxMostrarUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMostrarInstalaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMostrarArriendos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMostrarEventos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAgregarseAlEvento_Click(object sender, EventArgs e)
        {
            string Eventos = comboBoxMostrarEventos.Text;
            bool respuestaevento = nuevoregistro.InscribirseAevento(Eventos);
            if (respuestaevento == true)
            {
                //Actualizar disponibilidad evento -1 cupo
                labelAgregadoConExitoAlEvento.Show();
                labelAgregarEventoFallido.Hide();

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


    }
}
