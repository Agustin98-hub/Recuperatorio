using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApellidoNombre
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\ruta\de\tu\base\de\datos.accdb;";

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeView treeView = new TreeView
            {
                Dock = DockStyle.Fill 
            };
            this.Controls.Add(treeView);

            
            CargarCategoriasYUsuarios(treeView);
        }

        private void CargarCategoriasYUsuarios(TreeView treeView)
        {
            
            Dictionary<string, List<string>> categoriasUsuarios = ObtenerUsuariosPorCategoria();

            
            foreach (var categoria in categoriasUsuarios)
            {
                TreeNode categoriaNode = new TreeNode(categoria.Key);

                
                foreach (string usuario in categoria.Value)
                {
                    categoriaNode.Nodes.Add(new TreeNode(usuario));
                }

                
                treeView.Nodes.Add(categoriaNode);
            }

            
            treeView.ExpandAll();

            
            treeView.NodeMouseClick += new TreeNodeMouseClickEventHandler(TreeView_NodeMouseClick);
        }

        
        private Dictionary<string, List<string>> ObtenerUsuariosPorCategoria()
        {
            Dictionary<string, List<string>> categoriasUsuarios = new Dictionary<string, List<string>>();

            string query = "SELECT Nombre, Categoria FROM Usuarios ORDER BY Categoria, Nombre";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand cmd = new OleDbCommand(query, connection);
                connection.Open();

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string nombreUsuario = reader.GetString(0);  
                    string categoria = reader.GetString(1);  
                    if (!categoriasUsuarios.ContainsKey(categoria))
                    {
                        categoriasUsuarios[categoria] = new List<string>();
                    }

                    
                    categoriasUsuarios[categoria].Add(nombreUsuario);
                }
            }

            return categoriasUsuarios;
        }

        private void TreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
            MessageBox.Show("Seleccionado: " + e.Node.Text);
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
   

