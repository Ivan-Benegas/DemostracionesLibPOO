﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibPOO.Clinica;
using LibPOO.Estaticos;
using LibPOO.Musicos;

namespace WindowsAppDemos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearObjetos_Click(object sender, EventArgs e)
        {
            
            // Otra forma de instanciar objetos e inicializar las propiedades
            // con notación literal

            Paciente paciente = new Paciente()
            {
                NroHistClinica = 111,
                Apellido = "Giles",
                Nombre = "Gaby"
            };

            MessageBox.Show(paciente.Imprimir());

            Medico medico = new Medico() { Apellido = "Perez", Nombre = "Juan", Matricula = 4444 };

            MessageBox.Show(medico.Imprimir());

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {

            decimal resultado = Calculadora.Sumar(10, 20, "+");

            int num = 100;
            string valor = "100";
            int result;

            result = num + Convert.ToInt32(valor);

            lblResultado.Text = resultado.ToString();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Cliente cliente1 = new Cliente("Mariela");

            Cliente cliente2 = new Cliente("Gennaro");

            MessageBox.Show(Cliente.Instancias.ToString());

            Cliente cliente3 = new Cliente("Maria");

            MessageBox.Show(Cliente.Instancias.ToString());

        }

        /*private void btnListaClientes_Click(object sender, EventArgs e)
        {

            // Declarar y crear la lista
            List<Cliente> listaClientes = new List<Cliente>();

            // Creamos 2 clientes
            Cliente cliente1 = new Cliente("Mariela");
            Cliente cliente2 = new Cliente("Gennaro");

            // Agregar los clientes 1 y 2 a la lista
            listaClientes.Add(cliente1);
            listaClientes.Add(cliente2);

            // Crear un objeto anónimo del tipo cliente y guardar en la lista
            listaClientes.Add(new Cliente("Mirta"));

            // Recorrer la lista de clientes

            foreach (Cliente cliente in listaClientes)
            {
                lstClientes.Items.Add(cliente.Nombre);
            }

        }*/



        // Código de arriba refactorizado
        private void btnListaClientes_Click(object sender, EventArgs e)
        {
            List<Cliente> listaClientes = CargaListaClientes();

            MostrarClientesListBox(listaClientes);
        }

        private void MostrarClientesListBox(List<Cliente> listaClientes)
        {
            // Recorrer la lista de clientes

            foreach (Cliente cliente in listaClientes)
            {
                lstClientes.Items.Add(cliente.Nombre);
            }
        }

        private static List<Cliente> CargaListaClientes()
        {

            // Declarar y crear la lista
            List<Cliente> listaClientes = new List<Cliente>();

            // Creamos 2 clientes
            Cliente cliente1 = new Cliente("Mariela");
            Cliente cliente2 = new Cliente("Gennaro");

            // Agregar los clientes 1 y 2 a la lista
            listaClientes.Add(cliente1);
            listaClientes.Add(cliente2);

            // Crear un objeto anónimo del tipo cliente y guardar en la lista
            listaClientes.Add(new Cliente("Mirta"));
            return listaClientes;

        }

        private void btnCrearMedico_Click(object sender, EventArgs e)
        {
            try
            {
                Medico medico = new Medico() { Apellido = "Perez", Nombre = "Pedro", Matricula = 4444 };

                MessageBox.Show(medico.Imprimir());
            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message);
            }

            
        }
    }
}
