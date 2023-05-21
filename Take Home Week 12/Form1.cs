using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Take_Home_Week_12
{
    public partial class Form1 : Form
    {
        public static string connection = "server=localhost;uid=root;pwd=pwmy140204;database=premier_league";
        public MySqlConnection sqlConnect;
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public MySqlDataReader sqlReader;
        public string sqlquery;

        DataTable dtnationality = new DataTable();
        DataTable dtteam = new DataTable();
        DataTable dtgv = new DataTable();
        DataTable dtmanager = new DataTable();
        DataTable dtmanagerview = new DataTable();
        DataTable dtplayer = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.Hide();
            panel3.Hide();

            sqlquery = "SELECT n.`nation`, n.`nationality_id` FROM premier_league.nationality n;";
            sqlConnect = new MySqlConnection(connection);
            sqlCommand = new MySqlCommand(sqlquery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtnationality);
            cmb_nat.DataSource = dtnationality;
            cmb_nat.DisplayMember = "nation";
            cmb_nat.ValueMember = "nationality_id";

            sqlquery = "SELECT t.`team_name`, t.`team_id` FROM premier_league.team t;";
            sqlConnect = new MySqlConnection(connection);
            sqlCommand = new MySqlCommand(sqlquery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtteam);
            cmb_tea.DataSource = dtteam;
            cmb_tea.DisplayMember = "team_name";
            cmb_tea.ValueMember = "team_id";

            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;




            sqlquery = "select m.manager_name, m.birthdate, n.nation, convert(m.working, char) as status, m.manager_id as id from manager m, nationality n where m.nationality_id = n.nationality_id and m.working = 0 order by 1;";
            sqlConnect = new MySqlConnection(connection);
            sqlCommand = new MySqlCommand(sqlquery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtmanagerview);
            dataGridView2.DataSource = dtmanagerview;
            dataGridView2.Columns.Remove("id");


            sqlquery = $"select p.player_name, n.nation, p.playing_pos, p.team_number, p.height, p.weight, p.birthdate, p.player_id as id from player p, nationality n, team t where p.team_id = t.team_id and p.nationality_id = n.nationality_id and team_name = '{cmb_teamdelete.Text}' and status = 1;";
            sqlCommand = new MySqlCommand(sqlquery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtplayer);
            dataGridView3.DataSource = dtplayer;
            dataGridView3.Columns.Remove("id");


        }

        private void cmb_tea_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgv.Clear();
            sqlquery = "select p.player_name, p.team_number, n.nation, p.playing_pos, p.height, p.weight, p.birthdate, t.team_name from player p, nationality n, team t where p.nationality_id = n.nationality_id and p.team_id = t.team_id and t.team_name = '" + cmb_tea.Text + "';";
            sqlConnect = new MySqlConnection(connection);
            sqlCommand = new MySqlCommand(sqlquery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtgv);
            dataGridView1.DataSource = dtgv;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string datetimeformat = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            if (string.IsNullOrEmpty(txt_name.Text) || string.IsNullOrEmpty(txt_team.Text) || string.IsNullOrEmpty(txt_position.Text) || string.IsNullOrEmpty(txt_weight.Text) || string.IsNullOrEmpty(txt_height.Text))
            {

                MessageBox.Show("Please fill all the required fields");
            }
            else
            {
                sqlConnect.Open();
                sqlquery = $"select concat('{txt_name.Text.ToUpper()[0]}', lpad((count(player_id) + 1), 3, 0)) from player where player_name like '{txt_name.Text.ToUpper()[0]}%';";
                sqlCommand = new MySqlCommand(sqlquery, sqlConnect);
                string newid = sqlCommand.ExecuteScalar().ToString();

                sqlquery = $"insert into player values('{newid}', {txt_team.Text}, '{txt_name.Text}', '{cmb_nat.SelectedValue}', '{txt_position.Text}', {txt_height.Text} ,{txt_weight.Text} ,'{datetimeformat}','{cmb_tea.SelectedValue}', {1}, {0})";
                sqlCommand = new MySqlCommand(sqlquery, sqlConnect);
                sqlCommand = new MySqlCommand(sqlquery, sqlConnect);
                sqlCommand.ExecuteNonQuery().ToString();
                sqlConnect.Close();

                dtgv.Clear();
                sqlquery = "select p.player_name, p.team_number, n.nation, p.playing_pos, p.height, p.weight, p.birthdate, t.team_name from player p, nationality n, team t where p.nationality_id = n.nationality_id and p.team_id = t.team_id and t.team_name = '" + cmb_tea.Text + "';";
                sqlConnect = new MySqlConnection(connection);
                sqlCommand = new MySqlCommand(sqlquery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtgv);
                dataGridView1.DataSource = dtgv;

            }
        }
        private void txt_team_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txt_height_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txt_weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }


        private void editManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
            panel3.Hide();

            sqlquery = "SELECT t.`team_name`, t.`team_id` FROM premier_league.team t;";
            sqlConnect = new MySqlConnection(connection);
            sqlCommand = new MySqlCommand(sqlquery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtteam);
            cmb_managerteam.DataSource = dtteam;
            cmb_managerteam.DisplayMember = "team_name";
            cmb_managerteam.ValueMember = "team_id";

            




        }

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
        }

        private void cmb_managerteam_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtmanager.Clear();
            sqlquery = "select m.`manager_name`, t.team_name, m.birthdate, n.nation, m.manager_id from manager m, team t, nationality n where m.manager_id = t.manager_id and m.nationality_id = n.nationality_id and t.team_name = '" + cmb_managerteam.Text + "';";
            sqlConnect = new MySqlConnection(connection);
            sqlCommand = new MySqlCommand(sqlquery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtmanager);

            if (dtmanager.Rows.Count != 0)
            {
                lbl_mname.Text = dtmanager.Rows[0][0].ToString();
                lbl_mteam.Text = dtmanager.Rows[0][1].ToString();
                lbl_mbirth.Text = dtmanager.Rows[0][2].ToString().Substring(0, 10);
                lbl_mnat.Text = dtmanager.Rows[0][3].ToString();
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection(connection);
            sqlConnect.Open();
            sqlquery = $"update team set manager_id = '{dtmanagerview.Rows[dataGridView2.CurrentCell.RowIndex][4]}' where team_id = '{cmb_managerteam.SelectedValue}';";
            
            sqlCommand = new MySqlCommand(sqlquery, sqlConnect);
            sqlCommand.ExecuteNonQuery();

            sqlquery = $"update manager set working = 0 where manager_id = '{dtmanager.Rows[0][4]}';";
            sqlCommand = new MySqlCommand(sqlquery, sqlConnect);
            sqlCommand.ExecuteNonQuery();

            sqlquery = $"update manager set working = 1 where manager_id = '{dtmanagerview.Rows[dataGridView2.CurrentCell.RowIndex][4]}';";
            sqlCommand = new MySqlCommand(sqlquery, sqlConnect);
            sqlCommand.ExecuteNonQuery();

            //update label
            dtmanager.Clear();
            sqlquery = "select m.`manager_name`, t.team_name, m.birthdate, n.nation, m.manager_id from manager m, team t, nationality n where m.manager_id = t.manager_id and m.nationality_id = n.nationality_id and t.team_name = '" + cmb_managerteam.Text + "';";
            sqlConnect = new MySqlConnection(connection);
            sqlCommand = new MySqlCommand(sqlquery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtmanager);

            if (dtmanager.Rows.Count != 0)
            {
                lbl_mname.Text = dtmanager.Rows[0][0].ToString();
                lbl_mteam.Text = dtmanager.Rows[0][1].ToString();
                lbl_mbirth.Text = dtmanager.Rows[0][2].ToString().Substring(0, 10);
                lbl_mnat.Text = dtmanager.Rows[0][3].ToString();
            }

            //update dgv
            dtmanagerview.Clear();
            sqlquery = "select m.manager_name, m.birthdate, n.nation, convert(m.working, char) as status, m.manager_id as id from manager m, nationality n where m.nationality_id = n.nationality_id and m.working = 0 order by 1;";
            sqlConnect = new MySqlConnection(connection);
            sqlCommand = new MySqlCommand(sqlquery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtmanagerview);
            dataGridView2.DataSource = dtmanagerview;

            sqlConnect.Close();
        }

        private void deletePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Show();

            

            sqlquery = "SELECT t.`team_name`, t.`team_id` FROM premier_league.team t;";
            sqlConnect = new MySqlConnection(connection);
            sqlCommand = new MySqlCommand(sqlquery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtteam);
            cmb_teamdelete.DataSource = dtteam;
            cmb_teamdelete.DisplayMember = "team_name";
            cmb_teamdelete.ValueMember = "team_id";

           

        }

        private void cmb_teamdelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtplayer.Clear();
            sqlquery = $"select p.player_name, n.nation, p.playing_pos, p.team_number, p.height, p.weight, p.birthdate, p.player_id as id from player p, nationality n, team t where p.team_id = t.team_id and p.nationality_id = n.nationality_id and team_name = '{cmb_teamdelete.Text}' and status = 1;";
            sqlCommand = new MySqlCommand(sqlquery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtplayer);
            dataGridView3.DataSource = dtplayer;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dtplayer.Rows.Count == 11)
            {
                MessageBox.Show("Minimum player reached, can't delete player");
            }
            else
            {
                sqlConnect = new MySqlConnection(connection);
                sqlConnect.Open();
                sqlquery = $"update player set status = 0 where player_id = '{dtplayer.Rows[dataGridView3.CurrentCell.RowIndex][7]}';";
                sqlCommand = new MySqlCommand(sqlquery, sqlConnect);
                sqlCommand.ExecuteNonQuery();

                //update dgv
                dtplayer.Clear();
                sqlquery = $"select p.player_name, n.nation, p.playing_pos, p.team_number, p.height, p.weight, p.birthdate, p.player_id as id from player p, nationality n, team t where p.team_id = t.team_id and p.nationality_id = n.nationality_id and team_name = '{cmb_teamdelete.Text}' and status = 1;";
                sqlCommand = new MySqlCommand(sqlquery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtplayer);
                dataGridView3.DataSource = dtplayer;

                sqlConnect.Close();

            }
           
        }
    }
}
