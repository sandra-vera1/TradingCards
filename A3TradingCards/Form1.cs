using System.ComponentModel;
using System.Data;
using System.Numerics;

namespace A3TradingCards
{
    public partial class Form1 : Form
    {
        private int x = 0;
        Rectangle updateRectangle = new Rectangle(0, 275, 800, 100);
        List<Player> playerList = Data.GetPlayers();
        List<Team> teamList = Data.GetTeams(Data.GetPlayers());
        public Form1()
        {
            InitializeComponent();
            LoadPlayers();
            this.Width = 1125;
            this.Height = 1080;
            dataGridViewPlayers.SelectionChanged += dataGridViewPlayers_SelectionChanged;
            foreach (var team in teamList)
            {
                listBoxTeams.Items.Add(team);
            }
        }


        private void LoadPlayers()
        {
            var results = playerList.Join(teamList, e => e.TeamId, d => d.Id,
                (player, team) => new
                {
                    Id = player.Id,
                    FullName = player.FullName,
                    Photo = player.Photo,
                    DOB = player.DOB.ToString("yyyy-MM-dd"),
                    Skills = player.Skills,
                    Nationality = player.Nationality,
                    GrandTourAppearances = player.GrandTourAppearances,
                    TeamName = team.Name
                }).OrderBy(o => o.FullName);


            dataGridViewPlayers.ColumnCount = 8;
            dataGridViewPlayers.Columns[0].Name = "Id";
            dataGridViewPlayers.Columns[1].Name = "Full Name";
            dataGridViewPlayers.Columns[2].Name = "Photo";
            dataGridViewPlayers.Columns[3].Name = "Date of Birth";
            dataGridViewPlayers.Columns[4].Name = "Skills";
            dataGridViewPlayers.Columns[5].Name = "Nationality";
            dataGridViewPlayers.Columns[6].Name = "Grand Tour Appearances";
            dataGridViewPlayers.Columns[7].Name = "Team Name";
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn()
            {
                Name = "Photo",
                Width = 100,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dataGridViewPlayers.Columns.Add(imageColumn);

            dataGridViewPlayers.Columns[2].Visible = false;
            dataGridViewPlayers.Columns[0].Visible = false;
            dataGridViewPlayers.Columns["Full Name"].Width = 150;
            dataGridViewPlayers.Columns["Date of Birth"].Width = 100;
            dataGridViewPlayers.Columns["Skills"].Width = 200;
            dataGridViewPlayers.Columns["Nationality"].Width = 100;
            dataGridViewPlayers.Columns["Grand Tour Appearances"].Width = 100;
            dataGridViewPlayers.Columns["Team Name"].Width = 150;

            foreach (var player in results)
            {
                dataGridViewPlayers.Rows.Add(
                    player.Id,
                    player.FullName,
                    player.Photo,
                    player.DOB,
                    player.Skills,
                    player.Nationality,
                    player.GrandTourAppearances,
                    player.TeamName,
                    player.Photo
                 );
            }

            // handle image columns with special formatting
            dataGridViewPlayers.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewPlayers.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
        Graphics g;
        protected override void OnPaint(PaintEventArgs e)
        {
            g = e.Graphics;

            //Font Title
            Font font = new Font("Arial", 16, FontStyle.Bold);
            g.DrawString("Welcome to Cycling cards collection", font, Brushes.Black, new PointF(300, 15));

        }
        private Player GetPlayerFromGrid()
        {

            if (dataGridViewPlayers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewPlayers.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value.ToString());
                string Name = selectedRow.Cells["Full Name"].Value.ToString();
                DateTime DOB = DateTime.Parse(selectedRow.Cells["Date of Birth"].Value.ToString());
                string Skills = selectedRow.Cells["Skills"].Value.ToString();
                string Nationality = selectedRow.Cells["Nationality"].Value.ToString();
                string GrandTourAppearances = selectedRow.Cells["Grand Tour Appearances"].Value.ToString();
                string TeamName = selectedRow.Cells["Team Name"].Value.ToString();
                return new Player
                {
                    Id = id,
                    FullName = Name,
                    DOB = DOB,
                    Skills = Skills,
                    Nationality = Nationality,
                    GrandTourAppearances = GrandTourAppearances,
                    TeamId = teamList.First(t => t.Name == TeamName).Id,
                    imageId = playerList.First(p => p.Id == id).imageId
                };



            }
            else
            {
                return null;
            }
        }

        private void AfterSelection()
        {
            Player player = GetPlayerFromGrid();
            if (player != null)
            {
                string imageId = player.imageId;
                textBox_Name.Text = player.FullName;
                dateTimePickerDOB.Value = player.DOB;
                textBoxSkills.Text = player.Skills;
                textBoxNationality.Text = player.Nationality;
                textBoxGTAppearances.Text = player.GrandTourAppearances;
                string TeamName = teamList.First(t => t.Id == player.TeamId).Name;
                listBoxTeams.SelectedIndex = listBoxTeams.FindStringExact(TeamName);
                ReloadPhoto(imageId);

                if (teamList.First(t => t.Id == player.TeamId).Name == "Astana")
                {
                    panel1.BackColor = Color.Gray;

                }
                else if (teamList.First(t => t.Id == player.TeamId).Name == "Israel-Premier Tech")
                {
                    panel1.BackColor = Color.CadetBlue;
                }
                else if (teamList.First(t => t.Id == player.TeamId).Name == "Dimension Data")
                {
                    panel1.BackColor = Color.GreenYellow;
                }
                else if (teamList.First(t => t.Id == player.TeamId).Name == "Jumbo-Visma")
                {
                    panel1.BackColor = Color.Crimson;
                }

                
                int Participation = int.Parse(player.GrandTourAppearances.Substring(0,2));
                if (Participation >= 14)
                {
                    panel2.BackColor = Color.Gold;

                }
                else
                {
                    panel2.BackColor = Color.MediumSpringGreen;
                }



            }
        }

        //Event to be able to click one register from the grid en pass the inf to the text box to update inf
        private void dataGridViewPlayers_SelectionChanged(object sender, EventArgs e)
        {
            AfterSelection();
        }

        private void ReloadPhoto(string ImageId)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            string imagePath = $"photos/{ImageId}.jpg";
            this.Controls.Add(pictureBox1);
            pictureBox1.Image = Image.FromFile(imagePath);
        }

