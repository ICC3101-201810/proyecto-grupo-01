﻿namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BotonVerificar = new System.Windows.Forms.Button();
            this.labelbienvenido = new System.Windows.Forms.Label();
            this.textBoxRecibirRut = new System.Windows.Forms.TextBox();
            this.labelIngreseRut = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.labelContraseñaAdminIncorrecta = new System.Windows.Forms.Label();
            this.labelContraseñaAdmin = new System.Windows.Forms.Label();
            this.textBoxContraseñaAdmin = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonCrearInstalacion = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonMostrarDatos = new System.Windows.Forms.Button();
            this.buttonRevisarEventosDisp = new System.Windows.Forms.Button();
            this.buttonArrendarInstalacion = new System.Windows.Forms.Button();
            this.labelMenu = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelFechaHoraArriendo = new System.Windows.Forms.Label();
            this.comboBoxEspaciosPublicosDisp = new System.Windows.Forms.ComboBox();
            this.comboBoxSalaEstudioDisp = new System.Windows.Forms.ComboBox();
            this.comboBoxSalasClaseDisp = new System.Windows.Forms.ComboBox();
            this.comboBoxCanchasDisp = new System.Windows.Forms.ComboBox();
            this.labelMuestraEspPublic = new System.Windows.Forms.Label();
            this.labelMuestraSalasEstudio = new System.Windows.Forms.Label();
            this.labelMostrarSalasClase = new System.Windows.Forms.Label();
            this.labelMuestraCanchas = new System.Windows.Forms.Label();
            this.comboBoxSelecTipoInstalacion = new System.Windows.Forms.ComboBox();
            this.labelSelecInstalacion = new System.Windows.Forms.Label();
            this.labelArrendar = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonIrMenu = new System.Windows.Forms.Button();
            this.labelTituloCrearUsuario = new System.Windows.Forms.Label();
            this.labelUsuarioCreadoExito = new System.Windows.Forms.Label();
            this.buttonCrearUsuario = new System.Windows.Forms.Button();
            this.labelEscogertipodeusuario = new System.Windows.Forms.Label();
            this.comboBoxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.textBoxNombreNuevo = new System.Windows.Forms.TextBox();
            this.labelEscribirNombre = new System.Windows.Forms.Label();
            this.textBoxFechaHoraArriendo = new System.Windows.Forms.TextBox();
            this.buttonVerificarDispArriendo = new System.Windows.Forms.Button();
            this.labelInstalacionNoDisp = new System.Windows.Forms.Label();
            this.labelCantidadParticipantes = new System.Windows.Forms.Label();
            this.textBoxCantidadParticipantes = new System.Windows.Forms.TextBox();
            this.buttonArrendar = new System.Windows.Forms.Button();
            this.labelArriendoExitoso = new System.Windows.Forms.Label();
            this.buttonCrearEvento = new System.Windows.Forms.Button();
            this.labelNombreEvento = new System.Windows.Forms.Label();
            this.textBoxNombreEvento = new System.Windows.Forms.TextBox();
            this.labelInstalacionDisp = new System.Windows.Forms.Label();
            this.buttonAgendarEvento = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BotonVerificar
            // 
            this.BotonVerificar.Location = new System.Drawing.Point(258, 203);
            this.BotonVerificar.Name = "BotonVerificar";
            this.BotonVerificar.Size = new System.Drawing.Size(200, 58);
            this.BotonVerificar.TabIndex = 0;
            this.BotonVerificar.Text = "Verificar rut";
            this.BotonVerificar.UseVisualStyleBackColor = true;
            this.BotonVerificar.Click += new System.EventHandler(this.BotonVerificar_Click);
            // 
            // labelbienvenido
            // 
            this.labelbienvenido.AutoSize = true;
            this.labelbienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbienvenido.Location = new System.Drawing.Point(100, 35);
            this.labelbienvenido.Name = "labelbienvenido";
            this.labelbienvenido.Size = new System.Drawing.Size(411, 29);
            this.labelbienvenido.TabIndex = 1;
            this.labelbienvenido.Text = "Bienvenido al registro de arriendo";
            this.labelbienvenido.Click += new System.EventHandler(this.labelbienvenido_Click);
            // 
            // textBoxRecibirRut
            // 
            this.textBoxRecibirRut.Location = new System.Drawing.Point(258, 155);
            this.textBoxRecibirRut.Name = "textBoxRecibirRut";
            this.textBoxRecibirRut.Size = new System.Drawing.Size(175, 22);
            this.textBoxRecibirRut.TabIndex = 2;
            this.textBoxRecibirRut.TextChanged += new System.EventHandler(this.TextBoxRecibirRut_TextChanged);
            // 
            // labelIngreseRut
            // 
            this.labelIngreseRut.AutoSize = true;
            this.labelIngreseRut.Location = new System.Drawing.Point(93, 160);
            this.labelIngreseRut.Name = "labelIngreseRut";
            this.labelIngreseRut.Size = new System.Drawing.Size(100, 17);
            this.labelIngreseRut.TabIndex = 3;
            this.labelIngreseRut.Text = "Ingrese su Rut";
            this.labelIngreseRut.Click += new System.EventHandler(this.labelIngreseRut_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.buttonIngresar);
            this.panel1.Controls.Add(this.labelContraseñaAdminIncorrecta);
            this.panel1.Controls.Add(this.labelContraseñaAdmin);
            this.panel1.Controls.Add(this.labelIngreseRut);
            this.panel1.Controls.Add(this.BotonVerificar);
            this.panel1.Controls.Add(this.labelbienvenido);
            this.panel1.Controls.Add(this.textBoxRecibirRut);
            this.panel1.Controls.Add(this.textBoxContraseñaAdmin);
            this.panel1.Location = new System.Drawing.Point(36, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 423);
            this.panel1.TabIndex = 4;
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(258, 370);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(197, 50);
            this.buttonIngresar.TabIndex = 8;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // labelContraseñaAdminIncorrecta
            // 
            this.labelContraseñaAdminIncorrecta.AutoSize = true;
            this.labelContraseñaAdminIncorrecta.Location = new System.Drawing.Point(207, 329);
            this.labelContraseñaAdminIncorrecta.Name = "labelContraseñaAdminIncorrecta";
            this.labelContraseñaAdminIncorrecta.Size = new System.Drawing.Size(304, 17);
            this.labelContraseñaAdminIncorrecta.TabIndex = 7;
            this.labelContraseñaAdminIncorrecta.Text = "La contraseña es incorrecta, trate nuevamente";
            this.labelContraseñaAdminIncorrecta.Click += new System.EventHandler(this.labelContraseñaAdminIncorrecta_Click);
            // 
            // labelContraseñaAdmin
            // 
            this.labelContraseñaAdmin.AutoSize = true;
            this.labelContraseñaAdmin.Location = new System.Drawing.Point(63, 289);
            this.labelContraseñaAdmin.Name = "labelContraseñaAdmin";
            this.labelContraseñaAdmin.Size = new System.Drawing.Size(149, 17);
            this.labelContraseñaAdmin.TabIndex = 5;
            this.labelContraseñaAdmin.Text = "Escriba su contraseña";
            this.labelContraseñaAdmin.Click += new System.EventHandler(this.labelContraseñaAdmin_Click);
            // 
            // textBoxContraseñaAdmin
            // 
            this.textBoxContraseñaAdmin.Location = new System.Drawing.Point(258, 289);
            this.textBoxContraseñaAdmin.Name = "textBoxContraseñaAdmin";
            this.textBoxContraseñaAdmin.Size = new System.Drawing.Size(175, 22);
            this.textBoxContraseñaAdmin.TabIndex = 6;
            this.textBoxContraseñaAdmin.TextChanged += new System.EventHandler(this.textBoxContraseñaAdmin_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonCrearInstalacion);
            this.panel3.Controls.Add(this.buttonSalir);
            this.panel3.Controls.Add(this.buttonMostrarDatos);
            this.panel3.Controls.Add(this.buttonRevisarEventosDisp);
            this.panel3.Controls.Add(this.buttonArrendarInstalacion);
            this.panel3.Controls.Add(this.labelMenu);
            this.panel3.Location = new System.Drawing.Point(572, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(68, 38);
            this.panel3.TabIndex = 6;
            // 
            // buttonCrearInstalacion
            // 
            this.buttonCrearInstalacion.Location = new System.Drawing.Point(88, 285);
            this.buttonCrearInstalacion.Name = "buttonCrearInstalacion";
            this.buttonCrearInstalacion.Size = new System.Drawing.Size(318, 64);
            this.buttonCrearInstalacion.TabIndex = 6;
            this.buttonCrearInstalacion.Text = "CrearInstalacion";
            this.buttonCrearInstalacion.UseVisualStyleBackColor = true;
            this.buttonCrearInstalacion.Click += new System.EventHandler(this.buttonCrearInstalacion_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(89, 365);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(318, 59);
            this.buttonSalir.TabIndex = 4;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonMostrarDatos
            // 
            this.buttonMostrarDatos.Location = new System.Drawing.Point(89, 219);
            this.buttonMostrarDatos.Name = "buttonMostrarDatos";
            this.buttonMostrarDatos.Size = new System.Drawing.Size(318, 60);
            this.buttonMostrarDatos.TabIndex = 3;
            this.buttonMostrarDatos.Text = "Mostrar Datos";
            this.buttonMostrarDatos.UseVisualStyleBackColor = true;
            this.buttonMostrarDatos.Click += new System.EventHandler(this.buttonMostrarDatos_Click);
            // 
            // buttonRevisarEventosDisp
            // 
            this.buttonRevisarEventosDisp.Location = new System.Drawing.Point(89, 151);
            this.buttonRevisarEventosDisp.Name = "buttonRevisarEventosDisp";
            this.buttonRevisarEventosDisp.Size = new System.Drawing.Size(318, 61);
            this.buttonRevisarEventosDisp.TabIndex = 2;
            this.buttonRevisarEventosDisp.Text = "Revisar los eventos disponibles";
            this.buttonRevisarEventosDisp.UseVisualStyleBackColor = true;
            this.buttonRevisarEventosDisp.Click += new System.EventHandler(this.buttonRevisarEventosDisp_Click);
            // 
            // buttonArrendarInstalacion
            // 
            this.buttonArrendarInstalacion.Location = new System.Drawing.Point(88, 79);
            this.buttonArrendarInstalacion.Name = "buttonArrendarInstalacion";
            this.buttonArrendarInstalacion.Size = new System.Drawing.Size(319, 60);
            this.buttonArrendarInstalacion.TabIndex = 1;
            this.buttonArrendarInstalacion.Text = "Arrendar instalación";
            this.buttonArrendarInstalacion.UseVisualStyleBackColor = true;
            this.buttonArrendarInstalacion.Click += new System.EventHandler(this.buttonArrendarInstalacion_Click);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.Location = new System.Drawing.Point(210, 20);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(77, 29);
            this.labelMenu.TabIndex = 0;
            this.labelMenu.Text = "Menu";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonAgendarEvento);
            this.panel4.Controls.Add(this.labelInstalacionDisp);
            this.panel4.Controls.Add(this.textBoxNombreEvento);
            this.panel4.Controls.Add(this.labelNombreEvento);
            this.panel4.Controls.Add(this.buttonCrearEvento);
            this.panel4.Controls.Add(this.labelArriendoExitoso);
            this.panel4.Controls.Add(this.buttonArrendar);
            this.panel4.Controls.Add(this.textBoxCantidadParticipantes);
            this.panel4.Controls.Add(this.labelCantidadParticipantes);
            this.panel4.Controls.Add(this.labelInstalacionNoDisp);
            this.panel4.Controls.Add(this.buttonVerificarDispArriendo);
            this.panel4.Controls.Add(this.textBoxFechaHoraArriendo);
            this.panel4.Controls.Add(this.labelFechaHoraArriendo);
            this.panel4.Controls.Add(this.comboBoxEspaciosPublicosDisp);
            this.panel4.Controls.Add(this.comboBoxSalaEstudioDisp);
            this.panel4.Controls.Add(this.comboBoxSalasClaseDisp);
            this.panel4.Controls.Add(this.comboBoxCanchasDisp);
            this.panel4.Controls.Add(this.labelMuestraEspPublic);
            this.panel4.Controls.Add(this.labelMuestraSalasEstudio);
            this.panel4.Controls.Add(this.labelMostrarSalasClase);
            this.panel4.Controls.Add(this.labelMuestraCanchas);
            this.panel4.Controls.Add(this.comboBoxSelecTipoInstalacion);
            this.panel4.Controls.Add(this.labelSelecInstalacion);
            this.panel4.Controls.Add(this.labelArrendar);
            this.panel4.Location = new System.Drawing.Point(573, 108);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(566, 542);
            this.panel4.TabIndex = 5;
            // 
            // labelFechaHoraArriendo
            // 
            this.labelFechaHoraArriendo.AutoSize = true;
            this.labelFechaHoraArriendo.Location = new System.Drawing.Point(7, 144);
            this.labelFechaHoraArriendo.Name = "labelFechaHoraArriendo";
            this.labelFechaHoraArriendo.Size = new System.Drawing.Size(492, 17);
            this.labelFechaHoraArriendo.TabIndex = 11;
            this.labelFechaHoraArriendo.Text = "Escriba la fecha y hora de la forma (año(YYYY)-mes(MM)-dia(DD) hora(HH))";
            this.labelFechaHoraArriendo.Click += new System.EventHandler(this.labelFechaHoraArriendo_Click);
            // 
            // comboBoxEspaciosPublicosDisp
            // 
            this.comboBoxEspaciosPublicosDisp.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxEspaciosPublicosDisp.FormattingEnabled = true;
            this.comboBoxEspaciosPublicosDisp.Location = new System.Drawing.Point(260, 99);
            this.comboBoxEspaciosPublicosDisp.Name = "comboBoxEspaciosPublicosDisp";
            this.comboBoxEspaciosPublicosDisp.Size = new System.Drawing.Size(184, 24);
            this.comboBoxEspaciosPublicosDisp.TabIndex = 10;
            this.comboBoxEspaciosPublicosDisp.SelectedIndexChanged += new System.EventHandler(this.comboBoxEspaciosPublicosDisp_SelectedIndexChanged);
            // 
            // comboBoxSalaEstudioDisp
            // 
            this.comboBoxSalaEstudioDisp.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxSalaEstudioDisp.FormattingEnabled = true;
            this.comboBoxSalaEstudioDisp.Location = new System.Drawing.Point(260, 99);
            this.comboBoxSalaEstudioDisp.Name = "comboBoxSalaEstudioDisp";
            this.comboBoxSalaEstudioDisp.Size = new System.Drawing.Size(184, 24);
            this.comboBoxSalaEstudioDisp.TabIndex = 9;
            this.comboBoxSalaEstudioDisp.SelectedIndexChanged += new System.EventHandler(this.comboBoxSalaEstudioDisp_SelectedIndexChanged);
            // 
            // comboBoxSalasClaseDisp
            // 
            this.comboBoxSalasClaseDisp.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxSalasClaseDisp.FormattingEnabled = true;
            this.comboBoxSalasClaseDisp.Location = new System.Drawing.Point(260, 99);
            this.comboBoxSalasClaseDisp.Name = "comboBoxSalasClaseDisp";
            this.comboBoxSalasClaseDisp.Size = new System.Drawing.Size(184, 24);
            this.comboBoxSalasClaseDisp.TabIndex = 8;
            this.comboBoxSalasClaseDisp.SelectedIndexChanged += new System.EventHandler(this.comboBoxSalasClaseDisp_SelectedIndexChanged);
            // 
            // comboBoxCanchasDisp
            // 
            this.comboBoxCanchasDisp.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxCanchasDisp.FormattingEnabled = true;
            this.comboBoxCanchasDisp.Location = new System.Drawing.Point(260, 99);
            this.comboBoxCanchasDisp.Name = "comboBoxCanchasDisp";
            this.comboBoxCanchasDisp.Size = new System.Drawing.Size(184, 24);
            this.comboBoxCanchasDisp.TabIndex = 7;
            this.comboBoxCanchasDisp.SelectedIndexChanged += new System.EventHandler(this.comboBoxCanchasDisp_SelectedIndexChanged);
            // 
            // labelMuestraEspPublic
            // 
            this.labelMuestraEspPublic.AutoSize = true;
            this.labelMuestraEspPublic.Location = new System.Drawing.Point(13, 107);
            this.labelMuestraEspPublic.Name = "labelMuestraEspPublic";
            this.labelMuestraEspPublic.Size = new System.Drawing.Size(180, 17);
            this.labelMuestraEspPublic.TabIndex = 6;
            this.labelMuestraEspPublic.Text = "Los Espacios Públicos son:";
            this.labelMuestraEspPublic.Click += new System.EventHandler(this.labelMuestraEspPublic_Click);
            // 
            // labelMuestraSalasEstudio
            // 
            this.labelMuestraSalasEstudio.AutoSize = true;
            this.labelMuestraSalasEstudio.Location = new System.Drawing.Point(6, 106);
            this.labelMuestraSalasEstudio.Name = "labelMuestraSalasEstudio";
            this.labelMuestraSalasEstudio.Size = new System.Drawing.Size(244, 17);
            this.labelMuestraSalasEstudio.TabIndex = 5;
            this.labelMuestraSalasEstudio.Text = "Las salas de estudio disponibles son:";
            this.labelMuestraSalasEstudio.Click += new System.EventHandler(this.labelMuestraSalasEstudio_Click);
            // 
            // labelMostrarSalasClase
            // 
            this.labelMostrarSalasClase.AutoSize = true;
            this.labelMostrarSalasClase.Location = new System.Drawing.Point(7, 106);
            this.labelMostrarSalasClase.Name = "labelMostrarSalasClase";
            this.labelMostrarSalasClase.Size = new System.Drawing.Size(238, 17);
            this.labelMostrarSalasClase.TabIndex = 4;
            this.labelMostrarSalasClase.Text = "Las salas de clases disponibles son:";
            this.labelMostrarSalasClase.Click += new System.EventHandler(this.labelMostrarSalasClase_Click);
            // 
            // labelMuestraCanchas
            // 
            this.labelMuestraCanchas.AutoSize = true;
            this.labelMuestraCanchas.Location = new System.Drawing.Point(13, 106);
            this.labelMuestraCanchas.Name = "labelMuestraCanchas";
            this.labelMuestraCanchas.Size = new System.Drawing.Size(194, 17);
            this.labelMuestraCanchas.TabIndex = 3;
            this.labelMuestraCanchas.Text = "Las canchas disponibles son:";
            this.labelMuestraCanchas.Click += new System.EventHandler(this.labelMuestraCanchas_Click);
            // 
            // comboBoxSelecTipoInstalacion
            // 
            this.comboBoxSelecTipoInstalacion.FormattingEnabled = true;
            this.comboBoxSelecTipoInstalacion.Items.AddRange(new object[] {
            "Cancha",
            "Sala de Clases",
            "Sala de Estudios",
            "Espacios Públicos"});
            this.comboBoxSelecTipoInstalacion.Location = new System.Drawing.Point(241, 46);
            this.comboBoxSelecTipoInstalacion.Name = "comboBoxSelecTipoInstalacion";
            this.comboBoxSelecTipoInstalacion.Size = new System.Drawing.Size(203, 24);
            this.comboBoxSelecTipoInstalacion.TabIndex = 2;
            this.comboBoxSelecTipoInstalacion.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelecTipoInstalacion_SelectedIndexChanged);
            // 
            // labelSelecInstalacion
            // 
            this.labelSelecInstalacion.AutoSize = true;
            this.labelSelecInstalacion.Location = new System.Drawing.Point(3, 49);
            this.labelSelecInstalacion.Name = "labelSelecInstalacion";
            this.labelSelecInstalacion.Size = new System.Drawing.Size(215, 17);
            this.labelSelecInstalacion.TabIndex = 1;
            this.labelSelecInstalacion.Text = "Seleccione un tipo de instalacion";
            // 
            // labelArrendar
            // 
            this.labelArrendar.AutoSize = true;
            this.labelArrendar.Location = new System.Drawing.Point(127, 15);
            this.labelArrendar.Name = "labelArrendar";
            this.labelArrendar.Size = new System.Drawing.Size(243, 17);
            this.labelArrendar.TabIndex = 0;
            this.labelArrendar.Text = "Ha seleccionado arrendar instalacion";
            this.labelArrendar.Click += new System.EventHandler(this.labelArrendar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonIrMenu);
            this.panel2.Controls.Add(this.labelTituloCrearUsuario);
            this.panel2.Controls.Add(this.labelUsuarioCreadoExito);
            this.panel2.Controls.Add(this.buttonCrearUsuario);
            this.panel2.Controls.Add(this.labelEscogertipodeusuario);
            this.panel2.Controls.Add(this.comboBoxTipoUsuario);
            this.panel2.Controls.Add(this.textBoxNombreNuevo);
            this.panel2.Controls.Add(this.labelEscribirNombre);
            this.panel2.Location = new System.Drawing.Point(572, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(68, 33);
            this.panel2.TabIndex = 4;
            // 
            // buttonIrMenu
            // 
            this.buttonIrMenu.Location = new System.Drawing.Point(271, 357);
            this.buttonIrMenu.Name = "buttonIrMenu";
            this.buttonIrMenu.Size = new System.Drawing.Size(131, 23);
            this.buttonIrMenu.TabIndex = 8;
            this.buttonIrMenu.Text = "Ir al menú";
            this.buttonIrMenu.UseVisualStyleBackColor = true;
            this.buttonIrMenu.Click += new System.EventHandler(this.buttonIrMenu_Click);
            // 
            // labelTituloCrearUsuario
            // 
            this.labelTituloCrearUsuario.AutoSize = true;
            this.labelTituloCrearUsuario.Location = new System.Drawing.Point(110, 32);
            this.labelTituloCrearUsuario.Name = "labelTituloCrearUsuario";
            this.labelTituloCrearUsuario.Size = new System.Drawing.Size(355, 17);
            this.labelTituloCrearUsuario.TabIndex = 7;
            this.labelTituloCrearUsuario.Text = "Debe ingresar sus datos para registrarse en el sistema";
            // 
            // labelUsuarioCreadoExito
            // 
            this.labelUsuarioCreadoExito.AutoSize = true;
            this.labelUsuarioCreadoExito.Location = new System.Drawing.Point(258, 328);
            this.labelUsuarioCreadoExito.Name = "labelUsuarioCreadoExito";
            this.labelUsuarioCreadoExito.Size = new System.Drawing.Size(173, 17);
            this.labelUsuarioCreadoExito.TabIndex = 5;
            this.labelUsuarioCreadoExito.Text = "Usuario Creado con exito!!";
            this.labelUsuarioCreadoExito.Click += new System.EventHandler(this.labelUsuarioCreadoExito_Click);
            // 
            // buttonCrearUsuario
            // 
            this.buttonCrearUsuario.Location = new System.Drawing.Point(258, 218);
            this.buttonCrearUsuario.Name = "buttonCrearUsuario";
            this.buttonCrearUsuario.Size = new System.Drawing.Size(153, 39);
            this.buttonCrearUsuario.TabIndex = 4;
            this.buttonCrearUsuario.Text = "Crear usuario";
            this.buttonCrearUsuario.UseVisualStyleBackColor = true;
            this.buttonCrearUsuario.Click += new System.EventHandler(this.buttonCrearUsuario_Click);
            // 
            // labelEscogertipodeusuario
            // 
            this.labelEscogertipodeusuario.AutoSize = true;
            this.labelEscogertipodeusuario.Location = new System.Drawing.Point(59, 145);
            this.labelEscogertipodeusuario.Name = "labelEscogertipodeusuario";
            this.labelEscogertipodeusuario.Size = new System.Drawing.Size(167, 17);
            this.labelEscogertipodeusuario.TabIndex = 3;
            this.labelEscogertipodeusuario.Text = "Escoja su tipo de usuario";
            this.labelEscogertipodeusuario.Click += new System.EventHandler(this.labelEscogertipodeusuario_Click);
            // 
            // comboBoxTipoUsuario
            // 
            this.comboBoxTipoUsuario.FormattingEnabled = true;
            this.comboBoxTipoUsuario.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBoxTipoUsuario.Items.AddRange(new object[] {
            "Alumno",
            "Profesor",
            "Funcionario"});
            this.comboBoxTipoUsuario.Location = new System.Drawing.Point(258, 145);
            this.comboBoxTipoUsuario.Name = "comboBoxTipoUsuario";
            this.comboBoxTipoUsuario.Size = new System.Drawing.Size(229, 24);
            this.comboBoxTipoUsuario.TabIndex = 2;
            this.comboBoxTipoUsuario.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoUsuario_SelectedIndexChanged);
            // 
            // textBoxNombreNuevo
            // 
            this.textBoxNombreNuevo.Location = new System.Drawing.Point(258, 79);
            this.textBoxNombreNuevo.Name = "textBoxNombreNuevo";
            this.textBoxNombreNuevo.Size = new System.Drawing.Size(229, 22);
            this.textBoxNombreNuevo.TabIndex = 1;
            this.textBoxNombreNuevo.TextChanged += new System.EventHandler(this.textBoxNombreNuevo_TextChanged);
            // 
            // labelEscribirNombre
            // 
            this.labelEscribirNombre.AutoSize = true;
            this.labelEscribirNombre.Location = new System.Drawing.Point(85, 85);
            this.labelEscribirNombre.Name = "labelEscribirNombre";
            this.labelEscribirNombre.Size = new System.Drawing.Size(126, 17);
            this.labelEscribirNombre.TabIndex = 0;
            this.labelEscribirNombre.Text = "Escriba su nombre";
            this.labelEscribirNombre.Click += new System.EventHandler(this.labelEscribirNombre_Click);
            // 
            // textBoxFechaHoraArriendo
            // 
            this.textBoxFechaHoraArriendo.Location = new System.Drawing.Point(103, 177);
            this.textBoxFechaHoraArriendo.Name = "textBoxFechaHoraArriendo";
            this.textBoxFechaHoraArriendo.Size = new System.Drawing.Size(209, 22);
            this.textBoxFechaHoraArriendo.TabIndex = 12;
            this.textBoxFechaHoraArriendo.TextChanged += new System.EventHandler(this.textBoxFechaHoraArriendo_TextChanged);
            // 
            // buttonVerificarDispArriendo
            // 
            this.buttonVerificarDispArriendo.Location = new System.Drawing.Point(130, 290);
            this.buttonVerificarDispArriendo.Name = "buttonVerificarDispArriendo";
            this.buttonVerificarDispArriendo.Size = new System.Drawing.Size(209, 63);
            this.buttonVerificarDispArriendo.TabIndex = 13;
            this.buttonVerificarDispArriendo.Text = "Verificar Disponibilidad Arriendo";
            this.buttonVerificarDispArriendo.UseVisualStyleBackColor = true;
            this.buttonVerificarDispArriendo.Click += new System.EventHandler(this.buttonVerificarDispArriendo_Click);
            // 
            // labelInstalacionNoDisp
            // 
            this.labelInstalacionNoDisp.Location = new System.Drawing.Point(77, 356);
            this.labelInstalacionNoDisp.Name = "labelInstalacionNoDisp";
            this.labelInstalacionNoDisp.Size = new System.Drawing.Size(328, 45);
            this.labelInstalacionNoDisp.TabIndex = 14;
            this.labelInstalacionNoDisp.Text = "La instalacion que seleccionó no esta disponible, pruebe con otra fecha y/u otra " +
    "instalacion.";
            this.labelInstalacionNoDisp.Click += new System.EventHandler(this.labelInstalacionNoDisp_Click);
            // 
            // labelCantidadParticipantes
            // 
            this.labelCantidadParticipantes.AutoSize = true;
            this.labelCantidadParticipantes.Location = new System.Drawing.Point(13, 231);
            this.labelCantidadParticipantes.Name = "labelCantidadParticipantes";
            this.labelCantidadParticipantes.Size = new System.Drawing.Size(237, 17);
            this.labelCantidadParticipantes.TabIndex = 15;
            this.labelCantidadParticipantes.Text = "Escriba la cantidad de participantes:";
            this.labelCantidadParticipantes.Click += new System.EventHandler(this.labelCantidadParticipantes_Click);
            // 
            // textBoxCantidadParticipantes
            // 
            this.textBoxCantidadParticipantes.Location = new System.Drawing.Point(257, 226);
            this.textBoxCantidadParticipantes.Name = "textBoxCantidadParticipantes";
            this.textBoxCantidadParticipantes.Size = new System.Drawing.Size(82, 22);
            this.textBoxCantidadParticipantes.TabIndex = 16;
            this.textBoxCantidadParticipantes.TextChanged += new System.EventHandler(this.textBoxCantidadParticipantes_TextChanged);
            // 
            // buttonArrendar
            // 
            this.buttonArrendar.Location = new System.Drawing.Point(355, 220);
            this.buttonArrendar.Name = "buttonArrendar";
            this.buttonArrendar.Size = new System.Drawing.Size(109, 32);
            this.buttonArrendar.TabIndex = 17;
            this.buttonArrendar.Text = "Arrendar";
            this.buttonArrendar.UseVisualStyleBackColor = true;
            this.buttonArrendar.Click += new System.EventHandler(this.buttonArrendar_Click);
            // 
            // labelArriendoExitoso
            // 
            this.labelArriendoExitoso.AutoSize = true;
            this.labelArriendoExitoso.Location = new System.Drawing.Point(109, 265);
            this.labelArriendoExitoso.Name = "labelArriendoExitoso";
            this.labelArriendoExitoso.Size = new System.Drawing.Size(254, 17);
            this.labelArriendoExitoso.TabIndex = 19;
            this.labelArriendoExitoso.Text = "Su arriendo ha sido realizado con exito";
            this.labelArriendoExitoso.Click += new System.EventHandler(this.labelArriendoExitoso_Click);
            // 
            // buttonCrearEvento
            // 
            this.buttonCrearEvento.Location = new System.Drawing.Point(160, 290);
            this.buttonCrearEvento.Name = "buttonCrearEvento";
            this.buttonCrearEvento.Size = new System.Drawing.Size(138, 38);
            this.buttonCrearEvento.TabIndex = 20;
            this.buttonCrearEvento.Text = "Crear evento";
            this.buttonCrearEvento.UseVisualStyleBackColor = true;
            this.buttonCrearEvento.Click += new System.EventHandler(this.buttonCrearEvento_Click);
            // 
            // labelNombreEvento
            // 
            this.labelNombreEvento.AutoSize = true;
            this.labelNombreEvento.Location = new System.Drawing.Point(44, 411);
            this.labelNombreEvento.Name = "labelNombreEvento";
            this.labelNombreEvento.Size = new System.Drawing.Size(110, 17);
            this.labelNombreEvento.TabIndex = 21;
            this.labelNombreEvento.Text = "Nombre Evento:";
            this.labelNombreEvento.Click += new System.EventHandler(this.labelNombreEvento_Click);
            // 
            // textBoxNombreEvento
            // 
            this.textBoxNombreEvento.Location = new System.Drawing.Point(186, 411);
            this.textBoxNombreEvento.Name = "textBoxNombreEvento";
            this.textBoxNombreEvento.Size = new System.Drawing.Size(139, 22);
            this.textBoxNombreEvento.TabIndex = 23;
            this.textBoxNombreEvento.TextChanged += new System.EventHandler(this.textBoxNombreEvento_TextChanged);
            // 
            // labelInstalacionDisp
            // 
            this.labelInstalacionDisp.AutoSize = true;
            this.labelInstalacionDisp.Location = new System.Drawing.Point(127, 265);
            this.labelInstalacionDisp.Name = "labelInstalacionDisp";
            this.labelInstalacionDisp.Size = new System.Drawing.Size(198, 17);
            this.labelInstalacionDisp.TabIndex = 25;
            this.labelInstalacionDisp.Text = "Su instalacion esta disponible!";
            this.labelInstalacionDisp.Click += new System.EventHandler(this.labelInstalacionDisp_Click);
            // 
            // buttonAgendarEvento
            // 
            this.buttonAgendarEvento.Location = new System.Drawing.Point(346, 408);
            this.buttonAgendarEvento.Name = "buttonAgendarEvento";
            this.buttonAgendarEvento.Size = new System.Drawing.Size(118, 23);
            this.buttonAgendarEvento.TabIndex = 26;
            this.buttonAgendarEvento.Text = "Agendar Evento";
            this.buttonAgendarEvento.UseVisualStyleBackColor = true;
            this.buttonAgendarEvento.Click += new System.EventHandler(this.buttonAgendarEvento_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 704);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonVerificar;
        private System.Windows.Forms.Label labelbienvenido;
        private System.Windows.Forms.TextBox textBoxRecibirRut;
        private System.Windows.Forms.Label labelIngreseRut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxNombreNuevo;
        private System.Windows.Forms.Label labelEscribirNombre;
        private System.Windows.Forms.Label labelEscogertipodeusuario;
        private System.Windows.Forms.ComboBox comboBoxTipoUsuario;
        private System.Windows.Forms.Button buttonCrearUsuario;
        private System.Windows.Forms.Label labelUsuarioCreadoExito;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonArrendarInstalacion;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button buttonRevisarEventosDisp;
        private System.Windows.Forms.Button buttonMostrarDatos;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Label labelContraseñaAdmin;
        private System.Windows.Forms.Label labelTituloCrearUsuario;
        private System.Windows.Forms.TextBox textBoxContraseñaAdmin;
        private System.Windows.Forms.Button buttonIrMenu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelArrendar;
        private System.Windows.Forms.ComboBox comboBoxSelecTipoInstalacion;
        private System.Windows.Forms.Label labelSelecInstalacion;
        private System.Windows.Forms.Label labelMuestraCanchas;
        private System.Windows.Forms.Label labelMostrarSalasClase;
        private System.Windows.Forms.Label labelMuestraSalasEstudio;
        private System.Windows.Forms.Label labelMuestraEspPublic;
        private System.Windows.Forms.Button buttonCrearInstalacion;
        private System.Windows.Forms.Label labelContraseñaAdminIncorrecta;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.ComboBox comboBoxCanchasDisp;
        private System.Windows.Forms.ComboBox comboBoxSalasClaseDisp;
        private System.Windows.Forms.ComboBox comboBoxSalaEstudioDisp;
        private System.Windows.Forms.ComboBox comboBoxEspaciosPublicosDisp;
        private System.Windows.Forms.Label labelFechaHoraArriendo;
        private System.Windows.Forms.TextBox textBoxFechaHoraArriendo;
        private System.Windows.Forms.Button buttonVerificarDispArriendo;
        private System.Windows.Forms.Label labelInstalacionNoDisp;
        private System.Windows.Forms.Label labelCantidadParticipantes;
        private System.Windows.Forms.TextBox textBoxCantidadParticipantes;
        private System.Windows.Forms.Button buttonArrendar;
        private System.Windows.Forms.Label labelArriendoExitoso;
        private System.Windows.Forms.Button buttonCrearEvento;
        private System.Windows.Forms.Label labelNombreEvento;
        private System.Windows.Forms.TextBox textBoxNombreEvento;
        private System.Windows.Forms.Label labelInstalacionDisp;
        private System.Windows.Forms.Button buttonAgendarEvento;
    }
}
