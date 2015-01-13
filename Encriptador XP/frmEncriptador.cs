using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Encriptador_XP
{
    public partial class frmEncriptador : Form
    {
        public frmEncriptador()
        {
            InitializeComponent();
        }

        private char[] alfabeto = {	'a','b','c','d','e','f','g','h','i',
								    'j','k','l','m','n','ñ','o','p','q',
								    'r','s','t','u','v','w','x','y','z',
								    'A','B','C','D','E','F','G','H','I',
								    'J','K','L','M','N','Ñ','O','P','Q',
								    'R','S','T','U','V','W','X','Y','Z',
                                    '1','2','3','4','5','6','7','8','9',
                                    '0'
							    };

        private String encriptarConAlgoritmoPropio(String mensaje)
        {
            String mensajeEncriptado = "";
            char[] mensajeFragmentado = mensaje.ToCharArray();
            char letraAnalizando;
            int numeroLetra;
            int nuevoNumeroLetra;
            int pasada = 0;

            for (int i = 0; i < mensaje.Length; i++)
            {

                letraAnalizando = mensajeFragmentado[i];
                numeroLetra = obtenerNumeroLetra(letraAnalizando);
                nuevoNumeroLetra = -1;
                
                if (numeroLetra >= 0)
                    {
                    
                    if (pasada == 0)
                    {
                        nuevoNumeroLetra = numeroLetra + 5;
                        pasada = 1;
                    }
                    else if (pasada == 1)
                    {
                        nuevoNumeroLetra = numeroLetra + 18;
                        pasada = 2;
                    }
                    else
                    {
                        nuevoNumeroLetra = numeroLetra + 11;
                        pasada = 0;
                    }

                    if (nuevoNumeroLetra > alfabeto.Length - 1)
                    {
                        nuevoNumeroLetra -= alfabeto.Length;
                    }

                    mensajeEncriptado += alfabeto[nuevoNumeroLetra];
                }
                else
                {
                    mensajeEncriptado += letraAnalizando;
                }
                
            }
            
            return mensajeEncriptado;
        }

        private String desencriptarConAlgoritmoPropio(String mensaje)
        {
            String mensajeDesencriptado = "";
            char[] mensajeFragmentado = mensaje.ToCharArray();
            char letraAnalizando;
            int numeroLetra;
            int nuevoNumeroLetra;
            int pasada = 0;

            for (int i = 0; i < mensaje.Length; i++)
            {

                letraAnalizando = mensajeFragmentado[i];
                numeroLetra = obtenerNumeroLetra(letraAnalizando);
                nuevoNumeroLetra = -1;

                if (numeroLetra >= 0)
                {

                    if (pasada == 0)
                    {
                        nuevoNumeroLetra = numeroLetra - 5;
                        pasada = 1;
                    }
                    else if (pasada == 1)
                    {
                        nuevoNumeroLetra = numeroLetra - 18;
                        pasada = 2;
                    }
                    else
                    {
                        nuevoNumeroLetra = numeroLetra - 11;
                        pasada = 0;
                    }

                    if (nuevoNumeroLetra < 0)
                    {
                        nuevoNumeroLetra += alfabeto.Length;
                    }

                    mensajeDesencriptado += alfabeto[nuevoNumeroLetra];
                }
                else
                {
                    mensajeDesencriptado += letraAnalizando;
                }

            }
            return mensajeDesencriptado;
        }

        private String encriptarConClave(String clave, String mensaje)
        {
            String mensajeEncriptado = "";
            char[] mensajeFragmentado = mensaje.ToCharArray();
            char[] claveFragmentada = clave.ToCharArray();
            char letraAnalizando;
            int numeroLetra;
            int nuevoNumeroLetra;
            int i = 0, j = 0;

            while(i < mensaje.Length)
            {
                letraAnalizando = mensajeFragmentado[i];
                numeroLetra = obtenerNumeroLetra(letraAnalizando);
                nuevoNumeroLetra = -1;

                if (numeroLetra >= 0)
                {
                    if (j >= claveFragmentada.Length){j = 0;}

                    nuevoNumeroLetra = numeroLetra + obtenerNumeroLetra(claveFragmentada[j]);
                    j++;

                    if (nuevoNumeroLetra > alfabeto.Length - 1)
                    {
                        nuevoNumeroLetra -= alfabeto.Length;
                    }

                    mensajeEncriptado += alfabeto[nuevoNumeroLetra];
                }
                else
                {
                    mensajeEncriptado += letraAnalizando;
                }
                i++;
            }

            return mensajeEncriptado;
        }

        private String desencriptarConClave(String clave, String mensaje)
        {
            String mensajeDesencriptado = "";
            char[] mensajeFragmentado = mensaje.ToCharArray();
            char[] claveFragmentada = clave.ToCharArray();
            char letraAnalizando;
            int numeroLetra;
            int nuevoNumeroLetra;
            int i = 0, j = 0;

            while (i < mensaje.Length)
            {
                letraAnalizando = mensajeFragmentado[i];
                numeroLetra = obtenerNumeroLetra(letraAnalizando);
                nuevoNumeroLetra = -1;

                if (numeroLetra >= 0)
                {
                    if (j >= claveFragmentada.Length) { j = 0; }

                    nuevoNumeroLetra = numeroLetra - obtenerNumeroLetra(claveFragmentada[j]);
                    j++;

                    if (nuevoNumeroLetra < 0)
                    {
                        nuevoNumeroLetra += alfabeto.Length;
                    }

                    mensajeDesencriptado += alfabeto[nuevoNumeroLetra];
                }
                else
                {
                    mensajeDesencriptado += letraAnalizando;
                }
                i++;
            }

            return mensajeDesencriptado;
        }

        private String invertirMensaje(String mensaje)
        {
            String mensajeInvertido = "";
            char[] mensajeFragmentado = mensaje.ToCharArray();
                
            for (int i = mensajeFragmentado.Length - 1; i >= 0; i--)
            {
                mensajeInvertido += mensajeFragmentado[i];
            }

            return mensajeInvertido;
        }
        
        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            if (procedeTextoMensaje() && procedeTextoClave())
            {
                txtMensaje.Text = encriptarConAlgoritmoPropio(txtMensaje.Text);
                txtMensaje.Text = encriptarConClave(txtClave.Text, txtMensaje.Text);
                txtMensaje.Text = invertirMensaje(txtMensaje.Text);
                btnEncriptar.Enabled = false;
                btnDesencriptar.Enabled = true;
                lblMensajeAccion.Text = "Mensaje encriptado";
                pnlElementosMoviles.Left = -125;                
            }
        }

        private void btnDesencriptar_Click(object sender, EventArgs e)
        {
            if (procedeTextoMensaje() && procedeTextoClave())
            {
                txtMensaje.Text = invertirMensaje(txtMensaje.Text);
                txtMensaje.Text = desencriptarConClave(txtClave.Text,txtMensaje.Text);
                txtMensaje.Text = desencriptarConAlgoritmoPropio(txtMensaje.Text);
                btnDesencriptar.Enabled = false;
                btnEncriptar.Enabled = true;
                lblMensajeAccion.Text = "Mensaje desencriptado";
                pnlElementosMoviles.Left = -125;
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            txtMensaje.Text = abrirArchivo();
            btnDesencriptar.Enabled = true;
            btnEncriptar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (procedeTextoMensaje())
                guardarArchivo(txtMensaje.Text);
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            txtMensaje.Text = "";
            txtClave.Text = "";
            btnEncriptar.Enabled = true;
            btnDesencriptar.Enabled = true;
            lblPath.Text = "";
            lblMensajeAccion.Text = "Introduce texto";
            pnlElementosMoviles.Left = 10;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            pnlElementosMoviles.Left = 10;
            lblMensajeAccion.Text = "Introduce texto";
        }

        private int obtenerNumeroLetra(char letra)
        {
            int indice = -1;

            for (int i = 0; i < alfabeto.Length; i++)
            {
                if (alfabeto[i] == letra)
                {
                    indice = i;
                    i = alfabeto.Length;
                }
            }
            return indice;
        }

        private void guardarArchivo(String mensajeAGuardar)
        {
            SaveFileDialog escritorArchivo = new SaveFileDialog();
            escritorArchivo.Filter = "Archivo de texto (*.txt)|*.txt|Todos los archivos(*.*)|*.*";

            if (escritorArchivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(escritorArchivo.FileName);
                    sw.Write(mensajeAGuardar);
                    sw.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception: " + ex.Message);
                }
                finally
                {
                    lblPath.Text = escritorArchivo.FileName;
                    //Console.WriteLine("Executing finally block.");
                }
            }
        }

        private String abrirArchivo()
        {
            String textoLeido = txtMensaje.Text;

            OpenFileDialog lectorArchivo = new OpenFileDialog();
            lectorArchivo.Filter = "Archivo de texto (*.txt)|*.txt|Todos los archivos(*.*)|*.*";
            lectorArchivo.InitialDirectory = "%desktop%";
            lectorArchivo.Title = "Elige un archivo de texto";

            if (lectorArchivo.ShowDialog() == DialogResult.OK)
            {
                textoLeido = "";
                StreamReader lectorLineas = new StreamReader(lectorArchivo.FileName);
                string linea = "";

                while (linea != null)
                {
                    linea = lectorLineas.ReadLine();
                    textoLeido += linea;
                }
                lectorLineas.Close();
                lblPath.Text = lectorArchivo.FileName;

            }
            return textoLeido;
        }

        private bool procedeTextoMensaje()
        {
            if (txtMensaje.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Introduce texto para efectuar la operacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private bool procedeTextoClave()
        {
            if (txtClave.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Introduce una clave para efectuar la operacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

    }

    
}
