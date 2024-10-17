namespace areas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cuadrado_Click(object sender, EventArgs e)
        {
            cuadrado.cuadrado nuevoFormulario = new cuadrado.cuadrado();
            nuevoFormulario.Show();
        }

        private void rectangulo_Click(object sender, EventArgs e)
        {
            rectangulo.rectangulo nuevoFormulario = new rectangulo.rectangulo();
            nuevoFormulario.Show();
        }

        private void circulo_Click(object sender, EventArgs e)
        {
            circulo.circulo nuevoFormulario = new circulo.circulo();
            nuevoFormulario.Show();
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            string repoPath = @"C:\path\to\your\repo";
            string gitCommand = "git pull";
            ExecuteGitCommand(repoPath, gitCommand);
        }


        private void ExecuteGitCommand(string repoPath, string command)
        {
            try
            {
                var processInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe", "/c " + command);
                processInfo.WorkingDirectory = repoPath;
                processInfo.RedirectStandardOutput = true;
                processInfo.RedirectStandardError = true;
                processInfo.UseShellExecute = false;
                processInfo.CreateNoWindow = true;

                using (var process = System.Diagnostics.Process.Start(processInfo))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();
                    process.WaitForExit();
                    if (process.ExitCode != 0)
                    {
                        MessageBox.Show($"Error al actualizar el repositorio: {error}");
                    }
                    else
                    {
                        MessageBox.Show("Repositorio actualizado con éxito");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error ejecutando el comando Git: {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
