using MiPrimeraAppMAUIBlazor.Class.Persona;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiPrimeraAppMAUIBlazor.Services
{
    public class PersonaService
    {

        private List<PersonaListCLS> lista;
        public PersonaService(){
            lista = new List<PersonaListCLS>();
            lista.Add(new PersonaListCLS { 
                IdPersona = 1, 
                Nombre = "Zoe", 
                Apmaterno = "Gonzalez", 
                Appaterno = "Perez",
                });

            lista.Add(new PersonaListCLS
            {
                IdPersona = 2,
                Nombre = "Josse",
                Apmaterno = "Navarro",
                Appaterno = "Perez",
            });
        }

        public async Task<List<PersonaListCLS>> listaPersona()
        {
            return lista;
        }

        public async Task guardarPersona(PersonaListCLS persona)
        {
            persona.IdPersona = lista.Count == 0 ? 1 : lista.Max(x => x.IdPersona) + 1;
            lista.Add(persona); //NO CAMBIE EL NOMBRE ENTERO DEL PROYECTO PORQUE ME GUIE DE EL PROYECTO DEL PROFESOR 
        }
    }
}
