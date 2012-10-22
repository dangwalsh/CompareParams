using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Autodesk.Revit.DB;

using CompareParams.Classes;

namespace CompareParams.UI
{
    public partial class FormCompare : System.Windows.Forms.Form
    {
        private ClsSettings _Settings = null;
        private BindingList<ClsPair> _Pairs = new BindingList<ClsPair>();
        private List<ClsResults> _Results = new List<ClsResults>();

        public FormCompare(ClsSettings settings)
        {
            InitializeComponent();
            _Settings = settings;
        }

        void RunComparison()
        {
            ClsCategory catInst = this.comboInst.SelectedItem as ClsCategory;
            ClsCategory catHost = this.comboHost.SelectedItem as ClsCategory;
           
            foreach (Element elem in catInst.InstanceElements)
            {
                try
                {
                    //_Results.Add(new ClsResults(_Settings.Doc, elem, this.comboInstProp.SelectedItem.ToString()));
                    FamilyInstance inst = elem as FamilyInstance;

                    if (inst != null)
                    {
                        Element host = inst.Host;

                        ClsParameter paramInst = new ClsParameter(inst.get_Parameter(this.comboInstProp.SelectedItem.ToString()));
                        ClsParameter paramHost = new ClsParameter(host.get_Parameter(this.comboInstProp.SelectedItem.ToString()));

                        if (paramInst.ParameterObject != null && paramHost.ParameterObject != null)
                        {
                            _Results.Add(new ClsResults(_Settings.Doc, paramHost, paramInst, host.Name, inst.Name));
                        }
                        else
                        {
                            Element instType = _Settings.Doc.GetElement(inst.GetTypeId());
                            Element hostType = _Settings.Doc.GetElement(host.GetTypeId());

                            paramInst = new ClsParameter(instType.get_Parameter(this.comboInstProp.SelectedItem.ToString()));
                            paramHost = new ClsParameter(hostType.get_Parameter(this.comboInstProp.SelectedItem.ToString()));

                            _Results.Add(new ClsResults(_Settings.Doc, paramHost, paramInst, host.Name, inst.Name));
                        }

                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            LoadResults();
        }

        void UpdateInstParameterList()
        {
            try
            {
                this.comboInstProp.Items.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ClsCategory catInst = this.comboInst.SelectedItem as ClsCategory;
            catInst.GetInstanceParameters();

            try
            {
                foreach (ClsParameter param in catInst.InstanceParameters)
                {
                    if(!this.comboInstProp.Items.Contains(param.ParameterObject.Definition.Name))
                        this.comboInstProp.Items.Add(param.ParameterObject.Definition.Name);
                }
                if (this.comboInstProp.Items != null) this.comboInstProp.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void UpdateHostParameterList()
        {
            try
            {
                this.comboHostProp.Items.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ClsCategory catHost = this.comboHost.SelectedItem as ClsCategory;
            catHost.GetInstanceParameters();

            try
            {
                foreach (ClsParameter param in catHost.InstanceParameters)
                {
                    this.comboHostProp.Items.Add(param.ParameterObject.Definition.Name);
                }
                if (this.comboHostProp.Items != null) this.comboHostProp.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void LoadResults()
        {
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = _Results;
        }

        private void FormCompare_Shown(object sender, EventArgs e)
        {
            try
            {
                this.comboInst.DataSource = _Settings.InstCategoryList;
                this.comboInst.DisplayMember = "CatName";
                this.comboInst.SelectedIndex = 0;

                this.comboHost.DataSource = _Settings.HostCategoryList;
                this.comboHost.DisplayMember = "CatName";
                this.comboHost.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboInst_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInstParameterList();
        }

        private void comboHost_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateHostParameterList();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                RunComparison();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _Results.Clear();
            RunComparison();
            dataGridView1.Refresh();
        }
    }
}
