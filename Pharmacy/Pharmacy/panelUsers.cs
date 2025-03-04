using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class panelUsers : UserControl
    {
       
      
        public panelUsers()
        {
            InitializeComponent();
            //loadUsers();
            dgUsers.Rows.Clear();
            //loadProducts();
            comboBoxSorting.SelectedIndex = 0;
            checkBoxSorting.Checked = true;
            loadAndDisplayUsers();
            adjustDGHeight();
            
        }

        private void loadAndDisplayUsers()
        {
            try
            {
                displayUsers(new PharmacyDB().Users.ToList());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Users: " + ex.Message);

            }
        }
        public void setSerbian()
        {
            lblUsersHeader.Text = "Korisnici";
            lblSorting.Text = "Sortiranje";
            lblSearch.Text = "Pretraga";
            btnNewUser.Text = "Novi korisnik";
            List<string> columns = new List<string> {"Šifra", "Korisničko ime", "Ime", "Prezime", "JMBG", "Uloga" };
            List<string> items = new List<string> { "Šifra","Korisničko ime", "Ime", "Prezime", "Uloga" };

            int i = 0;
            foreach(var element in columns)
            {
                dgUsers.Columns[i++].HeaderText = element;
            }
            i = 0;
            foreach(var element in items)
            {
                comboBoxSorting.Items[i++] = element;
            }
        }


        public void setEnglish()
        {

            lblUsersHeader.Text = "Users";
            lblSorting.Text = "Sort by";
            lblSearch.Text = "Search";
            btnNewUser.Text = "New user";

            List<string> columns = new List<string> { "ID","Username", "First name", "Last name", "PID", "Role" };
            List<string> items = new List<string> { "ID","Username", "First name", "Last name", "Role" };

            int i = 0;
            foreach (var element in columns)
            {
                dgUsers.Columns[i++].HeaderText = element;
            }
            i = 0;
            foreach (var element in items)
            {
                comboBoxSorting.Items[i++] = element;
            }
        }

        public void setTheme(Theme theme)
        {
            panelUsersHeader.BackColor = panelUsersFooter.BackColor = theme.headerFooterColor;
            BackColor = theme.backColor;
            lblUsersHeader.ForeColor = theme.foreColorMain; 
            lblSorting.ForeColor = lblSearch.ForeColor = btnNewUser.ForeColor= theme.foreColorText;
            lblSorting.Font = lblSearch.Font = btnNewUser.Font = new Font(theme.font, 11);
        }
        private void adjustDGHeight()
        {
            int rowsHeight = dgUsers.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
            int headerHeight = dgUsers.ColumnHeadersHeight;
            dgUsers.Height = rowsHeight + headerHeight + 2;
        }

        public void loadUsers()
        {
            try
            {
                using (var context = new PharmacyDB())
                {
                    User[] users = context.Users.ToArray();
                    foreach (User user in users)
                    {
                        string role = (user.UserRole == (byte)0) ? "farmaceut" : "admin";
                        int r = dgUsers.Rows.Add(user.UserId, user.Username, user.FirstName, user.LastName, user.PID, role);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Load users:" + ex.Message);
            }
        }


        private void displayUsers(List<User> users)
        {
            dgUsers.Rows.Clear();

            try
            {
                using (var context = new PharmacyDB())
                {
                    foreach (User user in users)
                    {
                        if (user.IsDeleted == 0)
                        {
                            byte roleByte = (byte)context.Users.Where(u => u.UserId == user.UserId).FirstOrDefault().UserRole;
                            string role = (roleByte == 0) ? "farmaceut" : "admin";
                            int r = dgUsers.Rows.Add(user.UserId, user.Username, user.FirstName, user.LastName, user.PID, role);
                        }
                    }
                    adjustDGHeight();
                    dgUsers.Refresh();
                    dgUsers.Show();

                }
            }catch(Exception ex)
            {
                Console.WriteLine("Users.. " + ex.Message);
            }
        }


        public void setTitleUsersColor(Color color)
        {
            lblUsersHeader.ForeColor = color;
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            new NewUserForm().Show();

            //var tm=new PharmacyDB().Users.ElementAt(1);
            //dgUsers.Rows.Add(tm.Username, tm.FirstName, tm.LastName, tm.PID, tm.UserId);
        }

        public void setPanelColors(Color headerFooterColor,Color backColor)
        {
            panelUsersHeader.BackColor = panelUsersFooter.BackColor = headerFooterColor;
            this.BackColor = backColor;
            
        }

        public void setPanelFont(FontFamily font)
        {
            lblUsersHeader.Font = new Font(font, (float)Convert.ToInt32(lblUsersHeader.Font.Size));
            lblSorting.Font= new Font(font, (float)Convert.ToInt32(lblSorting.Font.Size));
            lblSearch.Font= new Font(font, (float)Convert.ToInt32(lblSearch.Font.Size));
            btnNewUser.Font= new Font(font, (float)Convert.ToInt32(btnNewUser.Font.Size));
        }

        private void setPanelProperties(Color headerFooterColor, Color backColor,FontFamily font)
        {
            setPanelColors(headerFooterColor, backColor);
            setPanelFont(font);
        }


        
        public void setUsers(User[] users)
        {
            dgUsers.Rows.Add(users);
        }
        public void addUser(User user)
        {
            dgUsers.Rows.Add(user.Username, user.FirstName, user.LastName, user.PID, user.AddressId);
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string[] rowData = { "korisnik1", "Ivanka", "Jovanic", "03032236", "farmaceut" };
            dgUsers.Rows.Add(rowData);
            
        }

       
       private void dgUsers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
       {
            int row = e.RowIndex;
            int column = e.ColumnIndex;
            string username = dgUsers.Rows[row].Cells[0].Value.ToString();
            try
               {
                 using (var context = new PharmacyDB())
                 {
                    var user = context.Users.Where(u => u.Username == username).FirstOrDefault();
                    var userForm = new NewUserForm();
                    userForm.setUserData(user);
                    userForm.Show();
                 }
               }
               catch (Exception ex)
               {
                 Console.WriteLine("Update user:" + ex.Message);
               }


            }


        private void searchUsers()
        {
            string keyword = tbSearch.Text.Trim();
            try
            {
                using (var context = new PharmacyDB())
                {
                    var users = context.Users.ToArray();
                    dgUsers.Dispose();
                    foreach (var user in users)
                    {
                        string role = (user.UserRole == (byte)0) ? "farmaceut" : "admin";
                        if (user.Username.Contains(keyword) || user.FirstName.Contains(keyword) || user.LastName.Contains(keyword) || user.PID.Contains(keyword) || role.Contains(keyword))
                        {
                            dgUsers.Rows.Add(user.Username, user.FirstName, user.LastName, user.PID, user.UserRole);
                        }
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Search " + ex.Message);
            }
        }


        
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var context = new PharmacyDB())
                {
                    var users = context.Users.ToArray();
                    var words = tbSearch.Text.Trim().ToLower().Split(' ').ToList();
                    int count = words.Count;

                    foreach (DataGridViewRow row in dgUsers.Rows)
                    {
                        List<int> indexes = new List<int>();

                        foreach (string word in words)
                        {
                            for (int i = 0; i < row.Cells.Count; i++)
                            {
                                DataGridViewCell cell = row.Cells[i];

                                if (cell.Value != null && cell.Value.ToString().ToLower().Contains(word))
                                {

                                    if (!indexes.Contains(i))
                                    {
                                        indexes.Add(i);
                                        break;
                                    }
                                }
                            }
                        }

                        if (indexes.Count == count)
                        {
                            row.Visible = true;
                        }
                        else
                        {
                            row.Visible = false;
                        }
                        adjustDGHeight();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Search: " + ex.Message);
            }
            
        }


        private List<User> sortUsers(string criteria, bool ascending)
        {
            if (criteria == "ID" || criteria == "Šifra")
            {
                return sortByUserId(ascending);
            }
            if (criteria == "Username" || criteria == "Korisničko ime")
            {
                return sortByUsername(ascending);
            }
            else if (criteria == "First name" || criteria == "Ime")
            {
                return sortByFirstName(ascending);
            }
            else if (criteria == "Last name" || criteria == "Prezime")
            {
                return sortByLastName(ascending);
            }
            else if (criteria == "Role" || criteria == "Uloga")
            {
                return sortByUserRole(ascending);
            }
            else return null;
        }

        private List<User> sortByUserId(bool ascending)
        {
            List<User> result = new List<User>();
            try
            {
                using (var context = new PharmacyDB())
                {
                    var users = context.Users.ToList();
                    if (ascending == true)
                    {
                        result=users.OrderBy(u => u.UserId).ToList();
                    }
                    else
                    {
                        result=users.OrderByDescending(u => u.UserId).ToList();
                    }

                }
            }catch (Exception ex)
            {
                Console.WriteLine("Sorting ex: " + ex.Message);
            }
            return result;
           
        }


        private List<User> sortByUsername(bool ascending)
        {
            List<User> result = new List<User>();
            try
            {
                using (var context = new PharmacyDB())
                {
                    var users = context.Users.ToList();
                    if (ascending == true)
                    {
                        result=users.OrderBy(u => u.Username).ToList();
                    }
                    else
                    {
                        result=users.OrderByDescending(u => u.Username).ToList();
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorting ex: " + ex.Message);
            }
            return result;
        }

        private List<User> sortByFirstName(bool ascending)
        {
            List<User> result = new List<User>();
            try
            {
                using (var context = new PharmacyDB())
                {
                    var users = context.Users.ToList();
                    if (ascending == true)
                    {
                        result=users.OrderBy(p => p.FirstName).ToList();
                    }
                    else
                    {
                        result=users.OrderByDescending(p => p.FirstName).ToList();
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorting ex: " + ex.Message);
            }
            return result;
        }

        private List<User> sortByLastName(bool ascending)
        {
            List<User> result = new List<User>();
            try
            {
                using (var context = new PharmacyDB())
                {
                    var users = context.Users.ToList();
                    if (ascending == true)
                    {
                        result=users.OrderBy(p => p.LastName).ToList();
                    }

                    else
                    {
                        result=users.OrderByDescending(p => p.LastName).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorting ex: " + ex.Message);
            }
            return result;

        }

        private List<User> sortByUserRole(bool ascending)
        {
            List<User> result = new List<User>();
            try
            {
                using (var context = new PharmacyDB())
                {
                    var users = context.Users.ToList();
                    if (ascending == true)
                    {
                        result=users.OrderBy(p => p.UserRole).ToList();
                    }
                    else
                    {
                        result=users.OrderByDescending(p => p.UserRole).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorting ex: " + ex.Message);
            }
            return result;
        }

        private void dgUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgUsers.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                if (dgUsers.Columns[e.ColumnIndex].HeaderText == "Edit")
                {
                    try
                    {
                        using (var context = new PharmacyDB())
                        {
                            int id = Convert.ToInt32(dgUsers.Rows[e.RowIndex].Cells[0].Value);
                            var user = context.Users.Where(u => u.UserId == id).FirstOrDefault();
                            if (user != null)
                            {
                                updateUser(user);
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Update user: " + ex.Message);
                    }
                }

            }
        }


        private void updateUser(User user)
        {
            try
            {
                var userForm = new NewUserForm();
                userForm.setUserData(user);
                userForm.Show();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Update user" + ex.Message);
            }
        }

        private void comboBoxSorting_SelectedValueChanged(object sender, EventArgs e)
        {
            string criteria = comboBoxSorting.SelectedItem.ToString();
            bool ascending = (checkBoxSorting.Checked) ? true : false;
            displayUsers(sortUsers(criteria, ascending));
        }

        private void checkBoxSorting_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine(comboBoxSorting.SelectedItem.ToString());
            List<User> users = new List<User>();
            bool isChecked = (checkBoxSorting.Checked) ? true : false;

            switch (comboBoxSorting.SelectedItem.ToString())
            {
                case "ID":
                case "Šifra":

                    {
                        users = sortByUserId(isChecked);
                        break;
                    }

                case "First name":
                case "Ime":
                    {
                        Console.WriteLine("Mrvica.");
                        users = sortByFirstName(isChecked);
                        
                        break;
                    }
                case "Last name":
                case "Prezime":
                    {
                        users = sortByLastName(isChecked);
                        break;
                    }

                case "Username":
                case "Korisničko ime":
                    {
                        users = sortByUsername(isChecked);
                        break;
                    }
                case "Role":
                case "Uloga":
                    {
                        users = sortByUserRole(isChecked);
                        break;
                    }
            }

            displayUsers(users);
        }
    }





}

