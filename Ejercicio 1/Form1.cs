namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] Pn1, Pn2;
        string[] Pdatos;
        int nc = 0, indice = 0;
        Random random = new Random();
        private void mostrarArreglo(string[] arreglo, ListBox list)
        {
            list.Items.Clear();
            for (int i = 0; i < arreglo.Length; i++)
                list.Items.Add(arreglo[i]);
        }
        private void generarArreglo(int Pn, int tipo)
        {
            if (tipo == 1)
            {
                Pn1 = new int[Pn];
                for (int i = 0; i < Pn1.Length; i++)
                    Pn1[i] = random.Next(1000, 5001);
            }
            else if (tipo == 2)
            {
                Pn2 = new int[Pn];
                for (int i = 0; i < Pn2.Length; i++)
                    Pn2[i] = random.Next(0, 21);
            }
            else
            {
                Pdatos = new string[Pn];
            }
        }

        private void ordenarArreglo(string[] Parreglo)
        {
            string aux;
            for (int i = 0; i < Parreglo.Length; i++)
            {
                for (int j = i + 1; j < Parreglo.Length; j++)
                {
                    if (Parreglo[i].CompareTo(Parreglo[j]) > 0)
                    {
                        aux = Parreglo[i];
                       Parreglo[i] = Parreglo[j];
                        Parreglo[j] = aux;
                    }
                }
            }
        }
        private void btnGenerar_3_Click(object sender, EventArgs e)
        {try
            {
                if (btnGenerar_3.Text == "Generar")
                {
                    nc = int.Parse(txtContactos.Text);
                    generarArreglo(nc, 3);
                    btnGenerar_3.Text = "Ordenar";

                }
                else
                {
                    ordenarArreglo(Pdatos);
                    mostrarArreglo(Pdatos, listBox3);
                    btnGenerar_3.Text = "Generar";

                }
            }
            catch(Exception)
                {
                   
                MessageBox.Show("EL NUMERO NO FUE INGRESADO",
                 "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        { try
            {
                listBox3.Items.Add(txtNombre.Text);
                Pdatos[indice] = txtNombre.Text;
                indice++;
                if ((indice + 1) > nc)
                    txtNombre.Enabled = false;
                txtNombre.Text = ""; txtNombre.Focus();
            }
            catch( Exception)
            {
                MessageBox.Show("EL NUMERO NO FUE INGRESADO",
                "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}