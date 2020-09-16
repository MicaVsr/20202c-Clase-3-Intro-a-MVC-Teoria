using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceLayer
{
    public class PersonaService
    {
        private static List<Persona> personas { get; set; }

        public PersonaService()
        {
            if (personas == null)
            {
                personas = new List<Persona>()
                {
                    new Persona(){ Nombre="Alberto", Apellido ="Rodriguez" },
                    new Persona(){ Nombre="Juana", Apellido ="Ramirez" },
                    new Persona(){ Nombre="Matias", Apellido ="Paz" }
                };
            
            }            
        }

        public List<Persona> ListarTodas()
        {
            return personas;
        }

        public void AgregarPersona(Persona p)
        {
            personas.Add(p);     
        }

    }
}