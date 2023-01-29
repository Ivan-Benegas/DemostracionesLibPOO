using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPOO.Clinica
{
    public class Medico : Persona
    {
        public int Matricula { get; set; }

        private string _Nombre;

        public string Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                if (value.Trim().Length < 1 || value.Trim().Length > 50)
                {
                    throw new Exception("El nombre no puede estar vacio o superar los 50 caracteres.");
                }

                _Nombre = value.Trim();
            }
        }

        // Propiedad de navegación
        public List<Paciente> Pacientes { get; set; }

    }
}
