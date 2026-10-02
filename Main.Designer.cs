using System.Drawing;
using System.Windows.Forms;

namespace Sistema_Taller
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;
        private Panel header;
        private Label brandLabel;
        private Label subtitleLabel;
        private PictureBox logoBox;
        private Label userLabel;
        private PictureBox userIcon;
        private Button logoutButton;
        private FlowLayoutPanel navPanel;
        private Panel workspace;
        private Label titleLabel;
        private Label descriptionLabel;
        private Button actionButton;
        private Panel contentCard;
        private TextBox searchBox;
        private Label previewLabel;
        private DataGridView grid;
        private FlowLayoutPanel cardsPanel;
        private Panel welcomePanel;
        private Panel recentPanel;
        private Label recentTitle;
        private DataGridView recentGrid;
        private Panel quickPanel;
        private Label quickTitle;
        private FlowLayoutPanel quickActions;
        private Label welcomeTitle;
        private Label welcomeText;
        private Button navInicio;
        private Button navClientes;
        private Button navVehiculos;
        private Button navOrdenes;
        private Button navServicios;
        private Button navInventario;
        private Button navFacturacion;
        private Button navReportes;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            header = new Panel();
            brandLabel = new Label();
            subtitleLabel = new Label();
            logoBox = new PictureBox();
            userLabel = new Label();
            userIcon = new PictureBox();
            logoutButton = new Button();
            navPanel = new FlowLayoutPanel();
            navInicio = new Button();
            navClientes = new Button();
            navVehiculos = new Button();
            navOrdenes = new Button();
            navServicios = new Button();
            navInventario = new Button();
            navFacturacion = new Button();
            navReportes = new Button();
            workspace = new Panel();
            titleLabel = new Label();
            descriptionLabel = new Label();
            actionButton = new Button();
            contentCard = new Panel();
            searchBox = new TextBox();
            previewLabel = new Label();
            grid = new DataGridView();
            cardsPanel = new FlowLayoutPanel();
            card0 = new Panel();
            cardTitle0 = new Label();
            cardValue0 = new Label();
            card1 = new Panel();
            cardTitle1 = new Label();
            cardValue1 = new Label();
            card2 = new Panel();
            cardTitle2 = new Label();
            cardValue2 = new Label();
            card3 = new Panel();
            cardTitle3 = new Label();
            cardValue3 = new Label();
            card4 = new Panel();
            cardTitle4 = new Label();
            cardValue4 = new Label();
            card5 = new Panel();
            cardTitle5 = new Label();
            cardValue5 = new Label();
            welcomePanel = new Panel();
            welcomeTitle = new Label();
            welcomeText = new Label();
            recentPanel = new Panel();
            recentTitle = new Label();
            recentGrid = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            quickPanel = new Panel();
            quickTitle = new Label();
            quickActions = new FlowLayoutPanel();
            quick0 = new Button();
            quick1 = new Button();
            quick2 = new Button();
            quick3 = new Button();
            quick4 = new Button();
            quick5 = new Button();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).BeginInit();
            navPanel.SuspendLayout();
            workspace.SuspendLayout();
            contentCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            cardsPanel.SuspendLayout();
            card0.SuspendLayout();
            card1.SuspendLayout();
            card2.SuspendLayout();
            card3.SuspendLayout();
            card4.SuspendLayout();
            card5.SuspendLayout();
            welcomePanel.SuspendLayout();
            recentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)recentGrid).BeginInit();
            quickPanel.SuspendLayout();
            quickActions.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(7, 23, 40);
            header.Controls.Add(brandLabel);
            header.Controls.Add(subtitleLabel);
            header.Controls.Add(logoBox);
            header.Controls.Add(userLabel);
            header.Controls.Add(userIcon);
            header.Controls.Add(logoutButton);
            header.Controls.Add(navPanel);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(1450, 134);
            header.TabIndex = 1;
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            brandLabel.ForeColor = Color.White;
            brandLabel.Location = new Point(90, 12);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(187, 50);
            brandLabel.TabIndex = 0;
            brandLabel.Text = "MecaSoft";
            // 
            // subtitleLabel
            // 
            subtitleLabel.AutoSize = true;
            subtitleLabel.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            subtitleLabel.ForeColor = Color.FromArgb(126, 172, 195);
            subtitleLabel.Location = new Point(90, 68);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Size = new Size(218, 19);
            subtitleLabel.TabIndex = 1;
            subtitleLabel.Text = "GESTIÓN DE TALLER MECÁNICO";
            // 
            // logoBox
            // 
            logoBox.Image = (Image)resources.GetObject("logoBox.Image");
            logoBox.Location = new Point(20, 13);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(64, 65);
            logoBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoBox.TabIndex = 2;
            logoBox.TabStop = false;
            // 
            // userLabel
            // 
            userLabel.Anchor = AnchorStyles.None;
            userLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            userLabel.ForeColor = Color.White;
            userLabel.Location = new Point(1216, 41);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(125, 25);
            userLabel.TabIndex = 3;
            userLabel.Text = "Usuario";
            // 
            // userIcon
            // 
            userIcon.Anchor = AnchorStyles.None;
            userIcon.Image = (Image)resources.GetObject("userIcon.Image");
            userIcon.Location = new Point(1152, 30);
            userIcon.Name = "userIcon";
            userIcon.Size = new Size(42, 38);
            userIcon.SizeMode = PictureBoxSizeMode.Zoom;
            userIcon.TabIndex = 4;
            userIcon.TabStop = false;
            // 
            // logoutButton
            // 
            logoutButton.Anchor = AnchorStyles.None;
            logoutButton.BackColor = Color.FromArgb(29, 68, 99);
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            logoutButton.ForeColor = Color.White;
            logoutButton.Location = new Point(1358, 32);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(80, 36);
            logoutButton.TabIndex = 5;
            logoutButton.Text = "Salir";
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += LogoutButton_Click;
            // 
            // navPanel
            // 
            navPanel.AutoScroll = true;
            navPanel.Controls.Add(navInicio);
            navPanel.Controls.Add(navClientes);
            navPanel.Controls.Add(navVehiculos);
            navPanel.Controls.Add(navOrdenes);
            navPanel.Controls.Add(navServicios);
            navPanel.Controls.Add(navInventario);
            navPanel.Controls.Add(navFacturacion);
            navPanel.Controls.Add(navReportes);
            navPanel.Dock = DockStyle.Bottom;
            navPanel.Location = new Point(0, 90);
            navPanel.Name = "navPanel";
            navPanel.Padding = new Padding(270, 0, 0, 0);
            navPanel.Size = new Size(1450, 44);
            navPanel.TabIndex = 6;
            navPanel.WrapContents = false;
            // 
            // navInicio
            // 
            navInicio.BackColor = Color.FromArgb(0, 179, 224);
            navInicio.FlatAppearance.BorderSize = 0;
            navInicio.FlatStyle = FlatStyle.Flat;
            navInicio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            navInicio.ForeColor = Color.White;
            navInicio.Location = new Point(270, 0);
            navInicio.Margin = new Padding(0, 0, 6, 0);
            navInicio.Name = "navInicio";
            navInicio.Size = new Size(110, 37);
            navInicio.TabIndex = 0;
            navInicio.Text = "Inicio";
            navInicio.UseVisualStyleBackColor = false;
            navInicio.Click += Navigation_Click;
            // 
            // navClientes
            // 
            navClientes.BackColor = Color.FromArgb(7, 23, 40);
            navClientes.FlatAppearance.BorderSize = 0;
            navClientes.FlatStyle = FlatStyle.Flat;
            navClientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            navClientes.ForeColor = Color.White;
            navClientes.Location = new Point(386, 0);
            navClientes.Margin = new Padding(0, 0, 6, 0);
            navClientes.Name = "navClientes";
            navClientes.Size = new Size(110, 37);
            navClientes.TabIndex = 1;
            navClientes.Text = "Clientes";
            navClientes.UseVisualStyleBackColor = false;
            navClientes.Click += Navigation_Click;
            // 
            // navVehiculos
            // 
            navVehiculos.BackColor = Color.FromArgb(7, 23, 40);
            navVehiculos.FlatAppearance.BorderSize = 0;
            navVehiculos.FlatStyle = FlatStyle.Flat;
            navVehiculos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            navVehiculos.ForeColor = Color.White;
            navVehiculos.Location = new Point(502, 0);
            navVehiculos.Margin = new Padding(0, 0, 6, 0);
            navVehiculos.Name = "navVehiculos";
            navVehiculos.Size = new Size(110, 37);
            navVehiculos.TabIndex = 2;
            navVehiculos.Text = "Vehículos";
            navVehiculos.UseVisualStyleBackColor = false;
            navVehiculos.Click += Navigation_Click;
            // 
            // navOrdenes
            // 
            navOrdenes.BackColor = Color.FromArgb(7, 23, 40);
            navOrdenes.FlatAppearance.BorderSize = 0;
            navOrdenes.FlatStyle = FlatStyle.Flat;
            navOrdenes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            navOrdenes.ForeColor = Color.White;
            navOrdenes.Location = new Point(618, 0);
            navOrdenes.Margin = new Padding(0, 0, 6, 0);
            navOrdenes.Name = "navOrdenes";
            navOrdenes.Size = new Size(110, 37);
            navOrdenes.TabIndex = 3;
            navOrdenes.Text = "Órdenes";
            navOrdenes.UseVisualStyleBackColor = false;
            navOrdenes.Click += Navigation_Click;
            // 
            // navServicios
            // 
            navServicios.BackColor = Color.FromArgb(7, 23, 40);
            navServicios.FlatAppearance.BorderSize = 0;
            navServicios.FlatStyle = FlatStyle.Flat;
            navServicios.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            navServicios.ForeColor = Color.White;
            navServicios.Location = new Point(734, 0);
            navServicios.Margin = new Padding(0, 0, 6, 0);
            navServicios.Name = "navServicios";
            navServicios.Size = new Size(110, 37);
            navServicios.TabIndex = 4;
            navServicios.Text = "Servicios";
            navServicios.UseVisualStyleBackColor = false;
            navServicios.Click += Navigation_Click;
            // 
            // navInventario
            // 
            navInventario.BackColor = Color.FromArgb(7, 23, 40);
            navInventario.FlatAppearance.BorderSize = 0;
            navInventario.FlatStyle = FlatStyle.Flat;
            navInventario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            navInventario.ForeColor = Color.White;
            navInventario.Location = new Point(850, 0);
            navInventario.Margin = new Padding(0, 0, 6, 0);
            navInventario.Name = "navInventario";
            navInventario.Size = new Size(110, 37);
            navInventario.TabIndex = 5;
            navInventario.Text = "Inventario";
            navInventario.UseVisualStyleBackColor = false;
            navInventario.Click += Navigation_Click;
            // 
            // navFacturacion
            // 
            navFacturacion.BackColor = Color.FromArgb(7, 23, 40);
            navFacturacion.FlatAppearance.BorderSize = 0;
            navFacturacion.FlatStyle = FlatStyle.Flat;
            navFacturacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            navFacturacion.ForeColor = Color.White;
            navFacturacion.Location = new Point(966, 0);
            navFacturacion.Margin = new Padding(0, 0, 6, 0);
            navFacturacion.Name = "navFacturacion";
            navFacturacion.Size = new Size(125, 37);
            navFacturacion.TabIndex = 6;
            navFacturacion.Text = "Facturación";
            navFacturacion.UseVisualStyleBackColor = false;
            navFacturacion.Click += Navigation_Click;
            // 
            // navReportes
            // 
            navReportes.BackColor = Color.FromArgb(7, 23, 40);
            navReportes.FlatAppearance.BorderSize = 0;
            navReportes.FlatStyle = FlatStyle.Flat;
            navReportes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            navReportes.ForeColor = Color.White;
            navReportes.Location = new Point(1097, 0);
            navReportes.Margin = new Padding(0, 0, 6, 0);
            navReportes.Name = "navReportes";
            navReportes.Size = new Size(110, 37);
            navReportes.TabIndex = 7;
            navReportes.Text = "Reportes";
            navReportes.UseVisualStyleBackColor = false;
            navReportes.Click += Navigation_Click;
            // 
            // workspace
            // 
            workspace.BackColor = Color.FromArgb(244, 247, 250);
            workspace.Controls.Add(titleLabel);
            workspace.Controls.Add(descriptionLabel);
            workspace.Controls.Add(actionButton);
            workspace.Controls.Add(contentCard);
            workspace.Dock = DockStyle.Fill;
            workspace.Location = new Point(0, 134);
            workspace.Name = "workspace";
            workspace.Size = new Size(1450, 766);
            workspace.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(29, 48, 65);
            titleLabel.Location = new Point(35, 25);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(123, 52);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Inicio";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI", 10F);
            descriptionLabel.ForeColor = Color.FromArgb(100, 119, 135);
            descriptionLabel.Location = new Point(38, 80);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(180, 23);
            descriptionLabel.TabIndex = 1;
            descriptionLabel.Text = "Vista general del taller";
            // 
            // actionButton
            // 
            actionButton.Anchor = AnchorStyles.None;
            actionButton.BackColor = Color.FromArgb(0, 179, 224);
            actionButton.FlatAppearance.BorderSize = 0;
            actionButton.FlatStyle = FlatStyle.Flat;
            actionButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            actionButton.ForeColor = Color.White;
            actionButton.Location = new Point(1500, 35);
            actionButton.Name = "actionButton";
            actionButton.Size = new Size(170, 42);
            actionButton.TabIndex = 2;
            actionButton.Text = "+ Nuevo";
            actionButton.UseVisualStyleBackColor = false;
            actionButton.Visible = false;
            actionButton.Click += ActionButton_Click;
            // 
            // contentCard
            // 
            contentCard.Anchor = AnchorStyles.None;
            contentCard.BackColor = Color.White;
            contentCard.BorderStyle = BorderStyle.FixedSingle;
            contentCard.Controls.Add(searchBox);
            contentCard.Controls.Add(previewLabel);
            contentCard.Controls.Add(grid);
            contentCard.Controls.Add(cardsPanel);
            contentCard.Controls.Add(welcomePanel);
            contentCard.Controls.Add(recentPanel);
            contentCard.Controls.Add(quickPanel);
            contentCard.Location = new Point(35, 125);
            contentCard.Name = "contentCard";
            contentCard.Size = new Size(1380, 600);
            contentCard.TabIndex = 3;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(1500, 22);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Buscar...";
            searchBox.Size = new Size(370, 27);
            searchBox.TabIndex = 0;
            searchBox.Visible = false;
            // 
            // previewLabel
            // 
            previewLabel.AutoSize = true;
            previewLabel.ForeColor = Color.FromArgb(100, 119, 135);
            previewLabel.Location = new Point(1500, 85);
            previewLabel.Name = "previewLabel";
            previewLabel.Size = new Size(420, 20);
            previewLabel.TabIndex = 1;
            previewLabel.Text = "Los registros aparecerán aquí cuando se conecte este módulo.";
            previewLabel.Visible = false;
            // 
            // grid
            // 
            grid.AllowUserToAddRows = false;
            grid.Anchor = AnchorStyles.None;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.None;
            grid.ColumnHeadersHeight = 42;
            grid.Location = new Point(1500, 130);
            grid.Name = "grid";
            grid.ReadOnly = true;
            grid.RowHeadersVisible = false;
            grid.RowHeadersWidth = 51;
            grid.Size = new Size(1215, 450);
            grid.TabIndex = 2;
            grid.Visible = false;
            // 
            // cardsPanel
            // 
            cardsPanel.Anchor = AnchorStyles.None;
            cardsPanel.Controls.Add(card0);
            cardsPanel.Controls.Add(card1);
            cardsPanel.Controls.Add(card2);
            cardsPanel.Controls.Add(card3);
            cardsPanel.Controls.Add(card4);
            cardsPanel.Controls.Add(card5);
            cardsPanel.Location = new Point(22, 23);
            cardsPanel.Name = "cardsPanel";
            cardsPanel.Size = new Size(660, 270);
            cardsPanel.TabIndex = 3;
            // 
            // card0
            // 
            card0.BackColor = Color.FromArgb(244, 247, 250);
            card0.Controls.Add(cardTitle0);
            card0.Controls.Add(cardValue0);
            card0.Location = new Point(0, 0);
            card0.Margin = new Padding(0, 0, 15, 0);
            card0.Name = "card0";
            card0.Size = new Size(205, 116);
            card0.TabIndex = 0;
            // 
            // cardTitle0
            // 
            cardTitle0.AutoSize = true;
            cardTitle0.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            cardTitle0.Location = new Point(16, 15);
            cardTitle0.Name = "cardTitle0";
            cardTitle0.Size = new Size(150, 25);
            cardTitle0.TabIndex = 0;
            cardTitle0.Text = "Órdenes activas";
            // 
            // cardValue0
            // 
            cardValue0.AutoSize = true;
            cardValue0.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            cardValue0.ForeColor = Color.FromArgb(0, 179, 224);
            cardValue0.Location = new Point(16, 42);
            cardValue0.Name = "cardValue0";
            cardValue0.Size = new Size(67, 57);
            cardValue0.TabIndex = 1;
            cardValue0.Text = "—";
            // 
            // card1
            // 
            card1.BackColor = Color.FromArgb(244, 247, 250);
            card1.Controls.Add(cardTitle1);
            card1.Controls.Add(cardValue1);
            card1.Location = new Point(220, 0);
            card1.Margin = new Padding(0, 0, 15, 0);
            card1.Name = "card1";
            card1.Size = new Size(205, 116);
            card1.TabIndex = 1;
            // 
            // cardTitle1
            // 
            cardTitle1.AutoSize = true;
            cardTitle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            cardTitle1.Location = new Point(16, 15);
            cardTitle1.Name = "cardTitle1";
            cardTitle1.Size = new Size(177, 25);
            cardTitle1.TabIndex = 0;
            cardTitle1.Text = "Entregas próximas";
            // 
            // cardValue1
            // 
            cardValue1.AutoSize = true;
            cardValue1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            cardValue1.ForeColor = Color.FromArgb(0, 179, 224);
            cardValue1.Location = new Point(16, 42);
            cardValue1.Name = "cardValue1";
            cardValue1.Size = new Size(67, 57);
            cardValue1.TabIndex = 1;
            cardValue1.Text = "—";
            // 
            // card2
            // 
            card2.BackColor = Color.FromArgb(244, 247, 250);
            card2.Controls.Add(cardTitle2);
            card2.Controls.Add(cardValue2);
            card2.Location = new Point(440, 0);
            card2.Margin = new Padding(0, 0, 15, 0);
            card2.Name = "card2";
            card2.Size = new Size(205, 116);
            card2.TabIndex = 2;
            // 
            // cardTitle2
            // 
            cardTitle2.AutoSize = true;
            cardTitle2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            cardTitle2.Location = new Point(16, 15);
            cardTitle2.Name = "cardTitle2";
            cardTitle2.Size = new Size(106, 25);
            cardTitle2.TabIndex = 0;
            cardTitle2.Text = "Stock bajo";
            // 
            // cardValue2
            // 
            cardValue2.AutoSize = true;
            cardValue2.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            cardValue2.ForeColor = Color.FromArgb(0, 179, 224);
            cardValue2.Location = new Point(16, 42);
            cardValue2.Name = "cardValue2";
            cardValue2.Size = new Size(67, 57);
            cardValue2.TabIndex = 1;
            cardValue2.Text = "—";
            // 
            // card3
            // 
            card3.BackColor = Color.FromArgb(244, 247, 250);
            card3.Controls.Add(cardTitle3);
            card3.Controls.Add(cardValue3);
            card3.Location = new Point(0, 116);
            card3.Margin = new Padding(0, 0, 15, 0);
            card3.Name = "card3";
            card3.Size = new Size(205, 116);
            card3.TabIndex = 3;
            // 
            // cardTitle3
            // 
            cardTitle3.AutoSize = true;
            cardTitle3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            cardTitle3.Location = new Point(16, 15);
            cardTitle3.Name = "cardTitle3";
            cardTitle3.Size = new Size(91, 25);
            cardTitle3.TabIndex = 0;
            cardTitle3.Text = "Servicios";
            // 
            // cardValue3
            // 
            cardValue3.AutoSize = true;
            cardValue3.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            cardValue3.ForeColor = Color.FromArgb(0, 179, 224);
            cardValue3.Location = new Point(16, 42);
            cardValue3.Name = "cardValue3";
            cardValue3.Size = new Size(67, 57);
            cardValue3.TabIndex = 1;
            cardValue3.Text = "—";
            // 
            // card4
            // 
            card4.BackColor = Color.FromArgb(244, 247, 250);
            card4.Controls.Add(cardTitle4);
            card4.Controls.Add(cardValue4);
            card4.Location = new Point(220, 116);
            card4.Margin = new Padding(0, 0, 15, 0);
            card4.Name = "card4";
            card4.Size = new Size(205, 116);
            card4.TabIndex = 4;
            // 
            // cardTitle4
            // 
            cardTitle4.AutoSize = true;
            cardTitle4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            cardTitle4.Location = new Point(16, 15);
            cardTitle4.Name = "cardTitle4";
            cardTitle4.Size = new Size(103, 25);
            cardTitle4.TabIndex = 0;
            cardTitle4.Text = "Repuestos";
            // 
            // cardValue4
            // 
            cardValue4.AutoSize = true;
            cardValue4.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            cardValue4.ForeColor = Color.FromArgb(0, 179, 224);
            cardValue4.Location = new Point(16, 42);
            cardValue4.Name = "cardValue4";
            cardValue4.Size = new Size(67, 57);
            cardValue4.TabIndex = 1;
            cardValue4.Text = "—";
            // 
            // card5
            // 
            card5.BackColor = Color.FromArgb(244, 247, 250);
            card5.Controls.Add(cardTitle5);
            card5.Controls.Add(cardValue5);
            card5.Location = new Point(440, 116);
            card5.Margin = new Padding(0, 0, 15, 0);
            card5.Name = "card5";
            card5.Size = new Size(205, 116);
            card5.TabIndex = 5;
            // 
            // cardTitle5
            // 
            cardTitle5.AutoSize = true;
            cardTitle5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            cardTitle5.Location = new Point(16, 15);
            cardTitle5.Name = "cardTitle5";
            cardTitle5.Size = new Size(85, 25);
            cardTitle5.TabIndex = 0;
            cardTitle5.Text = "Facturas";
            // 
            // cardValue5
            // 
            cardValue5.AutoSize = true;
            cardValue5.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            cardValue5.ForeColor = Color.FromArgb(0, 179, 224);
            cardValue5.Location = new Point(16, 42);
            cardValue5.Name = "cardValue5";
            cardValue5.Size = new Size(67, 57);
            cardValue5.TabIndex = 1;
            cardValue5.Text = "—";
            // 
            // welcomePanel
            // 
            welcomePanel.Anchor = AnchorStyles.None;
            welcomePanel.BackColor = Color.FromArgb(13, 41, 67);
            welcomePanel.Controls.Add(welcomeTitle);
            welcomePanel.Controls.Add(welcomeText);
            welcomePanel.Location = new Point(22, 320);
            welcomePanel.Name = "welcomePanel";
            welcomePanel.Size = new Size(655, 245);
            welcomePanel.TabIndex = 4;
            // 
            // welcomeTitle
            // 
            welcomeTitle.AutoSize = true;
            welcomeTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            welcomeTitle.ForeColor = Color.White;
            welcomeTitle.Location = new Point(25, 25);
            welcomeTitle.Name = "welcomeTitle";
            welcomeTitle.Size = new Size(371, 41);
            welcomeTitle.TabIndex = 0;
            welcomeTitle.Text = "Tu taller, más organizado";
            // 
            // welcomeText
            // 
            welcomeText.Font = new Font("Segoe UI", 10F);
            welcomeText.ForeColor = Color.FromArgb(198, 224, 239);
            welcomeText.Location = new Point(26, 80);
            welcomeText.Name = "welcomeText";
            welcomeText.Size = new Size(530, 48);
            welcomeText.TabIndex = 1;
            welcomeText.Text = "Controla clientes, vehículos, servicios, repuestos y facturación.";
            // 
            // recentPanel
            // 
            recentPanel.Anchor = AnchorStyles.None;
            recentPanel.BackColor = Color.FromArgb(248, 251, 254);
            recentPanel.BorderStyle = BorderStyle.FixedSingle;
            recentPanel.Controls.Add(recentTitle);
            recentPanel.Controls.Add(recentGrid);
            recentPanel.Location = new Point(700, 23);
            recentPanel.Name = "recentPanel";
            recentPanel.Size = new Size(655, 270);
            recentPanel.TabIndex = 5;
            // 
            // recentTitle
            // 
            recentTitle.AutoSize = true;
            recentTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            recentTitle.ForeColor = Color.FromArgb(29, 48, 65);
            recentTitle.Location = new Point(18, 16);
            recentTitle.Name = "recentTitle";
            recentTitle.Size = new Size(345, 30);
            recentTitle.TabIndex = 0;
            recentTitle.Text = "▤  Órdenes de trabajo recientes";
            // 
            // recentGrid
            // 
            recentGrid.AllowUserToAddRows = false;
            recentGrid.Anchor = AnchorStyles.None;
            recentGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            recentGrid.BackgroundColor = Color.White;
            recentGrid.BorderStyle = BorderStyle.None;
            recentGrid.ColumnHeadersHeight = 29;
            recentGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            recentGrid.Location = new Point(18, 60);
            recentGrid.Name = "recentGrid";
            recentGrid.ReadOnly = true;
            recentGrid.RowHeadersVisible = false;
            recentGrid.RowHeadersWidth = 51;
            recentGrid.Size = new Size(617, 190);
            recentGrid.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Orden";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Vehículo";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Cliente";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Ingreso";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Estado";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // quickPanel
            // 
            quickPanel.Anchor = AnchorStyles.None;
            quickPanel.BackColor = Color.FromArgb(248, 251, 254);
            quickPanel.BorderStyle = BorderStyle.FixedSingle;
            quickPanel.Controls.Add(quickTitle);
            quickPanel.Controls.Add(quickActions);
            quickPanel.Location = new Point(700, 320);
            quickPanel.Name = "quickPanel";
            quickPanel.Size = new Size(655, 245);
            quickPanel.TabIndex = 6;
            // 
            // quickTitle
            // 
            quickTitle.AutoSize = true;
            quickTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            quickTitle.ForeColor = Color.FromArgb(29, 48, 65);
            quickTitle.Location = new Point(18, 16);
            quickTitle.Name = "quickTitle";
            quickTitle.Size = new Size(222, 30);
            quickTitle.TabIndex = 0;
            quickTitle.Text = "⚡  Accesos rápidos";
            // 
            // quickActions
            // 
            quickActions.Anchor = AnchorStyles.None;
            quickActions.Controls.Add(quick0);
            quickActions.Controls.Add(quick1);
            quickActions.Controls.Add(quick2);
            quickActions.Controls.Add(quick3);
            quickActions.Controls.Add(quick4);
            quickActions.Controls.Add(quick5);
            quickActions.Location = new Point(18, 60);
            quickActions.Name = "quickActions";
            quickActions.Size = new Size(617, 160);
            quickActions.TabIndex = 1;
            // 
            // quick0
            // 
            quick0.BackColor = Color.FromArgb(231, 245, 252);
            quick0.FlatAppearance.BorderSize = 0;
            quick0.FlatStyle = FlatStyle.Flat;
            quick0.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            quick0.ForeColor = Color.FromArgb(22, 89, 143);
            quick0.Location = new Point(0, 0);
            quick0.Margin = new Padding(0, 0, 10, 10);
            quick0.Name = "quick0";
            quick0.Size = new Size(150, 60);
            quick0.TabIndex = 0;
            quick0.Text = "+ Nuevo cliente";
            quick0.UseVisualStyleBackColor = false;
            quick0.Click += ActionButton_Click;
            // 
            // quick1
            // 
            quick1.BackColor = Color.FromArgb(231, 245, 252);
            quick1.FlatAppearance.BorderSize = 0;
            quick1.FlatStyle = FlatStyle.Flat;
            quick1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            quick1.ForeColor = Color.FromArgb(22, 89, 143);
            quick1.Location = new Point(160, 0);
            quick1.Margin = new Padding(0, 0, 10, 10);
            quick1.Name = "quick1";
            quick1.Size = new Size(150, 60);
            quick1.TabIndex = 1;
            quick1.Text = "+ Nuevo vehículo";
            quick1.UseVisualStyleBackColor = false;
            quick1.Click += ActionButton_Click;
            // 
            // quick2
            // 
            quick2.BackColor = Color.FromArgb(231, 245, 252);
            quick2.FlatAppearance.BorderSize = 0;
            quick2.FlatStyle = FlatStyle.Flat;
            quick2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            quick2.ForeColor = Color.FromArgb(22, 89, 143);
            quick2.Location = new Point(320, 0);
            quick2.Margin = new Padding(0, 0, 10, 10);
            quick2.Name = "quick2";
            quick2.Size = new Size(150, 60);
            quick2.TabIndex = 2;
            quick2.Text = "+ Nueva orden";
            quick2.UseVisualStyleBackColor = false;
            quick2.Click += ActionButton_Click;
            // 
            // quick3
            // 
            quick3.BackColor = Color.FromArgb(231, 245, 252);
            quick3.FlatAppearance.BorderSize = 0;
            quick3.FlatStyle = FlatStyle.Flat;
            quick3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            quick3.ForeColor = Color.FromArgb(22, 89, 143);
            quick3.Location = new Point(0, 70);
            quick3.Margin = new Padding(0, 0, 10, 10);
            quick3.Name = "quick3";
            quick3.Size = new Size(150, 60);
            quick3.TabIndex = 3;
            quick3.Text = "+ Servicio";
            quick3.UseVisualStyleBackColor = false;
            quick3.Click += ActionButton_Click;
            // 
            // quick4
            // 
            quick4.BackColor = Color.FromArgb(231, 245, 252);
            quick4.FlatAppearance.BorderSize = 0;
            quick4.FlatStyle = FlatStyle.Flat;
            quick4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            quick4.ForeColor = Color.FromArgb(22, 89, 143);
            quick4.Location = new Point(160, 70);
            quick4.Margin = new Padding(0, 0, 10, 10);
            quick4.Name = "quick4";
            quick4.Size = new Size(150, 60);
            quick4.TabIndex = 4;
            quick4.Text = "+ Repuesto";
            quick4.UseVisualStyleBackColor = false;
            quick4.Click += ActionButton_Click;
            // 
            // quick5
            // 
            quick5.BackColor = Color.FromArgb(231, 245, 252);
            quick5.FlatAppearance.BorderSize = 0;
            quick5.FlatStyle = FlatStyle.Flat;
            quick5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            quick5.ForeColor = Color.FromArgb(22, 89, 143);
            quick5.Location = new Point(320, 70);
            quick5.Margin = new Padding(0, 0, 10, 10);
            quick5.Name = "quick5";
            quick5.Size = new Size(150, 60);
            quick5.TabIndex = 5;
            quick5.Text = "+ Factura";
            quick5.UseVisualStyleBackColor = false;
            quick5.Click += ActionButton_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1450, 900);
            Controls.Add(workspace);
            Controls.Add(header);
            MinimumSize = new Size(1050, 650);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MecaSoft | Gestión de taller";
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).EndInit();
            navPanel.ResumeLayout(false);
            workspace.ResumeLayout(false);
            workspace.PerformLayout();
            contentCard.ResumeLayout(false);
            contentCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            cardsPanel.ResumeLayout(false);
            card0.ResumeLayout(false);
            card0.PerformLayout();
            card1.ResumeLayout(false);
            card1.PerformLayout();
            card2.ResumeLayout(false);
            card2.PerformLayout();
            card3.ResumeLayout(false);
            card3.PerformLayout();
            card4.ResumeLayout(false);
            card4.PerformLayout();
            card5.ResumeLayout(false);
            card5.PerformLayout();
            welcomePanel.ResumeLayout(false);
            welcomePanel.PerformLayout();
            recentPanel.ResumeLayout(false);
            recentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)recentGrid).EndInit();
            quickPanel.ResumeLayout(false);
            quickPanel.PerformLayout();
            quickActions.ResumeLayout(false);
            ResumeLayout(false);
        }
        private Panel card0;
        private Label cardTitle0;
        private Label cardValue0;
        private Panel card1;
        private Label cardTitle1;
        private Label cardValue1;
        private Panel card2;
        private Label cardTitle2;
        private Label cardValue2;
        private Panel card3;
        private Label cardTitle3;
        private Label cardValue3;
        private Panel card4;
        private Label cardTitle4;
        private Label cardValue4;
        private Panel card5;
        private Label cardTitle5;
        private Label cardValue5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Button quick0;
        private Button quick1;
        private Button quick2;
        private Button quick3;
        private Button quick4;
        private Button quick5;
    }
}


