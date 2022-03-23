using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DBMigrateESFinal
{

    public partial class Form1 : Form
    {
        string MysqlDatacn;
        int charcount = 0;
        int steamcount = 0;
        int rpcontador = 0;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          MysqlDatacn = "Datasource=" + textIp.Text + " ;port=" + textPort.Text + " ;username= " + textUser.Text + " ;password=" + textPW.Text + " ;database=" + textDB.Text + ";SslMode=none; Max Pool Size=500; Connection Lifetime =580000";

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button2.Visible = false;
            lblFuck.Visible = true;
            actualizoDBs();
        }
        private void actualizoDBs()
        {
            labelRead.Text = "connecting db...";
            labelWrite.Text = "connecting db...";
            Task.Factory.StartNew(() =>
            {
                int contador = 0;

                try
                {
                    MySqlConnection connection = new MySqlConnection(MysqlDatacn);
                    string selectQuery = "SELECT * FROM " + textDB.Text + ".owned_vehicles ";
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(selectQuery, connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        String owner = (reader.GetString("owner"));
                        
                        String RockstarID = GetRockstarID(owner);
                        System.Threading.Thread.Sleep(50);
                        if (owner.Contains("Char"))
                        {
                            CharLbl.Text = owner;
                            UpdateCarSteam(RockstarID);
                        }
                        else if (owner.Contains("steam"))
                        {
                            CharLbl.Text = "steam" + owner;
                            UpdateCar(RockstarID, owner);
                        }


                        contador = contador + 1;
                        labelCont.Text = contador.ToString();
                        String plates = (reader.GetString("plate").ToUpper());
                        labelPat.Text = plates;
                       
                    }

                    connection.Close();
                    connection.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error 999 " +ex.Message);
                }
            }).ContinueWith(taskState =>
            {
                //nada
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private string GetRockstarID(String license)
        {
            
            String licFinal = license;
            try
            {
                MySqlConnection connection = new MySqlConnection(MysqlDatacn);
                string selectQuery = "SELECT * FROM " + textDB.Text + ".users WHERE identifier='" + license.ToString().ToLower() + "'";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    String lic = (reader.GetString("license").ToUpper());
                    labelWrite.Text = lic.ToString().Replace("Char1:", "");
                    String newchar = lic.ToString().Replace("LICENSE", "Char1");
                    licFinal = newchar;

                }

                connection.Close();
                connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR 1: "+ex.Message);
                String a = "ERROR";
                return a;
            }

      
            return licFinal;
        }
        private void UpdateCar(String license, String steamid)
        {
            steamcount = steamcount+1;
            STText.Text = steamcount.ToString();
            try
            {
                MySqlConnection connection2 = new MySqlConnection(MysqlDatacn);
                connection2.Open();
                string selectQuery5 = "UPDATE owned_vehicles SET owner='"+ license + "' where owner='" + steamid + "' ";
                LblReemplazo.Text = steamid;
               MySqlCommand command5 = new MySqlCommand(selectQuery5, connection2);
                MySqlDataReader reader5 = command5.ExecuteReader();
                connection2.Close();
                connection2.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR 2: "+ex.Message);
            }
        }
        private void UpdateCarSteam( String steamid)
        {
            try
            {
                
               charcount = charcount + 1;
                CHText.Text = charcount.ToString();
                String RockstarLicenses = "error";
                String newsteamid = steamid.ToString().Replace("Char1", "Char1");
                newsteamid = steamid.ToString().Replace("Char2", "steam");
                newsteamid = steamid.ToString().Replace("Char3", "steam");
                newsteamid = steamid.ToString().Replace("Char4", "steam");
                newsteamid = steamid.ToString().Replace("Char5", "steam");
          
                String license = getrockstarChar(newsteamid);
      

                MySqlConnection connection2 = new MySqlConnection(MysqlDatacn);
                connection2.Open();
                string selectQuery5 = "UPDATE owned_vehicles SET owner='" + license + "' where owner='" + steamid + "' ";
                LblReemplazo.Text = steamid;
                MySqlCommand command5 = new MySqlCommand(selectQuery5, connection2);
                MySqlDataReader reader5 = command5.ExecuteReader();
                connection2.Close();
                connection2.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR 7: " + ex.Message);
            }
        }


        private String getrockstarChar(String charid)
        {
            String licFinal = charid;
            try
            {
              
                MySqlConnection connection = new MySqlConnection(MysqlDatacn);
                string selectQuery = "SELECT * FROM " + textDB.Text + ".users WHERE identifier='" + charid.ToString().ToLower() + "'";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    String lic = (reader.GetString("license").ToUpper());
                    labelWrite.Text = lic.ToString().Replace("Char1:", "");
                    String newchar = lic.ToString().Replace("LICENSE", "Char1");
                    licFinal = newchar;

                }

                connection.Close();
                connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR 1: " + ex.Message);
                String  d = "ERROR";
                return d;
            }

            return licFinal;
        }



        private void TextUser_TextChanged(object sender, EventArgs e)
        {
            MysqlDatacn = "Datasource=" + textIp.Text + " ;port=" + textPort.Text + " ;username= " + textUser.Text + " ;password=" + textPW.Text + " ;database=" + textDB.Text + ";SslMode=none; Max Pool Size=500; Connection Lifetime =580000";

        }

        private void CharLbl_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
          


            try
            {
                MessageBox.Show("Executing Repair DB Please Wait..");
               MySqlConnection connection = new MySqlConnection(MysqlDatacn);
                string selectQuery = "SELECT * FROM " + textDB.Text + ".owned_vehicles ";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    //timer
                    System.Threading.Thread.Sleep(50);
                    String owner = (reader.GetString("owner"));
                 
                    if (owner.Contains("Char"))
                    {

                        rpcontador = rpcontador + 1;
                        RepairDB(owner);
                        txtCount.Text = rpcontador.ToString();

                    }


                }

                connection.Close();
                connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void RepairDB(String steamid)
        {
            try
            {
               
                String RockstarLicenses = "error";
                //String newsteamid = steamid.ToString().Replace("Char1", "steam");
                String licenses = "error";
                //String license = getrockstarChar(newsteamid);
                licenses= steamid.ToString().Replace("Char1", "steam");

                MySqlConnection connection2 = new MySqlConnection(MysqlDatacn);
                connection2.Open();
                //cambiar para empezar inactivos
              //  MessageBox.Show("Replace7: " + steamid + " REEMPLAZADO: " + licenses);
                string selectQuery5 = "UPDATE owned_vehicles SET owner='" + licenses + "' where owner='" + steamid + "' ";
                LblReemplazo.Text = steamid;
                MySqlCommand command5 = new MySqlCommand(selectQuery5, connection2);
                MySqlDataReader reader5 = command5.ExecuteReader();
                connection2.Close();
                //connection2.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR 7: " + ex.Message);
            }

            
           
        }

        private void RpCont_Click(object sender, EventArgs e)
        {

        }

        private void TextIp_TextChanged(object sender, EventArgs e)
        {
            MysqlDatacn = "Datasource=" + textIp.Text + " ;port=" + textPort.Text + " ;username= " + textUser.Text + " ;password=" + textPW.Text + " ;database=" + textDB.Text + ";SslMode=none; Max Pool Size=500; Connection Lifetime =580000";

        }

        private void TextDB_TextChanged(object sender, EventArgs e)
        {
            MysqlDatacn = "Datasource=" + textIp.Text + " ;port=" + textPort.Text + " ;username= " + textUser.Text + " ;password=" + textPW.Text + " ;database=" + textDB.Text + ";SslMode=none; Max Pool Size=500; Connection Lifetime =580000";

        }

        private void TextPort_TextChanged(object sender, EventArgs e)
        {
            MysqlDatacn = "Datasource=" + textIp.Text + " ;port=" + textPort.Text + " ;username= " + textUser.Text + " ;password=" + textPW.Text + " ;database=" + textDB.Text + ";SslMode=none; Max Pool Size=500; Connection Lifetime =580000";

        }

        private void TextPW_TextChanged(object sender, EventArgs e)
        {
            MysqlDatacn = "Datasource=" + textIp.Text + " ;port=" + textPort.Text + " ;username= " + textUser.Text + " ;password=" + textPW.Text + " ;database=" + textDB.Text + ";SslMode=none; Max Pool Size=500; Connection Lifetime =580000";

        }

        private void TxtCount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
