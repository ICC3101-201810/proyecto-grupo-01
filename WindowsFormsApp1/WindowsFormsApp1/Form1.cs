﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        RegistroHistorico nuevoregistro = new RegistroHistorico();
        Persona nuevapersona = new Persona("194632126", "Antonia Saez", "Alumno");
        Persona otrapersona = new Persona("190843408", "Joaquin Alonso", "Administrador");
        Administrador admin1 = new Administrador("191234567", "Administrador1", "123456789", "Administrador");
        Cancha cancha1 = new Cancha("futbol1", "Univ Los Andes", 12, "Cancha");
        


        Persona persona = null;
        Instalacion instalacion = null;
        
        public Form1(RegistroHistorico nuevoregistro, Persona persona)
        {
            InitializeComponent();
            

            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            panel4.Dock = System.Windows.Forms.DockStyle.Fill;

            
            panel1.BringToFront();
            labelContraseñaAdmin.Hide();
            textBoxContraseñaAdmin.Hide();
            labelContraseñaAdminIncorrecta.Hide();
            buttonIngresar.Hide();


        }

        private void BotonVerificar_Click(object sender, EventArgs e)
        {
            //Agregue usuario para probar si funcionaba
            nuevoregistro.AgregarUsuario(nuevapersona);
            nuevoregistro.AgregarUsuario(otrapersona);
            nuevoregistro.AgregarAdministrador(admin1);
            nuevoregistro.AgregarUsuario(admin1);
            

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
                persona = nuevoregistro.GetPersona(rut);
                nuevoregistro.AgregarUsuario(persona);
                labelUsuarioCreadoExito.Show();
                buttonIrMenu.Show();
                

            }
            if (tipoUsuario == "Profesor")
            {
                nuevoregistro.AgregarProfesor(nuevoregistro.CrearProfesor(rut, nombre));
                persona = nuevoregistro.GetPersona(rut);
                nuevoregistro.AgregarUsuario(persona);
                labelUsuarioCreadoExito.Show();
                buttonIrMenu.Show();
                
            }
            if (tipoUsuario == "Funcionario")
            {
                nuevoregistro.AgregarFuncionario(nuevoregistro.CrearFuncionario(rut, nombre));
                persona = nuevoregistro.GetPersona(rut);
                nuevoregistro.AgregarUsuario(persona);
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
            
            labelInstalacionDisp.Hide();
            buttonAgendarEvento.Hide();
        }

        private void buttonRevisarEventosDisp_Click(object sender, EventArgs e)
        {

        }

        private void buttonMostrarDatos_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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
            }
            else
            {
                //Mostrar mensaje contraseña incorrecta
                labelContraseñaAdminIncorrecta.Show();

            }

        }

        private void comboBoxCanchasDisp_SelectedIndexChanged(object sender, EventArgs e)
        {
            nuevoregistro.AgregarCancha(cancha1);
            string tipocancha = cancha1.GetTipoCancha();
            this.comboBoxCanchasDisp.Items.AddRange(new object[] {
            "Cancha",
            "Sala de Clases",
            "Sala de Estudios",
            "Espacios Públicos"});


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
            //tipo instalacion:
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
                    string tiposalaclase = comboBoxCanchasDisp.Text;
                    SalaClases salaclase1 = nuevoregistro.VerificarExistenciaSalaClase(tiposalaclase);

                    bool respuestaArriendo = nuevoregistro.VerificarArriendoSaladeClaseExistente(persona, salaclase1, fecha1);
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
                        //La sala de clases no esta disponible
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
                if (instalacionescogida == "Sala de Estudios")
                {
                    buttonAgendarEvento.Hide();
                    labelInstalacionDisp.Hide();
                    instalacion = nuevoregistro.GetInstalacion(instalacionescogida);
                    string tiposalaestudio = comboBoxCanchasDisp.Text;
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
                    string tipoespacioescogido = comboBoxCanchasDisp.Text;
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
            Arriendo arriendo1 = new Arriendo(persona, tipopersona, instalacion, subtipoinstalacion, cantidadparticipantes, fecha1);
            nuevoregistro.AgregarArriendo(arriendo1);
            labelArriendoExitoso.Show();
            buttonCrearEvento.Show();
            labelNombreEvento.Hide();
            
            textBoxNombreEvento.Hide();
          
            labelInstalacionDisp.Hide();
            buttonVerificarDispArriendo.Hide();
            buttonAgendarEvento.Hide();

        }

        private void labelArriendoExitoso_Click(object sender, EventArgs e)
        {

        }

        private void buttonCrearEvento_Click(object sender, EventArgs e)
        {
        
            labelNombreEvento.Show();
            textBoxNombreEvento.Show();
            string tipopersona = persona.GetTipoPersona();
            string subtipoinstalacion = comboBoxCanchasDisp.Text;
            string fechayhora = textBoxFechaHoraArriendo.Text;
            DateTime fecha1 = DateTime.ParseExact(fechayhora, "yyyy-MM-dd HH", System.Globalization.CultureInfo.InvariantCulture);
            int cantidadparticipantes = int.Parse(textBoxCantidadParticipantes.Text);
            Arriendo arriendo1 = new Arriendo(persona, tipopersona, instalacion, subtipoinstalacion, cantidadparticipantes, fecha1);
            string nombreevento = textBoxNombreEvento.Text;
            if(nombreevento != " ")
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
            string tipopersona = persona.GetTipoPersona();
            string subtipoinstalacion = comboBoxCanchasDisp.Text;
            string fechayhora = textBoxFechaHoraArriendo.Text;
            DateTime fecha1 = DateTime.ParseExact(fechayhora, "yyyy-MM-dd HH", System.Globalization.CultureInfo.InvariantCulture);
            int cantidadparticipantes = int.Parse(textBoxCantidadParticipantes.Text);
            Arriendo arriendo1 = new Arriendo(persona, tipopersona, instalacion, subtipoinstalacion, cantidadparticipantes, fecha1);
            string nombreevento = textBoxNombreEvento.Text;
            bool respuestacrearevento = nuevoregistro.CrearEvento(nombreevento, cantidadparticipantes, arriendo1);
            if (respuestacrearevento == true)
            {
                Eventos nuevoevento = new Eventos(arriendo1, nombreevento, cantidadparticipantes);
                nuevoregistro.AgregarEventos(nuevoevento);

            }
        }
        
        
    }
}