using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sistema_Taller
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            contentCard.Anchor = AnchorStyles.None;
            cardsPanel.Anchor = AnchorStyles.None;
            recentPanel.Anchor = AnchorStyles.None;
            welcomePanel.Anchor = AnchorStyles.None;
            quickPanel.Anchor = AnchorStyles.None;
            recentGrid.Anchor = AnchorStyles.None;
            quickActions.Anchor = AnchorStyles.None;
            grid.Anchor = AnchorStyles.None;
            userIcon.Anchor = AnchorStyles.None;
            userLabel.Anchor = AnchorStyles.None;
            logoutButton.Anchor = AnchorStyles.None;
            actionButton.Anchor = AnchorStyles.None;
            workspace.Resize += (_, _) => LayoutDashboard();
            Shown += (_, _) => LayoutDashboard();
            LayoutDashboard();
        }

        public string UsuarioActual
        {
            get => userLabel.Text;
            set => userLabel.Text = string.IsNullOrWhiteSpace(value) ? "Usuario" : value;
        }

        private void LayoutDashboard()
        {
            if (workspace.ClientSize.Width < 850 || workspace.ClientSize.Height < 450) return;
            contentCard.SetBounds(35, 130,
                workspace.ClientSize.Width - 70,
                workspace.ClientSize.Height - 155);
            userIcon.Left = header.ClientSize.Width - 305;
            userLabel.Left = header.ClientSize.Width - 258;
            logoutButton.Left = header.ClientSize.Width - 110;
            actionButton.Left = workspace.ClientSize.Width - actionButton.Width - 35;

            int width = contentCard.ClientSize.Width;
            int height = contentCard.ClientSize.Height;
            if (width < 780 || height < 290) return;

            const int margin = 22;
            const int gap = 22;
            int leftWidth = (int)((width - margin * 2 - gap) * 0.52);
            int rightX = margin + leftWidth + gap;
            int rightWidth = width - rightX - margin;
            int topHeight = Math.Max(180, (int)((height - 65) * 0.52));
            int bottomY = margin + topHeight + 20;
            int bottomHeight = Math.Max(160, height - bottomY - margin);

            cardsPanel.SetBounds(margin, margin, leftWidth, topHeight);
            recentPanel.SetBounds(rightX, margin, rightWidth, topHeight);
            welcomePanel.SetBounds(margin, bottomY, leftWidth, bottomHeight);
            quickPanel.SetBounds(rightX, bottomY, rightWidth, bottomHeight);

            int cardWidth = Math.Min(280, Math.Max(145, (leftWidth - 24) / 3));
            int cardHeight = Math.Max(96, (topHeight - 18) / 2);
            foreach (Control card in cardsPanel.Controls)
            {
                card.Size = new Size(cardWidth - 8, cardHeight - 8);
                card.Margin = new Padding(0, 0, 8, 8);
            }

            recentGrid.SetBounds(18, 60, rightWidth - 36, topHeight - 78);
            quickActions.SetBounds(18, 60, rightWidth - 36, bottomHeight - 78);
            int quickWidth = Math.Min(210, Math.Max(115, (quickActions.Width - 24) / 3));
            foreach (Control shortcut in quickActions.Controls)
            {
                shortcut.Size = new Size(quickWidth - 8, 58);
                shortcut.Margin = new Padding(0, 0, 8, 9);
            }
            grid.SetBounds(22, 130, width - 44, height - 155);
        }

        private void LogoutButton_Click(object? sender, EventArgs e)
        {
            var answer = MessageBox.Show("¿Deseas salir de MecaSoft?", "Cerrar sesión",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes) Close();
        }

        private void Navigation_Click(object? sender, EventArgs e)
        {
            if (sender is not Button selected) return;
            foreach (Control control in navPanel.Controls)
                if (control is Button button)
                    button.BackColor = button == selected ? Color.FromArgb(0, 179, 224) : Color.FromArgb(7, 23, 40);

            titleLabel.Text = selected.Text == "Órdenes" ? "Órdenes de trabajo" : selected.Text;
            descriptionLabel.Text = selected.Text == "Inicio"
                ? "Vista general del taller"
                : "Consulta y organiza la información de " + selected.Text.ToLowerInvariant();
            actionButton.Visible = selected.Text != "Inicio" && selected.Text != "Reportes";
            actionButton.Text = selected.Text switch
            {
                "Clientes" => "+ Nuevo cliente",
                "Vehículos" => "+ Nuevo vehículo",
                "Órdenes" => "+ Nueva orden",
                "Servicios" => "+ Nuevo servicio",
                "Inventario" => "+ Nuevo repuesto",
                "Facturación" => "+ Nueva factura",
                _ => "+ Nuevo"
            };
            searchBox.Visible = selected.Text != "Inicio";
            grid.Visible = selected.Text != "Inicio";
            if (selected.Text != "Inicio")
            {
                searchBox.Location = new Point(22, 22);
                previewLabel.Location = new Point(23, 85);
            }
            cardsPanel.Visible = selected.Text == "Inicio";
            welcomePanel.Visible = selected.Text == "Inicio";
            recentPanel.Visible = selected.Text == "Inicio";
            quickPanel.Visible = selected.Text == "Inicio";
            previewLabel.Visible = selected.Text != "Inicio";
            grid.Columns.Clear();
            string[] columns = selected.Text switch
            {
                "Clientes" => new[] { "Nombre", "Teléfono", "Correo", "Dirección" },
                "Vehículos" => new[] { "Placa", "Marca", "Modelo", "Propietario", "Color" },
                "Órdenes" => new[] { "N.º orden", "Vehículo", "Ingreso", "Entrega estimada", "Kilometraje" },
                "Servicios" => new[] { "Servicio", "Descripción", "Precio base" },
                "Inventario" => new[] { "Repuesto", "Stock", "Precio compra", "Precio venta" },
                "Facturación" => new[] { "N.º factura", "N.º orden", "Fecha", "Subtotal", "Impuesto", "Total" },
                _ => new[] { "Período", "Órdenes", "Ingresos" }
            };
            foreach (string column in columns) grid.Columns.Add(column, column);
        }

        private void ActionButton_Click(object? sender, EventArgs e) =>
            MessageBox.Show("Esta es una vista de diseño. El formulario se agregará en la siguiente etapa.", "MecaSoft");
    }
}
