using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using System.Drawing;

namespace Practica01.SolveNote
{
    public class Notas
    {
        public static object JsonSerializar { get; private set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }

        //Guardar notas en archivo JSON
        public static void SolveNotesJSON(string titulo, string descripcion)
        {
            List<Notas> nota = new List<Notas>();

            if (File.Exists("notas.json"))
            {
                string json = File.ReadAllText("notas.json");
                nota = JsonSerializer.Deserialize<List<Notas>>(json);
            }

            // agregar la nota a la lista
            nota.Add(new Notas { Titulo = titulo, Descripcion = descripcion });

            // convierte la lista  a json y la guarda en el archivo
            string nuevoJson = JsonSerializer.Serialize(nota);
            File.WriteAllText("notas.json", nuevoJson);

            MessageBox.Show("Nota guardada satisfactoriamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
           

        }
        public static List<Notas> ObtenerNotasDesdeJSON()
        {
            if (File.Exists("notas.json"))
            {
                string json = File.ReadAllText("notas.json");
                return JsonSerializer.Deserialize<List<Notas>>(json) ?? new List<Notas>();
            }
            return new List<Notas>();
        }

    }
}