        private void UploadPhoto(object sender, EventArgs e)
        {
            // Create and configure the OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg"; // Allow common image file formats
            openFileDialog.Title = "Select a Photo";

            // Show the dialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load the selected image into the PictureBox
                    string filePath = openFileDialog.FileName;
                    pictureBox1.Image = new Bitmap(filePath);  // pictureBox1 is the PictureBox control
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        private string ValidateFields()
        {
            if (string.IsNullOrEmpty(textBox_Name.Text))
            {
                return "The name is required";
            }
            if (string.IsNullOrEmpty(textBoxSkills.Text))
            {
                return "The skills are required";
            }
            if (string.IsNullOrEmpty(textBoxNationality.Text))
            {
                return "The nationality is required";
            }
            if (string.IsNullOrEmpty(textBoxGTAppearances.Text))
            {
                return "The appearances are required";
            }
            if (((A3TradingCards.Team)listBoxTeams.SelectedItem) == null)
            {
                return "Team is required";
            }
            if (pictureBox1.Image == null)
            {
                return "No image to save.";
            }
            return "";
        }

        private void SaveNewPlayer(object sender, EventArgs e)
        {
            string errorVal = ValidateFields();
            if (!string.IsNullOrEmpty(errorVal))
            {
                MessageBox.Show(errorVal);
            }
            else
            {
                string currentTime = DateTime.Now.Ticks.ToString();
                int Id = playerList.Count + 1;
                string teamName = ((A3TradingCards.Team)listBoxTeams.SelectedItem).Name;
                Player player = new Player
                {
                    Id = Id,
                    FullName = textBox_Name.Text,
                    DOB = dateTimePickerDOB.Value,
                    Skills = textBoxSkills.Text,
                    Nationality = textBoxNationality.Text,
                    GrandTourAppearances = textBoxGTAppearances.Text,
                    imageId = currentTime,
                    TeamId = teamList.First(t => t.Name == teamName).Id
                };
                playerList.Add(player);

                // Get the project's directory path (the root of your project)
                string projectDirectory = Directory.GetParent(Application.StartupPath).Parent.FullName;

                // Define the folder where we want to save the image (e.g., "Images")
                string imagesFolder = "photos/";
                string savePath = Path.Combine(imagesFolder, $"{currentTime}.jpg");
                pictureBox1.Image.Save(savePath, System.Drawing.Imaging.ImageFormat.Jpeg);

                dataGridViewPlayers.Rows.Add(
                    player.Id,
                    player.FullName,
                    player.Photo,
                    player.DOB.ToString("yyyy-MM-dd"),
                    player.Skills,
                    player.Nationality,
                    player.GrandTourAppearances,
                    teamName,
                    System.Drawing.Image.FromFile($"photos/{currentTime}.jpg")
                    );

                dataGridViewPlayers.Sort(dataGridViewPlayers.Columns["Full Name"], ListSortDirection.Ascending);
            }
        }

        private void UpdatePlayer(object sender, EventArgs e)
        {
            if (dataGridViewPlayers.SelectedRows.Count > 0)
            {
                string errorVal = ValidateFields();
                if (!string.IsNullOrEmpty(errorVal))
                {
                    MessageBox.Show(errorVal);
                    return;
                }
                string currentTime = DateTime.Now.Ticks.ToString();
                DataGridViewRow selectedRow = dataGridViewPlayers.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value.ToString());
                string teamName = ((A3TradingCards.Team)listBoxTeams.SelectedItem).Name;
                Player updatedPlayer = new Player
                {
                    Id = id,
                    FullName = textBox_Name.Text,
                    DOB = dateTimePickerDOB.Value,
                    Skills = textBoxSkills.Text,
                    Nationality = textBoxNationality.Text,
                    GrandTourAppearances = textBoxGTAppearances.Text
                };
                //update image on player list
                playerList.Find(p => p.Id == id).imageId = currentTime;
                // Get the project's directory path (the root of your project)
                string projectDirectory = Directory.GetParent(Application.StartupPath).Parent.FullName;
                string imagesFolder = "photos/";
                string savePath = Path.Combine(imagesFolder, $"{currentTime}.jpg");
                pictureBox1.Image.Save(savePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                ReloadPhoto($"{currentTime}");

                selectedRow.Cells["Id"].Value = id;
                selectedRow.Cells["Full Name"].Value = updatedPlayer.FullName;
                selectedRow.Cells["Date of Birth"].Value = updatedPlayer.DOB;
                selectedRow.Cells["Skills"].Value = updatedPlayer.Skills;
                selectedRow.Cells["Nationality"].Value = updatedPlayer.Nationality;
                selectedRow.Cells["Grand Tour Appearances"].Value = updatedPlayer.GrandTourAppearances;
                selectedRow.Cells["Team Name"].Value = teamName;

                selectedRow.Cells[8].Value = System.Drawing.Image.FromFile($"photos/{currentTime}.jpg");
            }
            else
            {
                MessageBox.Show("No player selected.");
            }
            AfterSelection();
        }


        private void DeletePlayer(object sender, EventArgs e)
        {
            if (dataGridViewPlayers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewPlayers.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value.ToString());
                playerList.Remove(playerList.Find(p => p.Id == id));
                dataGridViewPlayers.Rows.RemoveAt(selectedRow.Index);
                //reset data after delete
                textBox_Name.Text = "";
                dateTimePickerDOB.Value = DateTime.Now;
                textBoxSkills.Text = "";
                textBoxNationality.Text = "";
                textBoxGTAppearances.Text = "";
                listBoxTeams.SelectedIndex = -1;
                pictureBox1.Image = null;
                panel1.BackColor = Color.Tan;
                panel2.BackColor = Color.Tan;
            }
            else
            {
                MessageBox.Show("No player selected.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox_Name.Text = "";
            dateTimePickerDOB.Value = DateTime.Now;
            textBoxSkills.Text = "";
            textBoxNationality.Text = "";
            textBoxGTAppearances.Text = "";
            listBoxTeams.SelectedIndex = -1;
            pictureBox1.Image = null;
            panel1.BackColor = Color.Tan;
            panel2.BackColor = Color.Tan;
            dataGridViewPlayers.ClearSelection();
        }
    }
}
