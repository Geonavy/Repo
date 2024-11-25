using Newtonsoft.Json; // Descargar el paquete Newtonsoft.Json necesario para trabajar con JSON...
using System.Data;

namespace InterfazJSON
{
    public partial class Administrador : Form
    {
        // Lógica para encontrar el archivo desde el directorio actual...

        static string file = Path.Combine( // Une la ruta base con la ruta relativa...
            AppDomain.CurrentDomain.BaseDirectory, // Obtener la ruta base...
            "Trabajadores.json"); // Ubicación del archivo...

        public Administrador()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        // Método para cargar los datos...
        private void Cargar_Archivo()
        {
            try { 
                string content = File.ReadAllText(file); // Leer todo el archivo...
                DataTable tabla = (DataTable)JsonConvert.DeserializeObject(content, typeof(DataTable));
                // Convertir el JSON a un objeto de tipo tabla...

                GridViewArchivo.DataSource = tabla;

            } catch {
                MessageBox.Show("Error al cargar los datos.", "Carga Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Cargar_Archivo();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una lista para convertirla en la estructura JSON...
                List<Trabajador> trabajadores = new List<Trabajador>();

                // Si no hay filas entonces no hay datos...
                if (GridViewArchivo.Rows.Count == 0)
                {
                    throw new Exception("No hay ningún archivo cargado.");
                }

                // Recorre las filas del DataGridView...
                foreach (DataGridViewRow row in GridViewArchivo.Rows)
                {
                    if (row.IsNewRow) continue; // Omitir las filas nuevas...

                    Trabajador trabajador = new Trabajador
                    (
                        row.Cells["Nombre"].Value != DBNull.Value ? row.Cells["Nombre"].Value?.ToString() : throw new Exception("Debe añadir el nombre del trabajador."),
                        row.Cells["Apellido"].Value != DBNull.Value ? row.Cells["Apellido"].Value?.ToString() : throw new Exception("Debe añadir el apellido del trabajador."),
                        row.Cells["Edad"].Value != DBNull.Value ? Convert.ToInt32(row.Cells["Edad"].Value) : throw new Exception("Debe añadir la edad del trabajador."),
                        row.Cells["Oficio"].Value != DBNull.Value ? row.Cells["Oficio"].Value?.ToString() : throw new Exception("Debe añadir el oficio del trabajador."),
                        row.Cells["Trabajando"].Value != DBNull.Value && Convert.ToBoolean(row.Cells["Trabajando"].Value)
                    );

                    trabajadores.Add(trabajador);
                }

                // Serializar la lista a JSON...
                string jsonContent = JsonConvert.SerializeObject(trabajadores, Formatting.Indented);

                // Guardar el JSON convertido al archivo...
                File.WriteAllTextAsync(file, jsonContent);

                MessageBox.Show("Datos guardados con éxito." + jsonContent, "Operación Realizada.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cargar_Archivo();
            }
            catch (Exception error)
            {
                MessageBox.Show("ERROR: No se lograron guardar los datos : " + error.Message, "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
