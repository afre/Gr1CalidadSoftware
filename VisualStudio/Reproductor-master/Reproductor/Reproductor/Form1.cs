using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO; 
namespace ReproductorMp3
{
	/// <summary>
	/// Descripci�n breve de Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		private System.Windows.Forms.StatusBarPanel statusBarPanel3;
		private System.Windows.Forms.OpenFileDialog Of;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.StatusBar stMensajes;
		private System.Windows.Forms.StatusBar stTiempos;

		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.LinkLabel linkLabel3;

		// Creamos el objeto dela clase reproductor.
		private Reproductor Sonido = new Reproductor();
		// Una colecci�n para agrupar los elementos listados.
		private Hashtable hashMusica = new Hashtable();
        private Button buttonNext;
        private Button buttonPrevious;
		// Bandera para informar sobre el arrastre del indicador de progreso.
		private bool trackBarClick = false;

		public Form1()
		{
            
			//
			// Necesario para admitir el Dise�ador de Windows Forms
			//
			InitializeComponent();
            this.KeyPreview = true;
            checkBox1.Checked = true;
			//
			// TODO: Agregar c�digo de constructor despu�s de llamar a InitializeComponent
			//
		}

		/// <summary>
		/// Limpiar los recursos que se est�n utilizando.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// M�todo necesario para admitir el Dise�ador, no se puede modificar
		/// el contenido del m�todo con el editor de c�digo.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.stMensajes = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.stTiempos = new System.Windows.Forms.StatusBar();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel3 = new System.Windows.Forms.StatusBarPanel();
            this.Of = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(280, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Reproducir";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(280, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "&Pausar";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(280, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 24);
            this.button3.TabIndex = 3;
            this.button3.Text = "&Detener";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Location = new System.Drawing.Point(280, 168);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 24);
            this.button4.TabIndex = 4;
            this.button4.Text = "&Salir";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Location = new System.Drawing.Point(8, 196);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(56, 16);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Examinar";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // stMensajes
            // 
            this.stMensajes.Location = new System.Drawing.Point(0, 313);
            this.stMensajes.Name = "stMensajes";
            this.stMensajes.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1});
            this.stMensajes.ShowPanels = true;
            this.stMensajes.Size = new System.Drawing.Size(374, 20);
            this.stMensajes.TabIndex = 6;
            this.stMensajes.Text = "statusBar1";
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Width = 200;
            // 
            // listBox1
            // 
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(8, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(260, 134);
            this.listBox1.TabIndex = 7;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Location = new System.Drawing.Point(68, 196);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(92, 16);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Quitar Elementos";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // stTiempos
            // 
            this.stTiempos.Dock = System.Windows.Forms.DockStyle.Top;
            this.stTiempos.Location = new System.Drawing.Point(0, 0);
            this.stTiempos.Name = "stTiempos";
            this.stTiempos.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel2,
            this.statusBarPanel3});
            this.stTiempos.ShowPanels = true;
            this.stTiempos.Size = new System.Drawing.Size(374, 20);
            this.stTiempos.TabIndex = 9;
            this.stTiempos.Text = "statusBar2";
            // 
            // statusBarPanel2
            // 
            this.statusBarPanel2.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
            this.statusBarPanel2.Name = "statusBarPanel2";
            this.statusBarPanel2.Text = "Tiempo Total:";
            this.statusBarPanel2.Width = 180;
            // 
            // statusBarPanel3
            // 
            this.statusBarPanel3.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
            this.statusBarPanel3.Name = "statusBarPanel3";
            this.statusBarPanel3.Text = "Tiempo Transcurrido";
            this.statusBarPanel3.Width = 180;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(4, 224);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(368, 45);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseDown);
            this.trackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lista de Reproducci�n";
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(164, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 16);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Recorrer la lista";
            // 
            // linkLabel3
            // 
            this.linkLabel3.Location = new System.Drawing.Point(164, 196);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(108, 16);
            this.linkLabel3.TabIndex = 13;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Quitar Seleccionado";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(259, 275);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 14;
            this.buttonNext.Text = "Siguiente";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(42, 275);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 15;
            this.buttonPrevious.Text = "Anterior";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(374, 333);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stTiempos);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.stMensajes);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trackBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reproductor de mp3";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.Form1_DragOver);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AtajoSiguiente);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AtajoAnterior);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Punto de entrada principal de la aplicaci�n.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// Inicializamos el panel de mensajes.
			stMensajes.Panels[0].Text = "Listo";
			// Asiganamos un manejador para el evento Mensajes del Reproductor.
			Sonido.ReproductorEstado += new Reproductor.ReproductorMessage(this.MensajesDelReproductor);
			// Establecemos la propiedad que permite seleccionar varios elementos
			// en el cuadro de dialogo abrir.
			Of.Multiselect = true;

			//Verificamos el n�mero de dispositivos de salida existentes
			int numDevs = Sonido.DispositivosDeSonido();
			if (numDevs == 0)
				MessageBox.Show("No se han encontrado dispositivos de salida de audio \n presentes en el sistema",
					"Dispositivos no encontrados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		/// <summary>
		/// M�todo que gestiona los mensajes emitidos por la clase Reproductor.
		/// </summary>
		/// <param name="Msg">Cadena de mensajes.</param>
		private void MensajesDelReproductor(string Msg)
		{
			// S� el mensaje es diferente de Ok, 
			if (Msg != "Ok")
			{
				// se muestra en el panel de mensajes.
				stMensajes.Panels[0].Text = Msg;
				// y detenemos el reloj.
				timer1.Stop();
				timer1.Enabled = false;
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
            if (listBox1.Items.Count!=0 & listBox1.SelectedIndex == -1) listBox1.SetSelected(0, true); ;
			// Iniciamos la Reproducci�n
			IniciarReproduccion();
		}

		private void Form1_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
		{
			// Nos aseguramos que estamos arrastrando archivos, no texto u otra cosa
			if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
				// permitimos la operaci�n.
				e.Effect = DragDropEffects.Copy;
		}

		private void Form1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			// obtenemos la lista de los archivos arrastrados.
			string[] archivos = (string[])(e.Data.GetData(DataFormats.FileDrop));
			// por cada archivo en la lista,
			for (int i = 0; i < archivos.Length; i++)
			{
				// si la extensi�n del archivo es la correcta
                if (Path.GetExtension(archivos[i]) == ".mp3" || Path.GetExtension(archivos[i]) == ".wav")
					// agrega a la lista de reproducci�n.
					AgregarArchivos(Sonido.NombreLargo(archivos[i]));
			}
		}

		private void linkLabel2_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			// Si hay elementos en la lista de reproducci�n
			if (listBox1.Items.Count > 0)
			{
				// se eliminan de la lista, y de la colecci�n.
				listBox1.Items.Clear();	
				hashMusica.Clear();
			}
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			// Cerramos la aplicaci�n.
			Close();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if (button2.Text == "&Pausar")
			{
				// se env�a la operaci�n de pausar,
				Sonido.Pausar();
				// cambiamos el texto del bot�n
				button2.Text = "&Continuar";
				// detenemos el reloj.
				timer1.Stop();
			}
			else // s� el archivo se encontraba pausado,
			{
				// continuamos con la reproducci�n
				Sonido.Continuar();
				// cambiamos el texto del bot�n.
				button2.Text = "&Pausar";
				// iniciamos el reloj.
				timer1.Start();
			}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			// Detenemos la reproducci�n.
			DetenerReproduccion();
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			// Cada tick de nuestro reloj de control, nos permitir�
			// actualizar el panel de tiempos, con el total de tiempo y
			// tiempo transcurrido y el progreso
			stTiempos.Panels[0].Text = "Tiempo Total: " + Sonido.Tama�o();
			stTiempos.Panels[1].Text = "Tiempo Tracurrido: " + Sonido.Posicion();
			stMensajes.Panels[0].Text = "Estado del Reproductor: " + Sonido.Estado();

			if (!trackBarClick)
				trackBar1.Value = (int) Sonido.CalcularPosicion();

			// s� la reproducci�n se ha detenido,
			if (Sonido.EstadoDetenido())
			{
				// Cerramos el archivo y los recursos utilizados
				DetenerReproduccion();
				// Si a�n hay elementos que recorrer en la lista
				// y la opci�n de avance autom�tica este habilitada
				if ((listBox1.SelectedIndex < listBox1.Items.Count - 1) && checkBox1.Checked)
				{
					// avanzamos en una posici�n el elemento actualmente seleccionado
					listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
					// e iniciamos nuevamente la reproducci�n.
					IniciarReproduccion();
				}
			}
		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			// Establecemos el filtro para el tipo de archivos que deseamos
            Of.Filter = "Archivos de mp3 (*.mp3) | *.mp3|Audio Files (.wav)|*.wav";
            
			if (Of.ShowDialog() == DialogResult.OK)
			{
				// agregamos los elementos a la lista de reproducci�n.
				string[] archivos = Of.FileNames;
				for (int i = 0; i < archivos.Length; i++)
					AgregarArchivos(archivos[i]);
			}
		}

		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			// Verificamos que el reproductor no se encuetre activo, pausado o el archivo
			// abierto.
			if (Sonido.EstadoReproduciendo() || Sonido.EstadoPausado() || Sonido.EstadoAbierto())
				// de ser as�, detenemos la reproducci�n y cerramos el archivo.
				Sonido.Cerrar();
		}

		/// <summary>
		/// Agrega nombre de archivos sin extensi�n a la lista de reproducci�n y
		/// nombres de archivos largos a la colecci�n de m�sica.
		/// </summary>
		/// <param name="NombreArchivoLargo">Nombre de archivo completo.</param>
		private void AgregarArchivos(string NombreArchivoLargo)
		{
			// Obtenemos el nombre de archivo, eliminando la ruta y la extensi�n.
			string nombreArchivo = Path.GetFileNameWithoutExtension(NombreArchivoLargo);
            string extension = Path.GetExtension(NombreArchivoLargo);
			// agregamos la ruta completa a la lista de reproducci�n,
			if (!hashMusica.ContainsKey(nombreArchivo))
			{
				hashMusica.Add(nombreArchivo, NombreArchivoLargo);
				// agregamos solo el nombre del archivo a la lista.
				listBox1.Items.Add(nombreArchivo);
			}
		}

		private void listBox1_DoubleClick(object sender, System.EventArgs e)
		{
			// Iniciamos la reproducci�n
			IniciarReproduccion();
		}

		private void trackBar1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			// si se ha hecho click en la barra de progreso, 
			// habilitamos el avance manual.
			trackBarClick = true;
		}

		private void trackBar1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			// Deshabilitamos el avance manual
			trackBarClick = false;
			// detenemos la reproducci�n actual
			Sonido.Detener();
			// Avanzamos el apuntador de archivo a la posici�n deseada,
			Sonido.Reposicionar(trackBar1.Value);
			// reinciamos la reproducci�n desde ese punto
			Sonido.ReproducirDesde(trackBar1.Value);
			// iniciamos el reloj nuevamente.
			timer1.Start();
		}

		private void linkLabel3_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			// Si hay alg�n elemento seleccionado
			if (listBox1.SelectedIndex > -1)
				// lo eliminamos.
				listBox1.Items.RemoveAt(listBox1.SelectedIndex);
		}

        private void buttonNext_Click(object sender, EventArgs e)
        {
            CancionSiguiente();
        }        

        private void AtajoSiguiente(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad3)
            {
                CancionSiguiente();
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            CancionAnterior();
        }

        private void AtajoAnterior(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad1)
            {
                CancionAnterior();
            }
        }

        private void CancionSiguiente()
        {
            // S� hay un elemento seleccionado en la lista            
            if (listBox1.SelectedIndex > -1 && listBox1.Items.Count - 1 != listBox1.SelectedIndex)
            {
               // Si hay alg�n otro archivo escuch�ndose, se detiene.
                if (Sonido.EstadoReproduciendo()) DetenerReproduccion();
                // Asignamos el nombre del archivo a la propiedad correspondiente,

                //Sonido.NombreDeArchivo = ObtenerNombreLargo(listBox1.SelectedItem.ToString());
                int seleccionado = listBox1.SelectedIndex;
                listBox1.SetSelected(seleccionado + 1, true);
                Sonido.NombreDeArchivo = ObtenerNombreLargo(listBox1.SelectedItem.ToString());
                //MessageBox.Show(Sonido.NombreDeArchivo);
                // Iniciamos la reproducci�n,
                Sonido.Reproducir();
                // establecemos los valores para la barra de progreso.
                trackBar1.Minimum = 0;
                trackBar1.Maximum = (int)Sonido.CalcularTama�o();
                // Iniciamos el reloj de control.
                timer1.Enabled = true;
                timer1.Start();
            }
        }

        private void CancionAnterior()
        {
            // S� hay un elemento seleccionado en la lista
            if (listBox1.SelectedIndex > 0)
            {
                // Si hay alg�n otro archivo escuch�ndose, se detiene.
                if (Sonido.EstadoReproduciendo()) DetenerReproduccion();
                // Asignamos el nombre del archivo a la propiedad correspondiente,

                //Sonido.NombreDeArchivo = ObtenerNombreLargo(listBox1.SelectedItem.ToString());
                int seleccionado = listBox1.SelectedIndex;
                listBox1.SetSelected(seleccionado - 1, true);
                Sonido.NombreDeArchivo = ObtenerNombreLargo(listBox1.SelectedItem.ToString());
                //MessageBox.Show(Sonido.NombreDeArchivo);
                // Iniciamos la reproducci�n,
                Sonido.Reproducir();
                // establecemos los valores para la barra de progreso.
                trackBar1.Minimum = 0;
                trackBar1.Maximum = (int)Sonido.CalcularTama�o();
                // Iniciamos el reloj de control.
                timer1.Enabled = true;
                timer1.Start();
            }
        }

        private void IniciarReproduccion()
        {
            // S� hay un elemento seleccionado en la lista
            if (listBox1.SelectedIndex > -1)
            {
                // Si hay alg�n otro archivo escuch�ndose, se detiene.
                if (Sonido.EstadoReproduciendo()) DetenerReproduccion();
                // Asignamos el nombre del archivo a la propiedad correspondiente,
                Sonido.NombreDeArchivo = ObtenerNombreLargo(listBox1.SelectedItem.ToString());
                // Iniciamos la reproducci�n,
                Sonido.Reproducir();
                // establecemos los valores para la barra de progreso.
                trackBar1.Minimum = 0;
                trackBar1.Maximum = (int)Sonido.CalcularTama�o();
                // Iniciamos el reloj de control.
                timer1.Enabled = true;
                timer1.Start();
            }
        }

        /// <summary>
        /// Detiene la reproducci�n actual y libera los recursos utilizados.
        /// </summary>
        private void DetenerReproduccion()
        {
            // Cerramos el archivo actual en reproducci�n,detenemos el reloj de control
            // e reiniciamos los recursos utilizados.
            Sonido.Cerrar();
            timer1.Enabled = false;
            timer1.Stop();
            trackBar1.Value = 0;
            button2.Text = "&Pausar";
            stTiempos.Panels[0].Text = "Tiempo Total:";
            stTiempos.Panels[1].Text = "Tiempo Transcurrido:";
            stMensajes.Panels[0].Text = "Listo";
        }

        /// <summary>
        /// Devuelve la ruta completa a partir del nombre de archivo obtenido de la lista
        /// de reproducci�n.
        /// </summary>
        /// <param name="ArchivoBuscado">Nombre de archivo seleccionado.</param>
        /// <returns>Cadena con la informaci�n completa del archivo.</returns>
        private string ObtenerNombreLargo(string ArchivoBuscado)
        {
            // Recorremos cada elemento de la colecci�n de m�sica,
            foreach (DictionaryEntry entry in hashMusica)
            {
                // Si encontramos el elemento deseado,
                if (entry.Key.ToString() == ArchivoBuscado)
                    // devolvemos la informaci�n sobre �l.
                    return entry.Value.ToString();
            } // de no ser as�, devolvemos una cadena vac�a.
            return "";
        }
	}
}
