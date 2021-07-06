using System;
using System.Windows.Forms;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using FormsUI.DependencyResolvers;

namespace FormsUI
{
    public partial class GroupForm : Form
    {
        private IGroupService _groupService;

        private Form1 _form1;
        public GroupForm()
        {
            InitializeComponent();
            this._groupService = InstanceFactory.GetInstance<IGroupService>(new BusinessModule());
        }

        private void dgwGroups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwGroups.CurrentRow.Cells[1].Value.ToString();
        }

        private void GroupForm_Load(object sender, EventArgs e)
        {
            LoadGroups();
        }

        private void LoadGroups()
        {
            dgwGroups.DataSource = this._groupService.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this._groupService.Add(new Group
            {
                Name = tbxNameAdd.Text
            });
            LoadGroups();
            MessageBox.Show("Added!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this._groupService.Update(new Group
            {
                Id = (int) dgwGroups.CurrentRow.Cells[0].Value,
                Name = tbxNameUpdate.Text
            });
            LoadGroups();
            MessageBox.Show("Updated!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this._groupService.Delete(new Group
            {
                Id = (int) dgwGroups.CurrentRow.Cells[0].Value
            });
            LoadGroups();
            MessageBox.Show("Deleted!");
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            _form1 = InstanceFactory.GetInstance<Form1>(new FormModule());
            _form1.Show();
            this.Hide();
        }

        private void GroupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
