using EFDay1.Models;
    namespace EFDay1
    {
    public partial class Form1 : Form
    {
        FootballContext db;
        public Form1()
        {
            InitializeComponent();
            new FootballContext();
        }

        private void DGV_Players_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<Player> players = db.Players.ToList();
            DGV_Players.DataSource = players;


            var teamNames = db.Teams.Select(t => t.TeamName).Distinct().ToList();
            cb_team_name.DataSource = teamNames;
            cb_team_name.DisplayMember = "TeamName";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nationality_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (FootballContext db = new FootballContext())
            {

                string playerName = txt_name.Text;
                string position = txt_position.Text;
                string nationality = txt_nationality.Text;
                string teamName = cb_team_name.SelectedItem.ToString();


                Team team = db.Teams.FirstOrDefault(t => t.TeamName == teamName);
                if (team == null)
                {
                    team = new Team { TeamName = teamName };
                    db.Teams.Add(team);
                    db.SaveChanges();
                }


                Player newPlayer = new Player
                {
                    Name = playerName,
                    Position = position,
                    Nationality = nationality,
                    TeamId = team.TeamId
                };


                db.Players.Add(newPlayer);
                db.SaveChanges();


                DGV_Players.DataSource = db.Players.ToList();


                txt_name.Clear();
                txt_position.Clear();
                txt_nationality.Clear();
                cb_team_name.SelectedIndex = -1;
            }

            MessageBox.Show("Player added successfully!");
        }

        private void DGV_Players_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                int playerId = (int)DGV_Players.Rows[e.RowIndex].Cells["Id"].Value;

                using (FootballContext db = new FootballContext())
                {

                    Player selectedPlayer = db.Players.FirstOrDefault(p => p.PlayerId == playerId);

                    if (selectedPlayer != null)
                    {

                        txt_name.Text = selectedPlayer.Name;
                        txt_position.Text = selectedPlayer.Position;
                        txt_nationality.Text = selectedPlayer.Nationality;

                        cb_team_name.SelectedValue = selectedPlayer.TeamId;
                    }
                    else
                    {
                        MessageBox.Show("Player not found.");
                    }
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            if (DGV_Players.SelectedRows.Count > 0)
            {

                int playerId = (int)DGV_Players.SelectedRows[0].Cells["Id"].Value;

                using (FootballContext db = new FootballContext())
                {

                    Player playerToUpdate = db.Players.FirstOrDefault(p => p.PlayerId == playerId);

                    if (playerToUpdate != null)
                    {

                        playerToUpdate.Name = txt_name.Text;
                        playerToUpdate.Position = txt_position.Text;
                        playerToUpdate.Nationality = txt_nationality.Text;


                        string teamName = cb_team_name.SelectedItem.ToString();
                        Team team = db.Teams.FirstOrDefault(t => t.TeamName == teamName);


                        if (team == null)
                        {
                            team = new Team { TeamName = teamName };
                            db.Teams.Add(team);
                            db.SaveChanges();
                        }

                        playerToUpdate.TeamId = team.TeamId;

                        db.SaveChanges();


                        DGV_Players.DataSource = db.Players.ToList();

                        MessageBox.Show("Player updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Player not found.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a player to update.");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
          
            if (DGV_Players.SelectedRows.Count > 0)
            {
                
                int playerId = (int)DGV_Players.SelectedRows[0].Cells["Id"].Value; 

                using (FootballContext db = new FootballContext())
                {
                    
                    Player playerToDelete = db.Players.FirstOrDefault(p => p.PlayerId == playerId);

                    if (playerToDelete != null)
                    {
                       
                        var result = MessageBox.Show("Are you sure you want to delete this player?", "Confirm Deletion", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                          
                            db.Players.Remove(playerToDelete);
                            db.SaveChanges(); 

                            
                            DGV_Players.DataSource = db.Players.ToList();

                            MessageBox.Show("Player deleted successfully!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Player not found.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a player to delete.");
            }
        }

    }
}
