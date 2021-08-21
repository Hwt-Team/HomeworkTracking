using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Ninject.Modules;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormsUI.Forms.UserForms.Claims.Both
{
    public partial class ClaimForm : Form
    {
        private readonly IClaimService _claimService;
        private readonly IMainClaimService _mainClaimService;
        private readonly ISubsidiaryClaimService _subsidiaryClaimService;

        public ClaimForm()
        {
            InitializeComponent();
            this._claimService = InstanceFactory
                .GetInstance<IClaimService>(new INinjectModule[] { new CoreModule(), new BusinessModule() });
            this._mainClaimService = InstanceFactory
                .GetInstance<IMainClaimService>(new INinjectModule[] { new CoreModule(), new BusinessModule() });
            this._subsidiaryClaimService = InstanceFactory
                .GetInstance<ISubsidiaryClaimService>(new INinjectModule[] { new CoreModule(), new BusinessModule() });
        }

        private void ClaimForm_Load(object sender, EventArgs e)
        {
            this.DesignDataGridView(this.dgwClaims);
        }

        private void DesignDataGridView(DataGridView dataGridView)
        {
            dataGridView.RowHeadersVisible = false;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(32, 30, 45);
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(23, 21, 32);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(11, 7, 17);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadAllClaims()
        {
            this.dgwClaims.DataSource = this._claimService.GetAll();
        }

        private void LoadSubsidiaries()
        {
            this.dgwClaims.DataSource = this._subsidiaryClaimService.GetAll();
        }

        private void LoadMain()
        {
            this.dgwClaims.DataSource = this._mainClaimService.GetAll();
        }

        private void btnMainDgw_Click(object sender, EventArgs e)
        {
            this.LoadMain();
        }

        private void btnSubsidiariesDgw_Click(object sender, EventArgs e)
        {
            this.LoadSubsidiaries();
        }

        private void btnBothDgw_Click(object sender, EventArgs e)
        {
            this.LoadAllClaims();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.LoadAllClaims();
        }
    }
}
