using System;
using System.Drawing;
using System.Windows.Forms;

namespace Facebook_Clone_C_
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            BackColor = ColorTranslator.FromHtml("#F2F3F5");
            Icon = new Icon("facebook.ico");
            
            MaximizeBox = false; // Desabilita o botão de maximizar
            FormBorderStyle = FormBorderStyle.FixedDialog; // Impede redimensionamento com o mouse
        }

        void MainFormLoad(object sender, EventArgs e)
        {
            // Réplica de uma navbar
        	Panel container = new Panel();
            container.Parent = this;
            container.BackColor = ColorTranslator.FromHtml("#4267B2");
            container.Size = new Size(780, 50);

            // Logo da Navbar
            Label title = new Label();
            title.Text = "facebook";
            title.ForeColor = Color.White;
            title.Font = new Font("Segoe UI", 20f, FontStyle.Bold);
            title.AutoSize = true;
            title.Location = new Point(10, 3);
            
            // Perfil Logado
            Label profileName = new Label();
            profileName.Text = "▼ Mark Zuckerberg";
            profileName.BackColor = ColorTranslator.FromHtml("#4267B2");
            profileName.ForeColor = Color.White;
            profileName.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            profileName.AutoSize = true;
            profileName.Location = new Point(550, 15);
            
            // Miniatura da foto do perfil logado
            PictureBox miniProfile_picture = new PictureBox();
            miniProfile_picture.Image = Image.FromFile("profile.jpeg");
            miniProfile_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            miniProfile_picture.BorderStyle = BorderStyle.FixedSingle;
           	miniProfile_picture.Size = new Size(30, 30);
            miniProfile_picture.BackColor = Color.White;
            miniProfile_picture.Location = new Point(695, 12);
            miniProfile_picture.Padding = new Padding(1);	

            // "Adicionando" os itens na Navbar.
            container.Controls.Add(title);
            container.Controls.Add(profileName);
            container.Controls.Add(miniProfile_picture);
            miniProfile_picture.BringToFront();
            profileName.BringToFront();
            title.BringToFront();

            // Caixa de Texto, representando um "buscador" de perfis
            TextBox search = new TextBox();
            search.Text = "Search";
            search.ForeColor = Color.LightGray;
            search.Font = new Font("Arial", 8f, FontStyle.Regular);
            search.Size = new Size(250, 20);
            search.Location = new Point(240, 15);

            // Configuração da lupa na TextBox
            PictureBox searchIcon = new PictureBox();
            searchIcon.Image = Image.FromFile("lupa.png");
            searchIcon.SizeMode = PictureBoxSizeMode.Zoom;
            searchIcon.BackColor = Color.White;
            searchIcon.Size = new Size(10, 10);
            searchIcon.Location = new Point(search.Location.X + search.Width - searchIcon.Width - 5, search.Location.Y + (search.Height - searchIcon.Height) / 2);

            // "Adicionando" itens na TextBox
            container.Controls.Add(search);
            container.Controls.Add(searchIcon);
            search.BringToFront();
            searchIcon.BringToFront();

            search.Select(0, 0); // Não selecionar o texto ao iniciar o Software
            search.ReadOnly = true; // Texto fixo

            // Papel de parede do perfil
            PictureBox wallpaper = new PictureBox();
            wallpaper.Image = Image.FromFile("wallpaper.jpg");
            wallpaper.SizeMode = PictureBoxSizeMode.StretchImage;
            wallpaper.Size = new Size(600, 250);
            wallpaper.Top = 30;
            wallpaper.Left = 10;
            this.Controls.Add(wallpaper);

            // Foto de Perfil
            PictureBox profilePicture = new PictureBox();
            profilePicture.Image = Image.FromFile("profile.jpeg");
            profilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            profilePicture.BorderStyle = BorderStyle.FixedSingle;
            profilePicture.Size = new Size(140, 150);
            profilePicture.BackColor = Color.White;
            profilePicture.Padding = new Padding(5);
            profilePicture.Top = 170;
            profilePicture.Left = 30;

            this.Controls.Add(profilePicture);
            profilePicture.BringToFront(); // Colocando a foto de perfil na "frente" do papel de parede.

            // Configurando a Label do nome do usuário
            Label name = new Label();
            name.Text = "Mark Zuckerberg";
            name.BackColor = Color.White;
            name.ForeColor = ColorTranslator.FromHtml("#4267B2");
            name.Font = new Font("Segoe UI", 14f, FontStyle.Bold);
            name.AutoSize = true;
            name.Top = 285;
            name.Left = 180;
            this.Controls.Add(name);
            name.BringToFront();
            
            //  Configurando a Label da Profissão do usuário
            Label occupation = new Label();
            occupation.Text = "• CEO and Founder of Facebook";
            occupation.BackColor = Color.White;
            occupation.ForeColor = ColorTranslator.FromHtml("#4267B2");
            occupation.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
            occupation.AutoSize = true;
            occupation.Top = 310;
            occupation.Left = 180;
            this.Controls.Add(occupation);
            occupation.BringToFront();
            
            // Configuração do botão de "Editar Perfil"
            Button edit = new Button();
            edit.Text = "Update Info";
            edit.BackColor = ColorTranslator.FromHtml("#F2F3F5");
            edit.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            edit.Top = 295;
            edit.Left = 490;
            edit.AutoSize = true;
            this.Controls.Add(edit);
            edit.BringToFront();            

            // Fundo branco
            Panel whitePanel = new Panel();
            whitePanel.BackColor = Color.White;
            whitePanel.Size = new Size(600, 500);
            whitePanel.Top = 200;
            whitePanel.Left = 10;
            this.Controls.Add(whitePanel);
			
			// "Contêiner" com a lista de jogos.
            Panel games_container = new Panel();
			games_container.BackColor = Color.White;
			games_container.Size = new Size(120, 250);
			games_container.Top = 70;
			games_container.Left = 630;
			this.Controls.Add(games_container);
			
			// Configuração da Label "Games..."
			Label games_list = new Label();
            games_list.Text = "Games(2)...▼";
            games_list.BackColor = Color.White;
            games_list.ForeColor = ColorTranslator.FromHtml("#4267B2");
            games_list.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            games_list.AutoSize = true;
            games_list.Top = 80;
            games_list.Left = 643;
            this.Controls.Add(games_list);
            games_list.BringToFront();
			
			// Ícone do primeiro jogo
            PictureBox angry_birds = new PictureBox();
			angry_birds.Image = Image.FromFile("friendsAngry.png");
			angry_birds.SizeMode = PictureBoxSizeMode.StretchImage;
			angry_birds.Size = new Size(60, 60);
			angry_birds.BackColor = Color.White;
			angry_birds.Top = 110;
			angry_birds.Left = 660;
			this.Controls.Add(angry_birds);
			
			// Nome do primeiro jogo
			Label games_name1 = new Label();
            games_name1.Text = "Angry Birds: Friends";
            games_name1.BackColor = Color.White;
            games_name1.ForeColor = ColorTranslator.FromHtml("#4267B2");
            games_name1.Font = new Font("Segoe UI", 8f, FontStyle.Regular);
            games_name1.AutoSize = true;
            games_name1.Top = 170;
            games_name1.Left = 635;
            this.Controls.Add(games_name1);
            games_name1.BringToFront();		
			angry_birds.BringToFront();
			
			// Ícone do Segundo Jogo
			PictureBox dragon_city = new PictureBox();
			dragon_city.Image = Image.FromFile("dragon_city.jpeg");
			dragon_city.SizeMode = PictureBoxSizeMode.StretchImage;
			dragon_city.Size = new Size(60, 60);
			dragon_city.BackColor = Color.White;
			dragon_city.Top = 200;
			dragon_city.Left = 660;
			this.Controls.Add(dragon_city);
			dragon_city.BringToFront();
			
			// Nome do segundo jogo
			Label games_name2 = new Label();
            games_name2.Text = "Dragon City";
            games_name2.BackColor = Color.White;
            games_name2.ForeColor = ColorTranslator.FromHtml("#4267B2");
            games_name2.Font = new Font("Segoe UI", 8f, FontStyle.Regular);
            games_name2.AutoSize = true;
            games_name2.Top = 260;
            games_name2.Left = 655;
            this.Controls.Add(games_name2);
            games_name2.BringToFront();			
		}
    }
}
