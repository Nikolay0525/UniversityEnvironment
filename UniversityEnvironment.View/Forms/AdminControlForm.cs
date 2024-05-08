using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityEnvironment.Data.Model.Tables;
using UniversityEnvironment.Data.Repositories;
using static UniversityEnvironment.View.Utility.ViewHelper;
using static UniversityEnvironment.View.Utility.AuthorizationHelper;
using Microsoft.EntityFrameworkCore;
using UniversityEnvironment.Data;

namespace UniversityEnvironment.View.Forms
{
    public partial class AdminControlForm : MaterialForm
    {
        private readonly User _user;
        private readonly UniversityEnvironmentContext _context;
        public AdminControlForm(User user)
        {
            _user = user;
            _context = new UniversityEnvironmentContext();
            InitializeComponent();
        }
        private void RequestsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /* if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
             {
                 DataGridViewRow selectedRow = RequestsTable.Rows[e.RowIndex];
                 string? selectedUsername = selectedRow.Cells["FromUsernameColumn"].Value.ToString();
                 if (RepositoryManager.GetRepo<Admin>().FindByFilter(a => a.Username == selectedUsername) != null)
                 {
                     Hide();
                     ShowNextForm(this, new AdminRequestForm());
                 }
                 else
                 {
                     Hide();
                     ShowNextForm(this, new AdminRequestForm());
                 }
             }*/
        }
    }
}
